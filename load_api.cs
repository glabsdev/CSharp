using System;
using RestSharp;
namespace csharp_master
{
	class load_api
    {
        static void Main(string[] args)
        {
			var app_id = "MaRxFKA4MkfjgTBj7xi4oyfExabxFERp";
			var app_secret = "552ed60fab76317d91cd1f691f07cea85388b26e6586a9ac7e63221ac9f4d8aa";
			var rewards_token = "-H6l4ET0-mDRsBjmFy8vIQ==";
			var address = "9772824313";
			var promo = "LOAD 1";
			var defaulturl = "https://devapi.globelabs.com.ph/rewards/v1/transactions/send";
			var url = "";
            url = defaulturl;
				var client = new RestClient(url);
				var request = new RestRequest();
				request.Method = Method.POST;
				request.RequestFormat = DataFormat.Json;
				request.Parameters.Clear();
				request.AddBody(new {
					outboundRewardRequest = new {
					app_id = app_id,
					app_secret = app_secret,
					rewards_token = rewards_token,
					address = address,
					promo = promo
				}
			});
			IRestResponse response = client.Execute(request);
			var content = response.Content;
			Console.WriteLine(content);
			}
        }
    }	