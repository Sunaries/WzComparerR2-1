﻿using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar;
using WzComparerR2.WzLib;
using WzComparerR2;
using WzComparerR2.Common;

namespace WzComparerR2.PluginBase
{
    internal interface PluginContextProvider
    {
        Office2007RibbonForm MainForm { get; }
        IList<Wz_Structure> LoadedWz { get; }
        Wz_Node SelectedNode1 { get; }
        Wz_Node SelectedNode2 { get; }
        Wz_Node SelectedNode3 { get; }
        StringLinker DefaultStringLinker { get; }
        event EventHandler<WzNodeEventArgs> SelectedNode1Changed;
        event EventHandler<WzNodeEventArgs> SelectedNode2Changed;
        event EventHandler<WzNodeEventArgs> SelectedNode3Changed;
        event EventHandler<WzStructureEventArgs> WzOpened;
        event EventHandler<WzStructureEventArgs> WzClosing;
    }
}
