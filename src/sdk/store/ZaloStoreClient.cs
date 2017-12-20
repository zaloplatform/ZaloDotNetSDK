using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class ZaloStoreClient : ZaloBaseClient
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

        public ZaloStoreClient(ZaloOaInfo oaInfo)
        {
            OaInfo = oaInfo;
        }

        public JObject updateVariation(Variation variation)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    variation = variation
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.UPDATE_VARIATION_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject addVariation(string productid, List<Variation> variations)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    productid = productid,
                    variations = variations
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.ADD_VARIATION_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject getAttr(List<string> attributeids)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    attributeids = attributeids
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpGetRequest(ZaloEndpoint.GET_ATTR_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject getAttrOfOa(int offset, int count)
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
            string response = sendHttpGetRequest(ZaloEndpoint.GET_ATTR_OF_OA_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject updateAttr(string name, string attributeid)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    name = name,
                    attributeid = attributeid
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.UPDATE_ATTR_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject createAttr(string name, string type)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    name = name,
                    type = type
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.CREATE_ATTR_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject getAttrTypeOfOa(int offset, int count)
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
            string response = sendHttpGetRequest(ZaloEndpoint.GET_ATTR_TYPE_OF_OA_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject createProduct(Product product)
        {
            JObject data = JObject.FromObject(new
            {
                data = product
            });
            Console.WriteLine(data);
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.CREATE_PRODUCT_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject uploadProductPhoto(string pathToFile)
        {
            Dictionary<string, string> param = createParam(OaInfo, new JObject());
            string response = sendHttpUploadRequest(ZaloEndpoint.UPLOAD_PRODUCT_PHOTO_ENDPOINT, pathToFile, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject updateProduct(string productid, Product product)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    productid = productid,
                    product = product
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.UPDATE_PRODUCT_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject removeProduct(string productid)
        {
            JObject data = JObject.FromObject(new
            {
                productid = productid
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.REMOVE_PRODUCT_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject getProduct(string productid)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    productid = productid
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpGetRequest(ZaloEndpoint.GET_PRODUCT_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject getProductOfOa(int offset, int count)
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
            string response = sendHttpGetRequest(ZaloEndpoint.GET_PRODUCT_OF_OA_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject createCategory(Category category)
        {
            JObject data = JObject.FromObject(new
            {
                data = category
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.CREATE_CATEGORY_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject updateCategory(string categoryid, Category category)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    categoryid = categoryid,
                    category = category
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.UPDATE_CATEGORY_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject getCategoryOfOa(int offset, int count)
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
            string response = sendHttpGetRequest(ZaloEndpoint.GET_CATEGORY_OF_OA_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject uploadCategoryPhoto(string pathToFile)
        {
            Dictionary<string, string> param = createParam(OaInfo, new JObject());
            string response = sendHttpUploadRequest(ZaloEndpoint.UPLOAD_CATEGORY_PHOTO, pathToFile, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject updateOrder(Order order)
        {
            JObject data = JObject.FromObject(new
            {
                data = order
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.UPDATE_ORDER_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject getOrderOfOa(int offset, int count, int filter)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    offset = offset,
                    count = count,
                    filter = filter
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpGetRequest(ZaloEndpoint.GET_ORDER_OF_OA_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject getOrder(string orderid)
        {
            JObject data = JObject.FromObject(new
            {
                orderid = orderid
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpGetRequest(ZaloEndpoint.GET_ORDER_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }

        public JObject updateShop(int requireAddress)
        {
            JObject data = JObject.FromObject(new
            {
                data = new
                {
                    orderPolicy = new
                    {
                        requireAddress = requireAddress
                    }
                }
            });
            Dictionary<string, string> param = createParam(OaInfo, data);
            string response = sendHttpPostRequest(ZaloEndpoint.UPDATE_SHOP_ENDPOINT, param, APIConfig.DEFAULT_HEADER);
            return JObject.Parse(response);
        }
    }
}
