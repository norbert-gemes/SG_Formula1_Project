using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bejelentkezés.utilities
{
    public class jsonReader
    {
        public List<string> extractdataList(string tokenname)
        {
            string myJsonString = File.ReadAllText("tests/tests.json");
            var jsonObject = JToken.Parse(myJsonString);
            return jsonObject.SelectToken(tokenname).Values<string>().ToList();
        }
    }
}
