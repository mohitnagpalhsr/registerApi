using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace RepoLayer;

public class LoginModelRepo : ILoginModelRepo<LoginModel>
{
    private readonly SportsEventManagementContext db;

    public LoginModelRepo(SportsEventManagementContext _db)
    {
        db = _db;
    }

    public void AddLoginModel(LoginModel L)
    {
        db.LoginModels.Add(L);
        db.SaveChanges();
    }
}