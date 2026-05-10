namespace OM_Kafe_Sistemi
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            lattebtn = new Button();
            button2 = new Button();
            frozenbtn = new Button();
            limonata = new Button();
            espressobtn = new Button();
            button6 = new Button();
            ordertxt = new ListBox();
            removebtn = new Button();
            deletebtn = new Button();
            paybtn = new Button();
            SuspendLayout();
            // 
            // lattebtn
            // 
            lattebtn.BackColor = Color.FromArgb(216, 200, 176);
            lattebtn.Location = new Point(604, 281);
            lattebtn.Name = "lattebtn";
            lattebtn.Size = new Size(100, 100);
            lattebtn.TabIndex = 0;
            lattebtn.Text = "Latte";
            lattebtn.UseVisualStyleBackColor = false;
            lattebtn.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(216, 200, 176);
            button2.Location = new Point(795, 281);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.Text = "Turkish coffee";
            button2.UseVisualStyleBackColor = false;
            // 
            // frozenbtn
            // 
            frozenbtn.BackColor = Color.FromArgb(216, 200, 176);
            frozenbtn.Location = new Point(604, 461);
            frozenbtn.Name = "frozenbtn";
            frozenbtn.Size = new Size(100, 100);
            frozenbtn.TabIndex = 2;
            frozenbtn.Text = "Frozen";
            frozenbtn.UseVisualStyleBackColor = false;
            // 
            // limonata
            // 
            limonata.BackColor = Color.FromArgb(216, 200, 176);
            limonata.Location = new Point(795, 461);
            limonata.Name = "limonata";
            limonata.Size = new Size(100, 100);
            limonata.TabIndex = 3;
            limonata.Text = "Limonata";
            limonata.UseVisualStyleBackColor = false;
            // 
            // espressobtn
            // 
            espressobtn.BackColor = Color.FromArgb(216, 200, 176);
            espressobtn.Location = new Point(604, 101);
            espressobtn.Name = "espressobtn";
            espressobtn.Size = new Size(100, 100);
            espressobtn.TabIndex = 4;
            espressobtn.Text = "Espresso";
            espressobtn.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(216, 200, 176);
            button6.Location = new Point(795, 101);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 5;
            button6.Text = "Double Espresso";
            button6.UseVisualStyleBackColor = false;
            // 
            // ordertxt
            // 
            ordertxt.BackColor = Color.FromArgb(216, 200, 176);
            ordertxt.FormattingEnabled = true;
            ordertxt.Location = new Point(1031, 101);
            ordertxt.Name = "ordertxt";
            ordertxt.Size = new Size(382, 224);
            ordertxt.TabIndex = 6;
            // 
            // removebtn
            // 
            removebtn.BackColor = Color.FromArgb(150, 78, 72);
            removebtn.Location = new Point(1087, 377);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(80, 50);
            removebtn.TabIndex = 7;
            removebtn.Text = "Remove";
            removebtn.UseVisualStyleBackColor = false;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.FromArgb(150, 78, 72);
            deletebtn.Location = new Point(1292, 377);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(80, 50);
            deletebtn.TabIndex = 8;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            // 
            // paybtn
            // 
            paybtn.BackColor = Color.FromArgb(128, 135, 94);
            paybtn.Location = new Point(1098, 461);
            paybtn.Name = "paybtn";
            paybtn.Size = new Size(265, 47);
            paybtn.TabIndex = 9;
            paybtn.Text = "Pay";
            paybtn.UseVisualStyleBackColor = false;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1538, 737);
            Controls.Add(paybtn);
            Controls.Add(deletebtn);
            Controls.Add(removebtn);
            Controls.Add(ordertxt);
            Controls.Add(button6);
            Controls.Add(espressobtn);
            Controls.Add(limonata);
            Controls.Add(frozenbtn);
            Controls.Add(button2);
            Controls.Add(lattebtn);
            Margin = new Padding(2);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button lattebtn;
        private Button button2;
        private Button frozenbtn;
        private Button limonata;
        private Button espressobtn;
        private Button button6;
        private ListBox ordertxt;
        private Button removebtn;
        private Button deletebtn;
        private Button paybtn;
    }
}