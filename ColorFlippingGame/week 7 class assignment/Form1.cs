using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_7_class_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int a;

        private void button_number_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbox_input.Text))
            {
                MessageBox.Show("Please fill it with Number!", "Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a = (Convert.ToInt32(textbox_input.Text));
                if (a < 5)
                {
                    MessageBox.Show("Input can't be lower than 5!");
                    textbox_input.Clear();
                    textbox_input.Focus();
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.b = a;
                    form2.ShowDialog();
                    textbox_input.Clear();
                }
            }
        }

        private void textbox_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) ;

            if (e.KeyChar == (char)Keys.Enter)
            {
                button_number_Click(sender, e);
            }
        }
    }
}
