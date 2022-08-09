using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace WinFormsApiClient
{
    internal class PutMethod
    {
        public string PutData(string URL, Quote quote)
        {
            using (var client = new HttpClient())
            {
                var res = client.PutAsync(URL,
                  new StringContent(JsonConvert.SerializeObject(quote), Encoding.UTF8, "application/json"));



                try
                {
                    res.Result.EnsureSuccessStatusCode();
                    return HttpVerb.PUT.ToString();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }


        }
    }
}
