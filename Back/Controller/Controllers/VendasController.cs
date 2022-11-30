using Microsoft.AspNetCore.Mvc;
namespace Controller.Controllers;
using Model;


[ApiController]
[Route("[controller]")]
public class VendasController : ControllerBase
{
    [HttpPost]
    [Route("register")]
    public object registerVenda([FromBody] Vendas vendas){
        var id = vendas.save();
        return new{
            id = id,
            data = vendas.data,
            quantidade = vendas.quantidade,
            total = vendas.total,
            alocacao = vendas.alocacao,
            cliente = vendas.cliente
        };
    }

    [HttpPut]
    [Route("update/{id}")]
    public object editVenda([FromBody] Vendas venda, int id){
        venda.update(venda, id);
        return new{
            status = "ok",
            mensagem = "deu boa"
        };
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public object deleteVenda([FromBody] Vendas venda, int id)
    {
        venda.delete(id);
        return new
        {
            status = "ok",
            mensagem = "excluido"
        };
    }

    [HttpGet]
    [Route("get/{id}")]
    public object getVenda(int id)
    {
        var venda = Model.Vendas.findId(id);
        return venda;
    }
}
