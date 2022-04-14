using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using RestSharp;
using Newtonsoft.Json;
namespace WebApi.Rest


{
    
    public partial class Demo
    {
        public Class GetUsers()
        {
            var restClient = new RestClient("https://reqres.in");
            var restRequest = new RestRequest("/api/users?page=2", Method.GET);
            restRequest.AddHeader("Accept","application/json");
            restRequest.RequestFormat =DataFormat.Json;

            IRestResponse response =restClient.Execute(restRequest);
            var content =response.Content;


            var users= JsonConvert.DeserializeObject<Class>(content);
            return users;
        }
     
    }
}