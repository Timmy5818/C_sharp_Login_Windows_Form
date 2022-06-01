using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net;
using System.Diagnostics;
using Newtonsoft.Json;

namespace LoginAPP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            HttpClient httpClient = new HttpClient();
            using (HttpClient client = httpClient)
            {
                var values = new Dictionary<string, string>
            {
                { "email_id", "timmy.app@mail.tw" },
                { "password_id", "Timmy123" }
            };

                string url = "http://localhost:8080/login";
                var data = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, data);
                Console.WriteLine(response);
            }

            //SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\tools\Chocolatey GUI Build\Windows_Forms\LoginAPP\SQL DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            //string query = "Select * from tbl_Login Where username = '" + txtUsername.Text.Trim() + "' and password = '"+txtPassword.Text.Trim()+"'";
            //SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            //DataTable dtbl = new DataTable();
            //sda.Fill(dtbl);
            //if (dtbl.Rows.Count == 1)
            //{ 
            //    frmMain objFrmMain = new frmMain();
            //    this.Hide();
            //    objFrmMain.Show();
            //}
            //else
            //{
            //    MessageBox.Show("請確定你的帳號密碼是否正確");
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(Environment.ExitCode);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
         
        }
        
        static readonly HttpClient client = new HttpClient();
        private async void btnLogin_body_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost:8080/login");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
        }

        private async void btnLogin_head_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            using (HttpClient client = httpClient)
            {
                string url = "http://localhost:8080/login";
                var response = await client.GetAsync(url);
                Console.WriteLine(response);
            }
        }

        private async void btn_post_body_Click(object sender, EventArgs e)
        {
            var url = "https://httpbin.org/post";

            using var client = new HttpClient();

            var data = new Dictionary<string, string>
            {
                {"name", "John Doe"},
                {"occupation", "gardener"}
            };

            var res = await client.PostAsync(url, new FormUrlEncodedContent(data));

            var content = await res.Content.ReadAsStringAsync();
            Console.WriteLine(content);

            
        }

        private async void btn_post_head_Click(object sender, EventArgs e)
        {

            HttpClient httpClient = new HttpClient();
            using (HttpClient client = httpClient)
            {
                var values = new Dictionary<string, string>
            {
                { "email_id", "timmy.app@mail.tw" },
                { "password_id", "Timmy123" }
            };

                string url = "http://localhost:8080/login";
                var data = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(url, data);
                Console.WriteLine(response);
            }
        }
    }
}
