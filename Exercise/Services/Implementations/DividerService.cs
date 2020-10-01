using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Services
{
    public class DividerService : IDividerService
    {
        public IEnumerable<DividerNumber> GetDividerNumbers(List<int> numbers)
        {
            return numbers.Select(x =>  new DividerNumber { number = x, isMutiple = isMultiple(x)});
        }

        private bool isMultiple(int number)
        {
            var isDiviser = false;
            var lastNumber = number % 10;
            var newNumber = (number - (number % 10)) / 10;
            var minus = newNumber - lastNumber;
            if (Math.Ceiling(Math.Log10(minus)) == 2)
            {
                if (minus.ToString().Distinct().Count() == 1)
                    return true;
            }
            else
                isDiviser = isMultiple(minus);

            return isDiviser;
        }
    }
}
