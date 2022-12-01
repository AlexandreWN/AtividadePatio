using Microsoft.AspNetCore.Mvc;
namespace Controller.Controllers;
using Model;
using DTO;


[ApiController]
[Route("[controller]")]
public class ConcessionariaController : ControllerBase
{
    [HttpPost]
    [Route("register")]
    public object registerConcessionaria([FromBody] ConcessionariaDTO concessionaria){
        var concessionariaModel = new Concessionaria{
            nome = concessionaria.nome
        };
        concessionariaModel.save();
        return concessionaria;
    }

    [HttpPut]
    [Route("update/{id}")]
    public object editConcessionaria([FromBody] ConcessionariaDTO concessionaria, int id){
        var concessionariaModel = new Concessionaria{
            nome = concessionaria.nome
        };
        concessionariaModel.update(concessionariaModel, id);
        return concessionariaModel;
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public object deleteConcessionaria(int id)
    {
        var concessionaria = Model.Concessionaria.delete(id);
        return concessionaria;
    }

    [HttpGet]
    [Route("get/{id}")]
    public object getConcessionaria(int id)
    {
        var concessionaria = Model.Concessionaria.findId(id);
        return concessionaria;
    }

    [HttpGet]
    [Route("getAll")]
    public IActionResult getAllConcessionaria()
    {
        var concessionaria = Model.Concessionaria.findAll();
        var result = new ObjectResult(concessionaria);
        return result;
    }
}
