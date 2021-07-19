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
    public class Device
    {
        public static List<modelDevice> GetList(string url, string token, ref string err)
        {
            modelResultError _err = null;
            try
            {

                string res = apiSelect.GetSelectIdentity(url, token, "Device", "", ref _err);

                List<modelDevice> res_data = new List<modelDevice>();

                if (_err != null)
                {
                    err = _err.message;
                }
                else {
                    res_data = JsonConvert.DeserializeObject<List<modelDevice>>(res);
                }
                return res_data;
            }
            catch (Exception ex) {
                err = ex.Message;
                return null;
            }            
        }

        public static bool Update(string url, string token,string deviceid, modelDeviceUpdate md, ref string err)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/api/v1/companyGroup/device/" + deviceid);
                httpWebRequest.Headers.Add("Authorization", token);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";

                using (var streamWriter = new

                StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        name = md.Name,
                        serialNo = md.SerialNo,
                        serialNoHash = md.SerialNoHash
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
