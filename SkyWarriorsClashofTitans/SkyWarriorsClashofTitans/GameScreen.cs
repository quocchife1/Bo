using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SkyWarriorsClashofTitans
{
    public partial class GameScreen : Form
    {
        bool goLeft, goRight, goDown, goUp, shooting, isGameOver;
        bool isFormClosing = false;
        int score;
        int highestScrore;
        int playerSpeed = 12;
        int enemySpeed;
        int bulletSpeed;
        string notification;
        int countB = 10;
        int count = 0;
        int charSelected;        
        Random rand = new Random();
        WindowsMediaPlayer player;
        private SoundPlayer shootSound;
        private SoundPlayer enemyDeadSound;
        private UnmanagedMemoryStream enemyDeadStream;
        public GameScreen(int choice)
 
        {
            InitializeComponent();

            this.FormClosing += GameScreen_FormClosing;

            LoadShootSound();
            updatePlayer();

            updateScoreLabel();
            resetGame();
            charSelected = choice;
            updatePlayer();
        }
        private void GameScreen_Load(object sender, EventArgs e)
        {
            enemyDeadStream = Properties.Resources.EnemyDeadSFX;
            enemyDeadSound = new SoundPlayer(enemyDeadStream);
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

        private void LoadShootSound()
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "Sound_Shotting.wav");
            switch (charSelected)
            {
                case 1:
                    File.WriteAllBytes(tempPath, Properties.Resources.Sound_Shotting);
                    break;
                case 2:
                    File.WriteAllBytes(tempPath, Properties.Resources.Sound_Shotting);
                    break;
                case 3:
                    File.WriteAllBytes(tempPath, Properties.Resources.Sound_Shotting);
                    break;
                case 4:
                    File.WriteAllBytes(tempPath, Properties.Resources.Sound_Shotting);
                    break;
                case 5:
                    File.WriteAllBytes(tempPath, Properties.Resources.Sound_Shotting);
                    break;
                case 6:
                    File.WriteAllBytes(tempPath, Properties.Resources.Sound_Shotting);
                    break;
                case 7:
                    File.WriteAllBytes(tempPath, Properties.Resources.Sound_Shotting);
                    break;
                case 8:
                    File.WriteAllBytes(tempPath, Properties.Resources.Sound_Shotting);
                    break;
                case 9:
                    File.WriteAllBytes(tempPath, Properties.Resources.Sound_Shotting);
                    break;
                case 10:
                    File.WriteAllBytes(tempPath, Properties.Resources.Sound_Shotting);
                    break;
                default:
                    File.WriteAllBytes(tempPath, Properties.Resources.Sound_Shotting);
                    break;
            }
            shootSound = new SoundPlayer(tempPath);
        }


        private void GameScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            isFormClosing = true;
            StopGame();

            if (enemyDeadStream != null)
            {
                enemyDeadStream.Close();
                enemyDeadStream = null;
            }
        }
        private void StopGame()
        {
            gameTimer.Stop();
        }


        private void updatePlayer()
        {
            switch (charSelected)
            {
                case 1:
                    playerF9.Image = Properties.Resources.Pl_F9;
                    break;
                case 2:
                    playerF9.Image = Properties.Resources.PL_F10;
                    break;
                case 3:
                    playerF9.Image = Properties.Resources.Pl_F11;
                    break;
                case 4:
                    playerF9.Image = Properties.Resources.Pl_F12;
                    break;
                case 5:
                    playerF9.Image = Properties.Resources.Pl_F13;
                    break;
                case 6:
                    playerF9.Image = Properties.Resources.Pl_F14;
                    break;
                case 7:
                    playerF9.Image = Properties.Resources.Pl_F15;
                    break;
                case 8:
                    playerF9.Image = Properties.Resources.Pl_F16;
                    break;
                case 9:
                    playerF9.Image = Properties.Resources.Pl_18;
                    break;
                case 10:
                    playerF9.Image = Properties.Resources.Pl_19;
                    break;
                default:
                    break;
            }
            LoadShootSound();
        }

        
        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            

            #region End condition
            
            if (enemyOne.Left < -300 || enemyTwo.Left < -300 || enemyThree.Left < -300 || enemyFour.Left < -300 )
            {
                gameOver();
            }
            #endregion

            #region Player movement logic

            if (goLeft == true && playerF9.Left > 0)
            {
                playerF9.Left -= playerSpeed;
            }

            if(goRight == true && playerF9.Right < 1536)
            {
                playerF9.Left += playerSpeed;
            }

            if(goUp == true && playerF9.Top > 0) 
            {
                playerF9.Top -= playerSpeed;
            }
            if(goDown == true && playerF9.Top < 750)
            {
                playerF9.Top += playerSpeed;
            }
            if (playerF9.Bounds.IntersectsWith(txtScore.Bounds))
            {
                playerF9.Top += playerSpeed;
                playerF9.Left += playerSpeed;
            }

            #endregion

            #region Shooting logic
            if (shooting == true)
            {
                bulletSpeed = 20;
                bulletF9.Left += bulletSpeed;
            }
            else
            {
                bulletF9.Left = -300;
                bulletSpeed = 0;
            }

            if(bulletF9.Left > 1470)
            {
                shooting = false;
            }

            #endregion 

            bossWave();

            #region Level up
            if (enemySpeed < 8)
            {
                while(count == 2)
                {
                enemySpeed += 1;
                count = 0;
                }
            }
            #endregion
        }
        #region Key setup
        private void keyisDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            
            if(e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

            if(e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if(e.KeyCode == Keys.Escape)
            {
                PauseGame();
            }
        }
        private void keyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if(e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;
                bulletF9.Left = playerF9.Left + 149;
                bulletF9.Top = playerF9.Top + 61;


                shootSound.Play();

            }

            if(e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
        }
        #endregion

        #region Main event
        private void stopEnemyWave()
        {
            enemyOne.Left = rand.Next(1600,2000);
            enemyTwo.Left = rand.Next(1600, 2000);
            enemyThree.Left = rand.Next(1600, 2000);
            enemyFour.Left = rand.Next(1600, 2000);
            
        }
        private void stopBossWave()
        {
            Boss.Left = rand.Next(1600, 2000);
        }

        private void enemyWave()
        {
            stopBossWave();
            enemyOne.Left -= enemySpeed;
            enemyTwo.Left -= enemySpeed;
            enemyThree.Left -= enemySpeed;
            enemyFour.Left -= enemySpeed;
            if (bulletF9.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                updateScore(1);
                count++;
                enemyOne.Top = rand.Next(10, 200);
                enemyOne.Left = rand.Next(1900, 2200);
                shooting = false;
                enemyDeadSound.Play();
            }
            if (bulletF9.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                updateScore(1);
                count++;
                enemyTwo.Top = rand.Next(210, 400);
                enemyTwo.Left = rand.Next(1900, 2200);
                shooting = false;

                enemyDeadSound.Play();

            }
            if (bulletF9.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                updateScore(1);
                count++;
                enemyThree.Top = rand.Next(410, 500);
                enemyThree.Left = rand.Next(1900, 2200);
                shooting = false;

                enemyDeadSound.Play();
            }

            if (bulletF9.Bounds.IntersectsWith(enemyFour.Bounds))
            {
                updateScore(1);
                count++;
                enemyFour.Top = rand.Next(610, 680);
                enemyFour.Left = rand.Next(1900, 2200);
                shooting = false;

                enemyDeadSound.Play();
            }
        }
        private void bossWave()
        {
            if(score == 10 || score == 15 || score == 20) 
            {
                stopEnemyWave();
                Boss.Left -= (enemySpeed) - 6;
                BossHealth.Visible = true;

                if (bulletF9.Bounds.IntersectsWith(Boss.Bounds))
                {
                    enemyDeadSound.Play();
                    countB -= 1;
                    BossHealth.Value = countB;
                    shooting = false;
                    if (countB == 0)
                    {
                        enemyDeadSound.Play();
                        updateScore(1);
                        count += 1;
                        Boss.Top = 48;
                        Boss.Left = 1500;
                        shooting = false;
                        BossHealth.Visible= false;
                        countB = 10;
                        BossHealth.Value = countB;
                    }
                }
                switch (score)
                {
                    case 15:
                        Boss.Image = Properties.Resources.Boss_1;
                        break;
                    case 20:
                        Boss.Image= Properties.Resources.Boss6;
                        break;
                    default:
                        break;
                }
               
            }
            else
            {
                enemyWave();
            }
        }
        #endregion

        #region Score
        private void updateScore(int point)
        {
            score += point;
            updateScoreLabel();
        }
        private void updateScoreLabel()
        {
            txtScore.Text = "Score: " + score.ToString();
        }

        #endregion

        #region Reset
        private void resetGame()
        {
            gameTimer.Start();
            enemySpeed = 5;
            count = 1;

            enemyOne.Top = rand.Next(10, 200);
            enemyTwo.Top = rand.Next(210, 400);
            enemyThree.Top = rand.Next(410, 500);
            enemyFour.Top = rand.Next(610, 680);

            enemyOne.Left = rand.Next(1900, 2200);
            enemyTwo.Left = rand.Next(1900, 2200);
            enemyThree.Left = rand.Next(1900, 2200);
            enemyFour.Left = rand.Next(1900, 2200);

            score = 0;
            bulletSpeed = 0;
            bulletF9.Left = -500;
            shooting = false;
            txtScore.Visible = true;

            playerF9.Top = 318;
            playerF9.Left = 12;

            updateScore(score);
        }
        #endregion

        #region ShowGameOverForm
        private void ShowGameOverForm()
        {
            GameOverForm gameOverForm = new GameOverForm();
            gameOverForm.SetScore(score);
            gameOverForm.ShowDialog();
        }
        #endregion

        private void ShowPauseScreen()
        {
            using (PauseScreen pauseScreen = new PauseScreen())
            {
                MenuScreen menuScreen = new MenuScreen();
                var result = pauseScreen.ShowDialog();
                if (result == DialogResult.OK)
                {
                    gameTimer.Start();
                }
                else
                {
                    if(result == DialogResult.Cancel)
                    {
                        menuScreen.ShowDialog();
                    }
                }
            }
        }

        private void PauseGame()
        {
            gameTimer.Stop();
            ShowPauseScreen();
        }


        #region Game over
        private void gameOver()
        {
            isGameOver = true;
            txtScore.Visible = false;
            gameTimer.Stop();
            if (!isFormClosing)
            {
                ShowGameOverForm();
            }
        }
        #endregion
    }
}