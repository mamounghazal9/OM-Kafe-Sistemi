namespace OM_Kafe_Sistemi
{
    partial class DailyReportForm
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
            listBox1 = new ListBox();
            label2 = new Label();
            toplabtn = new Button();
            silbtn = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(216, 200, 176);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(30, 107);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1232, 424);
            listBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Castellar", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Moccasin;
            label2.Location = new Point(304, 29);
            label2.Name = "label2";
            label2.Size = new Size(694, 47);
            label2.TabIndex = 4;
            label2.Text = "                   DAİLY SALES          ";
            // 
            // toplabtn
            // 
            toplabtn.Location = new Point(375, 565);
            toplabtn.Name = "toplabtn";
            toplabtn.Size = new Size(94, 29);
            toplabtn.TabIndex = 5;
            toplabtn.Text = "topla";
            toplabtn.UseVisualStyleBackColor = true;
            toplabtn.Click += button1_Click;
            // 
            // silbtn
            // 
            silbtn.Location = new Point(681, 562);
            silbtn.Name = "silbtn";
            silbtn.Size = new Size(94, 29);
            silbtn.TabIndex = 6;
            silbtn.Text = "sil";
            silbtn.UseVisualStyleBackColor = true;
            // 
            // DailyReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 16, 8);
            ClientSize = new Size(1184, 659);
            Controls.Add(silbtn);
            Controls.Add(toplabtn);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DailyReportForm";
            Text = "DailyReportForm";
            Load += DailyReportForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Label label2;
        private Button toplabtn;
        private Button silbtn;
    }
}