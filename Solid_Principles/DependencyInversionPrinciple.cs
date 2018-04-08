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
            Console.WriteLine("Save from Data Access Layer");
            return 1; 
        }
    }

    public class DIPMain
    {
        public static void Main(string[] args)
        {
            IRepositoryLayer dal = new DataAccessLayer();
            BusinessLogicLayer bl = new BusinessLogicLayer(dal);

            Employee emp = new PermanentEmployee(1, "James");
            var flag = dal.Save(emp);

            Console.ReadLine();
        }
    }

}
