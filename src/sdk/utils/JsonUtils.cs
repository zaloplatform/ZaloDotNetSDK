using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using ZaloDotNetSDK.entities;
using ZaloDotNetSDK.entities.oa;
using ZaloDotNetSDK.entities.shop;

namespace ZaloDotNetSDK.utils
{
    public class JsonUtils
    { 

        public static JObject parseArticle2Json(Article article)
        {
            JObject result = new JObject();

            result["type"] = article.Type;
            result["title"] = article.Title;
            result["author"] = article.Author;

            JObject cover = new JObject();
            cover["cover_type"] = article.Cover.CoverType;
            if (article.Cover.CoverType == "photo")
            {
                CoverPhoto photoCover = (CoverPhoto) article.Cover;
                cover["photo_url"] = photoCover.PhotoUrl;
            }
            else
            {
                CoverVideo videoCover = (CoverVideo)article.Cover;
                cover["cover_view"] = videoCover.CoverView.getValue();
                cover["video_id"] = videoCover.VideoId;
            }
            cover["status"] = article.Cover.Status.getValue();
            result["cover"] = cover;

            result["description"] = article.Description;

            JArray body = new JArray();
            foreach (Paragraph paragraph in article.Body)
            {
                JObject paragraphJson = new JObject();
                paragraphJson["type"] = paragraph.Type;
                switch (paragraph.Type)
                {
                    case "text":
                        ParagraphText textParagraph = (ParagraphText)paragraph;
                        paragraphJson["content"] = textParagraph.Content;
                        break;
                    case "image":
                        ParagraphImage imageParagraph = (ParagraphImage)paragraph;
                        paragraphJson["url"] = imageParagraph.Url;
                        paragraphJson["caption"] = imageParagraph.Caption;
                        break;
                    case "video":
                        ParagraphVideo videoParagraph = (ParagraphVideo)paragraph;
                        if (videoParagraph.Url != null)
                        {
                            paragraphJson["url"] = videoParagraph.Url;
                        }
                        else
                        {
                            paragraphJson["video_id"] = videoParagraph.VideoId;
                        }
                        paragraphJson["thumb"] = videoParagraph.Thumb;
                        break;
                    case "product":
                        ParagraphProduct productParagraph = (ParagraphProduct)paragraph;
                        paragraphJson["id"] = productParagraph.Id;
                        break;
                }
                body.Add(paragraphJson);
            }
            result["body"] = body;

            JArray related_medias = new JArray();
            
            foreach (RelatedMedia relatedMedia in article.RelatedMedias)
            {
                JObject relatedMediaJson = new JObject();
                relatedMediaJson["id"] = relatedMedia.Id;
                related_medias.Add(relatedMediaJson);
            }

            result["related_medias"] = related_medias;

            if (article.TrackingLink != null)
            {
                if (article.TrackingLink.Length != 0)
                {
                    result["tracking_link"] = article.TrackingLink;
                }
            }
            result["status"] = article.Status.getValue();
            result["comment"] = article.Comment.getValue();

            return result;
        }

        public static JObject parseVideoArticle2Json(VideoArticle videoArticle)
        {
            JObject result = new JObject();

            result["type"] = videoArticle.Type;
            result["title"] = videoArticle.Title;
            result["description"] = videoArticle.Description;
            result["video_id"] = videoArticle.Video_id;
            result["avatar"] = videoArticle.Avatar;
            result["comment"] = videoArticle.Comment.getValue();

            return result;
        }

