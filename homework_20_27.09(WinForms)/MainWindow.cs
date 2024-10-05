namespace homework_20_27._09_WinForms_
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow newWindow = new MainWindow();
            newWindow.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs args)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) 
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.Write(this.textBox1.Text);
                sw.Close();
            }
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs args)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                this.textBox1.Text = sr.ReadToEnd();
                sr.Close();
                this.Text += " " + openFileDialog.FileName;
            }
        }

        private void fontColorToolStripMenuItem_Click(object obj, EventArgs args)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.ForeColor = cd.Color;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object obj, EventArgs args)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.BackColor = cd.Color;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs args)
        {
            if(textBox1.SelectedText != "")
            {
                Clipboard.SetText(textBox1.SelectedText);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs args)
        {
            if (textBox1.SelectedText != "")
            {
                Clipboard.SetText(textBox1.SelectedText);
                textBox1.SelectedText = String.Empty;
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs args)
        {
            string? text = Clipboard.GetText();
            if(text != null)
            {
                this.textBox1.Paste(text);
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e) 
        { 
            if(textBox1.CanUndo)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }
    }
}
