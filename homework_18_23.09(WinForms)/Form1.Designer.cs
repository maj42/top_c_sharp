namespace homework_18_23._09_WinForms_
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
            dateTimePicker = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelDate = new Label();
            buttonChoose = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.None;
            dateTimePicker.Location = new Point(63, 193);
            dateTimePicker.Margin = new Padding(4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(256, 29);
            dateTimePicker.TabIndex = 0;
            dateTimePicker.Value = new DateTime(2024, 9, 24, 22, 56, 45, 0);
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(dateTimePicker, 1, 3);
            tableLayoutPanel1.Controls.Add(labelDate, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonChoose, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(384, 261);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelDate
            // 
            labelDate.Anchor = AnchorStyles.None;
            labelDate.AutoSize = true;
            labelDate.Location = new Point(165, 119);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(52, 21);
            labelDate.TabIndex = 1;
            labelDate.Text = "label1";
            // 
            // buttonChoose
            // 
            buttonChoose.Anchor = AnchorStyles.None;
            buttonChoose.AutoSize = true;
            buttonChoose.Location = new Point(136, 36);
            buttonChoose.Name = "buttonChoose";
            buttonChoose.Size = new Size(111, 31);
            buttonChoose.TabIndex = 2;
            buttonChoose.Text = "Choose Date:";
            buttonChoose.UseVisualStyleBackColor = true;
            buttonChoose.Click += buttonChoose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(384, 261);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Date Picker";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelDate;
        private Button buttonChoose;
    }
}
