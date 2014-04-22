using Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PS4AC1DFlashTool
{
    public partial class MAIN : Form
    {
        static string l = "log.txt";

        public MAIN()
        {
            InitializeComponent();
        }

        private void MAIN_Load(object sender, EventArgs e)
        {
            File.Create(l).Close();
            Logger.WriteLine(l, "Form Loaded...");
        }

        private void buttonExtract_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logger.WriteLine(l, "Hiding Main Form...");
            ExtractorDev ExtractorDev = new ExtractorDev();
            Logger.WriteLine(l, "Loading Extractor...");
            ExtractorDev.ShowDialog();

            if (ExtractorDev.DialogResult == DialogResult.Cancel)
            {
                this.Show();
                Logger.WriteLine(l, "Extractor Unloaded...");
            }
        }

        private void buttonFlash_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logger.WriteLine(l, "Hiding Main Form...");
            DevBoard DevBoard = new DevBoard();
            Logger.WriteLine(l, "Loading Flash Manager...");
            DevBoard.ShowDialog();

            if (DevBoard.DialogResult == DialogResult.Cancel)
            {
                this.Show();
                Logger.WriteLine(l, "Flash Manager Unloaded...");
            }
        }
    }
}
