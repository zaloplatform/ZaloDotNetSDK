using System;

namespace ZaloCSharpSDK {
    public class APIException : Exception {
        private int _code;

        public int code {get; set;}

        public APIException() : base() { }

        public APIException(string message) : base(message) { }
    }
}