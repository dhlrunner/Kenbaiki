namespace kenbaiki
{
    partial class IDreadform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idlabel = new System.Windows.Forms.Label();
            this.cardreader = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "東海大学の学生証をリーダーにかざしてください。";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kenbaiki.Properties.Resources.수정됨_アートボード_1_4x_2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(696, 107);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // idlabel
            // 
            this.idlabel.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idlabel.Location = new System.Drawing.Point(12, 122);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(696, 138);
            this.idlabel.TabIndex = 2;
            this.idlabel.Text = "読取可";
            this.idlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardreader
            // 
            this.cardreader.BaudRate = 115200;
            this.cardreader.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Cardreader_DataReceived);
            // 
            // IDreadform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(720, 314);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 9F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "IDreadform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDreadform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IDreadform_FormClosing);
            this.Load += new System.EventHandler(this.IDreadform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label idlabel;
        private System.IO.Ports.SerialPort cardreader;
    }
}