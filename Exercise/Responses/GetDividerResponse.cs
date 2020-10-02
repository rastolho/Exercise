using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Exercise.Responses
{
    public class GetDividerResponse
    {
        [DataMember]
        public IEnumerable<DividerNumber> result { get; set; }
    }
}
