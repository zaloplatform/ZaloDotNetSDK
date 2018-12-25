# Zalo SDK for C# (v1)

A SDK for building Chatbot, Shop, Article, Social API, Login, Official Account messsage, Official Account Follower Managed... on Zalo Platform.


Landing page: <a href="https://developers.zalo.me/">https://developers.zalo.me/</a><br>
<strong>Blog:</strong> there are lots of great tutorials and guides published in our <a href="https://developers.zalo.me/docs/">Official Zalo Platform Blog</a> and we are adding new content regularly.<br>
<strong>Community:</strong> If you are having trouble using some feature, the best way to get help is the <a href="https://developers.zalo.me/community/">Zalo Community</a><br>
<strong>Support:</strong> We are also available to answer short questions on Zalo at <a href="https://zalo.me/zalo4developers">Official Account Zalo For Developers</a><br>

## Hướng dẫn cài đặt
```
Install-Package vng.zalo.ZaloCSharpSDK
```

## Hướng dẫn sử dụng
**Khởi tạo Zalo3rdAppClient**
```
Zalo3rdAppInfo appInfo = new Zalo3rdAppInfo(appId, "secretKey", "callbackUrl");
Zalo3rdAppClient appClient = new Zalo3rdAppClient(appInfo);
```

## Social API
**Lấy LoginUrl**
```
string loginUrl = appClient.getLoginUrl();
```

**Lấy AccessToken**
```
string code = 'put_your_code_here'
JObject token = appClient.getAccessToken(code);
```

**Thông tin người dùng**
```
JObject profile = appClient.getProfile(accessToken, "fields");
```

**Lấy danh sách tất cả bạn bè của người dùng đã sử dụng ứng dụng**
```
JObject friends = appClient.getFriends(accessToken, 0, 10, "fields");
```

**Lấy danh sách bạn bè chưa sử dụng ứng dụng và có thể nhắn tin mời sử dụng ứng dụng**
```
JObject invitableFriends = appClient.getInvitableFriends(accessToken, 0, 10, "fields");
```

**Đăng bài viết**
```
JObject postFeed = appClient.postFeed(accessToken, "put_your_message_here", "https://developers.zalo.me/");
```

**Mời sử dụng ứng dụng**
```
JObject sendAppRequest = appClient.sendAppRequest(accessToken, listUser, "put_your_message_here");
```

**Gởi tin nhắn tới bạn bè**
```
JObject sendMessage = appClient.sendMessage(accessToken, userId, "put_your_message_here", "https://developers.zalo.me/");
```

## Official Account Open API

**Khởi tạo ZaloOA**
```
ZaloOaInfo zaloOaInfo = new ZaloOaInfo(oaId, "secretKey");
ZaloOaClient oaClient = new ZaloOaClient(zaloOaInfo);
```

**Lấy danh sách nhãn**
```
JObject listTags = oaClient.getTagsOfOa();
```

**Xóa nhãn**
```
JObject rmTag = oaClient.removeTag("test");
```

**Lấy thông tin người theo dõi**
```
JObject profile = oaClient.getProfile(userId);
```

**Gửi tin nhắn text**
```
JObject sendTextMessage = oaClient.sendTextMessage(userId, "test message");
```

**Lấy trạng thái tin nhắn**
```
JObject messageStatus = oaClient.getMessageStatus(messageId);
```

**Upload hình ảnh**
```
JObject uploadImage = oaClient.uploadImage(pathToFile);
```

**Upload ảnh Gìf**
```
JObject uploadGif = oaClient.uploadGif(pathToGif);
```

**Gửi tin nhắn hình**
```
JObject sendImageMessage = oaClient.sendImageMessage(userId, imageId, "test message");
```

**Gửi tin nhắn ảnh Gif**
```
JObject sendGifMessage = oaClient.sendGifMessage(userId, gifId, 50, 60);
```

**Gửi tin nhắn dạng liên kết**
```
MsgLink firstLink = new MsgLink();
firstLink.link = "put_url_here";
firstLink.linktitle = "put_title_here";
firstLink.linkdes = "put_description_here";
firstLink.linkthumb = "put_thumbnail_url_here";

MsgLink secondLink = new MsgLink();
secondLink.link = "put_url_here";
secondLink.linktitle = "put_title_here";
secondLink.linkdes = "put_description_here";
secondLink.linkthumb = "put_thumbnail_url_here";
JObject sendLinksMessage = oaClient.sendLinksMessage(userId, new List<MsgLink>() { firstLink, secondLink });
```

**Gửi tin nhắn tương tác**
```
MsgAction action = new OpenInAppAction();
action.title = "Send interactive messages";
action.description = "This is a test for API send interactive messages";
action.thumb = "https://developers.zalo.me/web/static/images/bg.jpg";

JObject popup = new JObject();
popup.Add("title", "Open Website Zalo For Developers");
popup.Add("desc", "Click ok to visit Zalo For Developers and read more Document");
popup.Add("ok", "ok");
popup.Add("cancel", "cancel");
action.popup = popup;

JObject sendActionMessage = oaClient.sendActionMessage(userId, new List<MsgAction>() { action });
```

