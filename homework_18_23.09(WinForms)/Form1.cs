namespace homework_18_23._09_WinForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Now;
            labelDate.Text = $"Choosed date: {dateTimePicker.Value.ToLongDateString()}";
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            dateTimePicker.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            labelDate.Text = $"Choosed date: {dateTimePicker.Value.ToLongDateString()}";
        }
    }
}
