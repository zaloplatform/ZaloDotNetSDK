using System.Net.Http;
using System.IO;
using System.Net.Http.Headers;

namespace ZaloDotNetSDK
{
    public class ZaloFile
    {
        private string name;
        private ByteArrayContent data;

        public ZaloFile(string path) {
            data = new ByteArrayContent(FileUtils.loadFile(path));
            name = Path.GetFileName(path);
        }

        public string GetName() {
            return name;
        }

        public ByteArrayContent GetData() {
            return data;
        }

        public void setMediaTypeHeader(string type) {
            data.Headers.ContentType = new MediaTypeHeaderValue(type);
        }
    }
}