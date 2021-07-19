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

namespace webAPI
{
    public class WebAPI
    {
        public static model_Res_Login Login(string url, string username, string password,  ref modelResultError ResultError)
        {
            model_Res_Login lg = new model_Res_Login();
            ResultError = null;
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/api/auth/token");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                //httpWebRequest.UserAgent = "Koala Admin";

              
                //httpWebRequest.CookieContainer = new CookieContainer();

                using (var streamWriter = new

                StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        userName = username,
                        password = password,
                        grantType = "password",
                        audience = "TescoLotus.SupplyLine.ApplicationApi"
                    });
                    streamWriter.Write(json);
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    //Cookies = httpResponse.Cookies;

                    var result = streamReader.ReadToEnd();
                    //DataTable dt = webAPI.WebAPI.ConvertJsonToDatatable(result);

                    lg = JsonConvert.DeserializeObject<model_Res_Login>(result);

                    if (lg.access_token != null)
                    {
                        return lg;
                    }
                    else
                    {
                        //message = "Username หรือ Password ผิดพลาด";
                        return null;
                    }
                }
            }
            catch (WebException ex)
            {
                ResultError = errorResponse.Response(ex);
                return null;
            }
        }

        public static string encrip_password(string url, string password, ref string err)
        {
            err = "";

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/TimeAtt/ncryp-p");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                //if (httpWebRequest.CookieContainer == null)
                //{
                //    httpWebRequest.CookieContainer = new CookieContainer();
                //}

                //httpWebRequest.CookieContainer.Add(Cookies);

                using (var streamWriter = new

                StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        password = password
                    });
                    streamWriter.Write( json);
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    modelRet modRet;
                    modRet = JsonConvert.DeserializeObject<modelRet>(result);

                    return modRet.result.ToString();
                }
            }
            catch (WebException ex)
            {
                err = ex.Message;
                return "";
            }
        }

    }
}
