using Microsoft.AspNetCore.Mvc;
namespace Controller.Controllers;
using Model;
using DTO;


[ApiController]
[Route("[controller]")]
public class AlocacaoController : ControllerBase
{
    [HttpPost]
    [Route("register")]
    public object registerAlocation([FromBody] AlocacaoDTO alocacao){

        var AlocacaoModel = new Alocacao{
            quantidade = alocacao.quantidade,
            area = alocacao.area,
            concessionariaId = alocacao.concessionariaId,
            automoveisId = alocacao.automoveisId
        };

        AlocacaoModel.save();
        return alocacao;  
    }

    [HttpPut]
    [Route("update/{id}")]
    public object editAlocation([FromBody] AlocacaoDTO alocacao, int id){
        
        var alocacaoModel = Model.Alocacao.findId(id);
        alocacaoModel.quantidade = alocacao.quantidade;
        alocacaoModel.area = alocacao.area;

        alocacaoModel.update();
        return alocacaoModel;
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public object deleteAlocation(int id)
    {
        var alocacao = Model.Alocacao.delete(id);
        return alocacao;
    }

    [HttpGet]
    [Route("get/{id}")]
    public object getAlocation(int id)
    {
        var alocacao = Model.Alocacao.findId(id);
        return alocacao;
    }

    [HttpGet]
    [Route("getAll")]
    public IActionResult getAllAlocacao()
    {
        var alocacao = Model.Alocacao.findAll();
        var result = new ObjectResult(alocacao);
        return result;
    }
}
