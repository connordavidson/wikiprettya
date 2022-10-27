using System ; 
using System.Data ;



public interface IService<T>
{ 
    public Task<T> GetById(uint id) ; 
    public Task<ICollection<T>> GetAll() ; 

}