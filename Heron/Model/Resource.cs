using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heron.Model
{
    public abstract class Resource
    {
        // Setting the order to -2 means this property is at the top of serialized properties.  
        [JsonProperty(Order = -2)]
        public string Href { get; set; }
    }
}
