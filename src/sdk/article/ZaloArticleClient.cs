using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class ZaloArticleClient : ZaloBaseClient
    {
        private ZaloOaInfo _oaInfo;

        public ZaloArticleClient(ZaloOaInfo oaInfo)
        {
            OaInfo = oaInfo;
        }

        public ZaloOaInfo OaInfo
        {
            get
            {
                return _oaInfo;
            }

            set
            {
                _oaInfo = value;
            }
        }

        public JObject getSliceVideoMedia(int offset, int count)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    offset = offset,
                    count = count
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpGetRequest(ZaloEndpoint.GET_SLICE_VIDEO_MEDIA_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject updateVideoMedia(string mediaid, VideoMedia media)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    mediaid = mediaid,
                    media = media
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.UPDATE_VIDEO_MEDIA_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject createVideoMedia(VideoMedia media)
        {
            JObject data = JObject.FromObject(new
            {
                media = media
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.CREATE_VIDEO_MEDIA_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject createMedia(Media media)
        {
            JObject data = JObject.FromObject(new
            {
                media = media
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.CREATE_MEDIA_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject verifyMedia(string token)
        {
            JObject data = JObject.FromObject(new
            {
                token = token
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.VERIFY_MEDIA_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject updateMedia(string mediaid, Media media)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    mediaid = mediaid,
                    media = media
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.UPDATE_MEDIA_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject removeMedia(string mediaid)
        {
            JObject data = JObject.FromObject(new
            {
                mediaid = mediaid
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.REMOVE_MEDIA_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject getSliceMedia(int offset, int count)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    offset = offset,
                    count = count
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpGetRequest(ZaloEndpoint.GET_SLICE_MEDIA_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }
        
        public JObject getUploadLink(string videoName, long videoSize)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    videoName = videoName,
                    videoSize = videoSize
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.GET_UPLOAD_LINK_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject uploadVideo(string uploadLink, string appId, string pathToFile, long timestamp, string sig)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("appId", appId);
            param.Add("timestamp", timestamp.ToString());
            param.Add("sig", sig);
            string response = sendHttpUploadRequest(uploadLink, pathToFile, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject getVideoId(string token, string videoName, long videoSize, long time, string sig)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    token = token,
                    videoName = videoName,
                    videoSize = videoSize,
                    time = time,
                    sig = sig
                }
            });

            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpGetRequest(ZaloEndpoint.GET_MEDIA_VIDEO_ID_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject getVideoStatus(string videoId)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    videoId = videoId
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpGetRequest(ZaloEndpoint.GET_MEDIA_VIDEO_STATUS_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }
    }
}
