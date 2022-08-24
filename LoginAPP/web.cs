using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net.Http;
using System.Windows.Forms;

namespace LoginAPP
{
    public partial class web : Form
    {
        public web()
        {
            InitializeComponent();
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            this.Visible = false;
            f.Visible = true;
        }

        private async void Web_Load(object sender, EventArgs e)
        {
            var url = "http://127.0.0.1:8080/chocolatey-software-description";
            var client = new HttpClient();
            var data = new Dictionary<string, string>
            {
                { "appname", "test_filezilla" },
            };

            var res = await client.PostAsync(url, new FormUrlEncodedContent(data));
            var content = await res.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            var html = @"
        <html>
            <head>
                <title>Basic Web Page</title>
            </head>
            <body>
                She said,
            </body>
        </html>
            ";

            await webView21.EnsureCoreWebView2Async();
            webView21.NavigateToString(content);
        }
    }
}