**Gửi tin nhắn Sticker**
```
JObject sendStickerMessage = oaClient.sendStickerMessage(userId, stickerId);
```

**Trả lời tin nhắn dạng text**
```
JObject replyTextMessage = oaClient.replyTextMessage(messageId, "test message");
```

**Trả lời tin nhắn dạng hình**
```
JObject replyImageMessage = oaClient.replyImageMessage(messageId, imageId, "test message");
```

**Trả lời tin nhắn dạng liên kết**
```
MsgLink firstLink = new MsgLink();
firstLink.link = "put_url_here";
firstLink.linktitle = "put_title_here";
firstLink.linkdes = "put_description_here";
firstLink.linkthumb = "put_thumbnail_url_here";

MsgLink secondLink = new MsgLink();
secondLink.link = "put_url_here";
secondLink.linktitle = "put_title_here";
secondLink.linkdes = "put_description_here";
secondLink.linkthumb = "put_thumbnail_url_here";
JObject replyLinksMessage = oaClient.replyLinksMessage(messageId, new List<MsgLink>() { firstLink, secondLink });
```

**Tạo QR Code**
```
JObject createQRcode = oaClient.createQRcode(qrdata, 10);
```

## Store API
**Thêm Variation vào sản phẩm**
```
Variation firstVariation = new Variation();
firstVariation.name = "test";
firstVariation.price = 1;
firstVariation.@default = 1;
firstVariation.attributes = new List<string>() { attrId };
firstVariation.variationid = "1";
JObject addVariation = storeClient.addVariation(productId, new List<Variation>() { firstVariation });
```

**Chỉnh sửa variation**
```
Product product = new Product();
product.name = "test product";
product.desc = "a new product";
product.code = "1234";
product.price = 3;
product.photos = new List<JObject>() { JObject.FromObject(new { id = photoId }) };
product.display = "show";
product.payment = 2;
JObject updateVariation = storeClient.updateVariation(firstVariation);
```

**Lấy thông tin thuộc tính sản phẩm**
```
JObject getAttr = storeClient.getAttr(new List<string>() { attrId });
```

**Lấy danh sách thuộc tính sản phẩm**
```
JObject getAttrOfOa = storeClient.getAttrOfOa(0, 10);
```

**Chỉnh sửa thuộc tính sản phẩm**
```
JObject updateAttr = storeClient.updateAttr("test", attrId);
```

**Tạo thuộc tính sản phẩm**
```
JObject createAttr = storeClient.createAttr("test", attrTypeId);
```

**Lấy danh sách kiểu thuộc tính**
```
JObject getAttrTypeOfOa = storeClient.getAttrTypeOfOa(0, 10);
```

**Tạo sản phẩm**
```
Product product = new Product();
product.name = "test product";
product.desc = "a new product";
product.code = "1234";
product.price = 3;
product.cateids = new List<JObject>() { JObject.FromObject(new { cateid = categoryId }) };
product.photos = new List<JObject>() { JObject.FromObject(new { id = photoId }) };
product.display = "show";
product.payment = 2;

JObject createProduct = storeClient.createProduct(product);
```

**Chỉnh sửa sản phẩm**
```
Product product = new Product();
product.name = "test product";
product.desc = "a new product";
product.code = "1234";
product.price = 3;
product.photos = new List<JObject>() { JObject.FromObject(new { id = photoId }) };
product.display = "show";
product.payment = 2;
JObject updateProduct = storeClient.updateProduct(productId, product);
```

**Xóa sản phẩm**
```
JObject removeProduct = storeClient.removeProduct(productId);
```

**Lấy thông tin sản phẩm**
```
JObject getProduct = storeClient.getProduct(productId);
```

**Danh sách sản phẩm**
```
JObject getProductOfOa = storeClient.getProductOfOa(0, 10);
```

**Upload hình sản phẩm**
```
JObject uploadProductPhoto = storeClient.uploadProductPhoto(pathToPhoto);
```

**Tạo danh mục**
```
Category category = new Category();
category.name = "test category";
category.desc = "a new category";
category.photo = photoId;
category.status = 0;

JObject createCategory = storeClient.createCategory(category);
```

**Chỉnh sửa danh mục**
```
JObject updateCategory = storeClient.updateCategory(categoryId, category);
```

**Danh sách danh mục**
```
JObject getCategoryOfOa = storeClient.getCategoryOfOa(0, 10);
```

**Upload hình danh mục**
```
JObject uploadCategoryPhoto = storeClient.uploadCategoryPhoto(pathToPhoto);
```

**Chỉnh sửa đơn hàng**
```
Order order = new Order();
order.orderid = orderId;
order.status = 1;
order.reason = "test reason";
order.cancelReason = "cancel";

JObject updateOrder = storeClient.updateOrder(order);
```

**Danh sách đơn hàng**
```
JObject getOrderOfOa = storeClient.getOrderOfOa(0, 10, 0);
```

