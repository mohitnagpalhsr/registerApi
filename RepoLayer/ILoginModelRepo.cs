using Models;

namespace RepoLayer
{

public interface ILoginModelRepo<LoginModel>
{
    void AddLoginModel(LoginModel L);
}
}