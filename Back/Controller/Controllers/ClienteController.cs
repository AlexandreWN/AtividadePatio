using Microsoft.AspNetCore.Mvc;
namespace Controller.Controllers;
using Model;
using DTO;

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
    public object registerUser([FromBody] ClienteDTO cliente){
        var clienteModel = new Cliente{
            nome = cliente.nome
        };
        clienteModel.save();
        return cliente;
    }

    [HttpGet]
    [Route("getAll")]
    public IActionResult getAllCliente()
    {
        var cliente = Model.Cliente.findAll();
        var result = new ObjectResult(cliente);
        return result;
    }
}