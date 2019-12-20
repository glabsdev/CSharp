using System;
using RestSharp;
namespace csharp_master
{
    class sms_mt
    {
        static void Main(string[] args)
        {
            var shortcode = "1234";
            var defaulturl = "https://devapi.globelabs.com.ph/smsmessaging/v1/outbound/";
			var app_id="5qkjCMGA76CG123456cAXnCGzqpKC5Mr";
			var app_secret="6e3ef1202f1e112345d1380a6b30ea59f507c12345929064eec2123a5fe1b036";
			var address = "6390000000000";
			var passphrase="XXXXXXXXXX";
			var clientCorrelator = "264801";
			var message = "Csharp SMS Test  (Bypassed)";
            var url = "";
            url = defaulturl + shortcode + "/requests";
			var client = new RestClient(url);
			var request = new RestRequest();
			request.Method = Method.POST;
			request.RequestFormat = DataFormat.Json;
			request.Parameters.Clear();
			request.AddBody(new {
					clientCorrelator = clientCorrelator,
					senderAddress = shortcode, 
					message = message,
					app_id = app_id,
					app_secret=app_secret,
					passphrase=passphrase,
					address = address
			});
			IRestResponse response = client.Execute(request);
			var content = response.Content;
			Console.WriteLine(content);
        }
    }
}
