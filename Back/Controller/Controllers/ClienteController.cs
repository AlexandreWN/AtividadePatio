using Microsoft.AspNetCore.Mvc;
namespace Controller.Controllers;
using Model;

using Microsoft.AspNetCore.Cors;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    [HttpPost]
    [Route("register")]
    public object registerUser([FromBody] Cliente cliente){
        var id = cliente.save();
        return new{
            id = id,
            nome = cliente.nome
        };
    }
}
