namespace WebViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeWebView();
        }
        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.Source = new Uri("http://localhost:3000");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
