namespace SkyWarriorsClashofTitans
{
    partial class MenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.MenuTimer = new System.Windows.Forms.Timer(this.components);
            this.BackgroundMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.player_icon3 = new System.Windows.Forms.PictureBox();
            this.player_icon1 = new System.Windows.Forms.PictureBox();
            this.player_icon4 = new System.Windows.Forms.PictureBox();
            this.player_icon2 = new System.Windows.Forms.PictureBox();
            this.btn_quit = new System.Windows.Forms.PictureBox();
            this.btn_shop = new System.Windows.Forms.PictureBox();
            this.btn_settings = new System.Windows.Forms.PictureBox();
            this.btn_play = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMusic)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player_icon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_icon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_shop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTimer
            // 
            this.MenuTimer.Tag = "MainMenuEvent";
            // 
            // BackgroundMusic
            // 
            this.BackgroundMusic.Enabled = true;
            this.BackgroundMusic.Location = new System.Drawing.Point(668, 12);
            this.BackgroundMusic.Name = "BackgroundMusic";
            this.BackgroundMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BackgroundMusic.OcxState")));
            this.BackgroundMusic.Size = new System.Drawing.Size(195, 60);
            this.BackgroundMusic.TabIndex = 1;
            this.BackgroundMusic.Visible = false;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.BackgroundImage = global::SkyWarriorsClashofTitans.Properties.Resources.MenuPanel;
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPanel.Controls.Add(this.player_icon3);
            this.menuPanel.Controls.Add(this.player_icon1);
            this.menuPanel.Controls.Add(this.player_icon4);
            this.menuPanel.Controls.Add(this.player_icon2);
            this.menuPanel.Controls.Add(this.btn_quit);
            this.menuPanel.Controls.Add(this.btn_shop);
            this.menuPanel.Controls.Add(this.btn_settings);
            this.menuPanel.Controls.Add(this.btn_play);
            this.menuPanel.Location = new System.Drawing.Point(608, 116);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(311, 656);
            this.menuPanel.TabIndex = 0;
            // 
            // player_icon3
            // 
            this.player_icon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player_icon3.Image = global::SkyWarriorsClashofTitans.Properties.Resources.Enemy3;
            this.player_icon3.Location = new System.Drawing.Point(238, 79);
            this.player_icon3.Name = "player_icon3";
            this.player_icon3.Size = new System.Drawing.Size(51, 41);
            this.player_icon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player_icon3.TabIndex = 1;
            this.player_icon3.TabStop = false;
            // 
            // player_icon1
            // 
            this.player_icon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player_icon1.Image = global::SkyWarriorsClashofTitans.Properties.Resources.F9_ezgif_com_crop;
            this.player_icon1.Location = new System.Drawing.Point(27, 30);
            this.player_icon1.Name = "player_icon1";
            this.player_icon1.Size = new System.Drawing.Size(103, 90);
            this.player_icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player_icon1.TabIndex = 1;
            this.player_icon1.TabStop = false;
            // 
            // player_icon4
            // 
            this.player_icon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player_icon4.Image = global::SkyWarriorsClashofTitans.Properties.Resources.Enemy3;
            this.player_icon4.Location = new System.Drawing.Point(168, 66);
            this.player_icon4.Name = "player_icon4";
            this.player_icon4.Size = new System.Drawing.Size(51, 41);
            this.player_icon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player_icon4.TabIndex = 1;
            this.player_icon4.TabStop = false;
            // 
            // player_icon2
            // 
            this.player_icon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player_icon2.Image = global::SkyWarriorsClashofTitans.Properties.Resources.Enemy3;
            this.player_icon2.Location = new System.Drawing.Point(220, 17);
            this.player_icon2.Name = "player_icon2";
            this.player_icon2.Size = new System.Drawing.Size(51, 41);
            this.player_icon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player_icon2.TabIndex = 1;
            this.player_icon2.TabStop = false;
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quit.Image = global::SkyWarriorsClashofTitans.Properties.Resources.QuitBtn;
            this.btn_quit.Location = new System.Drawing.Point(45, 510);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(226, 109);
            this.btn_quit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quit.TabIndex = 0;
            this.btn_quit.TabStop = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            this.btn_quit.MouseLeave += new System.EventHandler(this.btn_quit_MouseLeave);
            this.btn_quit.MouseHover += new System.EventHandler(this.btn_quit_MouseHover);
            // 
            // btn_shop
            // 
            this.btn_shop.BackColor = System.Drawing.Color.Transparent;
            this.btn_shop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_shop.Image = global::SkyWarriorsClashofTitans.Properties.Resources.ShopBtn;
            this.btn_shop.Location = new System.Drawing.Point(45, 254);
            this.btn_shop.Name = "btn_shop";
            this.btn_shop.Size = new System.Drawing.Size(226, 109);
            this.btn_shop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_shop.TabIndex = 0;
            this.btn_shop.TabStop = false;
            this.btn_shop.Click += new System.EventHandler(this.btn_shop_Click);
            this.btn_shop.MouseLeave += new System.EventHandler(this.btn_shop_MouseLeave);
            this.btn_shop.MouseHover += new System.EventHandler(this.btn_shop_MouseHover);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.Image = global::SkyWarriorsClashofTitans.Properties.Resources.SettingsBtn;
            this.btn_settings.Location = new System.Drawing.Point(45, 382);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(226, 109);
            this.btn_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_settings.TabIndex = 0;
            this.btn_settings.TabStop = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            this.btn_settings.MouseLeave += new System.EventHandler(this.btn_settings_MouseLeave);
            this.btn_settings.MouseHover += new System.EventHandler(this.btn_settings_MouseHover);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.Image = global::SkyWarriorsClashofTitans.Properties.Resources.PlayBtn;
            this.btn_play.Location = new System.Drawing.Point(45, 126);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(226, 109);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_play.TabIndex = 0;
            this.btn_play.TabStop = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            this.btn_play.MouseLeave += new System.EventHandler(this.btn_play_MouseLeave);
            this.btn_play.MouseHover += new System.EventHandler(this.btn_play_MouseHover);
            // 
            // MenuScreen
            // 
            this.BackgroundImage = global::SkyWarriorsClashofTitans.Properties.Resources.Backgrounds7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1527, 784);
            this.ControlBox = false;
            this.Controls.Add(this.BackgroundMusic);
            this.Controls.Add(this.menuPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuScreen";
            this.Text = "Sky Warrios: Clash of Tians";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundMusic)).EndInit();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player_icon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_icon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_shop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_play;
        private System.Windows.Forms.PictureBox btn_settings;
        private System.Windows.Forms.PictureBox btn_quit;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox player_icon1;
        private System.Windows.Forms.PictureBox player_icon2;
        private System.Windows.Forms.PictureBox player_icon3;
        private System.Windows.Forms.PictureBox player_icon4;
        private System.Windows.Forms.Timer MenuTimer;
        private AxWMPLib.AxWindowsMediaPlayer BackgroundMusic;
        private System.Windows.Forms.PictureBox btn_shop;
    }
}