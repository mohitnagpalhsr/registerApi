using Models;
namespace ServiceLayer
{
    public interface ILoginModelService<LoginModel>
    {
        void AddLoginModel(LoginModel L);
    }
}