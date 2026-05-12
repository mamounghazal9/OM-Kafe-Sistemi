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
            turkishbtn = new Button();
            frozenbtn = new Button();
            limonatabtn = new Button();
            espressobtn = new Button();
            Desspbtn = new Button();
            ordertxt = new ListBox();
            removebtn = new Button();
            deletebtn = new Button();
            paybtn = new Button();
            SuspendLayout();
            // 
            // lattebtn
            // 
            lattebtn.Anchor = AnchorStyles.None;
            lattebtn.BackColor = Color.FromArgb(216, 200, 176);
            lattebtn.Location = new Point(604, 281);
            lattebtn.Name = "lattebtn";
            lattebtn.Size = new Size(162, 160);
            lattebtn.TabIndex = 0;
            lattebtn.Text = "Latte";
            lattebtn.UseVisualStyleBackColor = false;
            lattebtn.Click += button1_Click;
            // 
            // turkishbtn
            // 
            turkishbtn.Anchor = AnchorStyles.None;
            turkishbtn.BackColor = Color.FromArgb(216, 200, 176);
            turkishbtn.Location = new Point(808, 281);
            turkishbtn.Name = "turkishbtn";
            turkishbtn.Size = new Size(162, 160);
            turkishbtn.TabIndex = 1;
            turkishbtn.Text = "Turkish coffee";
            turkishbtn.UseVisualStyleBackColor = false;
            // 
            // frozenbtn
            // 
            frozenbtn.Anchor = AnchorStyles.None;
            frozenbtn.BackColor = Color.FromArgb(216, 200, 176);
            frozenbtn.Location = new Point(604, 497);
            frozenbtn.Name = "frozenbtn";
            frozenbtn.Size = new Size(162, 160);
            frozenbtn.TabIndex = 2;
            frozenbtn.Text = "Frozen";
            frozenbtn.UseVisualStyleBackColor = false;
            // 
            // limonatabtn
            // 
            limonatabtn.Anchor = AnchorStyles.None;
            limonatabtn.BackColor = Color.FromArgb(216, 200, 176);
            limonatabtn.Location = new Point(808, 497);
            limonatabtn.Name = "limonatabtn";
            limonatabtn.Size = new Size(162, 160);
            limonatabtn.TabIndex = 3;
            limonatabtn.Text = "Limonata";
            limonatabtn.UseVisualStyleBackColor = false;
            // 
            // espressobtn
            // 
            espressobtn.Anchor = AnchorStyles.None;
            espressobtn.BackColor = Color.FromArgb(216, 200, 176);
            espressobtn.Location = new Point(604, 66);
            espressobtn.Name = "espressobtn";
            espressobtn.Size = new Size(162, 160);
            espressobtn.TabIndex = 4;
            espressobtn.Text = "Espresso";
            espressobtn.UseVisualStyleBackColor = false;
            // 
            // Desspbtn
            // 
            Desspbtn.Anchor = AnchorStyles.None;
            Desspbtn.BackColor = Color.FromArgb(216, 200, 176);
            Desspbtn.Location = new Point(808, 66);
            Desspbtn.Name = "Desspbtn";
            Desspbtn.Size = new Size(162, 160);
            Desspbtn.TabIndex = 5;
            Desspbtn.Text = "Double Espresso";
            Desspbtn.UseVisualStyleBackColor = false;
            // 
            // ordertxt
            // 
            ordertxt.Anchor = AnchorStyles.None;
            ordertxt.BackColor = Color.White;
            ordertxt.FormattingEnabled = true;
            ordertxt.Location = new Point(1010, 66);
            ordertxt.Name = "ordertxt";
            ordertxt.Size = new Size(452, 260);
            ordertxt.TabIndex = 6;
            // 
            // removebtn
            // 
            removebtn.Anchor = AnchorStyles.None;
            removebtn.BackColor = Color.FromArgb(150, 78, 72);
            removebtn.Location = new Point(1031, 351);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(142, 76);
            removebtn.TabIndex = 7;
            removebtn.Text = "Remove";
            removebtn.UseVisualStyleBackColor = false;
            // 
            // deletebtn
            // 
            deletebtn.Anchor = AnchorStyles.None;
            deletebtn.BackColor = Color.FromArgb(150, 78, 72);
            deletebtn.Location = new Point(1283, 351);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(135, 76);
            deletebtn.TabIndex = 8;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            // 
            // paybtn
            // 
            paybtn.Anchor = AnchorStyles.None;
            paybtn.BackColor = Color.FromArgb(128, 135, 94);
            paybtn.Location = new Point(1058, 477);
            paybtn.Name = "paybtn";
            paybtn.Size = new Size(330, 61);
            paybtn.TabIndex = 9;
            paybtn.Text = "Pay";
            paybtn.UseVisualStyleBackColor = false;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1538, 737);
            Controls.Add(paybtn);
            Controls.Add(deletebtn);
            Controls.Add(removebtn);
            Controls.Add(ordertxt);
            Controls.Add(Desspbtn);
            Controls.Add(espressobtn);
            Controls.Add(limonatabtn);
            Controls.Add(frozenbtn);
            Controls.Add(turkishbtn);
            Controls.Add(lattebtn);
            Margin = new Padding(2);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button lattebtn;
        private Button turkishbtn;
        private Button frozenbtn;
        private Button limonatabtn;
        private Button espressobtn;
        private Button Desspbtn;
        private ListBox ordertxt;
        private Button removebtn;
        private Button deletebtn;
        private Button paybtn;
    }
}