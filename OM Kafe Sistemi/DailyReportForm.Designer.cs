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
            toplaradiobtn = new RadioButton();
            silradiobtn = new RadioButton();
            onaylabtn = new Button();
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
            // toplaradiobtn
            // 
            toplaradiobtn.AutoSize = true;
            toplaradiobtn.BackColor = Color.FromArgb(192, 192, 0);
            toplaradiobtn.Location = new Point(183, 550);
            toplaradiobtn.Name = "toplaradiobtn";
            toplaradiobtn.Size = new Size(65, 24);
            toplaradiobtn.TabIndex = 5;
            toplaradiobtn.TabStop = true;
            toplaradiobtn.Text = "topla";
            toplaradiobtn.UseVisualStyleBackColor = false;
            // 
            // silradiobtn
            // 
            silradiobtn.AutoSize = true;
            silradiobtn.BackColor = Color.FromArgb(0, 192, 0);
            silradiobtn.Location = new Point(469, 550);
            silradiobtn.Name = "silradiobtn";
            silradiobtn.Size = new Size(44, 24);
            silradiobtn.TabIndex = 6;
            silradiobtn.TabStop = true;
            silradiobtn.Text = "sil";
            silradiobtn.UseVisualStyleBackColor = false;
            // 
            // onaylabtn
            // 
            onaylabtn.Location = new Point(317, 622);
            onaylabtn.Name = "onaylabtn";
            onaylabtn.Size = new Size(94, 29);
            onaylabtn.TabIndex = 7;
            onaylabtn.Text = "onayla";
            onaylabtn.UseVisualStyleBackColor = true;
            // 
            // DailyReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 16, 8);
            ClientSize = new Size(1274, 705);
            Controls.Add(onaylabtn);
            Controls.Add(silradiobtn);
            Controls.Add(toplaradiobtn);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Margin = new Padding(2);
            Name = "DailyReportForm";
            Text = "DailyReportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label2;
        private RadioButton toplaradiobtn;
        private RadioButton silradiobtn;
        private Button onaylabtn;
    }
}