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
    public partial class Couponadmincheck : Form
    {
        Form1 f = new Form1();
        string idport = "";
        string admin_list = "";
        public Couponadmincheck(string p,string a)
        {
            InitializeComponent();
            idport = p;
            admin_list = a;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            IDreadform id = new IDreadform(idport);
            if(id.ShowDialog() == DialogResult.OK)
            {
                string stid = id.IDvalue.Split(',')[1];
                if (admin_list.Contains(stid))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("管理者リストに登録されてない学籍番号です。お店の方をお呼びください。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
