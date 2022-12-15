using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TrelloBackend.Models;

namespace TrelloBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // Users admin = new (1, "admin", "qwerty");
        //Users tim = new(2, "tim", "tim");
        //Users user = new(3, "user", "password");

       /* List<Users> users = new List<Users>
        {
            new (1, "admin", "qwerty"),
            new (2, "tim", "tim"),
            new (3, "user", "password")
        };


        [HttpPost]
        public async Task Post(HttpResponse response, HttpRequest request)
        {
            bool otvet = false;
            try
            {
                var usera = await request.ReadFromJsonAsync<Users>();
                if (usera != null)
                {
                    foreach (var user in users)
                    {
                        if (user.name == usera.name & user.password == usera.password)
                        {
                            otvet = !otvet;
                            break;
                        }
                    }
                    await response.WriteAsJsonAsync(otvet);
                }
                else
                {
                    throw new Exception("Некорректные данные");
                }
            }
            catch (Exception)
            {
                response.StatusCode = 400;
                await response.WriteAsJsonAsync(new { message = "Некорректные данные" });
            }
        }*/

    }
}
