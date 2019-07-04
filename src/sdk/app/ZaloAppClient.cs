using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace ZaloDotNetSDK {
    public class ZaloAppClient : ZaloBaseClient {
        private ZaloAppInfo _appInfo;

        public ZaloAppClient(ZaloAppInfo _appInfo) {
            this._appInfo = _appInfo;
        }
        private static string LOGIN_ENPOINT = "https://oauth.zaloapp.com/v3/auth?app_id={0}&redirect_uri={1}";
        public string getLoginUrl() {
            return string.Format(LOGIN_ENPOINT, _appInfo.appId, _appInfo.callbackUrl);
        }

        private static string ACCESSTOKEN_ENPOINT = "https://oauth.zaloapp.com/v3/access_token";    
        public JObject getAccessToken(string oauthCode) {
            string response = "";
            try {
                Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
                param.Add("app_id", _appInfo.appId.ToString());
                param.Add("app_secret", _appInfo.secretKey);
                param.Add("code", oauthCode);
                response = sendHttpGetRequest(ACCESSTOKEN_ENPOINT, param, APIConfig.DEFAULT_HEADER);
                return JObject.Parse(response);
            }
            catch (Exception e)
            {
                throw new APIException(response);
            }
        }

        private static String GET_PROFILE_ENPOINT = "https://graph.zalo.me/" + APIConfig.DEFAULT_3RDAPP_API_VERSION + "/me";
        public JObject getProfile(string accessToken, string fields) {
            string response = "";
            try {
                Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
                param.Add("access_token", accessToken);
                param.Add("fields", fields);
                response = sendHttpGetRequest(GET_PROFILE_ENPOINT, param, APIConfig.DEFAULT_HEADER);
                return JObject.Parse(response);
            }
            catch (Exception e)
            {
                throw new APIException(response);
            }
        }

        private static string GET_FRIENDS_ENPOINT = "https://graph.zalo.me/" + APIConfig.DEFAULT_3RDAPP_API_VERSION + "/me/friends";
        public JObject getFriends(string accessToken, int offset, int limit, string fields) {
            string response = "";
            try {
                Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
                param.Add("access_token", accessToken);
                param.Add("offset", offset.ToString());
                param.Add("limit", limit.ToString());
                param.Add("fields", fields);
                response = sendHttpGetRequest(GET_FRIENDS_ENPOINT, param, APIConfig.DEFAULT_HEADER);
                return JObject.Parse(response);
            }
            catch (Exception e)
            {
                throw new APIException(response);
            }
        }

        private static string GET_INVITABLE_FRIENDS_ENPOINT = "https://graph.zalo.me/" + APIConfig.DEFAULT_3RDAPP_API_VERSION + "/me/invitable_friends";
        public JObject getInvitableFriends(string accessToken, int offset, int limit, string fields) {
            string response = "";
            try {
                Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
                param.Add("access_token", accessToken);
                param.Add("offset", offset.ToString());
                param.Add("limit", limit.ToString());
                param.Add("fields", fields);
                response = sendHttpGetRequest(GET_INVITABLE_FRIENDS_ENPOINT, param, APIConfig.DEFAULT_HEADER);
                return JObject.Parse(response);
            }
            catch (Exception e)
            {
                throw new APIException(response);
            }
        }

        private static string POST_FEED_ENPOINT = "https://graph.zalo.me/" + APIConfig.DEFAULT_3RDAPP_API_VERSION + "/me/feed";
        public JObject postFeed(string accessToken, string message, string link) {
            string response = "";
            try {
                Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
                param.Add("access_token", accessToken);
                param.Add("message", message);
                param.Add("link", link);
                response = sendHttpPostRequest(POST_FEED_ENPOINT, param, APIConfig.DEFAULT_HEADER);
                return JObject.Parse(response);
            }
            catch (Exception e)
            {
                throw new APIException(response);
            }
        }

        private static string SEND_APP_REQUEST_ENPOINT = "https://graph.zalo.me/" + APIConfig.DEFAULT_3RDAPP_API_VERSION + "/apprequests";
        public JObject sendAppRequest(string accessToken, List<long> toUserIds, string message) {
            string response = "";
            try {
                Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
                param.Add("access_token", accessToken);
                param.Add("to", String.Join(",", toUserIds));
                param.Add("message", message);
                response = sendHttpPostRequest(SEND_APP_REQUEST_ENPOINT, param, APIConfig.DEFAULT_HEADER);
                return JObject.Parse(response);
            }
            catch (Exception e)
            {
                throw new APIException(response);
            }
        }

        private static String SEND_MESSAGE_ENDPOINT = "https://graph.zalo.me/" + APIConfig.DEFAULT_3RDAPP_API_VERSION + "/me/message";
        public JObject sendMessage(string accessToken, long userId, string message, string link) {
            string response = "";
            try {
                Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
                param.Add("access_token", accessToken);
                param.Add("to", userId.ToString());
                param.Add("message", message);
                param.Add("link", link);
                response = sendHttpPostRequest(SEND_MESSAGE_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
                return JObject.Parse(response);
            }
            catch (Exception e)
            {
                throw new APIException(response);
            }
        }
    }
}