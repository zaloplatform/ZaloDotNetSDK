using System;
using System.IO;
using System.Net;

namespace ZaloCSharpSDK
{
    public class FileUtils
    {
        public static byte[] loadFile(String path)
        {
            if (path.Contains("http")) {
                return new WebClient().DownloadData(path);
            }
            return File.ReadAllBytes(path);
        }
    }
}
