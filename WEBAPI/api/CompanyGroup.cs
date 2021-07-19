using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using webAPI.Models;

namespace webAPI.api
{
    public class CompanyGroup
    {
        public static List<modelCompanyGroup> GetList(string url, string token, ref string err)
        {
            modelResultError _err = null;
            try
            {

                string res = apiSelect.GetSelectIdentity(url, token, "CompanyGroup", "", ref _err);

                List<modelCompanyGroup> res_data = new List<modelCompanyGroup>();

                if (_err != null)
                {
                    err = _err.message;
                }
                else {
                    res_data = JsonConvert.DeserializeObject<List<modelCompanyGroup>>(res);
                }
                return res_data;
            }
            catch (Exception ex) {
                err = ex.Message;
                return null;
            }            
        }

        public static bool UpdateToken(string url, string token, string companygroupid, modelCompanyGroupUpdateToken md, ref string err)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/api/v1/companyGroup/" + companygroupid);
                httpWebRequest.Headers.Add("Authorization", token);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";

                using (var streamWriter = new

                StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        name = md.Name,
                        licenseToken = md.LicenseToken
                    });
                    streamWriter.Write("" + json + "");
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //lg = JsonConvert.DeserializeObject<model_classes>(result);
                    //return lg;
                }
                return true;
            }
            catch (WebException ex)
            {
                err = errorResponse.Response(ex).message;
                return false;
            }
        }
    }
}
