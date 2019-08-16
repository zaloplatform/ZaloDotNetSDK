using System;
using System.IO;
using System.Net;

namespace ZaloDotNetSDK
{
    public class FileUtils
    {
        public static byte[] loadFile(String path)
        {
            if (path.Contains("http"))
            {
#if (NETSTANDARD1_6)
                return Utils.DownloadFile(path);
#else
                return new WebClient().DownloadData(path);
#endif
            }
            return File.ReadAllBytes(path);
        }
    }
}
