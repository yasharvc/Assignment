using System;
using System.Collections.Generic;
using System.Text;
using Xero.Api.Core;
using Xero.Api.Infrastructure.Authenticators;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;

namespace XeroApiConsumer.Connection
{
    public class ApiConnector
    {
        private const string CertificatePath = @"D:\Yashar\public_privatekey.pfx";
        private const string CertificatePassword = "123";

        public ApiUser User()
        {
            return new ApiUser { Identifier = "Yashar" };
        }
        public PrivateAuthenticator Authenticator { get; private set; }

        public IXeroCoreApi Api { get; private set; }
        public ApiConnector()
        {
            Authenticator = new PrivateAuthenticator(CertificatePath, CertificatePassword);
            Api = new XeroCoreApi(Authenticator as IAuthenticator, GetApiSetting(), User());
        }

        private static Xero.Api.XeroApiSettings GetApiSetting() => new Xero.Api.XeroApiSettings();
    }
}
