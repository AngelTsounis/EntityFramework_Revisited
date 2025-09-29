namespace Application.Interfaces;

public interface IBaseRepository<T>
{
    Task<List<T>> GetAllAsync();
}
