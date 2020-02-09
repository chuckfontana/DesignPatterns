using System.Collections.Generic;
using System.Threading.Tasks;

namespace Adapter
{
    public class PatientFileSourceAdapterService : IPatientDataSourceAdapter
    {
        private readonly string _fileName;
        private readonly PatientFileSourceService _patientFileSourceService;

        public PatientFileSourceAdapterService(string fileName, PatientFileSourceService patientFileSourceService)
        {
            _fileName = fileName;
            _patientFileSourceService = patientFileSourceService;
        }
        public async Task<IEnumerable<Patient>> GetPatients()
        {
            return await _patientFileSourceService.GetPatients(_fileName);
        }
    }
}
