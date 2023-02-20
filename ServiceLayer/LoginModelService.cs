using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using ServiceLayer;
using RepoLayer;
using System.Security.Cryptography;
using System.Text;

namespace ServiceLayer;

public class LoginModelService : ILoginModelService<LoginModel>
{
    public static ILoginModelRepo<LoginModel> loginModelRepo;

    public LoginModelService(ILoginModelRepo<LoginModel> _containRepo)
    {
        loginModelRepo = _containRepo;
    }
    

    public void AddLoginModel(LoginModel L)
    {
        //using BCrypt to hash passwords
        L.Password= BCrypt.Net.BCrypt.HashPassword(L.Password);
        loginModelRepo.AddLoginModel(L);
    }
}