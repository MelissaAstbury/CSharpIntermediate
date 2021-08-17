using System.Collections.Generic;

namespace CSharpIntermediate.Models
{
    public class HttpCookie
    {
        // key should be type string and value also
        private readonly Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get{ return _dictionary[key]; }
            set{ _dictionary[key] = value; }
        }
    }
}