        public static List<JObject> parseListElement2Json(List<Element> elements)
        {
            List<JObject> result = new List<JObject>();

            if (elements == null || elements.Count == 0)
            {
                return result;
            }

            foreach (Element element in elements)
            {
                JObject elementJson = new JObject();
                switch (element.Type)
                {
                    case "oa.open.url":
                        {
                            OpenUrlElement openUrlElement = (OpenUrlElement)element;
                            elementJson = JObject.FromObject(new
                            {
                                title = element.Title,
                                subtitle = element.Subtitle,
                                image_url = element.Image_url,
                                default_action = new
                                {
                                    type = element.Type,
                                    url = openUrlElement.Url
                                },
                                buttons = parseListButton2Json(element.Buttons)
                            });
                            break;
                        }
                    case "oa.query.show":
                        {
                            QueryShowElement queryShowElement = (QueryShowElement)element;
                            elementJson = JObject.FromObject(new
                            {
                                title = element.Title,
                                subtitle = element.Subtitle,
                                image_url = element.Image_url,
                                default_action = new
                                {
                                    type = element.Type,
                                    payload = queryShowElement.Payload
                                },
                                buttons = parseListButton2Json(element.Buttons)
                            });
                            break;
                        }
                    case "oa.query.hide":
                        {
                            QueryHideElement queryHideElement = (QueryHideElement)element;
                            elementJson = JObject.FromObject(new
                            {
                                title = element.Title,
                                subtitle = element.Subtitle,
                                image_url = element.Image_url,
                                default_action = new
                                {
                                    type = element.Type,
                                    payload = queryHideElement.Payload
                                },
                                buttons = parseListButton2Json(element.Buttons)
                            });
                            break;
                        }
                    case "oa.open.sms":
                        {
                            OpenSMSElement openSMSElement = (OpenSMSElement)element;
                            elementJson = JObject.FromObject(new
                            {
                                title = element.Title,
                                subtitle = element.Subtitle,
                                image_url = element.Image_url,
                                default_action = new
                                {
                                    type = element.Type,
                                    payload = new
                                    {
                                        content = openSMSElement.Content,
                                        phone_code = openSMSElement.Phone_code
                                    }
                                },
                                buttons = parseListButton2Json(element.Buttons)
                            });
                            break;
                        }
                    case "oa.open.phone":
                        {
                            OpenPhoneElement openPhoneElement = (OpenPhoneElement)element;
                            elementJson = JObject.FromObject(new
                            {
                                title = element.Title,
                                subtitle = element.Subtitle,
                                image_url = element.Image_url,
                                default_action = new
                                {
                                    type = element.Type,
                                    payload = new
                                    {
                                        phone_code = openPhoneElement.Phone_code
                                    }
                                },
                                buttons = parseListButton2Json(element.Buttons)
                            });
                            break;
                        }
                }
                result.Add(elementJson);
            }

            return result;
        }

        public static List<JObject> parseListButton2Json(List<Button> buttons)


        {
            List<JObject> result = new List<JObject>();
            if (buttons == null || buttons.Count == 0)
            {
                return result;
            }
            
            foreach (Button button in buttons)
            {
                JObject elementJson = new JObject();
                switch (button.Type)
                {
                    case "oa.open.url":
                        {
                            OpenUrlButton openUrlbutton = (OpenUrlButton)button;
                            elementJson = JObject.FromObject(new
                            {
                                title = button.Title,
                                type = button.Type,
                                payload = new
                                {
                                    url = openUrlbutton.Url
                                }
                            });
                            break;
                        }
                    case "oa.query.show":
                        {
                            QueryShowButton queryShowButton = (QueryShowButton)button;
                            elementJson = JObject.FromObject(new
                            {
                                title = button.Title,
                                type = button.Type,
                                payload = queryShowButton.Payload
                            });
                            break;
                        }
                    case "oa.query.hide":
                        {
                            QueryHideButton queryHideButton = (QueryHideButton)button;
                            elementJson = JObject.FromObject(new
                            {
                                title = button.Title,
                                type = button.Type,
                                payload = queryHideButton.Payload
                            });
                            break;
                        }
                    case "oa.open.sms":
                        {
                            OpenSMSButton openSMSButton = (OpenSMSButton)button;
                            elementJson = JObject.FromObject(new
                            {
                                title = button.Title,
                                type = button.Type,
                                payload = new
                                {
                                    content = openSMSButton.Content,
                                    phone_code = openSMSButton.Phone_code
                                }
                            });
                            break;
                        }
                    case "oa.open.phone":
                        {
                            OpenPhoneButton openPhoneButton = (OpenPhoneButton)button;
                            elementJson = JObject.FromObject(new
                            {
                                title = button.Title,
                                type = button.Type,
                                payload = new
                                {
                                    phone_code = openPhoneButton.Phone_code
                                }
                            });
                            break;
                        }
                }
                result.Add(elementJson);
            }

            return result;
        }

