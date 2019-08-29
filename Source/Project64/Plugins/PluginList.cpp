/****************************************************************************
*                                                                           *
* Project64 - A Nintendo 64 emulator.                                      *
* http://www.pj64-emu.com/                                                  *
* Copyright (C) 2012 Project64. All rights reserved.                        *
*                                                                           *
* License:                                                                  *
* GNU/GPLv2 http://www.gnu.org/licenses/gpl-2.0.html                        *
*                                                                           *
****************************************************************************/
#include "stdafx.h"
#include <io.h>
#include "PluginList.h"
#include <Project64-core/Plugins/PluginBase.h>

static std::vector<CPath> SplitPath(std::string subject, char delim)
{
	std::vector<CPath> result;

	size_t count, start = 0;
    for (count = 0; count + start < subject.size(); ++count)
    {
        if (delim == subject[count])
        {
            if (count != 0)
                result.push_back(subject.substr(start, count));

            start += count + 1;
            count = 0;
        }
    }

    if (count != 0)
        result.push_back(subject.substr(start, count));

    return result;
}

CPluginList::CPluginList(bool bAutoFill /* = true */) :
m_PluginDirs(SplitPath(g_Settings->LoadStringVal(Directory_Plugin), ';'))
{
    if (bAutoFill)
    {
        LoadList();
    }
}

CPluginList::~CPluginList()
{
}

int CPluginList::GetPluginCount() const
{
    return m_PluginList.size();
}

const CPluginList::PLUGIN * CPluginList::GetPluginInfo(int indx) const
{
    if (indx < 0 || indx >= (int)m_PluginList.size())
    {
        return NULL;
    }
    return &m_PluginList[indx];
}

bool CPluginList::LoadList()
{
    WriteTrace(TraceUserInterface, TraceDebug, "Start");
    m_PluginList.clear();
	for (CPath p : m_PluginDirs)
		AddPluginFromDir(p);
    WriteTrace(TraceUserInterface, TraceDebug, "Done");
    return true;
}

void CPluginList::AddPluginFromDir(CPath Dir)
{
    size_t len = strlen(Dir);
    Dir.SetNameExtension("*");
    if (Dir.FindFirst(CPath::FIND_ATTRIBUTE_SUBDIR))
    {
        do
        {
            AddPluginFromDir(Dir);
        } while (Dir.FindNext());
        Dir.UpDirectory();
    }

    Dir.SetNameExtension("*.dll");
    if (Dir.FindFirst())
    {
        HMODULE hLib = NULL;
        do
        {
            if (hLib)
            {
                FreeLibrary(hLib);
                hLib = NULL;
            }

            //UINT LastErrorMode = SetErrorMode( SEM_FAILCRITICALERRORS );
            WriteTrace(TraceUserInterface, TraceDebug, "loading %s", (LPCSTR)Dir);
            hLib = LoadLibrary(Dir);
            //SetErrorMode(LastErrorMode);

            if (hLib == NULL)
            {
                DWORD LoadError = GetLastError();
                WriteTrace(TraceUserInterface, TraceDebug, "failed to load %s (error: %d)", (LPCSTR)Dir, LoadError);
                continue;
            }

            void(CALL *GetDllInfo) (PLUGIN_INFO * PluginInfo);
            GetDllInfo = (void(CALL *)(PLUGIN_INFO *))GetProcAddress(hLib, "GetDllInfo");
            if (GetDllInfo == NULL)
            {
                continue;
            }

            PLUGIN Plugin = { 0 };
            Plugin.Info.MemoryBswaped = true;
            GetDllInfo(&Plugin.Info);
            if (!CPlugin::ValidPluginVersion(Plugin.Info))
            {
                continue;
            }

            Plugin.FullPath = Dir;
            Plugin.FileName = stdstr((const char *)Dir).substr(len);

            if (GetProcAddress(hLib, "DllAbout") != NULL)
            {
                Plugin.AboutFunction = true;
            }
            m_PluginList.push_back(Plugin);
        } while (Dir.FindNext());

        if (hLib)
        {
            FreeLibrary(hLib);
            hLib = NULL;
        }
    }
}