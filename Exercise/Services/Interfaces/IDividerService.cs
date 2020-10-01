using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Services
{
    public interface IDividerService
    {
        IEnumerable<DividerNumber> GetDividerNumbers(List<int> numbers);
    }
}
