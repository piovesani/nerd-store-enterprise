using Microsoft.AspNetCore.Mvc;
using NSE.Identity.API.Models;

namespace NSE.Identity.API.Controllers;

public class AuthController: Controller
{
    public async Task<ActionResult> Register(NewUser newUser)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
    }

    public async Task<ActionResult> Login(UserLogin userLogin)
    {
    }
    }
