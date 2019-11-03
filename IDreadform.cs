using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kenbaiki
{
    public partial class IDreadform : Form
    {
        string readerport = "";
        public string IDvalue { get; set; }
        public IDreadform(string port)
        {
            InitializeComponent();
            readerport = port;
        }
        
        private void IDreadform_Load(object sender, EventArgs e)
        {
            cardreader.PortName = readerport;
            cardreader.Open();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.IDvalue = "thisisid";
            
        }

        private void Cardreader_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string value = cardreader.ReadLine();
            cardreader.Close();
            try
            {
                if (value.Split(',')[0].Contains("OK") && value.Split(',')[1].Length == 8)
                {
                    label1.Text = "読取に成功しました。";
                    idlabel.Text = "学籍番号：" + value.Split(',')[1] + Environment.NewLine + "受験番号：" + value.Split(',')[2];
                    label1.Text = "読取に成功しました。";
                    Thread.Sleep(2000);
                    this.DialogResult = DialogResult.OK;
                    this.IDvalue = value;                    
                    this.Close();
                }
                else
                {
                    cardreader.Open();
                    idlabel.Text = "エラー";
                    label1.Text = "読取に失敗しました。もう一度やり直してください。";
                }
            }
            catch (IndexOutOfRangeException)
            {
                cardreader.Open();
                idlabel.Text = "エラー";
                label1.Text = "読取に失敗しました。もう一度やり直してください。";
            }
            
            

        }

        private void IDreadform_FormClosing(object sender, FormClosingEventArgs e)
        {
            cardreader.Close();
        }
    }
}
