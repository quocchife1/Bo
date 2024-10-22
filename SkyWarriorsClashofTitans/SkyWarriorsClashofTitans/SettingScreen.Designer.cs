namespace SkyWarriorsClashofTitans
{
    partial class SettingScreen
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
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.MusicTag = new System.Windows.Forms.Label();
            this.SettingTitle = new System.Windows.Forms.PictureBox();
            this.MusicPercent = new System.Windows.Forms.PictureBox();
            this.Volume = new System.Windows.Forms.TrackBar();
            this.SettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingPanel
            // 
            this.SettingPanel.BackColor = System.Drawing.Color.Transparent;
            this.SettingPanel.BackgroundImage = global::SkyWarriorsClashofTitans.Properties.Resources.MenuPanel2;
            this.SettingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingPanel.Controls.Add(this.btn_back);
            this.SettingPanel.Controls.Add(this.MusicTag);
            this.SettingPanel.Controls.Add(this.SettingTitle);
            this.SettingPanel.Controls.Add(this.MusicPercent);
            this.SettingPanel.Controls.Add(this.Volume);
            this.SettingPanel.Location = new System.Drawing.Point(414, 260);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(698, 296);
            this.SettingPanel.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Image = global::SkyWarriorsClashofTitans.Properties.Resources.BackBtn__2_;
            this.btn_back.Location = new System.Drawing.Point(280, 199);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(178, 97);
            this.btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_back.TabIndex = 4;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            this.btn_back.MouseLeave += new System.EventHandler(this.btn_back_MouseLeave);
            this.btn_back.MouseHover += new System.EventHandler(this.btn_back_MouseHover);
            // 
            // MusicTag
            // 
            this.MusicTag.AutoSize = true;
            this.MusicTag.BackColor = System.Drawing.Color.Transparent;
            this.MusicTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicTag.ForeColor = System.Drawing.Color.White;
            this.MusicTag.Location = new System.Drawing.Point(42, 130);
            this.MusicTag.Name = "MusicTag";
            this.MusicTag.Size = new System.Drawing.Size(130, 46);
            this.MusicTag.TabIndex = 3;
            this.MusicTag.Text = "Music";
            // 
            // SettingTitle
            // 
            this.SettingTitle.BackColor = System.Drawing.Color.Transparent;
            this.SettingTitle.Image = global::SkyWarriorsClashofTitans.Properties.Resources.SettingTitle;
            this.SettingTitle.Location = new System.Drawing.Point(198, 0);
            this.SettingTitle.Name = "SettingTitle";
            this.SettingTitle.Size = new System.Drawing.Size(341, 103);
            this.SettingTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingTitle.TabIndex = 2;
            this.SettingTitle.TabStop = false;
            // 
            // MusicPercent
            // 
            this.MusicPercent.BackColor = System.Drawing.Color.Transparent;
            this.MusicPercent.Image = global::SkyWarriorsClashofTitans.Properties.Resources._100V;
            this.MusicPercent.Location = new System.Drawing.Point(602, 120);
            this.MusicPercent.Name = "MusicPercent";
            this.MusicPercent.Size = new System.Drawing.Size(53, 56);
            this.MusicPercent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MusicPercent.TabIndex = 1;
            this.MusicPercent.TabStop = false;
            // 
            // Volume
            // 
            this.Volume.BackColor = System.Drawing.Color.Black;
            this.Volume.Location = new System.Drawing.Point(174, 130);
            this.Volume.Maximum = 100;
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(422, 56);
            this.Volume.TabIndex = 0;
            this.Volume.Value = 50;
            this.Volume.Scroll += new System.EventHandler(this.Volume_Scroll);
            // 
            // SettingScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1527, 784);
            this.Controls.Add(this.SettingPanel);
            this.Name = "SettingScreen";
            this.Text = "SettingScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SettingPanel.ResumeLayout(false);
            this.SettingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar Volume;
        private System.Windows.Forms.PictureBox MusicPercent;
        private System.Windows.Forms.PictureBox SettingTitle;
        private System.Windows.Forms.Label MusicTag;
        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.PictureBox btn_back;
    }
}