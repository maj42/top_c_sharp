namespace homework_21_30._09
{
    partial class FormComponents
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
            textBoxName = new TextBox();
            textBoxDescr = new TextBox();
            textBoxPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonCompAdd = new Button();
            buttonCompEdit = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(22, 25);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(259, 304);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(405, 43);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(252, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxDescr
            // 
            textBoxDescr.Location = new Point(405, 116);
            textBoxDescr.Multiline = true;
            textBoxDescr.Name = "textBoxDescr";
            textBoxDescr.Size = new Size(252, 155);
            textBoxDescr.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(405, 306);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(252, 23);
            textBoxPrice.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 25);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 98);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 288);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // buttonCompAdd
            // 
            buttonCompAdd.Location = new Point(405, 374);
            buttonCompAdd.Name = "buttonCompAdd";
            buttonCompAdd.Size = new Size(75, 23);
            buttonCompAdd.TabIndex = 7;
            buttonCompAdd.Text = "Add";
            buttonCompAdd.UseVisualStyleBackColor = true;
            buttonCompAdd.Click += buttonCompAdd_Click;
            // 
            // buttonCompEdit
            // 
            buttonCompEdit.Location = new Point(582, 374);
            buttonCompEdit.Name = "buttonCompEdit";
            buttonCompEdit.Size = new Size(75, 23);
            buttonCompEdit.TabIndex = 8;
            buttonCompEdit.Text = "Edit";
            buttonCompEdit.UseVisualStyleBackColor = true;
            buttonCompEdit.Click += buttonCompEdit_Click;
            // 
            // FormComponents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 425);
            Controls.Add(buttonCompEdit);
            Controls.Add(buttonCompAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxDescr);
            Controls.Add(textBoxName);
            Controls.Add(listBox1);
            Name = "FormComponents";
            Text = "FormComponents";
            Load += FormComponents_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxName;
        private TextBox textBoxDescr;
        private TextBox textBoxPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonCompAdd;
        private Button buttonCompEdit;
        public ListBox listBox1;
    }
}