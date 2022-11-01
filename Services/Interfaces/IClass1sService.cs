using MVCProjects.Models;

namespace MVCProjects.Services.Interfaces
{
    public interface IClass1sService
    {
        Task<IEnumerable<Class1s>> FindAll();

        Task<Class1s> FindOne(int id);
    }
}