        public static JObject parseProduct2Json(Product product)
        {
            JObject result = new JObject();
            try
            {
                if (product.Id != null)
                {
                    result["id"] = product.Id;
                }
            }
            catch (Exception ex)
            {
            }
            

            result["industry"] = product.Industry;
            result["name"] = product.Name;
            result["description"] = product.Description;
            result["code"] = product.Code;
            result["price"] = product.Price;

            try
            {
                result["quantity"] = product.Quantity;
            } catch(Exception ex)
            {
            }

            try
            {
                if (product.Categories != null)
                {
                    result["categories"] = JsonConvert.SerializeObject(product.Categories);
                }
            } catch(Exception ex)
            {
            }

            result["photos"] = JsonConvert.SerializeObject(product.Photos);

            result["status"] = product.Status.getValue();
            try
            {
                if (product.PackageSize != null)
                {
                    if (product.PackageSize.Height > 0.0 || product.PackageSize.Width > 0.0 || product.PackageSize.Length > 0.0)
                    {
                        result["package_size"] = JObject.FromObject(new
                        {
                            weight = product.PackageSize.Weight,
                            length = product.PackageSize.Length,
                            width = product.PackageSize.Width,
                            height = product.PackageSize.Height
                        });
                    }
                    else
                    {
                        result["package_size"] = JObject.FromObject(new
                        {
                            weight = product.PackageSize.Weight
                        });
                    }
                }
            }
            catch (Exception ex)
            {
            }

            try
            {
                if (product.Variations != null)
                {
                    List<JObject> variationsJson = new List<JObject>();
                    foreach(Variation variation in product.Variations)
                    {
                        JObject package_size = new JObject();
                        if (variation.PackageSize.Height > 0.0 || variation.PackageSize.Width > 0.0 || variation.PackageSize.Length > 0.0)
                        {
                            package_size = JObject.FromObject(new
                            {
                                weight = variation.PackageSize.Weight,
                                length = variation.PackageSize.Length,
                                width = variation.PackageSize.Width,
                                height = variation.PackageSize.Height
                            });
                        }
                        else
                        {
                            package_size = JObject.FromObject(new
                            {
                                weight = variation.PackageSize.Weight
                            });
                        }
                            JObject variationJson = JObject.FromObject(new
                            {
                            
                            price = variation.Price,
                            name = variation.Name,
                            code = variation.Code,
                            status = variation.Status.getValue(),
                            quantity = variation.Quantity,
                            attributes = JsonConvert.SerializeObject(variation.Attributes),
                            package_size,
                            variation_default = variation.VariationDefault
                        });
                        variationsJson.Add(variationJson);
                    }
                    result["variations"] = JsonConvert.SerializeObject(variationsJson);
                }
            }
            catch (Exception ex)
            {
            }

            return result;
        }

        public static JObject parseOrder2Json(Order order)
        {
            JObject result = new JObject();

            result["customer"] = JObject.FromObject(new
            {
                name = order.Customer.Name,
                phone = order.Customer.Phone,
                user_id = order.Customer.User_id,
                address = order.Customer.Address,
                district = order.Customer.Dictrict,
                city = order.Customer.City
            });

            List<JObject> variationsJson = new List<JObject>();
            foreach(OrderItem orderItem in order.Order_items)
            {
                JObject variationJson = new JObject();
                variationJson["product_id"] = orderItem.Product_id;
                variationJson["quantity"] = orderItem.Quantity;
                if (orderItem.Variation_id != null)
                {
                    variationJson["variation"] = JObject.FromObject(new
                    {
                        id = orderItem.Variation_id
                    });
                }
                if (orderItem.Partner_item_data != null)
                {
                    variationJson["partner_item_data"] = orderItem.Partner_item_data;
                }
                variationsJson.Add(variationJson);
            }
            result["order_items"] = JsonConvert.SerializeObject(variationsJson);

            result["extra_note"] = order.Extra_note;

            return result;
        }

