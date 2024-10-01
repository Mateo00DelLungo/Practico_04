namespace Practico_04.Interfaces
{
    public interface IManager<T>
    {
        Task<bool> Save(T dto);
        Task<bool> Update(T dto);
        Task<bool> Delete(int id);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
    }
}
