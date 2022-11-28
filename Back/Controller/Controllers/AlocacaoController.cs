using Microsoft.AspNetCore.Mvc;
namespace Controller.Controllers;
using Model;


[ApiController]
[Route("[controller]")]
public class AlocacaoController : ControllerBase
{
    [HttpPost]
    [Route("register")]
    public object registerAlocation([FromBody] Alocacao alocacao){
        var id = alocacao.save();
        return new{
            id = id,
            quantidade = alocacao.quantidade,
            area = alocacao.area,
            concessionaria = alocacao.concessionaria,
            automoveis = alocacao.automoveis
        };
    }

    [HttpPut]
    [Route("update/{Id}")]
    public object editAlocation([FromBody] Alocacao alocacao, int Id){
        alocacao.update(alocacao, Id);
        return new{
            status = "ok",
            mensagem = "deu boa"
        };
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public object deleteAlocation([FromBody] Alocacao alocacao, int id)
    {
        alocacao.delete(id);
        return new
        {
            status = "ok",
            mensagem = "excluido"
        };
    }

    [HttpGet]
    [Route("get/{id}")]
    public object getAlocation(int id)
    {
        var alocacao = Model.Alocacao.findId(id);
        return alocacao;
    }
}
