using Security.Models;
using System.Threading.Tasks;

namespace Security.Repositories
{
    public interface IHospitalRepository
    {
        Task<IEnumerable<Hospital>> GetAll();
        Task<Hospital> GetOne(Guid id);
        Task Add(Hospital hospital);
        Task Update(Hospital hospital);
        Task Delete(Guid id);
        Task<IEnumerable<Hospital>> GetPublicHospitals();
    }
}
