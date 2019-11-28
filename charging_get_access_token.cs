using System;
using RestSharp;
namespace csharp_master
{
	class charge_customer
    {
        static void Main(string[] args)
        {
			var app_id = "n6xEuRxXAzhMoc6ekgTXMKh756AMu9GM";
			var app_secret = "731fcbf3ac947d69cb85f030d51747b4a739d89e7a960be64365bd82713cb923";
			var code = "KfjpeXnHR4g9gsM77xzI7gpoqfxdxrof8MMMRsoa4KnF5npLofjrzekhLArAMUBj56yFKGkdbu5rE69hxqxRBIrbqReFqpogMsKrBbxCK6k5rCr7BeBSrXoEjfebi9bxkRqTodgfKMBpxSELkjeC8kBaMC6Eo6dsGgqEXFkexyLIjkEz8hebkLnu4z5G8FzEro5UzozGEhyopyMf6q4xMFdrMzLskXxeEfpgpERfex7oqIzgge5sqxe9bHEK6qzf";
			var defaulturl = "https://developer.globelabs.com.ph/oauth/access_token";
			var url = "";
            url = defaulturl + "?app_id=" + app_id + "&app_secret=" + app_secret + "&code=" + code;
			var client = new RestClient(url);
			var request = new RestRequest();
			request.Method = Method.POST;
			request.RequestFormat = DataFormat.Json;
			request.Parameters.Clear();
			request.AddHeader("cache-control", "no-cache");
			IRestResponse response = client.Execute(request);
			var content = response.Content;
			Console.WriteLine(content);
        }
    }
}