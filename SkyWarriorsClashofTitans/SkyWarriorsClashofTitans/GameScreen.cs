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

namespace SkyWarriorsClashofTitans
{
    public partial class GameScreen : Form
    {
        bool goLeft, goRight, goDown, goUp, shooting, isGameOver;
        int score;
        int highestScrore;
        int playerSpeed = 12;
        int enemySpeed;
        int bulletSpeed;
        string notification;
        int countB = 0;
        int count = 0;
        
        Random rand = new Random();
        WindowsMediaPlayer player;
        public GameScreen()
        {
            InitializeComponent();
            Form1_Load();
            updateScoreLabel();
            resetGame();
        }
        private void mainGameTimerEvent(object sender, EventArgs e)
        {


            #region End condition

            if (enemyOne.Left < -300 || enemyTwo.Left < -300 || enemyThree.Left < -300 || enemyFour.Left < -300)
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
            if(goDown == true && playerF9.Top < 782)
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
            if (enemySpeed < 10)
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
                this.Close();
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

                bulletF9.Left = playerF9.Left + 120;
                bulletF9.Top = playerF9.Top + 23;
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
            }
            if (bulletF9.Bounds.IntersectsWith(enemyTwo.Bounds))
            {

                updateScore(1);
                count++;
                enemyTwo.Top = rand.Next(210, 400);
                enemyTwo.Left = rand.Next(1900, 2200);
                shooting = false;

            }
            if (bulletF9.Bounds.IntersectsWith(enemyThree.Bounds))
            {

                updateScore(1);
                count++;
                enemyThree.Top = rand.Next(410, 500);
                enemyThree.Left = rand.Next(1900, 2200);
                shooting = false;
            }

            if (bulletF9.Bounds.IntersectsWith(enemyFour.Bounds))
            {

                updateScore(1);
                count++;
                enemyFour.Top = rand.Next(610, 680);
                enemyFour.Left = rand.Next(1900, 2200);
                shooting = false;
            }
        }

        private void bossWave()
        {
            if(score == 10)
            {
                stopEnemyWave();
                Boss.Left -= (enemySpeed) - 5;
                if (bulletF9.Bounds.IntersectsWith(Boss.Bounds))
                {

                    countB += 1;
                    shooting = false;
                    if (countB == 5)
                    {
                        updateScore(1);
                        count += 1;
                        Boss.Top = 394;
                        Boss.Left = 1500;
                        shooting = false;
                    }
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

        #region Full screen
        private void Form1_Load()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None; 
            this.WindowState = FormWindowState.Maximized; 
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
            bulletF9.Left = -300;
            shooting = false;
            txtScore.Visible = true;
        }
        #endregion


        #region Game over
        private void gameOver()
        {
            isGameOver = true;
            txtScore.Visible = false;

            //playerF9.BackColor = Color.FromArgb(100,0,0,0);

            gameTimer.Stop();
        }
        #endregion
    }
}