namespace BBB.ClientRESTHelpers
{

    internal class BearerToken
    {
        private static readonly Lazy<BearerToken> instance = new Lazy<BearerToken>(() => new BearerToken());
        public static BearerToken Instance => instance.Value;

        private string _token;
        private bool _status;

        public string Token
        {
            get
            {
                return _token;
            }
            set
            {
                _token = value;
                Status = !string.IsNullOrEmpty(_token);

            }
        }

        public bool Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                if (!_status)
                {
                    _token = "";
                }
            }
        }

        private BearerToken()
        {
            _token = "";
        }
    }
}
