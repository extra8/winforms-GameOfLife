namespace GameofLife.GUI
{
    partial class FormWait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWait));
            this.pictureBoxGifWait = new System.Windows.Forms.PictureBox();
            this.buttonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGifWait)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGifWait
            // 
            this.pictureBoxGifWait.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGifWait.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGifWait.Image")));
            this.pictureBoxGifWait.Location = new System.Drawing.Point(40, 30);
            this.pictureBoxGifWait.Name = "pictureBoxGifWait";
            this.pictureBoxGifWait.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxGifWait.TabIndex = 0;
            this.pictureBoxGifWait.TabStop = false;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.White;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStop.Location = new System.Drawing.Point(55, 150);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(70, 25);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // FormWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameofLife.Properties.Resources.bg_wait;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(184, 191);
            this.ControlBox = false;
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.pictureBoxGifWait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGifWait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGifWait;
        private System.Windows.Forms.Button buttonStop;
    }
}