using System.Collections.Generic;
using System.Threading.Tasks;

namespace Adapter
{
    public class PatientAPIAdapterService : IPatientDataSourceAdapter
    {
        private readonly PatientAPIService _patientAPIService;

        public PatientAPIAdapterService(PatientAPIService patientAPIService)
        {
            _patientAPIService = patientAPIService;
        }

        public async Task<IEnumerable<Patient>> GetPatients()
        {
            return await _patientAPIService.GetPatients();
        }
    }
}
