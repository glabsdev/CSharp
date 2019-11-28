using System;
using RestSharp;
namespace csharp_master
{
    class sms_mt
    {
        static void Main(string[] args)
        {
            var shortcode = "1595";
			var access_token = "s0nmcL6TCFyUZ4yWViCmF_VRU-b9OOZ6QCd8A2NS0Go";
            var defaulturl = "https://devapi.globelabs.com.ph/smsmessaging/v1/outbound/";
			var address = "9772824313";
			var clientCorrelator = "264801";
			var message = "Csharp SMS Test";
            var url = "";
            url = defaulturl + shortcode + "/requests" + "?access_token=" + access_token;
			var client = new RestClient(url);
			var request = new RestRequest();
			request.Method = Method.POST;
			request.RequestFormat = DataFormat.Json;
			request.Parameters.Clear();
			request.AddBody(new {
					outboundSMSMessageRequest = new {
					clientCorrelator = clientCorrelator,
					senderAddress = shortcode,
					outboundSMSTextMessage = new { message = message},
					address = address
				}
			});
			IRestResponse response = client.Execute(request);
			var content = response.Content;
			Console.WriteLine(content);
        }
    }
}
