namespace SkyWarriorsClashofTitans
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.bulletF9 = new System.Windows.Forms.PictureBox();
            this.playerF9 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.enemyThree = new System.Windows.Forms.PictureBox();
            this.enemyFour = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.Boss = new System.Windows.Forms.PictureBox();
            this.noti = new System.Windows.Forms.Label();
            this.pNoti = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletF9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerF9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boss)).BeginInit();
            this.pNoti.SuspendLayout();
            this.SuspendLayout();
            // 
            // enemyTwo
            // 
            this.enemyTwo.BackColor = System.Drawing.Color.Transparent;
            this.enemyTwo.Image = global::SkyWarriorsClashofTitans.Properties.Resources.Enemy1_ezgif_com_crop;
            this.enemyTwo.Location = new System.Drawing.Point(1301, 638);
            this.enemyTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(200, 117);
            this.enemyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyTwo.TabIndex = 1;
            this.enemyTwo.TabStop = false;
            // 
            // bulletF9
            // 
            this.bulletF9.BackColor = System.Drawing.Color.Transparent;
            this.bulletF9.Cursor = System.Windows.Forms.Cursors.Default;
            this.bulletF9.Image = global::SkyWarriorsClashofTitans.Properties.Resources.Bullet13_ezgif_com_crop;
            this.bulletF9.Location = new System.Drawing.Point(158, 419);
            this.bulletF9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bulletF9.Name = "bulletF9";
            this.bulletF9.Size = new System.Drawing.Size(71, 30);
            this.bulletF9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bulletF9.TabIndex = 0;
            this.bulletF9.TabStop = false;
            // 
            // playerF9
            // 
            this.playerF9.BackColor = System.Drawing.Color.Transparent;
            this.playerF9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerF9.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.playerF9.Image = global::SkyWarriorsClashofTitans.Properties.Resources.F9_ezgif_com_crop;
            this.playerF9.Location = new System.Drawing.Point(12, 396);
            this.playerF9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerF9.Name = "playerF9";
            this.playerF9.Size = new System.Drawing.Size(140, 77);
            this.playerF9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerF9.TabIndex = 0;
            this.playerF9.TabStop = false;
            this.playerF9.UseWaitCursor = true;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // enemyOne
            // 
            this.enemyOne.BackColor = System.Drawing.Color.Transparent;
            this.enemyOne.Image = global::SkyWarriorsClashofTitans.Properties.Resources.Enemy1_ezgif_com_crop;
            this.enemyOne.Location = new System.Drawing.Point(1301, 224);
            this.enemyOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(200, 117);
            this.enemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyOne.TabIndex = 1;
            this.enemyOne.TabStop = false;
            // 
            // enemyThree
            // 
            this.enemyThree.BackColor = System.Drawing.Color.Transparent;
            this.enemyThree.Image = global::SkyWarriorsClashofTitans.Properties.Resources.Enemy1_ezgif_com_crop;
            this.enemyThree.Location = new System.Drawing.Point(1301, 44);
            this.enemyThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(200, 117);
            this.enemyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyThree.TabIndex = 1;
            this.enemyThree.TabStop = false;
            // 
            // enemyFour
            // 
            this.enemyFour.BackColor = System.Drawing.Color.Transparent;
            this.enemyFour.Image = global::SkyWarriorsClashofTitans.Properties.Resources.Enemy1_ezgif_com_crop;
            this.enemyFour.Location = new System.Drawing.Point(1301, 438);
            this.enemyFour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyFour.Name = "enemyFour";
            this.enemyFour.Size = new System.Drawing.Size(200, 117);
            this.enemyFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyFour.TabIndex = 1;
            this.enemyFour.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(28, 23);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(32, 46);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = " ";
            // 
            // Boss
            // 
            this.Boss.Image = global::SkyWarriorsClashofTitans.Properties.Resources.Boss2;
            this.Boss.Location = new System.Drawing.Point(831, 48);
            this.Boss.Name = "Boss";
            this.Boss.Size = new System.Drawing.Size(394, 688);
            this.Boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Boss.TabIndex = 4;
            this.Boss.TabStop = false;
            // 
            // noti
            // 
            this.noti.AutoSize = true;
            this.noti.BackColor = System.Drawing.Color.Transparent;
            this.noti.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noti.Location = new System.Drawing.Point(570, 320);
            this.noti.Name = "noti";
            this.noti.Size = new System.Drawing.Size(117, 46);
            this.noti.TabIndex = 2;
            this.noti.Text = "(noti)";
            this.noti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pNoti
            // 
            this.pNoti.BackColor = System.Drawing.Color.Transparent;
            this.pNoti.Controls.Add(this.noti);
            this.pNoti.Location = new System.Drawing.Point(0, 0);
            this.pNoti.Name = "pNoti";
            this.pNoti.Size = new System.Drawing.Size(1545, 864);
            this.pNoti.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1527, 784);
            this.Controls.Add(this.bulletF9);
            this.Controls.Add(this.Boss);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.playerF9);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.enemyFour);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.pNoti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sky Warrios: Clash of Tians";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletF9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerF9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boss)).EndInit();
            this.pNoti.ResumeLayout(false);
            this.pNoti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerF9;
        private System.Windows.Forms.PictureBox bulletF9;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.PictureBox enemyFour;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox Boss;
        private System.Windows.Forms.Label noti;
        private System.Windows.Forms.Panel pNoti;
    }
}

