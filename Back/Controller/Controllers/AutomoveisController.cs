using Microsoft.AspNetCore.Mvc;
namespace Controller.Controllers;
using Model;


[ApiController]
[Route("[controller]")]
public class AutomoveisController : ControllerBase
{
    [HttpPost]
    [Route("register")]
    public object registerUser([FromBody] Automoveis automoveis){
        var id = automoveis.save();
        return new{
            id = id,
            modelo = automoveis.modelo,
            valor = automoveis.valor
        };
    }

    [HttpPut]
    [Route("update/{Id}")]
    public object editAutomovel([FromBody] Automoveis automoveis, int Id){
        automoveis.update(automoveis, Id);
        return new{
            status = "ok",
            mensagem = "deu boa"
        };
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public object deleteAutomoveis([FromBody] Automoveis automoveis, int id)
    {
        automoveis.delete(id);
        return new
        {
            status = "ok",
            mensagem = "excluido"
        };
    }

    [HttpGet]
    [Route("get/{id}")]
    public object getAutomoveis(int id)
    {
        var automovel = Model.Automoveis.findId(id);
        return automovel;
    }
}
