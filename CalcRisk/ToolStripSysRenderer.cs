﻿using System.Windows.Forms;

namespace CalcRisk
{
    public class ToolStripSysRenderer : ToolStripSystemRenderer
    {
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip.GetType() == typeof(ToolStrip))
            {
                // skip render border
            }
            else
            {
                // do render border
                base.OnRenderToolStripBorder(e);
            }
        }
    }
}
