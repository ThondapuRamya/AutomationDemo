using APICore;
using APITestcases.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APITestcases
{
    public class APIClients
    {
        public bool ListOfObjects(string requiredId)
        {
            string url = ConfigurationProvider.apiDetails.APIBaseurl + "/objects";
            RestRequest request= CreateRestRequest.CreateRequest(url);            
            RestResponse restResponse = CreateRestResponse.SendRequest(request, HttpMethods.Get);

           if( restResponse.StatusCode.Equals(HttpStatusCode.OK) )              
            {
                GetObjectsResponce[] getObjectsResponce= JsonConvert.DeserializeObject<GetObjectsResponce[]>(restResponse.Content);
               return getObjectsResponce.Select(x => x.id).ToList().Any(y => y == requiredId);

            }
            return false;
        }
        public bool GetObject(string objid)
        {
           // string url = ConfigurationProvider.apiDetails.APIBaseurl+string .Format($@"/objects/{0}",objid);
            string url = ConfigurationProvider.apiDetails.APIBaseurl + "/objects/"+ objid;
            Console.WriteLine(ConfigurationProvider.apiDetails.APIBaseurl + "/objects/" + objid);
            RestRequest request = CreateRestRequest.CreateRequest(url);
            RestResponse response = CreateRestResponse.SendRequest(request,HttpMethods.Get);
            if (response.StatusCode.Equals(HttpStatusCode.OK) && response.Content != null)
            {
                GetObjectsResponce getObjectsResponce= JsonConvert.DeserializeObject<GetObjectsResponce>(response.Content);
                return getObjectsResponce.id.Equals(objid);
            }

            return false;

        }
        public bool SomeObjects(List<string> list)
        {
            string url = ConfigurationProvider.apiDetails.APIBaseurl + "/objects?";
            string resourceUrl =null;
            foreach (var obj in list)
            {
               resourceUrl=resourceUrl+ "id="+ obj;
                if (obj != list.ElementAt(list.Count - 1))
                    resourceUrl = resourceUrl + "&";
            }
            RestRequest request = CreateRestRequest.CreateRequest(url);
          
            RestResponse response = CreateRestResponse.SendRequest(request, HttpMethods.Get);

            if(response.StatusCode.Equals(HttpStatusCode.OK))
              {

                GetObjectsResponce[] getObjectsResponce =JsonConvert.DeserializeObject<GetObjectsResponce[]>(response.Content);
              List<string> ids=  getObjectsResponce.Select(x => x.id).ToList();
               return ids.Equals(list);
              }
            return false;
        }
    }
}

