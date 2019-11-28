using System;
using RestSharp;
namespace csharp_master
{
	class load_api_status
    {
        static void Main(string[] args)
        {
			var app_id = "MaRxFKA4MkfjgTBj7xi4oyfExabxFERp";
			var app_secret = "552ed60fab76317d91cd1f691f07cea85388b26e6586a9ac7e63221ac9f4d8aa";
			var rewards_token = "-H6l4ET0-mDRsBjmFy8vIQ==";
			var transaction_id = "12290932";
			var defaulturl = "https://devapi.globelabs.com.ph/rewards/v1/transactions/status";
			var url = "";
            url = defaulturl;
				var client = new RestClient(url);
				var request = new RestRequest();
				request.Method = Method.POST;
				request.RequestFormat = DataFormat.Json;
				request.Parameters.Clear();
				request.AddBody(new {
					rewardStatusRequest = new {
					app_id = app_id,
					app_secret = app_secret,
					rewards_token = rewards_token,
					transaction_id = transaction_id
				}
			});
			IRestResponse response = client.Execute(request);
			var content = response.Content;
			Console.WriteLine(content);		
        }
    }
}	