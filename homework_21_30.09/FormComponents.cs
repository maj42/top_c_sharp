namespace homework_21_30._09
{
    public partial class FormComponents : Form
    {
        BindingSource binding;
        public List<Form1.Component> listComponents;
        public FormComponents(List<Form1.Component> listComponents, BindingSource binding)
        {
            InitializeComponent();
            this.binding = binding;
            this.listComponents = listComponents;
        }

        private void FormComponents_Load(object sender, EventArgs e)
        {
            binding.ResetBindings(false);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBoxName.Text = ((Form1.Component)listBox1.SelectedItem).Name;
                textBoxDescr.Text = ((Form1.Component)listBox1.SelectedItem).Description;
                textBoxPrice.Text = ((Form1.Component)listBox1.SelectedItem).Price.ToString();
            }
        }

        private void buttonCompAdd_Click(object sender, EventArgs e)
        {
            Form1.Component newComponent = new(textBoxName.Text, textBoxDescr.Text, Convert.ToDecimal(textBoxPrice.Text));
            binding.Add(newComponent);
            Close();
        }

        private void buttonCompEdit_Click(object sender, EventArgs e)
        {
            Form1.Component newComponent = new(textBoxName.Text, textBoxDescr.Text, Convert.ToDecimal(textBoxPrice.Text));
            binding[listBox1.SelectedIndex] = newComponent;
            Close();
        }
    }
}
