using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace ZaloCSharpSDK
{
    public class ZaloClient : ZaloBaseClient
    {
        private ZaloOaInfo _oaInfo;

        public ZaloClient(ZaloOaInfo oaInfo)
        {
            _oaInfo = oaInfo;
        }

        public JObject get(string url, JObject data)
        {
            string endpoint = String.Format("{0}/{1}/{2}", APIConfig.DEFAULT_OA_API_BASE, APIConfig.DEFAULT_OA_API_VERSION, url);
            Dictionary<string, string> param = createParam(_oaInfo, data);
            string response = "";
            response = sendHttpGetRequest(endpoint, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject post(string url, JObject data)
        {
            string endpoint = String.Format("{0}/{1}/{2}", APIConfig.DEFAULT_OA_API_BASE, APIConfig.DEFAULT_OA_API_VERSION, url);
            Dictionary<string, string> param = createParam(_oaInfo, data);
            string response = "";
            if (data["file"] != null)
            {
                response = sendHttpUploadRequest(endpoint, data["file"].ToString(), param, APIConfig.DEFAULT_HEADER);
                return JObject.Parse(response);
            }
            
            response = sendHttpPostRequest(endpoint, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject uploadVideo(string url, JObject data)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("appId", data["appId"].ToString());
            param.Add("timestamp", data["timestamp"].ToString());
            param.Add("sig", data["sig"].ToString());
            string response = sendHttpUploadRequest(url, data["file"].ToString(), param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }
    }
}
