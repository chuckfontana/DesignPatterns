using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Adapter
{
    public class Test
    {
        private readonly ITestOutputHelper _output;

        public Test(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public async Task DisplayPatientsFromFile()
        {
            string filename = @"Patient.json";
            var service = new PatientService(
                new PatientFileSourceAdapterService(filename, new PatientFileSourceService()));

            var result = await service.GetPatientList();

            _output.WriteLine(result);
        }

        [Fact]
        public async Task DisplayPatientsFromApi()
        {
            var service = new PatientService(
                new PatientAPIAdapterService(new PatientAPIService()));

            var result = await service.GetPatientList();

            _output.WriteLine(result);
        }

    }
}
