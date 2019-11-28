using System;
using RestSharp;
namespace csharp_master
{
	class charge_customer
    {
        static void Main(string[] args)
        {
			var access_token = "JgP8JMU2TQrcHWFMtZ9FXKzKaopUN2Q8RRTtYeYI2hg";
			var amount = "0.00";
			var description = "CSharp Charging Description";
			var endUserId = "9772824313";
			var referenceCode = "83901000002";
			var transactionOperationStatus ="Charged";
			var duration = "0";
			var defaulturl = "https://devapi.globelabs.com.ph/payment/v1/transactions/amount";
			var url = "";
            url = defaulturl + "?access_token=" + access_token;
			var client = new RestClient(url);
			var request = new RestRequest();
			request.Method = Method.POST;
			request.RequestFormat = DataFormat.Json;
			request.Parameters.Clear();
			request.AddHeader("Host", "devapi.globelabs.com.ph");
			request.AddBody(new {
				amount = amount,
				description = description,
				endUserId = endUserId,
				referenceCode = referenceCode,
				transactionOperationStatus = transactionOperationStatus,
				duration = duration
			});
			IRestResponse response = client.Execute(request);
			var content = response.Content;
			Console.WriteLine(content);
        }
    }
}