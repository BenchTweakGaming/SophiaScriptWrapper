using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SophiaScriptWrapper
{
    public class Item
    {
        public string Arg { get; set; }
        // Maps the JSON property "1" to a C# variable
        [JsonProperty("1")]
        public string Num { get; set; }
        public string Tag { get; set; }
    }
}
