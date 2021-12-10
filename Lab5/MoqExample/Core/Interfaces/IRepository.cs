using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> GetById(int id);
    }
}
