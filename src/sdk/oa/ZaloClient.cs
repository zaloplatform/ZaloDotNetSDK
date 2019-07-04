using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ZaloDotNetSDK.entities;
using ZaloDotNetSDK.utils;
using ZaloDotNetSDK.entities.oa;
using ZaloDotNetSDK.entities.shop;

namespace ZaloDotNetSDK
{
    public class ZaloClient : ZaloBaseClient
    {
        string access_token = "";

        public ZaloClient(string access_token)
        {
            this.Access_token = access_token;
        }

        public string Access_token { get => access_token; set => access_token = value; }

        public JObject excuteRequest(string method, string endPoint,  Dictionary<string, dynamic> param){
            if (param == null) {
                param = new Dictionary<string, dynamic>();
            }
            param.Add("access_token", this.Access_token);
            string response;

            if ("GET".Equals(method.ToUpper()))
            {
                response = sendHttpGetRequest(endPoint, param, APIConfig.DEFAULT_HEADER);
            }
            else
            {
                if (param.ContainsKey("file"))
                {
                    response = sendHttpUploadRequest(endPoint, param, APIConfig.DEFAULT_HEADER);
                }
                else if (param.ContainsKey("body"))
                {
                    response = sendHttpPostRequestWithBody(endPoint, param, param["body"], APIConfig.DEFAULT_HEADER);
                }
                else 
                {
                    response = sendHttpPostRequest(endPoint, param, APIConfig.DEFAULT_HEADER);
                }
            }
            
            JObject result = null;
            try
            {
                result = JObject.Parse(response);
            }
            catch (Exception e)
            {
                throw new APIException("Response is not json: " + response);
            }
            return result;
        }

        //==========================Article=====================================
        public JObject createArticle(Article article)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            param.Add("body", JsonUtils.parseArticle2Json(article).ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/article/create", param);

            return result;
        }

        public JObject createVideoArticle(VideoArticle videoArticle)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            param.Add("body", JsonUtils.parseVideoArticle2Json(videoArticle).ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/article/create", param);

            return result;
        }

        public JObject updateArticle(Article article, string id)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject articleJson = JsonUtils.parseArticle2Json(article);
            articleJson.Add("id", id);
            param.Add("body", articleJson.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/article/update", param);

            return result;
        }

        public JObject updateVideoArticle(VideoArticle videoArticle, string id)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject articleJson = JsonUtils.parseVideoArticle2Json(videoArticle);
            articleJson.Add("id", id);
            param.Add("body", articleJson.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/article/update", param);

            return result;
        }

        public JObject deleteArticle(string id)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject articleJson = new JObject();
            articleJson.Add("id", id);
            param.Add("body", articleJson.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/article/remove", param);

            return result;
        }

        public JObject getsliceArticle(int offset, int limit, string type)
        {
            JObject result = new JObject();

            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("offset", offset.ToString());
            param.Add("limit", limit.ToString());
            param.Add("type", type);

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/article/getslice", param);

            return result;
        }

        public JObject getdetailArticle(string id)
        {
            JObject result = new JObject();

            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("id", id);

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/article/getdetail", param);

            return result;
        }

        public JObject verifyArticle(string token)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject articleJson = new JObject();
            articleJson.Add("token", token);
            param.Add("body", articleJson.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/article/verify", param);

            return result;
        }

        public JObject prepareUploadVideoForArticle(ZaloFile zaloFile)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("file", zaloFile);

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/article/upload_video/preparevideo", param);

            return result;
        }

        public JObject verifyUploadVideoForArticle(string token)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("token", token);

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/article/upload_video/verify", param);

