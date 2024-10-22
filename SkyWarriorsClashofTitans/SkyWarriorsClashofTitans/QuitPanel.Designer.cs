namespace SkyWarriorsClashofTitans
{
    partial class QuitPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.PictureBox();
            this.btnYes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure to exit the game? ";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.Image = global::SkyWarriorsClashofTitans.Properties.Resources.NoBtn;
            this.btnNo.Location = new System.Drawing.Point(112, 280);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(193, 95);
            this.btnNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNo.TabIndex = 2;
            this.btnNo.TabStop = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            this.btnNo.MouseLeave += new System.EventHandler(this.btnNo_MouseLeave);
            this.btnNo.MouseHover += new System.EventHandler(this.btn_no_hover);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Transparent;
            this.btnYes.Image = global::SkyWarriorsClashofTitans.Properties.Resources.YesBtn__1_;
            this.btnYes.Location = new System.Drawing.Point(497, 280);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(193, 95);
            this.btnYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnYes.TabIndex = 2;
            this.btnYes.TabStop = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            this.btnYes.MouseLeave += new System.EventHandler(this.btnYes_MouseLeave);
            this.btnYes.MouseHover += new System.EventHandler(this.btn_yes_hover);
            // 
            // QuitPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SkyWarriorsClashofTitans.Properties.Resources.BGquit1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "QuitPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuitPanel";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnNo;
        private System.Windows.Forms.PictureBox btnYes;
    }
}