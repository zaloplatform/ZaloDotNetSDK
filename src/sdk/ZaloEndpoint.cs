using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class ZaloEndpoint
    {
        //  OA API ENDPOINT
        public static string GET_TAGS_ENDPOINT = getEndpoint("tag/gettagsofoa");
        public static string TAG_FOLLOWER_ENDPOINT = getEndpoint("tag/tagfollower");
        public static string REMOVE_TAG_ENDPOINT = getEndpoint("tag/rmtag");
        public static string REMOVE_FOLLOWER_FROM_TAG_ENDPOINT = getEndpoint("tag/rmfollowerfromtag");
        public static string SEND_TEXT_MESSAGE_ENDPOINT = getEndpoint("sendmessage/text");
        public static string SEND_IMAGE_MESSAGE_ENDPOINT = getEndpoint("sendmessage/image");
        public static string SEND_LINKS_MESSAGE_ENDPOINT = getEndpoint("sendmessage/links");
        public static string SEND_ACTION_MESSAGE_ENDPOINT = getEndpoint("sendmessage/actionlist");
        public static string SEND_STICKER_MESSAGE_ENDPOINT = getEndpoint("sendmessage/sticker");
        public static string SEND_GIF_MESSAGE_ENDPOINT = getEndpoint("sendmessage/gif");
        public static string UPLOAD_IMAGE_ENDPOINT = getEndpoint("upload/image");
        public static string UPLOAD_GIF_ENDPOINT = getEndpoint("upload/gif");
        public static string GET_PROFILE_EDNPOINT = getEndpoint("getprofile");
        public static string GET_MESSAGE_STATUS_ENDPOINT = getEndpoint("getmessagestatus");
        public static string REPLY_TEXT_MESSAGE_ENDPOINT = getEndpoint("sendmessage/reply/text");
        public static string REPLY_IMAGE_MESSAGE_ENDPOINT = getEndpoint("sendmessage/reply/image");
        public static string REPLY_LINKS_MESSAGE_ENDPOINT = getEndpoint("sendmessage/reply/links");
        public static string CREATE_QRCODE_ENDPOINT = getEndpoint("qrcode");

        // STORE API ENDPOINT
        public static string UPDATE_VARIATION_ENDPOINT = getEndpoint("store/product/updatevariation");
        public static string ADD_VARIATION_ENDPOINT = getEndpoint("store/product/addvariation");
        public static string GET_ATTR_ENDPOINT = getEndpoint("store/product/mgetattr");
        public static string GET_ATTR_OF_OA_ENDPOINT = getEndpoint("store/product/getattrofoa");
        public static string UPDATE_ATTR_ENDPOINT = getEndpoint("store/product/updateattr");
        public static string CREATE_ATTR_ENDPOINT = getEndpoint("store/product/createattr");
        public static string GET_ATTR_TYPE_OF_OA_ENDPOINT = getEndpoint("store/product/getattrtypeofoa");
        public static string CREATE_PRODUCT_ENDPOINT = getEndpoint("store/product/create");
        public static string UPDATE_PRODUCT_ENDPOINT = getEndpoint("store/product/update");
        public static string REMOVE_PRODUCT_ENDPOINT = getEndpoint("store/product/remove");
        public static string GET_PRODUCT_ENDPOINT = getEndpoint("store/product/getproduct");
        public static string GET_PRODUCT_OF_OA_ENDPOINT = getEndpoint("store/product/getproductofoa");
        public static string UPLOAD_PRODUCT_PHOTO_ENDPOINT = getEndpoint("store/upload/productphoto");
        public static string CREATE_CATEGORY_ENDPOINT = getEndpoint("store/category/create");
        public static string UPDATE_CATEGORY_ENDPOINT = getEndpoint("store/category/update");
        public static string GET_CATEGORY_OF_OA_ENDPOINT = getEndpoint("store/category/getcategoryofoa");
        public static string UPLOAD_CATEGORY_PHOTO = getEndpoint("store/upload/categoryphoto");
        public static string UPDATE_ORDER_ENDPOINT = getEndpoint("store/order/update");
        public static string GET_ORDER_OF_OA_ENDPOINT = getEndpoint("store/order/getorderofoa");
        public static string GET_ORDER_ENDPOINT = getEndpoint("store/order/getorder");
        public static string UPDATE_SHOP_ENDPOINT = getEndpoint("store/updateshop");

        // ARTICLE API ENDPOINT
        public static string GET_SLICE_VIDEO_MEDIA_ENDPOINT = getEndpoint("media/video/getslice");
        public static string UPDATE_VIDEO_MEDIA_ENDPOINT = getEndpoint("media/video/update");
        public static string CREATE_VIDEO_MEDIA_ENDPOINT = getEndpoint("media/video/create");
        public static string CREATE_MEDIA_ENDPOINT = getEndpoint("media/create");
        public static string VERIFY_MEDIA_ENDPOINT = getEndpoint("media/verify");
        public static string UPDATE_MEDIA_ENDPOINT = getEndpoint("media/update");
        public static string REMOVE_MEDIA_ENDPOINT = getEndpoint("media/remove");
        public static string GET_SLICE_MEDIA_ENDPOINT = getEndpoint("media/getslice");
        public static string BROADCAST_MEDIA_ENDPOINT = getEndpoint("broadcast/medias");
        public static string GET_UPLOAD_LINK_ENDPOINT = getEndpoint("media/upload/video");
        public static string GET_MEDIA_VIDEO_ID_ENDPOINT = getEndpoint("media/getvideoid");
        public static string GET_MEDIA_VIDEO_STATUS_ENDPOINT = getEndpoint("media/getvideostatus");


        private static string getEndpoint(string url)
        {
            return String.Format("{0}/{1}/{2}", APIConfig.DEFAULT_OA_API_BASE, APIConfig.DEFAULT_OA_API_VERSION, url);
        }
    }
}
