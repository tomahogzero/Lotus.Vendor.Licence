using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using webAPI.Models;

namespace webAPI.api
{
    public class Company
    {
        public static List<modelCompany> GetList(string url, string token, ref string err)
        {
            modelResultError _err = null;
            try
            {

                string res = apiSelect.GetSelect(url, token, "Company", "", ref _err);

                List<modelCompany> res_data = new List<modelCompany>();

                if (_err != null)
                {
                    err = _err.message;
                }
                else {
                    res_data = JsonConvert.DeserializeObject<List<modelCompany>>(res);
                }
                return res_data;
            }
            catch (Exception ex) {
                err = ex.Message;
                return null;
            }            
        }
    }
}
