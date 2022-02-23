using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactureManagement.MainForm;

namespace FactureManagement.App
{
    public static class RequestHelper
    {
        private static readonly string baseURL = "http://syscompta.rtgroup-rdc.com/";
        public static async Task<string> Post(string url ,params List<KeyValuePair<string, string>>[] inputData)
        {
            try
            {
                var input = new FormUrlEncodedContent(inputData[0]);
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync(baseURL+ url, input))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show(" vous avez 15 jours d'essai","Pas d'internet!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                App.app.activated("AZERTYUIOP", 15,"essai");
                new FormActivation().Hide();
                new FormSplashScreen().Show();
            }
            return string.Empty;
        }

        public static string BeautifyJson(string jsonStr)
        {
            try
            {
                JToken parseJson = JToken.Parse(jsonStr);
                return parseJson.ToString(Formatting.Indented);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
