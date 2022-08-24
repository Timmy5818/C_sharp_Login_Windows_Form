using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Management;

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
            using HttpClient client = httpClient;
            var values = new Dictionary<string, string>
            {
                { "email_id", "timmy.app@mail.tw" },
                { "password_id", "Timmy123" }
            };

            string url = "http://localhost:8080/login";
            var data = new FormUrlEncodedContent(values);
            var response = await client.PostAsync(url, data);
            Console.WriteLine(response);

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
            using HttpClient client = httpClient;
            string url = "http://localhost:8080/login";
            var response = await client.GetAsync(url);
            Console.WriteLine(response);
        }

        private async void btn_post_body_Click(object sender, EventArgs e)
        {
            //var url = "https://httpbin.org/post";

            //using var client = new HttpClient();

            //var data = new Dictionary<string, string>
            //{
            //    {"name", "John Doe"},
            //    {"occupation", "gardener"}
            //};

            //var res = await client.PostAsync(url, new FormUrlEncodedContent(data));

            //var content = await res.Content.ReadAsStringAsync();
            //Console.WriteLine(content);

            var url = "http://localhost:8080/login";

            using var client = new HttpClient();

            var data = new Dictionary<string, string>
            {
                { "email", txtUsername.Text },
                { "password", txtPassword.Text }
            };

            var res = await client.PostAsync(url, new FormUrlEncodedContent(data));

            var content = await res.Content.ReadAsStringAsync();
            Console.WriteLine(res.RequestMessage.RequestUri);

            if (content == "OK")
            {
                frmMain objFrmMain = new frmMain();
                this.Hide();
                objFrmMain.Show();
            }
            else
            {
                MessageBox.Show("請確定你的帳號密碼是否正確");
            }


        }

        private async void btn_post_head_Click(object sender, EventArgs e)
        {

            HttpClient httpClient = new HttpClient();
            using HttpClient client = httpClient;
            var values = new Dictionary<string, string>
            {
                { "email", "timmy.app@mail.tw" },
                { "password", "Timmy123123" }
            };

            string url = "http://localhost:8080/login";
            var data = new FormUrlEncodedContent(values);
            var response = await client.PostAsync(url, data);
            Console.WriteLine(response);
        }

        private void ListTest_Click(object sender, EventArgs e)
        {
            Testlist();
        }
            static void Testlist()
            {
                List<string> l1 = new List<string>() { "a", "b", "c" };
                List<string> l2 = new List<string>() { "b", "a", "e" };

                foreach (string str in Intersect(l1, l2))
                {
                    Console.WriteLine(str);
                }

            }

            static IEnumerable<T> Intersect<T>(IList<T> lhs, IList<T> rhs)
            {
                if (lhs == null) throw new ArgumentNullException("lhs");
                if (rhs == null) throw new ArgumentNullException("rhs");

                // build the dictionary from the shorter list
                if (lhs.Count > rhs.Count)
                {
                    IList<T> tmp = rhs;
                    rhs = lhs;
                    lhs = tmp;
                }
                Dictionary<T, bool> lookup = new Dictionary<T, bool>();
                foreach (T item in lhs)
                {
                    if (!lookup.ContainsKey(item)) lookup.Add(item, true);
                }
                foreach (T item in rhs)
                {
                    if (lookup.ContainsKey(item))
                    {
                        lookup.Remove(item); // prevent duplicates
                        yield return item;

                    }
                }
            }

        private void MacBtn_Click(object sender, EventArgs e)
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            List<string> macList = new List<string>();
            foreach (var nic in nics)
            {
                // 因為電腦中可能有很多的網卡(包含虛擬的網卡)，
                // 我只需要 Ethernet 網卡的 MAC
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    macList.Add(nic.GetPhysicalAddress().ToString());
                    //MessageBox.Show(macList[0]);
                    Console.WriteLine(macList[0]);
                }
            }
        }

        private void MacBtn2_Click(object sender, EventArgs e)
        {
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            Console.WriteLine("Interface information for {0}.{1}     ",
                    computerProperties.HostName, computerProperties.DomainName);
            if (nics == null || nics.Length < 1)
            {
                Console.WriteLine("  No network interfaces found.");
                return;
            }

            Console.WriteLine("  Number of interfaces .................... : {0}", nics.Length);
            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties(); //  .GetIPInterfaceProperties();
                Console.WriteLine();
                Console.WriteLine(adapter.Description);
                Console.WriteLine(String.Empty.PadLeft(adapter.Description.Length, '='));
                Console.WriteLine("  Interface type .......................... : {0}", adapter.NetworkInterfaceType);
                Console.Write("  Physical address ........................ : ");
                PhysicalAddress address = adapter.GetPhysicalAddress();
                byte[] bytes = address.GetAddressBytes();
                for (int i = 0; i < bytes.Length; i++)
                {
                    // Display the physical address in hexadecimal.
                    Console.Write("{0}", bytes[i].ToString("X2"));
                    // Insert a hyphen after each byte, unless we are at the end of the
                    // address.
                    if (i != bytes.Length - 1)
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }

        private void MoboBtn_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("Select ProcessorID From Win32_processor");
            ManagementObjectCollection mbsList = mos.Get();
            string processorId = string.Empty;
            foreach (ManagementBaseObject mo in mbsList)
            {
                processorId = mo["ProcessorID"] as string;
            }

            mos = new ManagementObjectSearcher("SELECT UUID FROM Win32_ComputerSystemProduct");
            mbsList = mos.Get();
            string systemId = string.Empty;
            foreach (ManagementBaseObject mo in mbsList)
            {
                systemId = mo["UUID"] as string;
            }

            var compIdStr = $"{processorId}{systemId}";
            Console.WriteLine(compIdStr);
        }


        private void Btnweb_Click(object sender, EventArgs e)
        {
            web f = new web();
            this.Visible = false;
            f.Visible = true;
        }
    }
}