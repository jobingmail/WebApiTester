using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace WinFormsApp1
{
    public enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    public class GetMethod
    {
        public string endPoint { get; set; }
        public HttpVerb httpMethod { get; set; }

        public GetMethod()
        {
            endPoint = string.Empty;
            httpMethod = HttpVerb.GET;
        }

        public string GetData()
        {
            try
            {
                string strResponseValue = string.Empty;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
                request.Method = httpMethod.ToString();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception("error");
                    }

                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponseValue = reader.ReadToEnd();
                            }
                        }
                    }
                    return strResponseValue;

                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
