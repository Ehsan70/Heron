using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Heron.Model
{
    public class ApiError
    {
        public string Message { get; set; }
        public string Detail { get; set; }

        // Ignoring stack track if it's null so set the null value handling to ignore
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue("")]
        public string StackTrace { get; set; }
    }
}
