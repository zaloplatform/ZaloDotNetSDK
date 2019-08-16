using System;
using System.Web;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK {
    public class ZaloBaseClient {

        public bool isDebug = false;

        protected string sendHttpGetRequest(string endpoint, Dictionary<string, dynamic> param, Dictionary<string, string> header) {
            UriBuilder builder = new UriBuilder(endpoint);
            var query = HttpUtility.ParseQueryString(builder.Query);
            if (param != null) {
                foreach (KeyValuePair<string, dynamic> entry in param) {
                    if (entry.Value is string) {
                        query[entry.Key] = entry.Value;
                    }
                }
            }
            builder.Query = query.ToString();

            HttpClient httpClient = new HttpClient();
            if (header != null) {
                foreach (KeyValuePair<string, string> entry in header) {
                    httpClient.DefaultRequestHeaders.Add(entry.Key, entry.Value);
                }
            }
            if (isDebug)
            {
                Console.WriteLine("GET: "+ builder.ToString());
            }
            return httpClient.GetStringAsync(builder.ToString()).Result;
        }

        protected string sendHttpPostRequest(string endpoint, Dictionary<string, dynamic> param, Dictionary<string, string> header) {
            Dictionary<string, string> paramsUrl = new Dictionary<string, string>();
            HttpClient httpClient = new HttpClient();
            if (header != null) {
                foreach (KeyValuePair<string, string> entry in header) {
                    httpClient.DefaultRequestHeaders.Add(entry.Key, entry.Value);
                }
            }
            if (param != null) {
                foreach (KeyValuePair<string, dynamic> entry in param)
                {
                    if (entry.Value is string) {
                        paramsUrl[entry.Key] = entry.Value;
                    }
                }
            }
            FormUrlEncodedContent formUrlEncodedContent = new FormUrlEncodedContent(paramsUrl);
            if (isDebug)
            {
                UriBuilder builder = new UriBuilder(endpoint);
                var query = HttpUtility.ParseQueryString(builder.Query);
                    foreach (KeyValuePair<string, string> entry in paramsUrl)
                    {
                            query[entry.Key] = entry.Value;
                    }
                builder.Query = query.ToString();
                Console.WriteLine("POST: " + builder.ToString());
            }
            HttpResponseMessage response = httpClient.PostAsync(endpoint, formUrlEncodedContent).Result;
            return response.Content.ReadAsStringAsync().Result;
        }

        protected string sendHttpPostRequestWithBody(string endpoint, Dictionary<string, dynamic> param, string body, Dictionary<string, string> header) {
            HttpClient httpClient = new HttpClient();
            if (header != null) {
                foreach (KeyValuePair<string, string> entry in header) {
                    httpClient.DefaultRequestHeaders.Add(entry.Key, entry.Value);
                }
            }
            
            UriBuilder builder = new UriBuilder(endpoint);
            var query = HttpUtility.ParseQueryString(builder.Query);
            if (param != null)
            {
                foreach (KeyValuePair<string, dynamic> entry in param)
                {
                    if (entry.Value is string && !entry.Key.Equals("body")) {
                        query[entry.Key] = entry.Value;
                    }
                }
            }
            builder.Query = query.ToString();

            if (body == null) {
                body = "";
            }
            var content = new StringContent(body, Encoding.UTF8, "application/json");
            if (isDebug)
            {
                Console.WriteLine("POST: " + builder.ToString());
                Console.WriteLine("body: " + body);
                Console.WriteLine("body content: " + content);
            }
            HttpResponseMessage response = httpClient.PostAsync(builder.ToString(), content).Result;
            return response.Content.ReadAsStringAsync().Result;
        }

        protected string sendHttpUploadRequest(string endpoint, Dictionary<string, dynamic> param, Dictionary<string, string> header)
        {
            MultipartFormDataContent form = new MultipartFormDataContent();

            UriBuilder builder = new UriBuilder(endpoint);
            var query = HttpUtility.ParseQueryString(builder.Query);
            if (param != null)
            {
                foreach (KeyValuePair<string, dynamic> entry in param)
                {
                    if (entry.Value is string) {
                        query[entry.Key] = entry.Value;
                    }
                }
            }
            builder.Query = query.ToString();

            ZaloFile file = param["file"];
            form.Add(file.GetData(), "file", file.GetName());

            HttpClient httpClient = new HttpClient();
            if (header != null)
            {
                foreach (KeyValuePair<string, string> entry in header)
                {
                    httpClient.DefaultRequestHeaders.Add(entry.Key, entry.Value);
                }
            }

            HttpResponseMessage response = httpClient.PostAsync(builder.ToString(), form).Result;
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}