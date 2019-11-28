using System;
using RestSharp;
namespace csharp_master
{
	class lbs
    {
        static void Main(string[] args)
        {
			var access_token = "s0nmcL6TCFyUZ4yWViCmF_VRU-b9OOZ6QCd8A2NS0Go";
			var address = "9772824313";
			var requestedAccuracy = "100";
			var defaulturl = "https://devapi.globelabs.com.ph/location/v1/queries/location";
			var url = "";
            url = defaulturl + "?address=" + address + "&requestedAccuracy=" +
			requestedAccuracy +"&access_token=" + access_token ;
				var client = new RestClient(url);
				var request = new RestRequest();
				request.Method = Method.GET;
				request.RequestFormat = DataFormat.Json;
				request.Parameters.Clear();
				request.AddHeader("Host", "devapi.globelabs.com.ph");
				IRestResponse response = client.Execute(request);
				var content = response.Content;
				Console.WriteLine(content);
        }
    }
}	