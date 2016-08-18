using OneDriveAPI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneDriveAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void authoriseButton_Click(object sender, EventArgs e)
        {
            var scope = new string[] { "onedrive.readwrite", "wl.signin" };
            var authProvider = new AuthProvider();
            authProvider.AuthenticateRequestAsync(new System.Net.Http.HttpRequestMessage(HttpMethod.Get,
                $"https://login.live.com/oauth20_authorize.srf?client_id={ConfigurationManager.AppSettings.Get(AppSettings.ClientId.ToString())}&scope={scope}&response_type=token&redirect_uri=http://www.google.co.uk/"));
        }
    }
}
