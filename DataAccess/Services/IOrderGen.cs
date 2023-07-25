namespace DataAccess.Services
{
    public interface IOrderGen
    {
        Task<T> CreateAndAssignObject<T>(T sourceObj) where T : new();

        //Task<T> BuildObjectTest<T,U>(object obj ,U parameters);
        Task<T> CreateObject<T>() where T : new();
    }
}