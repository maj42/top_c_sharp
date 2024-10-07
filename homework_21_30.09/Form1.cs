namespace homework_21_30._09
{
    public partial class Form1 : Form
    {
        public BindingSource bindingAvailable = new BindingSource();
        public BindingSource bindingSold = new BindingSource();

        public List<Component> availableComponents = new List<Component>
            {
                new Component ("processor", "Intel i9", 25000),
                new Component ("video card", "GTX 3060", 35000),
                new Component ("monitor", "MSI MP2412", 10000)
            };

        public List<Component> soldComponents = new List<Component>();

        public Form1()
        {
            InitializeComponent();
        }

        public struct Component
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }

            public Component(string name, string description, decimal price)
            {
                this.Name = name;
                this.Description = description;
                this.Price = price;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingAvailable.DataSource = availableComponents;
            comboBoxAvailable.DataSource = bindingAvailable;
            comboBoxAvailable.DisplayMember = "Name";

            bindingSold.DataSource = soldComponents;
            listSale.DataSource = bindingSold;
            listSale.DisplayMember = "Name";

            textBoxPrice.Text = "0";
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (comboBoxAvailable.SelectedItem != null)
            {
                soldComponents.Add((Component)comboBoxAvailable.SelectedItem);
                textBoxPrice.Text = soldComponents.Sum(a => a.Price).ToString();

                bindingAvailable.ResetBindings(false);
                bindingSold.ResetBindings(false);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormComponents formComponents = new FormComponents(availableComponents, bindingAvailable);
            formComponents.listBox1.DataSource = availableComponents;
            formComponents.listBox1.DisplayMember = "Name";
            formComponents.ShowDialog();
        }
    }
}
