using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT3A1_WinForm
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        int duration = 0;
        int loadingTime = 2000; // milliseconds
        int interval = 20;
        int max = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            duration += 1;
            label1.Text = ((duration*100)/max).ToString()
                            + "%";
            if (duration > max)
            {
                this.Close();
                return;
            }
            progressBar1.Value = duration;
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            max = loadingTime / interval;
            timer1.Enabled = true;
            timer1.Interval = interval; // 100 milliseconds
            timer1.Start();
            progressBar1.Maximum = max;
        }
    }
}
