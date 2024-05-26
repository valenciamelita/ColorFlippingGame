using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace week_7_class_assignment
{
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();
        List <Button> buttonlist = new List <Button> ();
        private DateTime startTime;

        public int b;

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[b, b];
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(40, 40);
                    button.Location = new Point(40 * j + 100, 40 * i + 50);
                    button.Tag = i.ToString() + "," + j.ToString();
                    buttonlist.Add(button);
                    button.BackColor = Color.White;
                    button.Click += Button_Click;
                    Controls.Add(buttonlist[buttonlist.Count-1]);

                }

            }
            startTime = DateTime.Now;


            timer1.Start();
            

        }

        public void menang()
        {
            
            int scorered = 0;
            int scoreblue = 0;
            int total = b*b;
            for (int i = 0;i < buttonlist.Count;i++)
            {
                if (buttonlist[i].BackColor == Color.Salmon)
                {
                    scorered++;
                }
                if (buttonlist[i].BackColor == Color.CornflowerBlue)
                {
                    scoreblue++;
                }
            }
            if ((scorered == total) || (scoreblue == total))
            {
                label_scoreblue.Text = scoreblue.ToString();
                label_scorered.Text = scorered.ToString();
                timer1.Stop();
                var result = MessageBox.Show($"You win the Puzzle! Time elapsed: {label_timer.Text}\nDo you want to play again?", "Congratulations!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    this.Close();

                }
                else
                {
                    Environment.Exit(1);
                }
            }
            label_scoreblue.Text = scoreblue.ToString();
            label_scorered.Text = scorered.ToString();
        }

        

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
           

            if (button.BackColor != Color.Salmon)
            {
                button.BackColor = Color.Salmon;
            }
            else
            {
                button.BackColor = Color.CornflowerBlue;
            }

            
            int x = Convert.ToInt32(button.Tag.ToString().Split(',')[0]);
            int y = Convert.ToInt32(button.Tag.ToString().Split(',')[1]);

            for (int i = 0; i < buttonlist.Count; i++)
            {
                if (Convert.ToInt32(buttonlist[i].Tag.ToString().Split(',')[0])==x-1 && Convert.ToInt32(buttonlist[i].Tag.ToString().Split(',')[1]) == y)
                {
                    if (buttonlist[i].BackColor == Color.Salmon)
                    {
                        buttonlist[i].BackColor = Color.CornflowerBlue;    
                    }
                    else if (buttonlist[i].BackColor == Color.CornflowerBlue)
                    {
                        buttonlist[i].BackColor = Color.Salmon;
                    }
                }
                if (Convert.ToInt32(buttonlist[i].Tag.ToString().Split(',')[0]) == x + 1 && Convert.ToInt32(buttonlist[i].Tag.ToString().Split(',')[1]) == y)
                {
                    if (buttonlist[i].BackColor == Color.Salmon)
                    {
                        buttonlist[i].BackColor = Color.CornflowerBlue;
                    }
                    else if (buttonlist[i].BackColor == Color.CornflowerBlue)
                    {
                        buttonlist[i].BackColor = Color.Salmon;
                    }
                }
                if (Convert.ToInt32(buttonlist[i].Tag.ToString().Split(',')[0]) == x  && Convert.ToInt32(buttonlist[i].Tag.ToString().Split(',')[1]) == y+1)
                {
                    if (buttonlist[i].BackColor == Color.Salmon)
                    {
                        buttonlist[i].BackColor = Color.CornflowerBlue;
                    }
                    else if (buttonlist[i].BackColor == Color.CornflowerBlue)
                    {
                        buttonlist[i].BackColor = Color.Salmon;
                    }
                }
                if (Convert.ToInt32(buttonlist[i].Tag.ToString().Split(',')[0]) == x && Convert.ToInt32(buttonlist[i].Tag.ToString().Split(',')[1]) == y - 1)
                {
                    if (buttonlist[i].BackColor == Color.Salmon)
                    {
                        buttonlist[i].BackColor = Color.CornflowerBlue;
                    }
                    else if (buttonlist[i].BackColor == Color.CornflowerBlue)
                    {
                        buttonlist[i].BackColor = Color.Salmon;
                    }
                }

            }
            menang();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            label_timer.Text = $"{elapsedTime.Minutes:D2}:{elapsedTime.Seconds:D2}:{elapsedTime.Milliseconds:D3}";
        }
    }
}
