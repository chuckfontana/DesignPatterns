using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Adapter
{
    public class PatientFileSourceService
    {
        public async Task<IEnumerable<Patient>> GetPatients(string fileName)
        {
            var patients = JsonConvert.DeserializeObject<IEnumerable<Patient>>(await File.ReadAllTextAsync(fileName));

            return patients;
        }
    }
}
