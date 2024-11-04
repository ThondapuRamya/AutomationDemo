using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICore
{
    public class CreateRestResponse
    {
        public static RestResponse SendRequest(RestRequest restRequest , HttpMethods httpMethod)
        {
            RestClient restClient = new RestClient();
            switch(httpMethod)
            {
                case HttpMethods.Get:
                   return restClient.Get(restRequest);

                case HttpMethods.Post:
                    return restClient.Post(restRequest);

                 case HttpMethods.Put:
                    return restClient.Put(restRequest);

                  case HttpMethods.Patch:
                    return restClient.Patch(restRequest);

                  case HttpMethods.Delete:
                    return restClient.Delete(restRequest);

                default:
                    throw new Exception("The given method is not supported");

                    

            }
        }
    }
}
