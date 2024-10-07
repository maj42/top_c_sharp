namespace homework_21_30._09
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
            listSale = new ListBox();
            comboBoxAvailable = new ComboBox();
            label1 = new Label();
            textBoxPrice = new TextBox();
            label2 = new Label();
            buttonAdd = new Button();
            buttonBuy = new Button();
            SuspendLayout();
            // 
            // listSale
            // 
            listSale.FormattingEnabled = true;
            listSale.ItemHeight = 15;
            listSale.Location = new Point(12, 12);
            listSale.Name = "listSale";
            listSale.Size = new Size(510, 199);
            listSale.TabIndex = 0;
            // 
            // comboBoxAvailable
            // 
            comboBoxAvailable.FormattingEnabled = true;
            comboBoxAvailable.Location = new Point(12, 253);
            comboBoxAvailable.Name = "comboBoxAvailable";
            comboBoxAvailable.Size = new Size(510, 23);
            comboBoxAvailable.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 235);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 2;
            label1.Text = "Buy Component";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(546, 40);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(216, 23);
            textBoxPrice.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(546, 12);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Total price";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 314);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(216, 64);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add/Edit Component";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonBuy
            // 
            buttonBuy.Location = new Point(546, 278);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(216, 64);
            buttonBuy.TabIndex = 6;
            buttonBuy.Text = "Buy Component";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBuy);
            Controls.Add(buttonAdd);
            Controls.Add(label2);
            Controls.Add(textBoxPrice);
            Controls.Add(label1);
            Controls.Add(comboBoxAvailable);
            Controls.Add(listSale);
            Name = "Form1";
            Text = "Sales Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listSale;
        private ComboBox comboBoxAvailable;
        private Label label1;
        private TextBox textBoxPrice;
        private Label label2;
        private Button buttonAdd;
        private Button buttonBuy;
    }
}