        public static List<JObject> parseListElementV3ToJson(List<ElementV3> elements)
        {
            List<JObject> result = new List<JObject>();

            if (elements == null || elements.Count == 0)
            {
                return result;
            }

            foreach (ElementV3 element in elements)
            {
                JObject elementJson = new JObject();
                switch (element.Type)
                {
                    case "banner":
                        {
                            BannerElementV3 bannerElement = (BannerElementV3)element;
                            elementJson = JObject.FromObject(new
                            {
                                type = bannerElement.Type,
                                attachment_id = bannerElement.Attachment_id,
                                image_url = bannerElement.Image_url
                            });
                            break;
                        }
                    case "header":
                        {
                            HeaderElementV3 headerElementV3 = (HeaderElementV3)element;
                            elementJson = JObject.FromObject(new
                            {
                                type = headerElementV3.Type,
                                content = headerElementV3.Content,
                                align = headerElementV3.Align.getValue()
                            });
                            break;
                        }
                    case "text":
                        {
                            TextElementV3 textElementV3 = (TextElementV3)element;
                            elementJson = JObject.FromObject(new
                            {
                                type = textElementV3.Type,
                                content = textElementV3.Content,
                                align = textElementV3.Align.getValue()
                            });
                            break;
                        }
                    case "table":
                        {
                            TableElementV3 tableElementV3 = (TableElementV3)element;

                            List<JObject> tableContent = new List<JObject>();
                            foreach (ElementV3TableItem tableItem in tableElementV3.Content)
                            {
                                JObject tableItemJson = new JObject();
                                if (tableItem.Style.Equals(ElementV3TableItemStyle.NONE))
                                {
                                    tableItemJson = JObject.FromObject(new
                                    {
                                        key = tableItem.Key,
                                        value = tableItem.Value,
                                    });
                                } else
                                {
                                    tableItemJson = JObject.FromObject(new
                                    {
                                        key = tableItem.Key,
                                        value = tableItem.Value,
                                        style = tableItem.Style
                                    });
                                }

                                tableContent.Add(tableItemJson);
                            }

                            elementJson = JObject.FromObject(new
                            {
                                type = tableElementV3.Type,
                                content = tableContent
                            });
                            break;
                        }
                }
                result.Add(elementJson);
            }

            return result;
        }

        public static List<JObject> parseListButtonV3ToJson(List<ButtonV3> buttons)
        {
            List<JObject> result = new List<JObject>();
            if (buttons == null || buttons.Count == 0)
            {
                return result;
            }

            foreach (ButtonV3 button in buttons)
            {
                JObject buttonJson = new JObject();
                switch (button.Type)
                {
                    case "oa.open.url":
                        {
                            OpenUrlButtonV3 openUrlbutton = (OpenUrlButtonV3)button;
                            buttonJson = JObject.FromObject(new
                            {
                                title = button.Title,
                                image_icon = button.Image_icon,
                                type = button.Type,
                                payload = new
                                {
                                    url = openUrlbutton.Url
                                }
                            });
                            break;
                        }
                    case "oa.query.show":
                        {
                            QueryShowButtonV3 queryShowButton = (QueryShowButtonV3)button;
                            buttonJson = JObject.FromObject(new
                            {
                                title = button.Title,
                                image_icon = button.Image_icon,
                                type = button.Type,
                                payload = queryShowButton.Payload
                            });
                            break;
                        }
                    case "oa.query.hide":
                        {
                            QueryHideButtonV3 queryHideButton = (QueryHideButtonV3)button;
                            buttonJson = JObject.FromObject(new
                            {
                                title = button.Title,
                                image_icon = button.Image_icon,
                                type = button.Type,
                                payload = queryHideButton.Payload
                            });
                            break;
                        }
                    case "oa.open.sms":
                        {
                            OpenSMSButtonV3 openSMSButton = (OpenSMSButtonV3)button;
                            buttonJson = JObject.FromObject(new
                            {
                                title = button.Title,
                                image_icon = button.Image_icon,
                                type = button.Type,
                                payload = new
                                {
                                    content = openSMSButton.Content,
                                    phone_code = openSMSButton.Phone_code
                                }
                            });
                            break;
                        }
                    case "oa.open.phone":
                        {
                            OpenPhoneButtonV3 openPhoneButton = (OpenPhoneButtonV3)button;
                            buttonJson = JObject.FromObject(new
                            {
                                title = button.Title,
                                image_icon = button.Image_icon,
                                type = button.Type,
                                payload = new
                                {
                                    phone_code = openPhoneButton.Phone_code
                                }
                            });
                            break;
                        }
                }
                result.Add(buttonJson);
            }

            return result;
        }
    }
}
