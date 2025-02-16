namespace BingImageSearch
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.FlowLayoutPanel imagePanel;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.imagePanel = new System.Windows.Forms.FlowLayoutPanel();

            this.Text = "Image Search";
            this.Width = 800;
            this.Height = 600;

            this.searchBox.Location = new System.Drawing.Point(10, 10);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(600, 20);

            this.searchButton.Location = new System.Drawing.Point(620, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);

            this.imagePanel.Location = new System.Drawing.Point(10, 50);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(760, 500);
            this.imagePanel.AutoScroll = true;

            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.imagePanel);

            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
