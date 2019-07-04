namespace ZaloDotNetSDK {
    public class ZaloAppInfo {

        private long _appId;
        private string _secretKey;
        private string _callbackUrl;

        public long appId
        {
            get { return _appId; }
            set { _appId = value; }
        }

        public string secretKey
        {
            get { return _secretKey; }
            set { _secretKey = value; }
        }

        public string callbackUrl
        {
            get { return _callbackUrl; }
            set { _callbackUrl = value; }
        }

        public ZaloAppInfo(long appId, string secretKey, string callbackUrl) {
            _appId = appId;
            _secretKey = secretKey;
            _callbackUrl = callbackUrl;
        }
    }
}