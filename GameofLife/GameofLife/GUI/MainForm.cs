using GameofLife.GUI;
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


namespace GameofLife
{
    public partial class MainForm : Form
    {
        private int CycleValue = 0;
        private GameManager gm;
        private string inputNoOfCycles;
        private int noOfCycles;
        private bool breakLoop = false;
        private int runningSpeed = 1000;
        private Timer timerRun;
        private Color logoBackgroundColor = Color.FromArgb(34, 33, 39);
        private int newMax = 0;
        protected int playNo = 0;
        protected SoundPlayer player = new SoundPlayer(GameofLife.Properties.Resources.Copyright_Free_Background_Music_Loop_Audio_2_music_by_Camlyn_Royalty_Free_Music);



        public MainForm()
        {
            InitializeComponent();
            player.PlayLooping();

            gm = new GameManager(cellsFlowLayoutPanel.Height, cellsFlowLayoutPanel.Width);
            gm.BoardDraw(ref cellsFlowLayoutPanel);
            speedBar.BackColor = logoBackgroundColor;
            timerRun = new Timer();
            timerRun.Interval = runningSpeed;
            timerRun.Tick += new EventHandler(TimerRun_Tick);
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (buttonStartStop.Text == "Start")
            {
                inputNoOfCycles = textBoxInput.Text;
                if (checkString(inputNoOfCycles) == false)
                {
                    buttonRandomise.Enabled = false;
                    buttonReset.Enabled = false;
                    breakLoop = false;
                    textBoxInput.Enabled = false;
                    buttonStartStop.Text = "Stop";
                    GameStart(breakLoop);
                }
            }
            else if (buttonStartStop.Text == "Continue")
            {
                if (CycleValue == int.Parse(inputNoOfCycles)) buttonStartStop.Text = "Start";
                else
                {
                    buttonStartStop.Text = "Stop";
                    buttonRandomise.Enabled = false;
                    buttonReset.Enabled = false;
                    breakLoop = false;
                    textBoxInput.Enabled = false;
                    GameStart(breakLoop);
                }
            }
            else
            {
                if (CycleValue < int.Parse(inputNoOfCycles)) buttonStartStop.Text = "Continue";
                else buttonStartStop.Text = "Start";
                buttonRandomise.Enabled = true;
                buttonReset.Enabled = true;
                textBoxInput.Enabled = false;
                breakLoop = true;
            }
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            ++CycleValue;
            buttonRandomise.Enabled = true;
            buttonReset.Enabled = true;
            if (CycleValue < int.Parse(inputNoOfCycles)) buttonStartStop.Text = "Continue";
            else buttonStartStop.Text = "Start";
            breakLoop = true;
            gm.NextState();
            if (CycleValue > noOfCycles)
            {
                labelUpdateCycleDisplay.Text = (CycleValue).ToString() + " / " + (CycleValue).ToString();

            }
            else labelUpdateCycleDisplay.Text = (CycleValue).ToString() + " / " + textBoxInput.Text;

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timerRun.Stop();
            gm.ResetState();
            progressBar.Value = 0;
            textBoxInput.Text = "";
            checkBoxMaxSpeed.Checked = false;
            buttonRandomise.Enabled = true;
            labelUpdateCycleDisplay.Text = "-";
            textBoxInput.Enabled = true;
            buttonStartStop.Text = "Start";
            breakLoop = true;
        }

        private void buttonRandomise_Click(object sender, EventArgs e)
        {
            gm.RandomState();
        }

        private void speedBar_Scroll(object sender, EventArgs e)
        {
            switch (speedBar.Value)
            {
                case 1:
                    runningSpeed = 1000;
                    break;
                case 2:
                    runningSpeed = 900;
                    break;
                case 3:
                    runningSpeed = 800;
                    break;
                case 4:
                    runningSpeed = 700;
                    break;
                case 5:
                    runningSpeed = 600;
                    break;
                case 6:
                    runningSpeed = 500;
                    break;
                case 7:
                    runningSpeed = 400;
                    break;
                case 8:
                    runningSpeed = 300;
                    break;
                case 9:
                    runningSpeed = 200;
                    break;
                case 10:
                    runningSpeed = 100;
                    break;
                case 11:
                    runningSpeed = 1;
                    break;
                default:
                    runningSpeed = 1000;
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public bool checkString(String inputNoOfCycles)
        {
            bool isString = true;
            int ignore;
            if (int.TryParse(inputNoOfCycles, out ignore))
            {
                if (textBoxInput.Text.StartsWith("0"))
                    MessageBox.Show("Wrong number of cycles!");
                else
                {
                    isString = false;
                }

            }
            else
            {
                MessageBox.Show("Wrong number of cycles!");
            }
            return isString;
        }

        public void GameStart(bool breakloop)
        {
            noOfCycles = int.Parse(textBoxInput.Text);

            if (!checkBoxMaxSpeed.Checked)
                timerRun.Start();
            else
            {                
                var t = Task.Run(() =>
                {
                    var fw = new FormWait();

                    var tw = Task.Run(() =>
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            fw.ShowDialog(this);
                        });
                    });

                    CycleValue = 0;
                    while (CycleValue < noOfCycles && buttonStartStop.Text == "Stop")
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (fw.getState() == false && CycleValue < noOfCycles)
                            {
                                buttonStartStop.Text = "Continue";
                                buttonRandomise.Enabled = true;
                                buttonReset.Enabled = true;
                            }

                            gm.NextState();
                            CycleValue++;
                            if (CycleValue == noOfCycles)
                            {
                                buttonStartStop.Text = "Start";
                                buttonRandomise.Enabled = true;
                                buttonReset.Enabled = true;
                            }
                        });
                    }
                    this.Invoke((MethodInvoker)delegate
                    {
                        fw.Close();
                        
                    });
                });
            }
        }

        private void TimerRun_Tick(object sender, EventArgs e)
        {

            noOfCycles = int.Parse(textBoxInput.Text);

            if (newMax != noOfCycles) newMax = noOfCycles;
            progressBar.Maximum = newMax;
            timerRun.Interval = runningSpeed;
            if (buttonStartStop.Text == "Start" || buttonStartStop.Text == "Continue") timerRun.Stop();
            if (CycleValue >= newMax)
            {
                timerRun.Stop();
                buttonStartStop.Text = "Start";
                buttonRandomise.Enabled = true;
                buttonReset.Enabled = true;
                CycleValue = 0;
                textBoxInput.Enabled = true;
                progressBar.Value = 0;
            }
            else
            {
                CycleValue++;
                gm.NextState();
                progressBar.Value = CycleValue;
                if (CycleValue > 0) progressBar.Value = CycleValue - 1;
                labelUpdateCycleDisplay.Text = CycleValue.ToString() + " / " + noOfCycles.ToString();
            }
        }

        private void linkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life");
        }

        private void pictureBoxMusic_Click(object sender, EventArgs e)
        {
            playNo++;
            if (playNo % 2 == 0)
            {
                var ts = Task.Run(() =>
                {
                    player.PlayLooping();
                    pictureBoxMusic.Image = GameofLife.Properties.Resources.soundOff;
                });
            }
            else
            {
                player.Stop();
                pictureBoxMusic.Image = GameofLife.Properties.Resources.soundOn;

            }
        }

        private void labelSpeed_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxMaxSpeed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelAddCycle_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void cellsFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelUpdateCycleDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