**Lấy thông tin đơn hàng**
```
JObject getOrder = storeClient.getOrder(orderId);
```

**Thiết lập cửa hàng**
```
JObject updateShop = storeClient.updateShop(1);
```

## Article API
**Tạo bài viết**
```
Cover cover = new Cover();
cover.coverType = 1; // 0 (photo) | 1 (video);
cover.coverView = 1; // 1 (horizontal), 2 (vertical), 3 (square)
cover.videoId = "b0a710f62cb3c5ed9ca2";
cover.status = "show";

ActionLink actionLink = new ActionLink();
actionLink.type = 2; // 0 (link to web), 1 (link to image), 2 (link to video), 3 (link to audio)
actionLink.label = "put_label_here";
actionLink.url = "https://www.youtube.com/watch?v=jp3xBWgii8A&list=RDjp3xBWgii8A";

MediaBody paragraphText = new MediaBody();
paragraphText.type = 0;
paragraphText.content = "put_content_here";

MediaBody paragraphImage = new MediaBody();
paragraphImage.type = 1;
paragraphImage.url = "https://upload.wikimedia.org/wikipedia/commons/7/71/2010-kodiak-bear-1.jpg";
paragraphImage.caption = "put_caption_here";
paragraphImage.width = 500;
paragraphImage.height = 300;

MediaBody paragraphVideo = new MediaBody();
paragraphVideo.type = 3;
paragraphVideo.url = "https://www.youtube.com/watch?v=jp3xBWgii8A&list=RDjp3xBWgii8A";
paragraphVideo.category = "youtube";
paragraphVideo.caption = "put_caption_here";

Media media = new Media();
media.title = "put_title_here";
media.author = "put_author_here";
media.cover = cover;
media.desc = "put_description_here";
media.actionLink = actionLink;
media.body = new List<MediaBody>() { paragraphText, paragraphImage, paragraphVideo };
media.status = "show";

JObject createMedia = articleClient.createMedia(media);
```

**Lấy Id của bài viết**
```
JObject verifyMedia = articleClient.verifyMedia(token);
```

**Chỉnh sửa bài viết**
```
Cover cover = new Cover();
cover.coverType = 1; // 0 (photo) | 1 (video);
cover.coverView = 1; // 1 (horizontal), 2 (vertical), 3 (square)
cover.videoId = "b0a710f62cb3c5ed9ca2";
cover.status = "show";

ActionLink actionLink = new ActionLink();
actionLink.type = 2; // 0 (link to web), 1 (link to image), 2 (link to video), 3 (link to audio)
actionLink.label = "put_label_here";
actionLink.url = "https://www.youtube.com/watch?v=jp3xBWgii8A&list=RDjp3xBWgii8A";

MediaBody paragraphText = new MediaBody();
paragraphText.type = 0;
paragraphText.content = "put_content_here";

MediaBody paragraphImage = new MediaBody();
paragraphImage.type = 1;
paragraphImage.url = "https://upload.wikimedia.org/wikipedia/commons/7/71/2010-kodiak-bear-1.jpg";
paragraphImage.caption = "put_caption_here";
paragraphImage.width = 500;
paragraphImage.height = 300;

MediaBody paragraphVideo = new MediaBody();
paragraphVideo.type = 3;
paragraphVideo.url = "https://www.youtube.com/watch?v=jp3xBWgii8A&list=RDjp3xBWgii8A";
paragraphVideo.category = "youtube";
paragraphVideo.caption = "put_caption_here";

Media media = new Media();
media.title = "put_title_here";
media.author = "put_author_here";
media.cover = cover;
media.desc = "put_description_here";
media.actionLink = actionLink;
media.body = new List<MediaBody>() { paragraphText, paragraphImage, paragraphVideo };
media.status = "show";

JObject updateMedia = articleClient.updateMedia(mediaId, media);
```

**Xóa bài viết**
```
JObject removeMedia = articleClient.removeMedia(mediaId);
```

**Lấy danh sách bài viết**
```
JObject getSliceMedia = articleClient.getSliceMedia(0, 10);
```

**Upload video cho bài viết**
```
# Step 1 - Lấy link upload
JObject getUploadLink = articleClient.getUploadLink(videoName, videoSize);

# Step 2 - Upload file và lấy token
string appId = getUploadLink["data"]["appId"].ToString();
string uploadLink = getUploadLink["data"]["uploadLink"].ToString();
long timestamp = (long)getUploadLink["data"]["time"];
string sig = getUploadLink["data"]["sig"].ToString();

JObject uploadVideo = articleClient.uploadVideo(uploadLink, appId, pathToVideo, timestamp, sig);

# Step 3 - Lấy id của video
string token = uploadVideo["data"]["token"].ToString();
JObject getVideoId = articleClient.getVideoId(token, videoName, videoSize, timestamp, sig);

# step 4 - Kiểm tra trạng thái của video
JObject getVideoStatus = articleClient.getVideoStatus(videoId);
```

## Authors

* **NtkDuy**

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
