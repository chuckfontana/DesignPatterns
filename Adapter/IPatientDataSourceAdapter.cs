using System.Collections.Generic;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IPatientDataSourceAdapter
    {
        Task<IEnumerable<Patient>> GetPatients(); 
    }
}
