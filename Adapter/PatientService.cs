using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PatientService
    {
        private readonly IPatientDataSourceAdapter _patientDataSourceAdapter;

        public PatientService(IPatientDataSourceAdapter patientDataSourceAdapter)
        {
            _patientDataSourceAdapter = patientDataSourceAdapter;
        }
        
        public async Task<string> GetPatientList()
        {
            var patients = await _patientDataSourceAdapter.GetPatients();

            var sb = new StringBuilder();
            int nameWidth = 30;
            sb.AppendLine($"{"NAME".PadRight(nameWidth + 5)}   {"GENDER"}");
            foreach (Patient person in patients)
            {
                sb.AppendLine($"{person.Name.Trim().PadRight(nameWidth)} \t  {person.Gender.Trim()}");
            }

            return sb.ToString();
        }
    }
}
