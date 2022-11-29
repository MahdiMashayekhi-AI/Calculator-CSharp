using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double x, y, z;
        string op;
        Boolean flag;
        public Form1()
        {
            InitializeComponent();
        }

       

        
        private void Numbers(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                txtdisplay.Text = "";
                flag = false;
            }

            txtdisplay.Text += ((Button)sender).Text;
        }

        private void Operators(object sender, MouseEventArgs e)
        {
            if (op != null)
                btnequal_Click(null, null);
            x = Convert.ToDouble(txtdisplay.Text);
            op = ((Button)sender).Text;
            flag = true;
        }

        private void btnequal_Click(object sender, MouseEventArgs e)
        {
            y = Convert.ToDouble(txtdisplay.Text);
            switch (op)
            {

                case "+":
                    z = x + y;
                    break;
                case "-":
                    z = x - y;
                    break;
                case "*":
                    z = x * y;
                    break;
                case "/":
                    z = x / y;
                    break;

            }
            txtdisplay.Text = z.ToString();
            op = null;
        }

        private void btnonoff_Click(object sender, EventArgs e)
        {
            panel1.Enabled = !panel1.Enabled;
            if (btnonoff.Text == "On")
            {
                btnonoff.Text = "Off";
                this.KeyPreview = true;
            }
            else
            {
                btnonoff.Text = "On";
                this.KeyPreview = false;
            }
        }

        private void txtdisplay_TextChanged(object sender, EventArgs e)
        {
            //if (txtdisplay.Text.Contains(".") == true)
            //    btnpoint.Enabled = false;
            //else
            //    btnpoint.Enabled = true;
            btnpoint.Enabled = !txtdisplay.Text.Contains(".");
            btnbackspace.Enabled = Convert.ToBoolean(txtdisplay.Text.Length);
        }

        private void btnbackspace_Click(object sender, EventArgs e)
        {
            if(txtdisplay.TextLength>0)
            txtdisplay.Text = txtdisplay.Text.Substring(0, txtdisplay.Text.Length - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtdisplay_TextChanged(null, null);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Button x in panel1.Controls)
                if (x.Text == e.KeyChar.ToString())
                {
                    x.Focus();
                    x.ForeColor = Color.Red;
                }
                else
                    x.ForeColor = Color.Black;

            Button temp = new Button();
            temp.Text = e.KeyChar.ToString();
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                Numbers(temp, null);
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
                Operators(temp, null);
            else if (e.KeyChar == '=')
                btnequal_Click(null, null);
            else if (e.KeyChar == '.' && txtdisplay.Text.Contains(".") == false)
                Numbers(temp, null);
            else if (e.KeyChar == '\b')
                btnbackspace_Click(null, null);


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Im in Keyup");
            if (e.KeyCode == Keys.Enter){
                btnequal_Click(null, null);
                btnequal.Focus();
            }
        }

        private void btnonoff_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Im in btnonoff MouseClick");
        }

       

       

        
    }
}
