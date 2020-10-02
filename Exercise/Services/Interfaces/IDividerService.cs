using Exercise.Requests;
using Exercise.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.Services
{
    public interface IDividerService
    {
        GetDividerResponse GetDividerNumbers(GetDividerRequest request);

        GetDividerResponse GetDividerNumbersV2(GetDividerRequest request);

        GetDividerResponse GetDividerNumbersV3(GetDividerRequest request);
    }
}
