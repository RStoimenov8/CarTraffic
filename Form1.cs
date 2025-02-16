using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brichka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        int speed=5;
        int score = 0;
        bool goL = false;
        bool goR = false;
        bool gameStart = false;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = null;
            label2.Text = "За старт -> 'Space'\r\nКонтолите са стрелките!\r\nАвтор:\r\n-Росен Стоименов";
        }

        private void Put_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Road")
                {
                    x.Top += 2;
                    if (x.Top>=ClientSize.Height)
                    {
                        x.Top = -6;
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gameStart = true;
                label2.Visible = false;
                Game.Start();
                Put.Start();
            }
            if (e.KeyCode==Keys.Right)
            {
                goR = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goL = true;
            }
        }
        private void Stop()
        {
            
                Game.Stop();
                Put.Stop();
                MessageBox.Show("Ти загуби!\r\nРезултат: " + score);
                Application.Restart();
           
        }

        private void Game_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            if (gameStart)
            {
                Enemy1.Visible = false;
                Enemy2.Visible = false;
                Enemy3.Visible = false;
                gameStart = !gameStart;
            }
            label1.Text = "Резултат: " + score;
            
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Car")
                {
                    x.Top += 3;
                    if (Enemy1.Top >= ClientSize.Height)
                    {
                        Enemy1.Top = r.Next(-130, -80);
                        score++;
                        Enemy1.Visible = true;
                        
                    }
                    if (Enemy2.Top >= ClientSize.Height)
                    {
                        Enemy2.Top = r.Next(-350, -300);
                        score++;
                        Enemy2.Visible = true;

                    }
                    if (Enemy3.Top >= ClientSize.Height)
                    {
                        Enemy3.Top = r.Next(-820, -570);
                        score++;
                        Enemy3.Visible = true;

                    }
                   
                }
            }
            if (goL)
            {
                Player.Left -= speed;
            }
            if (goR)
            {
                Player.Left += speed;
            }
            if (Player.Left<=1)
            {
                goL = false;
            }
            else if (Player.Left>=302)
            {
                goR = false;
            }
            if (Player.Bounds.IntersectsWith(Enemy1.Bounds) && Enemy1.Visible == true)
            {
                Stop();
            }
            if (Player.Bounds.IntersectsWith(Enemy2.Bounds) && Enemy2.Visible == true)
            {
                Stop();
            }
            if (Player.Bounds.IntersectsWith(Enemy3.Bounds) && Enemy3.Visible == true)
            {
                Stop();
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                goR = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goL = false;
            }
        }
    }
}
