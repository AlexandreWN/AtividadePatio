using Microsoft.AspNetCore.Mvc;
namespace Controller.Controllers;
using System;
using Model;
using DTO;

[ApiController]
[Route("[controller]")]
public class VendasController : ControllerBase
{
    [HttpPost]
    [Route("register/{id}")]
    public object registerVenda([FromBody] VendasDTO vendas, int id){
        var VendasModel = new Vendas{
            data = DateTime.Now,
            quantidade = vendas.quantidade,
            total = vendas.total,
        };

        VendasModel.save(vendas.alocacao, vendas.cliente, id);
        return VendasModel;
    }
}
