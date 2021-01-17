namespace MiniServer.HTTP
{
    public interface IHttpHeaderCollection
    {
        void AddHeader(HttpHeader header);

        bool ContainsHeader(string key);

        HttpHeader GetHeader(string key);
    }
}
