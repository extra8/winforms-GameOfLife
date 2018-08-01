using GameofLife.Application_Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameofLife
{
    internal class GameManager : Commons
    {
        private Cell[,] CellsMatrix;
        private Cell[,] CloneMatrix;

        public GameManager(int height, int width)
        {
            this.Height = height / (SquareSize + 2);
            this.Width = width / (SquareSize + 2);
            CellsMatrix = new Cell[this.Height, this.Width];
            CloneMatrix = new Cell[this.Height, this.Width];
            GenerateCells();
        }

        public void GenerateCells()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Cell newCell = new Cell(i, j);
                    newCell.ThisCell.Click += new EventHandler(ClickCell);
                    CellsMatrix[i, j] = newCell;
                }
            }

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Cell newCell = new Cell(i, j);
                    CloneMatrix[i, j] = newCell;
                }
            }
        }

        public void BoardDraw(ref FlowLayoutPanel cellFlowLayoutPanel)
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    cellFlowLayoutPanel.Controls.Add(CellsMatrix[i, j].ThisCell);
                }
            }
        }

        public void ClickCell(object sender, EventArgs e)
        {
            PictureBox cell = (PictureBox)sender;
            if (cell.BackColor == Color.Orange) cell.BackColor = Color.White;
            else cell.BackColor = Color.Orange;
        }

        public void NextState()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (CellsMatrix[i, j].ThisCell.BackColor == Color.Orange) CloneMatrix[i, j].ThisCell.BackColor = Color.Orange;
                    else CloneMatrix[i, j].ThisCell.BackColor = Color.White;
                }
            }

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    bool isCellAlive = Rules(CellsMatrix[i, j].XCoordinate, CellsMatrix[i, j].YCoordinate); ;
                    if (isCellAlive == true) CloneMatrix[i, j].ThisCell.BackColor = Color.Orange;
                    else CloneMatrix[i, j].ThisCell.BackColor = Color.White;
                }
            }

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (CloneMatrix[i, j].ThisCell.BackColor == Color.Orange) CellsMatrix[i, j].ThisCell.BackColor = Color.Orange;
                    else CellsMatrix[i, j].ThisCell.BackColor = Color.White;
                }
            }
        }

        public bool Rules(int x, int y)
        {
            bool isAlive = false;
            int nrOfNeighbours = GetNumberOfAliveNeighbours(x, y);

            if (CellsMatrix[x, y].ThisCell.BackColor == Color.Orange)
            {
                if (nrOfNeighbours < 2 || nrOfNeighbours > 3)
                    isAlive = false;
                else
                    isAlive = true;

            }
            else if (CellsMatrix[x, y].ThisCell.BackColor == Color.White)
            {
                if (nrOfNeighbours == 3)
                    isAlive = true;
            }

            return isAlive;
        }

        public int GetNumberOfAliveNeighbours(int x, int y)
        {
            int nr = 0;
            List<Cell> neighbours = new List<Cell>();

            if (x == 0 && y == 0)
            {
                neighbours.Add(CellsMatrix[0, 1]);
                neighbours.Add(CellsMatrix[1, 0]);
                neighbours.Add(CellsMatrix[1, 1]);

                for (int i = 0; i < neighbours.Count(); i++) if (neighbours[i].ThisCell.BackColor == Color.Orange) nr++;
            }
            else if (x == 0 && y == Width - 1)
            {
                neighbours.Add(CellsMatrix[1, Width - 2]);
                neighbours.Add(CellsMatrix[0, Width - 2]);
                neighbours.Add(CellsMatrix[1, Width - 1]);

                for (int i = 0; i < neighbours.Count(); i++) if (neighbours[i].ThisCell.BackColor == Color.Orange) nr++;
            }
            else if (x == Height - 1 && y == 0)
            {
                neighbours.Add(CellsMatrix[Height - 1, 0]);
                neighbours.Add(CellsMatrix[Height - 2, 0]);
                neighbours.Add(CellsMatrix[Height - 1, 1]);

                for (int i = 0; i < neighbours.Count(); i++) if (neighbours[i].ThisCell.BackColor == Color.Orange) nr++;
            }
            else if (x == Height - 1 && y == Width - 1)
            {
                neighbours.Add(CellsMatrix[Height - 1, Width - 2]);
                neighbours.Add(CellsMatrix[Height - 2, Width - 2]);
                neighbours.Add(CellsMatrix[Height - 2, Width - 1]);

                for (int i = 0; i < neighbours.Count(); i++) if (neighbours[i].ThisCell.BackColor == Color.Orange) nr++;
            }
            else if (x == 0)
            {
                neighbours.Add(CellsMatrix[0, y - 1]);
                neighbours.Add(CellsMatrix[0, y + 1]);
                neighbours.Add(CellsMatrix[1, y]);
                neighbours.Add(CellsMatrix[1, y - 1]);
                neighbours.Add(CellsMatrix[1, y + 1]);

                for (int i = 0; i < neighbours.Count(); i++) if (neighbours[i].ThisCell.BackColor == Color.Orange) nr++;
            }
            else if (y == 0)
            {
                neighbours.Add(CellsMatrix[x + 1, 0]);
                neighbours.Add(CellsMatrix[x - 1, 0]);
                neighbours.Add(CellsMatrix[x, 1]);
                neighbours.Add(CellsMatrix[x + 1, 1]);
                neighbours.Add(CellsMatrix[x - 1, 1]);

                for (int i = 0; i < neighbours.Count(); i++) if (neighbours[i].ThisCell.BackColor == Color.Orange) nr++;
            }
            else if (x == Height - 1)
            {
                neighbours.Add(CellsMatrix[Height - 1, y - 1]);
                neighbours.Add(CellsMatrix[Height - 1, y + 1]);
                neighbours.Add(CellsMatrix[Height - 2, y]);
                neighbours.Add(CellsMatrix[Height - 2, y - 1]);
                neighbours.Add(CellsMatrix[Height - 2, y + 1]);

                for (int i = 0; i < neighbours.Count(); i++) if (neighbours[i].ThisCell.BackColor == Color.Orange) nr++;
            }
            else if (y == Width - 1)
            {
                neighbours.Add(CellsMatrix[x - 1, Width - 1]);
                neighbours.Add(CellsMatrix[x + 1, Width - 1]);
                neighbours.Add(CellsMatrix[x, Width - 2]);
                neighbours.Add(CellsMatrix[x - 1, Width - 2]);
                neighbours.Add(CellsMatrix[x + 1, Width - 2]);

                for (int i = 0; i < neighbours.Count(); i++) if (neighbours[i].ThisCell.BackColor == Color.Orange) nr++;
            }
            else
            {
                neighbours.Add(CellsMatrix[x - 1, y - 1]);
                neighbours.Add(CellsMatrix[x - 1, y]);
                neighbours.Add(CellsMatrix[x - 1, y + 1]);
                neighbours.Add(CellsMatrix[x, y - 1]);
                neighbours.Add(CellsMatrix[x, y + 1]);
                neighbours.Add(CellsMatrix[x + 1, y - 1]);
                neighbours.Add(CellsMatrix[x + 1, y]);
                neighbours.Add(CellsMatrix[x + 1, y + 1]);

                for (int i = 0; i < neighbours.Count(); i++) if (neighbours[i].ThisCell.BackColor == Color.Orange) nr++;
            }
            return nr;
        }

        public void ResetState()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    CellsMatrix[i, j].ThisCell.BackColor = Color.White;
                }
            }
        }

        public void RandomState()
        {
            Random r = new Random();
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    int color = r.Next(0, 2);

                    if (color == 1) CellsMatrix[i, j].ThisCell.BackColor = Color.Orange;
                    else CellsMatrix[i, j].ThisCell.BackColor = Color.White;
                }
            }
        }

    }
}