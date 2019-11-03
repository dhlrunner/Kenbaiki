using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kenbaiki
{
    public partial class passwordform : Form
    {
        public passwordform()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pass.AppendText("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pass.AppendText("2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pass.AppendText("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            pass.AppendText("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pass.AppendText("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            pass.AppendText("6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            pass.AppendText("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            pass.AppendText("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            pass.AppendText("9");
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            pass.AppendText("0");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            pass.Clear();
        }

        private void Buttonok_Click(object sender, EventArgs e)
        {
            if (pass.Text == "1214")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("パスワードが違います。","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
    }
}
