﻿namespace Cielo.Core.Configurations
{
    public class CieloEnvironment : IEnvironment
    {
        public static readonly CieloEnvironment Production = new CieloEnvironment("https://api.cieloecommerce.cielo.com.br", "https://apiquery.cieloecommerce.cielo.com.br");

        public static readonly CieloEnvironment Sandbox = new CieloEnvironment("https://apisandbox.cieloecommerce.cielo.com.br", "https://apiquerysandbox.cieloecommerce.cielo.com.br");

        public CieloEnvironment(string transactionUrl, string queryUrl)
        {
            this.TransactionUrl = transactionUrl;
            this.QueryUrl = queryUrl;
        }

        public string TransactionUrl { get; protected set; }

        public string QueryUrl { get; protected set; }
    }
}
