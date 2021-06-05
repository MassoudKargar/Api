namespace Api.Services
{
    public static class Connection
    {
        static Connection()
        {
            _senderValue = "1000596446";
            _kavenegarApiValue = "4F6664707564387766675275485A5550615A5039472B5777414D6672664863506D4A4F71646E4D6B6367493D";
            _zarinPalValue = "876be5c1-d30b-486a-af4d-9d277294a3bb";
            _clientSecretValue = "TSOxULOr1BBYyovaV-OYz_vM";
            _clientIdValue = "395349815909-221u0fr0ec4fhhf5nclgk63ffcfms74i.apps.googleusercontent.com";
            _secretKeyValue = "6Le9H2gaAAAAAIkGXQo0sa7H2jyVsmbQ3n8HSU5d";
            _siteKeyValue = "6Le9H2gaAAAAAPHf_wDSouYhuqlvg_lxVjC2G_PB";
            _configValue = "G-RJ8099H9PL";
            //ConnectionValue = "Data Source=.;Initial Catalog=Director;Integrated Security=SSPI; MultipleActiveResultSets=true;";
            //ConnectionValue = "Server=.;Database=Api;Integrated Security=SSPI; MultipleActiveResultSets=true;";
            //ConnectionValue = "Data Source=ToranjHome.ir\\MSSQLSERVER2019;Initial Catalog=Director;Persist Security Info=True;User ID=massoud; Password=~/Blood<100101001>(_(0)-(0)_);";
            _connectionValue = "Data Source=.;Initial Catalog=Api;Integrated Security=SSPI; MultipleActiveResultSets=true;";
            _apiKeyValue = "AIzaSyDTPbVnZNsJkPsd8FNHojOt0QLHyBP0uL0";

        }
        private static string _senderValue;
        private static string _kavenegarApiValue;
        private static string _zarinPalValue;
        private static string _clientSecretValue;
        private static string _clientIdValue;
        private static string _secretKeyValue;
        private static string _siteKeyValue;
        private static string _configValue;
        private static string _connectionValue;
        private static string _apiKeyValue;

        public static string Connectionlocal { get =>_connectionValue; set => _connectionValue = value; }
        public static string Config { get => _configValue; set => _configValue = value; }
        public static string SiteKey { get => _siteKeyValue; set => _siteKeyValue = value; }
        public static string SecretKey { get => _secretKeyValue; set => _secretKeyValue = value; }
        public static string ClientId { get => _clientIdValue; set => _clientIdValue = value; }
        public static string ClientSecret { get => _clientSecretValue; set => _clientSecretValue = value; }
        public static string ZarinPal { get => _zarinPalValue; set => _zarinPalValue = value; }
        public static string KavenegarApi { get => _kavenegarApiValue; set => _kavenegarApiValue = value; }
        public static string Sender { get => _senderValue; set => _senderValue = value; }
        public static string ApiKet { get => _apiKeyValue; set => _apiKeyValue = value; }

    }
}
