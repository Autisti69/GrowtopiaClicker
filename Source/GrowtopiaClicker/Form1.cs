using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrowtopiaClicker
{
    public partial class Form1 : Form
    {
        int playerScore = 0;
        int autist = 1;
        int n = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = autist.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playerScore > 50) {
            playerScore -= 50;
            textBox1.Text = playerScore.ToString();
            textBox2.Text = autist.ToString();
            autist += 1;
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

    private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerScore += autist;
            textBox1.Text = playerScore.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (playerScore > 150)
            {
                playerScore -= 150;
                textBox1.Text = playerScore.ToString();
                textBox2.Text = autist.ToString();
                autist += 3;
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
                textBox2.Text = autist.ToString();
                autist += 5;
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (playerScore > 1000000)
            {
                playerScore -= 1000000;
                textBox1.Text = playerScore.ToString();
                textBox2.Text = autist.ToString();
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                
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
                textBox2.Text = autist.ToString();
                autist += 10;
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
                textBox2.Text = autist.ToString();
                autist += 20;
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
                textBox2.Text = autist.ToString();
                autist += 50;
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
                textBox2.Text = autist.ToString();
                autist += 100;
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
                textBox2.Text = autist.ToString();
                autist += 200;
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
                textBox2.Text = autist.ToString();
                autist += 300;
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
                textBox2.Text = autist.ToString();
                autist += 400;
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
                textBox2.Text = autist.ToString();
                autist += 500;
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
                textBox2.Text = autist.ToString();
                autist += 1000;
            }
            else
            {
                MessageBox.Show("You cant do that! You dont have enough Emerald Locks.");
            }
        }
    }
}
