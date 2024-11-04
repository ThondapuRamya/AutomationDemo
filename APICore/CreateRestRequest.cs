using RestSharp;

namespace APICore
{
    public class CreateRestRequest
    {
        public static RestRequest CreateRequest(string url)
        {
            RestRequest request = new RestRequest(url);
            return request;
        }
    }
}
