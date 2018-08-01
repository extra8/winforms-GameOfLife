using GameofLife.Application_Logic;
using System.Drawing;
using System.Windows.Forms;

namespace GameofLife
{
    internal class Cell : Commons
    {

        private PictureBox thisCell = new PictureBox();
        private int xCoordinate = 0;
        private int yCoordinate = 0;
        

        public Cell(int x, int y)
        {
            this.XCoordinate = x;
            this.YCoordinate = y;
            this.thisCell = cellModel;
        }

        public PictureBox ThisCell { get => thisCell; set => thisCell = value; }


        public int XCoordinate { get => xCoordinate; set => xCoordinate = value; }
        public int YCoordinate { get => yCoordinate; set => yCoordinate = value; }

    }
}