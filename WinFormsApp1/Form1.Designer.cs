namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            combobox0 = new ComboBox();
            combobox1 = new TextBox();
            combobox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rich1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(759, 74);
            button1.Name = "button1";
            button1.Size = new Size(225, 43);
            button1.TabIndex = 0;
            button1.Text = "hinzufügen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // combobox0
            // 
            combobox0.FormattingEnabled = true;
            combobox0.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            combobox0.Location = new Point(86, 85);
            combobox0.Name = "combobox0";
            combobox0.Size = new Size(128, 23);
            combobox0.TabIndex = 1;
            combobox0.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // combobox1
            // 
            combobox1.Location = new Point(295, 85);
            combobox1.Name = "combobox1";
            combobox1.Size = new Size(160, 23);
            combobox1.TabIndex = 2;
            // 
            // combobox2
            // 
            combobox2.Location = new Point(497, 85);
            combobox2.Name = "combobox2";
            combobox2.Size = new Size(167, 23);
            combobox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 57);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Anzahl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 57);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 57);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 7;
            label4.Text = "Preis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 57);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 8;
            label5.Text = "Produktname";
            // 
            // rich1
            // 
            rich1.Location = new Point(86, 168);
            rich1.Name = "rich1";
            rich1.Size = new Size(898, 271);
            rich1.TabIndex = 9;
            rich1.Text = "";
            rich1.TextChanged += rich1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 507);
            Controls.Add(rich1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(combobox2);
            Controls.Add(combobox1);
            Controls.Add(combobox0);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Rechnungsvorlagen";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox combo1;
        private TextBox gg;
        private TextBox gg2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox rich1;
        private ComboBox combobox0;
        private TextBox combobox1;
        private TextBox combobox2;
    }
}