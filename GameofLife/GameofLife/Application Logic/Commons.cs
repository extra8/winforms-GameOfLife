using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLife.Application_Logic
{
    public abstract class Commons
    {
        protected int Width = 0;
        protected int Height = 0;
        protected int SquareSize = 18;

        protected static int squareSize = 18;

        protected PictureBox cellModel = new PictureBox
        {
            Width = squareSize,
            Height = squareSize,
            Margin = new Padding(1),
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
            BackColor = Color.White,
            TabStop = false
        };
    }
}
