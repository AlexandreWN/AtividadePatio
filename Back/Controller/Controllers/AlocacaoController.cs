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
        var concessionaria = Model.Concessionaria.findId(alocacao.concessionaria);
        var automoveis = Model.Automoveis.findId(alocacao.automoveis);

        /*var AlocacaoModel = new Alocacao{
            quantidade = alocacao.quantidade,
            area = alocacao.area,
            concessionaria = concessionaria,
            automoveis = automoveis
        };
        AlocacaoModel.save();*/
        return automoveis;  
    }

    [HttpPut]
    [Route("update/{id}")]
    public object editAlocation([FromBody] AlocacaoDTO alocacao, int id){
        var concessionaria = Model.Concessionaria.findId(alocacao.concessionaria);
        var automoveis = Model.Automoveis.findId(alocacao.automoveis);

       /* var alocacaoModel = new Alocacao{
            quantidade = alocacao.quantidade,
            area = alocacao.area,
            concessionaria = concessionaria,
            automoveis = automoveis
        };
        alocacaoModel.update(alocacaoModel, id);*/
        return automoveis;
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
