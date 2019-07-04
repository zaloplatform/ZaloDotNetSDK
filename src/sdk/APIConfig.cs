using System.Collections.Generic;
namespace ZaloDotNetSDK {
    public class APIConfig {
        public static readonly string DEFAULT_OA_API_VERSION = "v2";
        public static readonly string DEFAULT_3RDAPP_API_VERSION = "v2.0";
        public static readonly string DEFAULT_OA_API_BASE = "https://openapi.zalo.me/v2.0/oa";
        public static readonly string DEFAULT_STORE_API_BASE = "https://openapi.zalo.me/v2.0/store";
        public static readonly string DEFAULT_ARTICLE_API_BASE = "https://openapi.zalo.me/v2.0/article";
        public static readonly string USER_AGENT = "zalosdk/2.0 DotNet Open API Java SDK";
        public static readonly string SDK_VERSION = "DotNet 2.0";
        public static readonly string SDK_SOURCE = "DotNetSDK-2.0";
        public static readonly Dictionary<string, string> DEFAULT_HEADER = createDefaultHeader();

        private static Dictionary<string, string> createDefaultHeader() {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("User-Agent", USER_AGENT);
            dictionary.Add("SDK_VERSION", SDK_VERSION);
            dictionary.Add("SDK-Source", SDK_SOURCE);
            return dictionary;
        }
    }
}