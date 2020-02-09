using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Adapter
{
    public class PatientAPIService 
    {
        public async Task<List<Patient>> GetPatients()
        {
            using (var client = new HttpClient())
            {
                string url = "https://swapi.co/api/people";
                string result = await client.GetStringAsync(url);
                var patients = JsonConvert.DeserializeObject<APIResult<Patient>>(result).Results;

                return patients;
            }
        }
    }
}
