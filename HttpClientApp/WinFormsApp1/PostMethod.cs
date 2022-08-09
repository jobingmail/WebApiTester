using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace WinFormsApiClient
{
    public class PostMethod
    {

        public string PostData(string URL,Quote quote)
        {
            using (var client = new HttpClient())
            {
                var res = client.PostAsync(URL,
                  new StringContent(JsonConvert.SerializeObject(quote),Encoding.UTF8, "application/json"));

                           

                try
                {
                    res.Result.EnsureSuccessStatusCode();
                    return HttpVerb.POST.ToString();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }


        }
    }
}
