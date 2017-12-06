using System.Collections.Generic;
namespace ZaloCSharpSDK {
    public class APIConfig {
        public static readonly string DEFAULT_OA_API_VERSION = "v1";
        public static readonly string DEFAULT_3RDAPP_API_VERSION = "v2.0";
        public static readonly string DEFAULT_OA_API_BASE = "https://openapi.zaloapp.com/oa";
        public static readonly string USER_AGENT = "zalosdk/1.0 CSharp Open API Java SDK";
        public static readonly string SDK_VERSION = "CSharp 1.0";
        public static readonly string SDK_SOURCE = "CSharpSDK-1.0";
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