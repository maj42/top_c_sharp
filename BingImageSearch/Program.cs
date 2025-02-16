using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingImageSearch
{
    public partial class MainForm : Form
    {
        private HttpClient httpClient;

        public MainForm()
        {
            httpClient = new HttpClient();
            InitializeComponent();
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            string query = searchBox.Text;
            if (!string.IsNullOrWhiteSpace(query))
            {
                try
                {
                    imagePanel.Controls.Clear();

                    string searchUrl = $"https://www.bing.com/images/search?q={Uri.EscapeDataString(query)}";
                    string html = await httpClient.GetStringAsync(searchUrl);
                    List<string> imageUrls = ExtractImageUrls(html);

                    // limit = 20
                    imageUrls = imageUrls.Take(20).ToList();

                    DisplayImages(imageUrls);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private List<string> ExtractImageUrls(string html)
        {
            var matches = Regex.Matches(html, @"https://[^\s]+?\.(jpg|png|gif)");
            return matches.Cast<Match>().Select(m => m.Value).Distinct().ToList();
        }

        private void DisplayImages(List<string> imageUrls)
        {
            imagePanel.Controls.Clear();
            foreach (var url in imageUrls)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Width = 150,
                    Height = 150,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    ImageLocation = url
                };

                pictureBox.LoadCompleted += (sender, e) =>
                {
                    if (pictureBox.Image == null)
                    {
                        pictureBox.Image = new Bitmap(150, 150);
                        using (Graphics g = Graphics.FromImage(pictureBox.Image))
                        {
                            g.Clear(Color.Gray);
                            g.DrawString("Failed to load", new Font("Arial", 10), Brushes.White, new PointF(10, 60));
                        }
                    }
                };

                imagePanel.Controls.Add(pictureBox);
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}