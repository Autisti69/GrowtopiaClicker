using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrowtopiaClicker
{
    public partial class Form2 : Form
    {
        int playerScore = 0;
        int autist = 1;
        int n = 10;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.Text = autist.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (playerScore > 50)
            {
                playerScore -= 50;
                textBox1.Text = playerScore.ToString();
                autist += 1;
                textBox2.Text = autist.ToString();
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerScore += autist;
            textBox1.Text = playerScore.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (playerScore > 150)
            {
                playerScore -= 150;
                textBox1.Text = playerScore.ToString();
                autist += 3;
                textBox2.Text = autist.ToString();
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (playerScore > 250)
            {
                playerScore -= 250;
                textBox1.Text = playerScore.ToString();
                autist += 5;
                textBox2.Text = autist.ToString();
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (playerScore > 100000000)
            {
                playerScore -= 100000000;
                textBox1.Text = playerScore.ToString();
                
                MessageBox.Show("Congratz! You wasted 100 million because there is no next stage yet.");
                textBox2.Text = autist.ToString();
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (playerScore > 500)
            {
                playerScore -= 500;
                textBox1.Text = playerScore.ToString();
                autist += 10;
                textBox2.Text = autist.ToString();
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (playerScore > 1000)
            {
                playerScore -= 1000;
                textBox1.Text = playerScore.ToString();
                autist += 20;
                textBox2.Text = autist.ToString();
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (playerScore > 2500)
            {
                playerScore -= 2500;
                textBox1.Text = playerScore.ToString();
                autist += 50;
                textBox2.Text = autist.ToString();
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (playerScore > 5000)
            {
                playerScore -= 5000;
                textBox1.Text = playerScore.ToString();
                autist += 100;
                textBox2.Text = autist.ToString();
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (playerScore > 10000)
            {
                playerScore -= 10000;
                textBox1.Text = playerScore.ToString();
                autist += 200;
                textBox2.Text = autist.ToString();
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (playerScore > 15000)
            {
                playerScore -= 15000;
                textBox1.Text = playerScore.ToString();
                autist += 300;
                textBox2.Text = autist.ToString();
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (playerScore > 20000)
            {
                playerScore -= 20000;
                textBox1.Text = playerScore.ToString();
                autist += 400;
                textBox2.Text = autist.ToString();
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (playerScore > 25000)
            {
                playerScore -= 25000;
                textBox1.Text = playerScore.ToString();
                autist += 500;
                textBox2.Text = autist.ToString();
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (playerScore > 50000)
            {
                playerScore -= 50000;
                textBox1.Text = playerScore.ToString();
                autist += 1000;
                textBox2.Text = autist.ToString();
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}