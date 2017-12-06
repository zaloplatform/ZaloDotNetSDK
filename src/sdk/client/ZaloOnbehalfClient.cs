using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace ZaloCSharpSDK
{
    public class ZaloOnbehalfClient : ZaloBaseClient
    {
        private Zalo3rdAppInfo _appInfo;

        public ZaloOnbehalfClient(Zalo3rdAppInfo appInfo)
        {
            _appInfo = appInfo;
        }

        public string getLoginUrl()
        {
            string loginEndpoint = String.Format("https://oauth.zaloapp.com/page/login?app_id={0}&redirect_uri=%{1}", _appInfo.appId, _appInfo.secretKey);
            return loginEndpoint;
        }

        public JObject get(string url, JObject data)
        {
            string endpoint = String.Format("{0}/{1}/{2}", APIConfig.DEFAULT_OA_API_BASE, APIConfig.DEFAULT_OA_API_VERSION, url);
            Dictionary<string, string> param = createOnbehalfParam(_appInfo, data);
            string response = "";
            response = sendHttpGetRequest(endpoint, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject post(string url, JObject data)
        {
            string endpoint = String.Format("{0}/{1}/{2}", APIConfig.DEFAULT_OA_API_BASE, APIConfig.DEFAULT_OA_API_VERSION, url);
            Dictionary<string, string> param;
            string response = "";
            if (data["file"] != null)
            {
                JObject fileParam = JObject.FromObject(new
                {
                    data = new
                    {
                        file = data["file"],
                        accessTok = data["accessTok"]
                    }
                });
                param = createOnbehalfParam(_appInfo, fileParam);
                response = sendHttpUploadRequest(endpoint, data["file"].ToString(), param, APIConfig.DEFAULT_HEADER);
                return JObject.Parse(response);
            }
            else
            {
                param = createOnbehalfParam(_appInfo, data);
            }
            response = sendHttpPostRequest(endpoint, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }
    }
}
