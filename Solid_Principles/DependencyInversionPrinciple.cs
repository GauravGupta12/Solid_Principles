using System;
namespace Solid_Principles
{
    public class BusinessLogicLayer
    {
        private readonly IRepositoryLayer _dal;
        public BusinessLogicLayer(IRepositoryLayer dal)
        {
            _dal = dal;
        }
    }
    public interface IRepositoryLayer
    {
        int Save(Employee emp);
    }

    public class DataAccessLayer : IRepositoryLayer
    {
        public int Save(Employee emp)
        {
            // save logic
            return 1; 
        }
    }
}
