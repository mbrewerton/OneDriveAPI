using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.OneDrive.Sdk.Authentication;
using System.Configuration;
using OneDriveAPI.Enums;

namespace OneDriveAPI
{
    public class AuthProvider : IAuthenticationProvider
    {
        public Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            var scopes = new string[] { "onedrive.readonly", "wl.signin" };
            var provider = new MsaAuthenticationProvider(
                ConfigurationManager.AppSettings.Get(AppSettings.ClientId.ToString()),
                "https://login.live.com/oauth20_desktop.srf",
                scopes);

            return provider.AuthenticateUserAsync();
        }
    }
}
