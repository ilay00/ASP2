using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace WebAppSATES.Clients
{
   public abstract class BaseClaint
    {
        protected HttpClient Client { get; set; }

        protected string ServiceAddress { get; set; }

        public BaseClaint (IConfiguration configureation)
        {
            Client = new HttpClient()
            {
                BaseAddress = new Uri(configureation["ClientAddress"])
            };
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("applicationException/json"));
        }
    }
}
