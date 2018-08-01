using GameofLife.Application_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLife.GUI
{
    public partial class FormWait : Form
    {
        bool isRunning = true;
        public FormWait()
        {
            InitializeComponent();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            isRunning = false;
        }

        public bool getState()
        {
            return isRunning;
        }
    }
}
