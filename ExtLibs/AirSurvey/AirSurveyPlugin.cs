using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;

namespace AirSurvey
{
    class AirSurveyPlugin : MissionPlanner.Plugin.Plugin
    {
        ToolStripMenuItem but;

        public override string Name
        {
            get { return "Aerial Survey"; }
        }

        public override string Version
        {
            get { return "0.1"; }
        }

        public override string Author
        {
            get { return "Onur CANCI"; }
        }

        public override bool Init()
        {
            return true;
        }

        public override bool Loaded()
        {
            but = new ToolStripMenuItem("Aerial Survey");
            but.Click += but_Click;

            bool hit = false;
            ToolStripItemCollection col = Host.FPMenuMap.Items;
            col.Add(but);

            return true;
        }

        void but_Click(object sender, EventArgs e)
        {
            var gridui = new AerialSurveyUI();
            MissionPlanner.Utilities.ThemeManager.ApplyThemeTo(gridui);

            gridui.ShowDialog();
        }

        public override bool Exit()
        {
            return true;
        }
    }
}
