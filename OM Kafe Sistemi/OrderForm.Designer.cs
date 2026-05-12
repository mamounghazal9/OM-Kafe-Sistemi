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
            SuspendLayout();
            // 
            // lattebtn
            // 
            lattebtn.Location = new Point(1149, 414);
            lattebtn.Margin = new Padding(5, 5, 5, 5);
            lattebtn.Name = "lattebtn";
            lattebtn.Size = new Size(162, 160);
            lattebtn.TabIndex = 0;
            lattebtn.Text = "Latte";
            lattebtn.UseVisualStyleBackColor = true;
            lattebtn.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1532, 414);
            button2.Margin = new Padding(5, 5, 5, 5);
            button2.Name = "button2";
            button2.Size = new Size(162, 160);
            button2.TabIndex = 1;
            button2.Text = "Turkish coffee";
            button2.UseVisualStyleBackColor = true;
            // 
            // frozenbtn
            // 
            frozenbtn.Location = new Point(1149, 771);
            frozenbtn.Margin = new Padding(5, 5, 5, 5);
            frozenbtn.Name = "frozenbtn";
            frozenbtn.Size = new Size(162, 160);
            frozenbtn.TabIndex = 2;
            frozenbtn.Text = "Frozen";
            frozenbtn.UseVisualStyleBackColor = true;
            // 
            // limonata
            // 
            limonata.Location = new Point(1532, 771);
            limonata.Margin = new Padding(5, 5, 5, 5);
            limonata.Name = "limonata";
            limonata.Size = new Size(162, 160);
            limonata.TabIndex = 3;
            limonata.Text = "Limonata";
            limonata.UseVisualStyleBackColor = true;
            // 
            // espressobtn
            // 
            espressobtn.Location = new Point(1149, 133);
            espressobtn.Margin = new Padding(5, 5, 5, 5);
            espressobtn.Name = "espressobtn";
            espressobtn.Size = new Size(162, 160);
            espressobtn.TabIndex = 4;
            espressobtn.Text = "Espresso";
            espressobtn.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(1532, 133);
            button6.Margin = new Padding(5, 5, 5, 5);
            button6.Name = "button6";
            button6.Size = new Size(162, 160);
            button6.TabIndex = 5;
            button6.Text = "Double Espresso";
            button6.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2499, 1179);
            Controls.Add(button6);
            Controls.Add(espressobtn);
            Controls.Add(limonata);
            Controls.Add(frozenbtn);
            Controls.Add(button2);
            Controls.Add(lattebtn);
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
    }
}