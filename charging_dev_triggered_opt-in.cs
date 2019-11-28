using System;
using RestSharp;
namespace csharp_master
{
	class charge_dev_triggered
    {
        static void Main(string[] args)
        {
			var app_id = "n6xEuRxXAzhMoc6ekgTXMKh756AMu9GM";
			var app_secret = "731fcbf3ac947d69cb85f030d51747b4a739d89e7a960be64365bd82713cb923";
			var subscriber_number = "9772824313";
			var amount = "0.00";
			var duration = "0";
			var defaulturl = "https://devapi.globelabs.com.ph/payment/v1/smsoptin";
			var url = "";
            url = defaulturl + "?app_id=" + app_id + "&app_secret=" + app_secret +
			"&subscriber_number=" + subscriber_number + "&duration=" + duration + "&amount=" + amount;
			var client = new RestClient(url);
			var request = new RestRequest();
			request.Method = Method.POST;
			request.RequestFormat = DataFormat.Json;
			request.Parameters.Clear();
			request.AddHeader("Host", "devapi.globelabs.com.ph");
			IRestResponse response = client.Execute(request);
			var content = response.Content;
			Console.WriteLine(content);
        }
    }
}	