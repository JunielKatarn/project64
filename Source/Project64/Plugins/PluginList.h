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
#pragma once

#include <Project64-core/Settings.h>

class CPluginList
{
public:
    typedef struct
    {
        PLUGIN_INFO Info;
        bool        AboutFunction;
        CPath       FullPath;
        stdstr      FileName;
    } PLUGIN;

public:
    CPluginList(bool bAutoFill = true);
    ~CPluginList();

    bool     LoadList(void);
    int      GetPluginCount(void) const;
    const PLUGIN * GetPluginInfo(int indx) const;

private:
    typedef std::vector<PLUGIN>   PluginList;
    typedef std::vector<CPath>    CPathList;

    PluginList m_PluginList;
    CPathList  m_PluginDirs;

    void AddPluginFromDir(CPath Dir);
};
