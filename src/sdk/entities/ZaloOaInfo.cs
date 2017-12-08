namespace ZaloCSharpSDK
{
    public class ZaloOaInfo
    {
        private long _oaId;
        private string _secretKey;
        private string _name;
        private string _avatar;
        private string _cover;
        private string _description;

        public long oaId
        {
            get { return _oaId; }
            set { _oaId = value; }
        }

        public string secretKey
        {
            get { return _secretKey; }
            set { _secretKey = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string avatar
        {
            get { return _avatar; }
            set { _avatar = value; }
        }

        public string cover
        {
            get { return _cover; }
            set { _cover = value; }
        }

        public string description
        {
            get { return _description; }
            set { _description = value; }
        }

        public ZaloOaInfo(long oaId, string secretKey)
        {
            _oaId = oaId;
            _secretKey = secretKey;
        }
    }
}
