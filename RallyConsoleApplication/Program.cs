using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rally.RestApi;
using Rally.RestApi.Json;
using Rally.RestApi.Response;
using System.Net;

namespace RallyConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            string username = "emids@activehealth.net";
            string password = "Welcome1";
            string serverUrl = "https://rally1.rallydev.com";

            RallyRestApi restApi = new RallyRestApi();
            restApi.Authenticate(username, password, serverUrl, proxy:null, allowSSO: false);
            
            Request request = new Request("project"); 
            request.Fetch = new List<string>() { "Name", "Description", "FormattedID" };
            request.Query = new Query("Name", Query.Operator.Contains, "ahm");
            QueryResult queryResult = restApi.Query(request);
            foreach (var result in queryResult.Results)
            {
                string aa = result.ToString();
            }
        }
    }
}
