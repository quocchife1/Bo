﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SkyWarriorsClashofTitans
{
    public partial class ShopScreen : Form
    {
        public static int charSelected;
        public ShopScreen()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        private void btn_play_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE1.wav");
            sound.Play();
            this.Close();
        }

        private void btn_play_MouseHover(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.Back_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE2.wav");
            sound.Play();
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.BackBtn__2_;
        }

        private void OK_btn_MouseHover(object sender, EventArgs e)
        {
            OK_btn.Image = Properties.Resources.ok_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE2.wav");
            sound.Play();
        }

        private void OK_btn_MouseLeave(object sender, EventArgs e)
        {
            OK_btn.Image = Properties.Resources.OKbtn;
        }

        private void slot1_Click(object sender, EventArgs e)
        {
            charSelected = 1;
            selectBorder.Left = slot1.Left - 22;
            selectBorder.Top = slot1.Top - 26;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE8.wav");
            sound.Play();
        }

        private void slot2_Click(object sender, EventArgs e)
        {
            charSelected = 2;
            selectBorder.Left = slot2.Left - 22;
            selectBorder.Top = slot2.Top - 26;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE8.wav");
            sound.Play();
        }

        private void slot3_Click(object sender, EventArgs e)
        {
            charSelected = 3;
            selectBorder.Left = slot3.Left - 22;
            selectBorder.Top = slot3.Top - 26;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE8.wav");
            sound.Play();
        }

        private void slot4_Click(object sender, EventArgs e)
        {
            charSelected = 4;
            selectBorder.Left = slot4.Left - 22;
            selectBorder.Top = slot4.Top - 26;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE8.wav");
            sound.Play();
        }

        private void slot5_Click(object sender, EventArgs e)
        {
            charSelected = 5;
            selectBorder.Left = slot5.Left - 22;
            selectBorder.Top = slot5.Top - 26;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE8.wav");
            sound.Play();
        }

        private void slot6_Click(object sender, EventArgs e)
        {
            charSelected = 6;
            selectBorder.Left = slot6.Left - 22;
            selectBorder.Top = slot6.Top - 26;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE8.wav");
            sound.Play();
        }

        private void slot7_Click(object sender, EventArgs e)
        {
            charSelected = 7;
            selectBorder.Left = slot7.Left - 22;
            selectBorder.Top = slot7.Top - 26;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE8.wav");
            sound.Play();
        }

        private void slot8_Click(object sender, EventArgs e)
        {
            charSelected = 8;
            selectBorder.Left = slot8.Left - 22;
            selectBorder.Top = slot8.Top - 26;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE8.wav");
            sound.Play();
        }

        private void slot9_Click(object sender, EventArgs e)
        {
            charSelected = 9;
            selectBorder.Left = slot9.Left - 22;
            selectBorder.Top = slot9.Top - 26;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE8.wav");
            sound.Play();
        }

        private void slot10_Click(object sender, EventArgs e)
        {
            charSelected = 10;
            selectBorder.Left = slot10.Left - 22;
            selectBorder.Top = slot10.Top - 26;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE8.wav");
            sound.Play();
        }
        private void WriteFile()
        {
            string filePath = @"D:\Github\Winforms\Character.txt";
            string select = charSelected.ToString();

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(select);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
        private void OK_btn_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE1.wav");
            sound.Play();
            WriteFile();
        }
    }
}
