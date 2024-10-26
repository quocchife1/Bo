namespace SkyWarriorsClashofTitans
{
    partial class PauseScreen
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResumeBtn = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResumeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SkyWarriorsClashofTitans.Properties.Resources.deco1;
            this.pictureBox2.Location = new System.Drawing.Point(242, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(319, 212);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SkyWarriorsClashofTitans.Properties.Resources.PauseLabel;
            this.pictureBox1.Location = new System.Drawing.Point(231, -85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.Image = global::SkyWarriorsClashofTitans.Properties.Resources.ResumeBtn;
            this.ResumeBtn.Location = new System.Drawing.Point(568, 309);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(195, 129);
            this.ResumeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResumeBtn.TabIndex = 0;
            this.ResumeBtn.TabStop = false;
            this.ResumeBtn.Click += new System.EventHandler(this.ResumeBtn_Click);
            this.ResumeBtn.MouseLeave += new System.EventHandler(this.ResumeBtn_MouseLeave);
            this.ResumeBtn.MouseHover += new System.EventHandler(this.ResumeBtn_MouseHover);
            // 
            // BackBtn
            // 
            this.BackBtn.Image = global::SkyWarriorsClashofTitans.Properties.Resources.BackBtn__2_;
            this.BackBtn.Location = new System.Drawing.Point(41, 319);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(195, 129);
            this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackBtn.TabIndex = 0;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            this.BackBtn.MouseLeave += new System.EventHandler(this.BackBtn_MouseLeave);
            this.BackBtn.MouseHover += new System.EventHandler(this.BackBtn_MouseHover);
            // 
            // PauseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResumeBtn);
            this.Controls.Add(this.BackBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PauseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PauseScreen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PauseScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResumeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.PictureBox ResumeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}