using Exercise.Services;
using Exercise.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercise.Responses;
using Exercise;
using System.Linq;

namespace ExerciseTest
{
    [TestClass]
    public class ExerciseUnitTest
    {
        private DividerService dividerService;
        List<DividerNumber> result;
        List<DividerNumber> resultV2;
        List<DividerNumber> resultV3;

        [TestInitialize]
        public void Initialize()
        {
            dividerService = new DividerService();
            result = new List<DividerNumber> {
                new DividerNumber
                {
                    number = "112233",
                    isMutiple = true
                },
                new DividerNumber
                {
                    number = "30800",
                    isMutiple = true
                },
                new DividerNumber
                {
                    number = "2937",
                    isMutiple = true
                },
                new DividerNumber
                {
                    number = "323455693",
                    isMutiple = true
                },
                new DividerNumber
                {
                    number = "5038297",
                    isMutiple = true
                },
                new DividerNumber
                {
                    number = "112234",
                    isMutiple = false
                }};

            resultV2 = new List<DividerNumber> {
                new DividerNumber
                {
                    number = "94186565",
                    isMutiple = true
                },
                new DividerNumber
                {
                    number = "56568143",
                    isMutiple = false
                } };

            resultV3 = new List<DividerNumber> {
                new DividerNumber
                {
                    number = "4611686018427387901307445734561825860123058430092136939501844674407370955160",
                    isMutiple = true
                },
                new DividerNumber
                {
                    number = "4611686018427387903307445734561825860223058430092136939511844674407370955161",
                    isMutiple = false
                } };
        }

        [TestMethod]
        public void GetDividerNumbersTest()
        {
            var request = new GetDividerRequest { numbers = new List<string> { "112233", "30800", "2937", "323455693", "5038297", "112234" } };
            var response = dividerService.GetDividerNumbers(request);
            Assert.IsTrue(response.result.ToList()[0].Equals(result[0]));
            Assert.IsTrue(response.result.ToList()[1].Equals(result[1]));
            Assert.IsTrue(response.result.ToList()[2].Equals(result[2])); 
            Assert.IsTrue(response.result.ToList()[3].Equals(result[3]));
            Assert.IsTrue(response.result.ToList()[4].Equals(result[4]));
            Assert.IsTrue(response.result.ToList()[5].Equals(result[5]));

        }

        [TestMethod]
        public void GetDividerNumbersTestV2()
        {
            var request = new GetDividerRequest { numbers = new List<string> { "94186565", "56568143" } };
            var response = dividerService.GetDividerNumbersV2(request);
            Assert.IsTrue(response.result.ToList()[0].Equals(resultV2[0]));
            Assert.IsTrue(response.result.ToList()[1].Equals(resultV2[1]));
        }

        [TestMethod]
        public void GetDividerNumbersTestV3()
        {
            var request = new GetDividerRequest { numbers = new List<string> { "4611686018427387901307445734561825860123058430092136939501844674407370955160", 
                "4611686018427387903307445734561825860223058430092136939511844674407370955161" } };
            var response = dividerService.GetDividerNumbersV3(request);
            Assert.IsTrue(response.result.ToList()[0].Equals(resultV3[0]));
            Assert.IsTrue(response.result.ToList()[1].Equals(resultV3[1]));
        }
    }
}
