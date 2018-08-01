using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife_Team1.GUI
{
    public partial class StartForm : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public StartForm()
        {
            InitializeComponent();

            this.timer.Interval = 2000;
            this.timer.Tick += new EventHandler(timer_Tick);
            this.timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
