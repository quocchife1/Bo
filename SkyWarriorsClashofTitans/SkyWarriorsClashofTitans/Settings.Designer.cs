namespace SkyWarriorsClashofTitans
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SoundSituation = new System.Windows.Forms.PictureBox();
            this.SoundValue = new System.Windows.Forms.TrackBar();
            this.SettingsTitle = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundSituation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SkyWarriorsClashofTitans.Properties.Resources.MenuPanel2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.SoundSituation);
            this.panel1.Controls.Add(this.SoundValue);
            this.panel1.Controls.Add(this.SettingsTitle);
            this.panel1.Location = new System.Drawing.Point(457, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 446);
            this.panel1.TabIndex = 0;
            // 
            // SoundSituation
            // 
            this.SoundSituation.BackColor = System.Drawing.Color.Transparent;
            this.SoundSituation.Image = ((System.Drawing.Image)(resources.GetObject("SoundSituation.Image")));
            this.SoundSituation.Location = new System.Drawing.Point(91, 223);
            this.SoundSituation.Name = "SoundSituation";
            this.SoundSituation.Size = new System.Drawing.Size(102, 88);
            this.SoundSituation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SoundSituation.TabIndex = 2;
            this.SoundSituation.TabStop = false;
            // 
            // SoundValue
            // 
            this.SoundValue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SoundValue.Location = new System.Drawing.Point(217, 255);
            this.SoundValue.Maximum = 100;
            this.SoundValue.Name = "SoundValue";
            this.SoundValue.Size = new System.Drawing.Size(561, 56);
            this.SoundValue.TabIndex = 1;
            this.SoundValue.Value = 100;
            // 
            // SettingsTitle
            // 
            this.SettingsTitle.BackColor = System.Drawing.Color.Transparent;
            this.SettingsTitle.Image = global::SkyWarriorsClashofTitans.Properties.Resources.SettingBtn_crop;
            this.SettingsTitle.Location = new System.Drawing.Point(217, -199);
            this.SettingsTitle.Name = "SettingsTitle";
            this.SettingsTitle.Size = new System.Drawing.Size(504, 332);
            this.SettingsTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsTitle.TabIndex = 0;
            this.SettingsTitle.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 784);
            this.Controls.Add(this.panel1);
            this.Name = "Settings";
            this.Text = "HelpScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundSituation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoundValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox SettingsTitle;
        private System.Windows.Forms.TrackBar SoundValue;
        private System.Windows.Forms.PictureBox SoundSituation;
    }
}