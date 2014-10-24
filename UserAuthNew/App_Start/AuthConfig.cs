using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using UserAuthNew.AuthClient;
using UserAuthNew.Models;

namespace UserAuthNew
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // следует обновить сайт. Дополнительные сведения: http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            OAuthWebSecurity.RegisterTwitterClient(
                consumerKey: "Sj2eU4AAh9NSqVLoMERItP9Hy",
                consumerSecret: "SjNVG4cuDMYHEkRcxGbxm9cHPCuOTpludQVZhWGsH70JGPEskl");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "364141163710817",
                appSecret: "d368c6bfc4b8341282890671018a4f95");

            OAuthWebSecurity.RegisterClient(
                client: new VKontakteAuthenticationClient("4595168", "ezbp6Xmc5QvcjFeLyVff"),
                displayName: "ВКонтакте",
                extraData: null);

            //OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
