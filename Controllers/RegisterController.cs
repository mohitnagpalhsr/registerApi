using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceLayer;

namespace register
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController:ControllerBase
    {

        public static ILoginModelService<LoginModel> loginModelService;

        public RegisterController(ILoginModelService<LoginModel> _containService)
        {
            loginModelService = _containService;
        }


        [HttpPost]
        public async Task<ActionResult<LoginModel>> RegisterUser(LoginModel loginModel)
        {
            loginModelService.AddLoginModel(loginModel);
            //_log4net.Info("Product id" + contain.Pid + "is added");
            return Ok();
        }
    }
}