using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class ZaloOaClient : ZaloBaseClient
    {
        private ZaloOaInfo _oaInfo;

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

        public ZaloOaClient(ZaloOaInfo oaInfo)
        {
            OaInfo = oaInfo;
        }

        
        public JObject getTagsOfOa()
        {
            Dictionary<string, string> param = createParam(OaInfo, new JObject());
            string response = sendHttpGetRequest(ZaloEndpoint.GET_TAGS_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject removeTag(string tagName)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    tagName = tagName
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.REMOVE_TAG_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject removeFollowerFromTag(long uid, string tagName)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    uid = uid,
                    tagName = tagName
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.REMOVE_FOLLOWER_FROM_TAG_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        
        public JObject tagFollower(long uid, string tagName)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    uid = uid,
                    tagName = tagName
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.TAG_FOLLOWER_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject sendTextMessage(long uid, string message)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    uid = uid,
                    message = message
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.SEND_TEXT_MESSAGE_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject uploadImage(string pathToFile)
        {
            Dictionary<string, string> param = createParam(OaInfo, new JObject());
            string response = sendHttpUploadRequest(ZaloEndpoint.UPLOAD_IMAGE_ENDPOINT, pathToFile, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject uploadGif(string pathToGif)
        {
            Dictionary<string, string> param = createParam(OaInfo, new JObject());
            string response = sendHttpUploadRequest(ZaloEndpoint.UPLOAD_GIF_ENDPOINT, pathToGif, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject sendImageMessage(long uid, string imageId, string message)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    uid = uid,
                    imageid = imageId,
                    message = message
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.SEND_IMAGE_MESSAGE_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject sendGifMessage(long uid, string imageId, int width, int height)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    uid = uid,
                    imageid = imageId,
                    width = width,
                    height = height
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.SEND_GIF_MESSAGE_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject sendLinksMessage(long uid, List<MsgLink> links)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    uid = uid,
                    links = links
                }
            });
            Console.WriteLine(data);
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.SEND_LINKS_MESSAGE_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject sendActionMessage(long uid, List<MsgAction> actionList)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    uid = uid,
                    actionlist = actionList
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.SEND_ACTION_MESSAGE_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject sendStickerMessage(long uid, string stickerId)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    uid = uid,
                    stickerid = stickerId
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.SEND_STICKER_MESSAGE_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject getProfile(long uid)
        {
            JObject data = JObject.FromObject(new
            {
                uid = uid,
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpGetRequest(ZaloEndpoint.GET_PROFILE_EDNPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject getMessageStatus(string msgId)
        {
            JObject data = JObject.FromObject(new
            {
                msgid = msgId,
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpGetRequest(ZaloEndpoint.GET_MESSAGE_STATUS_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject replyTextMessage(string msgid, string message)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    msgid = msgid,
                    message = message
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.REPLY_TEXT_MESSAGE_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject replyImageMessage(string msgid, string imageid, string message)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    msgid = msgid,
                    imageid = imageid,
                    message = message
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.REPLY_IMAGE_MESSAGE_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject replyLinksMessage(string msgid, List<MsgLink> links)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    msgid = msgid,
                    links = links
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.REPLY_LINKS_MESSAGE_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject createQRcode(string qrdata, int size)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    qrdata = qrdata,
                    size = size
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.CREATE_QRCODE_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }
    }
}
