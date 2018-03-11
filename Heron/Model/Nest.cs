using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heron.Model
{
    public class Nest : Resource
    {
        /// <summary> Name of the file where eggs are stored. </summary>
        public string Name { get; set; }
        public string Description { get; set; }
        // public NestRoles nRole { get; set; }
    }
}
