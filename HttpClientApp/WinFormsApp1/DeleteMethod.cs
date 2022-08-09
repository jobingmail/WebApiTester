using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace WinFormsApiClient
{
    public class DeleteMethod
    {

        public string DeleteData(string URL)
        {
            using (var client = new HttpClient())
            {
                var response = client.DeleteAsync(URL).Result;

                if (response.IsSuccessStatusCode)
                {
                    return "DELETE";
                }
                else
                    return "Error";
            }
        }
    }
}
