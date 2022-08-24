using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            webView21.NavigateToString(html);
        }
    }
}
