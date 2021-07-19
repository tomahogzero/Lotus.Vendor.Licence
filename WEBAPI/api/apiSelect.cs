using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using webAPI.Models;
using System.Collections.Specialized;
using System.Net.Http;

namespace webAPI.api
{
    public class apiSelect
    {
        public static string GetSelect(string url, string token,string tablename,string where, ref modelResultError err)
        {
            err = null;
            try
            {
                string fullurl = "";
                string page = "1";
                string rows = "5000";

                if (where == "")
                {
                    fullurl = url + "/api/v1/load/" + tablename + "?page="+ page +"&rows=" + rows;

                }
                else {
                    fullurl = url + "/api/v1/load/" + tablename + "?page=" + page + "&rows=" + rows + "&where=" + where;
                }

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(fullurl);
                httpWebRequest.Headers.Add("Authorization", token);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    return result;
                    //lg = JsonConvert.DeserializeObject<model_class_res>(result);
                    //return lg;
                }
            }
            catch (WebException ex)
            {
                err = errorResponse.Response(ex);
                return null;
            }
        }

        public static string GetSelectIdentity(string url, string token, string tablename, string where, ref modelResultError err)
        {
            err = null;
            try
            {
                string fullurl = "";
                string page = "1";
                string rows = "5000";

                if (where == "")
                {
                    fullurl = url + "/api/v1/loadidentity/" + tablename + "?page=" + page + "&rows=" + rows;

                }
                else
                {
                    fullurl = url + "/api/v1/loadidentity/" + tablename + "?page=" + page + "&rows=" + rows + "&where=" + where;
                }

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(fullurl);
                httpWebRequest.Headers.Add("Authorization", token);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    return result;
                    //lg = JsonConvert.DeserializeObject<model_class_res>(result);
                    //return lg;
                }
            }
            catch (WebException ex)
            {
                err = errorResponse.Response(ex);
                return null;
            }
        }
    }
}
