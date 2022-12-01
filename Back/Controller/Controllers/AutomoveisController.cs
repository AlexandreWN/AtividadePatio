using Microsoft.AspNetCore.Mvc;
namespace Controller.Controllers;
using Model;
using DTO;


[ApiController]
[Route("[controller]")]
public class AutomoveisController : ControllerBase
{
    [HttpPost]
    [Route("register")]
    public object registerUser([FromBody] AutomoveisDTO automoveis){
        var automoveisModel = new Automoveis{
            modelo = automoveis.modelo,
            valor = automoveis.valor
        };
        automoveisModel.save();
        return automoveis;
    }

    [HttpPut]
    [Route("update/{id}")]
    public object editAutomovel([FromBody] AutomoveisDTO automoveis, int id){
        var automoveisModel = new Automoveis{
            modelo = automoveis.modelo,
            valor = automoveis.valor
        };
        automoveisModel.update(automoveisModel, id);
        return automoveisModel;
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public object deleteAutomoveis(int id)
    {
        var automoveis = Model.Automoveis.delete(id);
        return automoveis;
    }

    [HttpGet]
    [Route("get/{id}")]
    public object getAutomoveis(int id)
    {
        var automovel = Model.Automoveis.findId(id);
        return automovel;
    }

    [HttpGet]
    [Route("getAll")]
    public IActionResult getAllAutomoveis()
    {
        var automoveis = Model.Automoveis.findAll();
        var result = new ObjectResult(automoveis);
        return result;
    }
}
