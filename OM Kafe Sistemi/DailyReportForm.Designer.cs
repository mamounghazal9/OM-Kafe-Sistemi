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
            toplabtn = new Button();
            toplamlab = new Label();
            label2 = new Label();
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
            // toplabtn
            // 
            toplabtn.BackColor = Color.FromArgb(128, 135, 94);
            toplabtn.ForeColor = Color.Moccasin;
            toplabtn.Location = new Point(30, 558);
            toplabtn.Name = "toplabtn";
            toplabtn.Size = new Size(307, 36);
            toplabtn.TabIndex = 2;
            toplabtn.Text = "Topla";
            toplabtn.UseVisualStyleBackColor = false;
            toplabtn.Click += toplabtn_Click;
            // 
            // toplamlab
            // 
            toplamlab.BackColor = Color.FromArgb(150, 78, 72);
            toplamlab.ForeColor = Color.Moccasin;
            toplamlab.Location = new Point(882, 558);
            toplamlab.Name = "toplamlab";
            toplamlab.Size = new Size(237, 36);
            toplamlab.TabIndex = 3;
            toplamlab.Text = "                  Toplam Gelir";
            toplamlab.Click += label1_Click;
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
            // DailyReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 16, 8);
            ClientSize = new Size(1274, 705);
            Controls.Add(label2);
            Controls.Add(toplamlab);
            Controls.Add(toplabtn);
            Controls.Add(listBox1);
            Margin = new Padding(2);
            Name = "DailyReportForm";
            Text = "DailyReportForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button toplabtn;
        private Label toplamlab;
        private Label label2;
    }
}