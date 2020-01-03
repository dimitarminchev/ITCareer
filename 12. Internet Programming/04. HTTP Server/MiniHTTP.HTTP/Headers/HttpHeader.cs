using MiniHTTP.HTTP.Common;

namespace MiniHTTP.HTTP.Headers
{
    public class HttpHeader
    {
        // Fix
        public static string Location { get; set; }
        public static string ContentType { get; set; }

        // Constructor
        public HttpHeader(string key, string value)
        {
            CoreValidator.ThrowIfNullOrEmpty(key, nameof(key));
            CoreValidator.ThrowIfNullOrEmpty(value, nameof(value));
            this.Key = key;
            this.Value = value;
        }
       
        public string Key { get; }
        public string Value { get; }
        public override string ToString()
        {
            return $"{this.Key}: {this.Value}";
        }
    }
}
