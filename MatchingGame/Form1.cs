using System.Configuration;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        Random randomic = new Random();
        List<string> icons = new List<string>();

        Label firstClicked = null;
        Label secondClicked = null;
        decimal seconds = 0;

        int points = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillList();

            AssignIconsToSquares();

            //Inicializando meu timer
            timer1.Enabled = true;
            timer1.Start();
        }

        private void FillList()
        {
            icons.Add("!");
            icons.Add("!");
            icons.Add("N");
            icons.Add("N");
            icons.Add(",");
            icons.Add(",");
            icons.Add("k");
            icons.Add("k");
            icons.Add("b");
            icons.Add("b");
            icons.Add("v");
            icons.Add("v");
            icons.Add("w");
            icons.Add("w");
            icons.Add("z");
            icons.Add("z");
        }

        public void AssignIconsToSquares()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if(iconLabel != null)
                {
                    int randomNumber = randomic.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                    iconLabel.ForeColor = iconLabel.BackColor;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        public void ChangeForeColor(object sender)
        {
            Label clickedLabel = sender as Label;

            if (firstClicked != null && secondClicked != null)
            {
                if (firstClicked.Text != secondClicked.Text)
                {
                    firstClicked.ForeColor = firstClicked.BackColor;
                    secondClicked.ForeColor = secondClicked.BackColor;
                }

                firstClicked = null;
                secondClicked = null;
            }

            if (clickedLabel != null)
            {
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                }
                else if (secondClicked == null)
                {
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        points++;

                        if(points == 8)
                        {
                            MessageBox.Show("Parabéns, seu tempo foi: " + (seconds / 60).ToString("0.00") + " minutos");
                            
                            var response = MessageBox.Show("Deseja começar outro jogo?", "Iniciar outro jogo?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if(response == DialogResult.Yes)
                            {
                                FillList();

                                AssignIconsToSquares();

                                timer1.Stop();
                                timer1.Enabled = false;

                                timer1.Enabled = true;
                                timer1.Start();
                            }
                            else
                            {
                                this.Close();
                            }
                            
                            
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
        }
    }
}