            return result;
        }
        //==========================Article=====================================

        //==========================Message=====================================
        public JObject sendTextMessageToUserId(string user_id, string content)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    user_id
                },
                message = new
                {
                    text = content
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }

        public JObject sendImageMessageToUserIdByUrl(string user_id, string content, string image_url)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            List<JObject> elementJson = new List<JObject>();
            elementJson.Add(JObject.FromObject(new {
                media_type= "image",
                url = image_url
            }));

            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    user_id
                },
                message = new
                {
                    text = content,
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            template_type = "media",
                            elements = elementJson
                        }
                    }
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }

        public JObject sendImageMessageToUserIdByAttachmentId(string user_id, string content, string image_attachment_id)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            List<JObject> elementJson = new List<JObject>();
            elementJson.Add(JObject.FromObject(new
            {
                media_type = "image",
                attachment_id = image_attachment_id
            }));

            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    user_id
                },
                message = new
                {
                    text = content,
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            template_type = "media",
                            elements = elementJson
                        }
                    }
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }

        public JObject sendGifMessageToUserIdByAttachmentId(string user_id, string content, string gif_attachment_id, int gif_width = 120, int gif_height = 120)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            List<JObject> elementJson = new List<JObject>();
            elementJson.Add(JObject.FromObject(new
            {
                media_type = "gif",
                attachment_id = gif_attachment_id,
                width = gif_width,
                height = gif_height
            }));

            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    user_id
                },
                message = new
                {
                    text = content,
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            template_type = "media",
                            elements = elementJson
                        }
                    }
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }

        public JObject sendListElementMessagetoUserId(string user_id, string content, List<Element> elements)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            List<JObject> elementsJson = JsonUtils.parseListElement2Json(elements);

            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    user_id
                },
                message = new
                {
                    text = content,
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            template_type = "list",
                            elements = elementsJson
                        }
                    }
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }

        public JObject sendListButtonMessagetoUserId(string user_id, string content, List<Button> buttons)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            List<JObject> buttonsJson = JsonUtils.parseListButton2Json(buttons);

            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    user_id
                },
                message = new
                {
                    text = content,
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            buttons = buttonsJson
                        }
                    }
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }

        public JObject sendListButtonAndElementMessagetoUserId(string user_id, string content, List<Element> elements, List<Button> buttons)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            List<JObject> buttonsJson = JsonUtils.parseListButton2Json(buttons);
            List<JObject> elementsJson = JsonUtils.parseListElement2Json(elements);
            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    user_id
                },
                message = new
                {
                    text = content,
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            template_type = "list",
                            elements = elementsJson,
                            buttons = buttonsJson
                        }
                    }
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }

        public JObject sendRequestUserProfileToUserId(string user_id, string element_title, string element_subtitle, string url_image)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            List<JObject> elementsJson = new List<JObject>();
            elementsJson.Add(JObject.FromObject(new
            {
                title = element_title,
                subtitle = element_subtitle,
                image_url = url_image
            }));

            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    user_id
                },
                message = new
                {
                    text = "",
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            template_type = "request_user_info",
                            elements = elementsJson
                        }
                    }
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }

        public JObject sendFileToUserId(string user_id, string file_attachment_id)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    user_id
                },
                message = new
                {
                    attachment = new
                    {
                        type = "file",
                        payload = new
                        {
                            token = file_attachment_id
                        }
                    }
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }

        public JObject sendTextMessageToMessageId(string message_id, string content)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    message_id
                },
                message = new
                {
                    text = content
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }

        public JObject sendImageMessageToMessageIdByUrl(string message_id, string content, string image_url)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            List<JObject> elementJson = new List<JObject>();
            elementJson.Add(JObject.FromObject(new
            {
                media_type = "image",
                url = image_url
            }));

            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    message_id
                },
                message = new
                {
                    text = content,
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            template_type = "media",
                            elements = elementJson
                        }
                    }
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }

        public JObject sendImageMessageToMessageIdByAttachmentId(string message_id, string content, string image_attachment_id)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            List<JObject> elementJson = new List<JObject>();
            elementJson.Add(JObject.FromObject(new
            {
                media_type = "image",
                attachment_id = image_attachment_id
            }));

            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    message_id
                },
                message = new
                {
                    text = content,
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            template_type = "media",
                            elements = elementJson
                        }
                    }
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }

        public JObject sendListButtonMessageToMessageId(string message_id, string content, List<Button> buttons)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            List<JObject> buttonsJson = JsonUtils.parseListButton2Json(buttons);

            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    message_id
                },
                message = new
                {
                    text = content,
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            buttons = buttonsJson
                        }
                    }
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }

        public JObject getAllTagOfOfficialAccount()
        {
            JObject result = new JObject();

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/oa/tag/gettagsofoa", null);

            return result;
        }

        public JObject tagFollower(string user_id, string tag_name)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject body = JObject.FromObject(new
            {
                user_id,
                tag_name
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/tag/tagfollower", param);

            return result;
        }

        public JObject removeTagFromFollower(string user_id, string tag_name)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject body = JObject.FromObject(new
            {
                user_id,
                tag_name
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/tag/rmfollowerfromtag", param);

            return result;
        }

        public JObject deleteTag(string tag_name)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject body = JObject.FromObject(new
            {
                tag_name
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/tag/rmtag", param);

            return result;
        }

        public JObject uploadImageForOfficialAccountAPI(ZaloFile zaloFile)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("file", zaloFile);

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/upload/image", param);

            return result;
        }

        public JObject uploadGifForOfficialAccountAPI(ZaloFile zaloFile)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("file", zaloFile);

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/upload/gif", param);

            return result;
        }

        public JObject uploadFileForOfficialAccountAPI(ZaloFile zaloFile)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("file", zaloFile);

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/upload/file", param);

            return result;
        }

        public JObject getProfileOfFollower(string user_id)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject dataJson = JObject.FromObject(new
            {
                user_id
            });

            param.Add("data", dataJson.ToString());

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/oa/getprofile", param);

            return result;
        }

        public JObject getProfileOfOfficialAccount()
        {
            JObject result = new JObject();

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/oa/getoa", null);

            return result;
        }

        public JObject getListFollower(int offset, int count)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject dataJson = JObject.FromObject(new
            {
                offset,
                count
            });

            param.Add("data", dataJson.ToString());

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/oa/getfollowers", param);

            return result;
        }

        public JObject getListRecentChat(int offset, int count)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject dataJson = JObject.FromObject(new
            {
                offset,
                count
            });

            param.Add("data", dataJson.ToString());

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/oa/listrecentchat", param);

            return result;
        }

        public JObject getListConversationWithUser(string user_id, int offset, int count)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject dataJson = JObject.FromObject(new
            {
                user_id,
                offset,
                count
            });

            param.Add("data", dataJson.ToString());

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/oa/conversation", param);

            return result;
        }

        public JObject registerIP(string ip, string name)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject body = JObject.FromObject(new
            {
                ip,
                name
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/registerip", param);

            return result;
        }

        public JObject removeIP(string ip, string name)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject body = JObject.FromObject(new
            {
                ip,
                name
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/removeip", param);

            return result;
        }

        public JObject updateFollowerInfo(string user_id, string name, string phone, string address, int city_id, int district_id)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject body = JObject.FromObject(new
            {
                user_id,
                name,
                phone,
                address,
                city_id,
                district_id

            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/updatefollowerinfo", param);

            return result;
        }

        public JObject broadcastArticle(string attachment_id, TargetBroadcastGender gender, List<TargetBroadcastAges> ages=null, List<TargetBroadcastLocations> locations = null, List<TargetBroadcastCities> cities = null, List<TargetBroadcastPlatforms> platforms = null, List<TargetBroadcastTelcos> telcos = null)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            List<JObject> elementsJson = new List<JObject>();
            elementsJson.Add(JObject.FromObject(new
            {
                media_type = "article",
                attachment_id
            }));

            JObject target = new JObject();
            if (ages != null)
            {
                string agesStr = "";
                foreach (TargetBroadcastAges targetBroadcastAges in ages)
                {
                    agesStr += targetBroadcastAges.getValue() + ",";
                }
                agesStr = agesStr.Substring(0, agesStr.Length - 1);
                target.Add("ages", agesStr);
            }

            if (gender != null)
            {
                target.Add("gender", gender.getValue());
            }

            if (locations != null)
            {
                string locationsStr = "";
                foreach (TargetBroadcastLocations targetBroadcastLocations in locations)
                {
                    locationsStr += targetBroadcastLocations.getValue() + ",";
                }
                locationsStr = locationsStr.Substring(0, locationsStr.Length - 1);
                target.Add("locations", locationsStr);
            }

            if (cities != null)
            {
                string citiesStr = "";
                foreach (TargetBroadcastCities targetBroadcastCities in cities)
                {
                    citiesStr += targetBroadcastCities.getValue() + ",";
                }
                citiesStr = citiesStr.Substring(0, citiesStr.Length - 1);
                target.Add("cities", citiesStr);
            }

            if (platforms != null)
            {
                string platformsStr = "";
                foreach (TargetBroadcastPlatforms targetBroadcastPlatforms in platforms)
                {
                    platformsStr += targetBroadcastPlatforms.getValue() + ",";
                }
                platformsStr = platformsStr.Substring(0, platformsStr.Length - 1);
                target.Add("platforms", platformsStr);
            }

            if (telcos != null)
            {
                string telcosStr = "";
                foreach (TargetBroadcastTelcos targetBroadcastTelcos in telcos)
                {
                    telcosStr += targetBroadcastTelcos.getValue() + ",";
                }
                telcosStr = telcosStr.Substring(0, telcosStr.Length - 1);
                target.Add("telcos", telcosStr);
            }

            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    target
                },
                message = new
                {
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            template_type = "media",
                            elements = elementsJson
                        }
                    }
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }

        public JObject broadcastLinks(List<Element> elements, TargetBroadcastGender gender, List<TargetBroadcastAges> ages = null, List<TargetBroadcastLocations> locations = null, List<TargetBroadcastCities> cities = null, List<TargetBroadcastPlatforms> platforms = null, List<TargetBroadcastTelcos> telcos = null)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            List<JObject> elementsJson = JsonUtils.parseListElement2Json(elements);

            JObject target = new JObject();
            if (ages != null)
            {
                string agesStr = "";
                foreach (TargetBroadcastAges targetBroadcastAges in ages)
                {
                    agesStr += targetBroadcastAges.getValue() + ",";
                }
                agesStr = agesStr.Substring(0, agesStr.Length - 1);
                target.Add("ages", agesStr);
            }

            if (gender != null)
            {
                target.Add("gender", gender.getValue());
            }

            if (locations != null)
            {
                string locationsStr = "";
                foreach (TargetBroadcastLocations targetBroadcastLocations in locations)
                {
                    locationsStr += targetBroadcastLocations.getValue() + ",";
                }
                locationsStr = locationsStr.Substring(0, locationsStr.Length - 1);
                target.Add("locations", locationsStr);
            }

            if (cities != null)
            {
                string citiesStr = "";
                foreach (TargetBroadcastCities targetBroadcastCities in cities)
                {
                    citiesStr += targetBroadcastCities.getValue() + ",";
                }
                citiesStr = citiesStr.Substring(0, citiesStr.Length - 1);
                target.Add("cities", citiesStr);
            }

            if (platforms != null)
            {
                string platformsStr = "";
                foreach (TargetBroadcastPlatforms targetBroadcastPlatforms in platforms)
                {
                    platformsStr += targetBroadcastPlatforms.getValue() + ",";
                }
                platformsStr = platformsStr.Substring(0, platformsStr.Length - 1);
                target.Add("platforms", platformsStr);
            }

            if (telcos != null)
            {
                string telcosStr = "";
                foreach (TargetBroadcastTelcos targetBroadcastTelcos in telcos)
                {
                    telcosStr += targetBroadcastTelcos.getValue() + ",";
                }
                telcosStr = telcosStr.Substring(0, telcosStr.Length - 1);
                target.Add("telcos", telcosStr);
            }

            JObject body = JObject.FromObject(new
            {
                recipient = new
                {
                    target
                },
                message = new
                {
                    attachment = new
                    {
                        type = "template",
                        payload = new
                        {
                            template_type = "list",
                            elements= elementsJson
                        }
                    }
                }
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/oa/message", param);

            return result;
        }
        //==========================Message=====================================

        //==========================Shop=====================================
        public JObject createProduct(Product product)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            param.Add("body", JsonUtils.parseProduct2Json(product).ToString().Replace("\\","").Replace("\"[", "[").Replace("]\"", "]"));

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/store/product/create", param);

            return result;
        }

        public JObject updateProduct(Product product)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            param.Add("body", JsonUtils.parseProduct2Json(product).ToString().Replace("\\", "").Replace("\"[", "[").Replace("]\"", "]"));

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/store/product/update", param);

            return result;
        }

        public JObject removeProduct(string id)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            JObject body = JObject.FromObject(new
            {
                id
            });
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/store/product/remove", param);

            return result;
        }

        public JObject getdetailProduct(string id)
        {
            JObject result = new JObject();

            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("id", id);

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/store/product/getproduct", param);

            return result;
        }

        public JObject searchProductByProductCode(int offset, int limit, string code)
        {
            JObject result = new JObject();

            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("offset", offset.ToString());
            param.Add("limit", limit.ToString());
            param.Add("code", code);

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/store/product/search", param);

            return result;
        }

        public JObject getSliceProduct(int offset, int limit)
        {
            JObject result = new JObject();

            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("offset", offset.ToString());
            param.Add("limit", limit.ToString());

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/store/product/getproductofoa", param);

            return result;
        }

        public JObject getSliceOrder(int offset, int limit, int status)
        {
            JObject result = new JObject();

            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("offset", offset.ToString());
            param.Add("limit", limit.ToString());
            param.Add("status", status.ToString());

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/store/order/getorderofoa", param);

            return result;
        }

        public JObject getdetailOrder(string id)
        {
            JObject result = new JObject();

            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("id", id);

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/store/order/getorder", param);

            return result;
        }

        public JObject updateStatusOrder(string id, int status, string cancel_reason = null, string edit_reason = null)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            JObject body;

            if (edit_reason != null)
            {
                body = JObject.FromObject(new
                {
                    id,
                    status,
                    edit_reason
                });
            } else if(cancel_reason != null)
            {
                body = JObject.FromObject(new
                {
                    id,
                    status,
                    cancel_reason
                });
            } else
            {
                body = JObject.FromObject(new
                {
                    id,
                    status
                });
            }
            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/store/order/update", param);

            return result;
        }

        public JObject createOrder(Order order)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            param.Add("body", JsonUtils.parseOrder2Json(order).ToString().Replace("\\", "").Replace("\"[", "[").Replace("]\"", "]"));

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/store/order/create", param);

            return result;
        }

        public JObject getSliceCategory(int offset, int limit)
        {
            JObject result = new JObject();

            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("offset", offset);
            param.Add("limit", limit);

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/store/category/getcategoryofoa", param);

            return result;
        }

        public JObject createCategory(string name, string photo, string description, ShopStatus status)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject body = JObject.FromObject(new
            {
                name,
                photo,
                description,
                status = status.getValue()
            });

            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/store/category/create", param);

            return result;
        }

        public JObject updateCategory(string id, string name, string photo, string description, ShopStatus status)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject body = JObject.FromObject(new
            {
                id,
                name,
                photo,
                description,
                status = status.getValue()
            });

            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/store/category/update", param);

            return result;
        }

        public JObject uploadImageForShopAPI(ZaloFile zaloFile, string uploadType)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("file", zaloFile);
            param.Add("upload_type", uploadType);

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/store/upload/photo", param);

            return result;
        }

        public JObject createAttributeType(string name)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject body = JObject.FromObject(new
            {
                name
            });

            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/store/product/createattributetype", param);

            return result;
        }

        public JObject getAttributeType()
        {
            JObject result = new JObject();

            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/store/product/getsliceattributetype", param);

            return result;
        }

        public JObject createAttribute(string name, string attibuteType)
        {
            JObject result = new JObject();
            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();

            JObject body = JObject.FromObject(new
            {
                name,
                type = attibuteType
            });

            param.Add("body", body.ToString());

            result = excuteRequest("POST", "https://openapi.zalo.me/v2.0/store/product/createattribute", param);

            return result;
        }

        public JObject getSliceAttribute(int offset, int limit)
        {
            JObject result = new JObject();

            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("offset", offset);
            param.Add("limit", limit);

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/store/product/getsliceattribute", param);

            return result;
        }

        public JObject getAttribute(string id)
        {
            JObject result = new JObject();

            Dictionary<string, dynamic> param = new Dictionary<string, dynamic>();
            param.Add("id", id);

            result = excuteRequest("GET", "https://openapi.zalo.me/v2.0/store/product/getattribute", param);

            return result;
        }

        //==========================Shop=====================================
    }
}
