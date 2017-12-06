using System;
using System.Web;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ZaloCSharpSDK {
    public class ZaloBaseClient {
        private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        protected string sendHttpGetRequest(string endpoint, Dictionary<string, string> param, Dictionary<string, string> header) {
            UriBuilder builder = new UriBuilder(endpoint);
            var query = HttpUtility.ParseQueryString(builder.Query);
            if (param != null) {
                foreach (KeyValuePair<string, string> entry in param) {
                    query[entry.Key] = entry.Value;
                }
            }
            builder.Query = query.ToString();

            HttpClient httpClient = new HttpClient();
            if (header != null) {
                foreach (KeyValuePair<string, string> entry in header) {
                    httpClient.DefaultRequestHeaders.Add(entry.Key, entry.Value);
                }
            }

            return httpClient.GetStringAsync(builder.ToString()).Result;
        }

        protected string sendHttpPostRequest(string endpoint, Dictionary<string, string> param, Dictionary<string, string> header) {
            FormUrlEncodedContent formUrlEncodedContent = new FormUrlEncodedContent(param);

            HttpClient httpClient = new HttpClient();
            if (header != null) {
                foreach (KeyValuePair<string, string> entry in header) {
                    httpClient.DefaultRequestHeaders.Add(entry.Key, entry.Value);
                }
            }
            HttpResponseMessage response = httpClient.PostAsync(endpoint, formUrlEncodedContent).Result;
            return response.Content.ReadAsStringAsync().Result;
        }

        protected string sendHttpUploadRequest(string endpoint, string pathToFile, Dictionary<string, string> param, Dictionary<string, string> header)
        {
            MultipartFormDataContent form = new MultipartFormDataContent();

            if (param != null)
            {
                foreach (KeyValuePair<string, string> entry in param)
                {
                    form.Add(new StringContent(entry.Value), entry.Key);
                }
            }
            form.Add(new ByteArrayContent(FileUtils.loadFile(pathToFile)), "file", Path.GetFileName(pathToFile));

            HttpClient httpClient = new HttpClient();
            if (header != null)
            {
                foreach (KeyValuePair<string, string> entry in header)
                {
                    httpClient.DefaultRequestHeaders.Add(entry.Key, entry.Value);
                }
            }

            HttpResponseMessage response = httpClient.PostAsync(endpoint, form).Result;
            return response.Content.ReadAsStringAsync().Result;
        }

        protected Dictionary<string, string> createParam(ZaloOaInfo oaInfo, JObject data)
        {
            long timestamp = (long) (DateTime.UtcNow - Jan1st1970).TotalMilliseconds;

            StringBuilder macContent = new StringBuilder();
            macContent.Append(oaInfo.oaId);

            Dictionary<string, string> param = new Dictionary<string, string>();
            if (data["file"] == null)
            {
                foreach (var item in data)
                {
                    macContent.Append(item.Value);
                    param.Add(item.Key, item.Value.ToString());
                }
            }
            macContent.Append(timestamp);
            macContent.Append(oaInfo.secretKey);
            string mac = MacUtils.buildMac(macContent.ToString());

            param.Add("oaid", oaInfo.oaId.ToString());
            param.Add("timestamp", timestamp.ToString());
            param.Add("mac", mac);

            return param;
        }

        protected Dictionary<string, string> createOnbehalfParam(Zalo3rdAppInfo appInfo, JObject data)
        {
            long timestamp = (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;

            StringBuilder macContent = new StringBuilder();
            macContent.Append(appInfo.appId);

            Dictionary<string, string> param = new Dictionary<string, string>();
            foreach (var item in data)
            {
                macContent.Append(item.Value);
                param.Add(item.Key, item.Value.ToString());
            }
            macContent.Append(timestamp);
            macContent.Append(appInfo.secretKey);
            string mac = MacUtils.buildMac(macContent.ToString());

            param.Add("appid", appInfo.appId.ToString());
            param.Add("timestamp", timestamp.ToString());
            param.Add("mac", mac);

            return param;
        }
    }
}