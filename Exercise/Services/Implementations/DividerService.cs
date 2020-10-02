using Exercise.Requests;
using Exercise.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Services
{
    public class DividerService : IDividerService
    {
        public GetDividerResponse GetDividerNumbers(GetDividerRequest request)
        {
            var response = new GetDividerResponse();
            response.result = request.numbers.Select(x => new DividerNumber { number = x, isMutiple = isMultiple(x) });
            return response;
        }

        public GetDividerResponse GetDividerNumbersV2(GetDividerRequest request)
        {
            var response = new GetDividerResponse();
            response.result = request.numbers.Select(x => new DividerNumber { number = x, isMutiple = isMultipleV2(x) });
            return response;
        }

        public GetDividerResponse GetDividerNumbersV3(GetDividerRequest request)
        {
            var response = new GetDividerResponse();
            response.result = request.numbers.Select(x => new DividerNumber { number = x, isMutiple = isMultipleV3(x) });
            return response;
        }

        private bool isMultiple(string number)
        {
            var isDiviser = false;
            var stringAsNumber = int.Parse(number);
            var lastNumber = stringAsNumber % 10;
            var newNumber = (stringAsNumber - (stringAsNumber % 10)) / 10;
            var minus = newNumber - lastNumber;
            if (Math.Ceiling(Math.Log10(minus)) == 2)
            {
                if (minus.ToString().Distinct().Count() == 1)
                    return true;
            }
            else if (Math.Ceiling(Math.Log10(minus)) > 2)
                isDiviser = isMultiple(minus.ToString());

            return isDiviser;
        }

        private bool isMultipleV2(string number)
        {
            var digitsArray = GetDigits(number);
            var result = (digitsArray[0] + digitsArray[2] + digitsArray[4] + digitsArray[6]) -
                (digitsArray[1] + digitsArray[3] + digitsArray[5] + digitsArray[7]);

            return result % 11 == 0;
        }

        public int[] GetDigits(string number)
        {
            string temp = number.ToString();
            int[] rtn = new int[temp.Length];
            for (int i = 0; i < rtn.Length; i++)
            {
                rtn[i] = int.Parse(temp[i].ToString());
            }
            return rtn;
        }

        private bool isMultipleV3(string number)
        {
            var isDiviser = false;
            var evenNumbers = 0;
            var oddNumbers = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (i % 2 == 0)
                    oddNumbers +=int.Parse(number.ElementAt(i).ToString());
                else
                    evenNumbers +=int.Parse(number.ElementAt(i).ToString());
            }
            if ((oddNumbers % 11) == (evenNumbers % 11))
                isDiviser = true;

            return isDiviser;
        }
    }
}
