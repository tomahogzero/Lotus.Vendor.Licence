using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using webAPI.Models;
using System.Web;

namespace webAPI
{
    public class errorResponse
    {
        public static modelResultError Response(WebException ex) {
            modelResultError ResultError = new modelResultError();
            try
            {
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    ResultError = JsonConvert.DeserializeObject<modelResultError>(reader.ReadToEnd());
                }
                if (ResultError == null)
                {
                    ResultError = new modelResultError();
                    ResultError.message = ex.Message;
                    ResultError.title = "CallApiError";
                }
            }
            catch
            {
                if (ResultError == null)
                {
                    ResultError = new modelResultError();
                    ResultError.message = ex.Message;
                    ResultError.title = "CallApiError";
                }
                else
                {
                    ResultError.message = ex.Message;
                    ResultError.title = "CallApiError";
                }
            }

            return ResultError;
        }
    }
}
