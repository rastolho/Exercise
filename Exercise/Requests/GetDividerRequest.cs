using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Exercise.Requests
{
    public class GetDividerRequest
    {
        [DataMember]
        public List<string> numbers { get; set; }
    }
}
