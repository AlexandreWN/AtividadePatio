using Microsoft.AspNetCore.Mvc;
namespace Controller.Controllers;
using Model;


[ApiController]
[Route("[controller]")]
public class ConcessionariaController : ControllerBase
{
    [HttpPost]
    [Route("register")]
    public object registerConcessionaria([FromBody] Concessionaria concessionaria){
        var id = concessionaria.save();
        return new{
            id = id,
            nome = concessionaria.nome,
        };
    }

    [HttpPut]
    [Route("update/{id}")]
    public object editConcessionaria([FromBody] Concessionaria concessionaria, int id){
        concessionaria.update(concessionaria, id);
        return new{
            status = "ok",
            mensagem = "deu boa"
        };
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public object deleteConcessionaria([FromBody] Concessionaria concessionaria, int id)
    {
        concessionaria.delete(id);
        return new
        {
            status = "ok",
            mensagem = "excluido"
        };
    }

    [HttpGet]
    [Route("get/{id}")]
    public object getConcessionaria(int id)
    {
        var concessionaria = Model.Concessionaria.findId(id);
        return concessionaria;
    }
}
