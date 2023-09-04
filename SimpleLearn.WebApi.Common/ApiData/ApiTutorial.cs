using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLearn.WebApi.Common.ApiData
{
    public class ApiTutorial
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
