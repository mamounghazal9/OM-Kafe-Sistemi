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
            orderlist = new ListBox();
            removebtn = new Button();
            deletebtn = new Button();
            paybtn = new Button();
            toplamlabel = new Label();
            label1 = new Label();
            espressocheck = new CheckBox();
            doublecheck = new CheckBox();
            turkishcheck = new CheckBox();
            frozencheck = new CheckBox();
            lattecheck = new CheckBox();
            limonatacheck = new CheckBox();
            SuspendLayout();
            // 
            // orderlist
            // 
            orderlist.Anchor = AnchorStyles.None;
            orderlist.BackColor = Color.White;
            orderlist.FormattingEnabled = true;
            orderlist.Location = new Point(622, 41);
            orderlist.Margin = new Padding(2);
            orderlist.Name = "orderlist";
            orderlist.Size = new Size(280, 164);
            orderlist.TabIndex = 6;
            // 
            // removebtn
            // 
            removebtn.Anchor = AnchorStyles.None;
            removebtn.BackColor = Color.FromArgb(150, 78, 72);
            removebtn.Location = new Point(636, 294);
            removebtn.Margin = new Padding(2);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(87, 48);
            removebtn.TabIndex = 7;
            removebtn.Text = "Remove";
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Anchor = AnchorStyles.None;
            deletebtn.BackColor = Color.FromArgb(150, 78, 72);
            deletebtn.Location = new Point(791, 294);
            deletebtn.Margin = new Padding(2);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(83, 48);
            deletebtn.TabIndex = 8;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // paybtn
            // 
            paybtn.Anchor = AnchorStyles.None;
            paybtn.BackColor = Color.FromArgb(128, 135, 94);
            paybtn.Location = new Point(652, 373);
            paybtn.Margin = new Padding(2);
            paybtn.Name = "paybtn";
            paybtn.Size = new Size(203, 38);
            paybtn.TabIndex = 9;
            paybtn.Text = "Pay";
            paybtn.UseVisualStyleBackColor = false;
            paybtn.Click += paybtn_Click;
            // 
            // toplamlabel
            // 
            toplamlabel.Anchor = AnchorStyles.None;
            toplamlabel.AutoSize = true;
            toplamlabel.Location = new Point(748, 232);
            toplamlabel.Margin = new Padding(2, 0, 2, 0);
            toplamlabel.Name = "toplamlabel";
            toplamlabel.Size = new Size(36, 20);
            toplamlabel.TabIndex = 11;
            toplamlabel.Text = "0 TL";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(674, 232);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 12;
            label1.Text = "Toplam:";
            // 
            // espressocheck
            // 
            espressocheck.AutoSize = true;
            espressocheck.Location = new Point(269, 41);
            espressocheck.Name = "espressocheck";
            espressocheck.Size = new Size(88, 24);
            espressocheck.TabIndex = 13;
            espressocheck.Text = "Espresso";
            espressocheck.UseVisualStyleBackColor = true;
            // 
            // doublecheck
            // 
            doublecheck.AutoSize = true;
            doublecheck.Location = new Point(426, 41);
            doublecheck.Name = "doublecheck";
            doublecheck.Size = new Size(139, 24);
            doublecheck.TabIndex = 14;
            doublecheck.Text = "double espresso";
            doublecheck.UseVisualStyleBackColor = true;
            // 
            // turkishcheck
            // 
            turkishcheck.AutoSize = true;
            turkishcheck.Location = new Point(269, 121);
            turkishcheck.Name = "turkishcheck";
            turkishcheck.Size = new Size(106, 24);
            turkishcheck.TabIndex = 15;
            turkishcheck.Text = "turkish kafe";
            turkishcheck.UseVisualStyleBackColor = true;
            // 
            // frozencheck
            // 
            frozencheck.AutoSize = true;
            frozencheck.Location = new Point(467, 121);
            frozencheck.Name = "frozencheck";
            frozencheck.Size = new Size(73, 24);
            frozencheck.TabIndex = 16;
            frozencheck.Text = "frozen";
            frozencheck.UseVisualStyleBackColor = true;
            // 
            // lattecheck
            // 
            lattecheck.AutoSize = true;
            lattecheck.Location = new Point(296, 228);
            lattecheck.Name = "lattecheck";
            lattecheck.Size = new Size(61, 24);
            lattecheck.TabIndex = 17;
            lattecheck.Text = "latte";
            lattecheck.UseVisualStyleBackColor = true;
            // 
            // limonatacheck
            // 
            limonatacheck.AutoSize = true;
            limonatacheck.Location = new Point(450, 228);
            limonatacheck.Name = "limonatacheck";
            limonatacheck.Size = new Size(90, 24);
            limonatacheck.TabIndex = 18;
            limonatacheck.Text = "limonata";
            limonatacheck.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(946, 461);
            Controls.Add(limonatacheck);
            Controls.Add(lattecheck);
            Controls.Add(frozencheck);
            Controls.Add(turkishcheck);
            Controls.Add(doublecheck);
            Controls.Add(espressocheck);
            Controls.Add(label1);
            Controls.Add(toplamlabel);
            Controls.Add(paybtn);
            Controls.Add(deletebtn);
            Controls.Add(removebtn);
            Controls.Add(orderlist);
            Margin = new Padding(1);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lattebtn;
        private Button turkishbtn;
        private Button frozenbtn;
        private Button limonatabtn;
        private Button espressobtn;
        private Button Desspbtn;
        private ListBox orderlist;
        private Button removebtn;
        private Button deletebtn;
        private Button paybtn;
        private Label toplamlabel;
        private Label label1;
        private CheckBox espressocheck;
        private CheckBox doublecheck;
        private CheckBox turkishcheck;
        private CheckBox frozencheck;
        private CheckBox lattecheck;
        private CheckBox limonatacheck;
        private ComboBox comboBox1;
    }
}