namespace GameofLife
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cellsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.buttonStep = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRandomise = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelAddCycle = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelUpdateCycleDisplay = new System.Windows.Forms.Label();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.checkBoxMaxSpeed = new System.Windows.Forms.CheckBox();
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.pictureBoxMusic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.ForeColor = System.Drawing.Color.Orange;
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.MarqueeAnimationSpeed = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.UseWaitCursor = true;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // cellsFlowLayoutPanel
            // 
            resources.ApplyResources(this.cellsFlowLayoutPanel, "cellsFlowLayoutPanel");
            this.cellsFlowLayoutPanel.Name = "cellsFlowLayoutPanel";
            this.cellsFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.cellsFlowLayoutPanel_Paint);
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.BackColor = System.Drawing.Color.White;
            this.buttonStartStop.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonStartStop, "buttonStartStop");
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.UseVisualStyleBackColor = false;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // buttonStep
            // 
            this.buttonStep.BackColor = System.Drawing.Color.White;
            this.buttonStep.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonStep, "buttonStep");
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.UseVisualStyleBackColor = false;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.White;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonReset, "buttonReset");
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRandomise
            // 
            this.buttonRandomise.BackColor = System.Drawing.Color.White;
            this.buttonRandomise.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonRandomise, "buttonRandomise");
            this.buttonRandomise.Name = "buttonRandomise";
            this.buttonRandomise.UseVisualStyleBackColor = false;
            this.buttonRandomise.Click += new System.EventHandler(this.buttonRandomise_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBoxLogo, "pictureBoxLogo");
            this.pictureBoxLogo.Image = global::GameofLife.Properties.Resources.logo_in_app;
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelAddCycle
            // 
            this.labelAddCycle.BackColor = System.Drawing.Color.Transparent;
            this.labelAddCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.labelAddCycle, "labelAddCycle");
            this.labelAddCycle.ForeColor = System.Drawing.Color.White;
            this.labelAddCycle.Name = "labelAddCycle";
            this.labelAddCycle.Click += new System.EventHandler(this.labelAddCycle_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxInput, "textBoxInput");
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // labelUpdateCycleDisplay
            // 
            resources.ApplyResources(this.labelUpdateCycleDisplay, "labelUpdateCycleDisplay");
            this.labelUpdateCycleDisplay.BackColor = System.Drawing.Color.Transparent;
            this.labelUpdateCycleDisplay.ForeColor = System.Drawing.Color.White;
            this.labelUpdateCycleDisplay.Name = "labelUpdateCycleDisplay";
            this.labelUpdateCycleDisplay.Click += new System.EventHandler(this.labelUpdateCycleDisplay_Click);
            // 
            // speedBar
            // 
            resources.ApplyResources(this.speedBar, "speedBar");
            this.speedBar.BackColor = System.Drawing.Color.White;
            this.speedBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.speedBar.LargeChange = 2;
            this.speedBar.Maximum = 11;
            this.speedBar.Minimum = 1;
            this.speedBar.Name = "speedBar";
            this.speedBar.Value = 1;
            this.speedBar.Scroll += new System.EventHandler(this.speedBar_Scroll);
            // 
            // labelSpeed
            // 
            this.labelSpeed.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.labelSpeed, "labelSpeed");
            this.labelSpeed.ForeColor = System.Drawing.Color.White;
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Click += new System.EventHandler(this.labelSpeed_Click);
            // 
            // checkBoxMaxSpeed
            // 
            resources.ApplyResources(this.checkBoxMaxSpeed, "checkBoxMaxSpeed");
            this.checkBoxMaxSpeed.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMaxSpeed.ForeColor = System.Drawing.Color.White;
            this.checkBoxMaxSpeed.Name = "checkBoxMaxSpeed";
            this.checkBoxMaxSpeed.UseVisualStyleBackColor = false;
            this.checkBoxMaxSpeed.CheckedChanged += new System.EventHandler(this.checkBoxMaxSpeed_CheckedChanged);
            // 
            // linkLabelAbout
            // 
            resources.ApplyResources(this.linkLabelAbout, "linkLabelAbout");
            this.linkLabelAbout.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelAbout.LinkColor = System.Drawing.Color.White;
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.VisitedLinkColor = System.Drawing.Color.Orange;
            this.linkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAbout_LinkClicked);
            // 
            // pictureBoxMusic
            // 
            this.pictureBoxMusic.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMusic.BackgroundImage = global::GameofLife.Properties.Resources.soundOff;
            resources.ApplyResources(this.pictureBoxMusic, "pictureBoxMusic");
            this.pictureBoxMusic.Name = "pictureBoxMusic";
            this.pictureBoxMusic.TabStop = false;
            this.pictureBoxMusic.Click += new System.EventHandler(this.pictureBoxMusic_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameofLife.Properties.Resources.bg_large;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMusic);
            this.Controls.Add(this.linkLabelAbout);
            this.Controls.Add(this.checkBoxMaxSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.labelUpdateCycleDisplay);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelAddCycle);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonRandomise);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStep);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.cellsFlowLayoutPanel);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel cellsFlowLayoutPanel;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRandomise;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelAddCycle;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelUpdateCycleDisplay;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.CheckBox checkBoxMaxSpeed;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
        private System.Windows.Forms.PictureBox pictureBoxMusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

