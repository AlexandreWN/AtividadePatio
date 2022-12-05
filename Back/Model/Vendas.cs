namespace Model;
public class Vendas
{
    public int id { get; set; }
    public DateTime data { get; set; }
    public int quantidade { get; set; }
    public float total { get; set; }
    public Alocacao alocacao { get; set; }
    public Cliente cliente { get; set; }

    public int save(int alocacao_id, int cliente_id, int concessionaria_id){
        using var context = new Context();

        var alocacao = context.Alocacao.FirstOrDefault(a => a.id == alocacao_id && a.concessionaria.id == concessionaria_id);
        var cliente = context.Cliente.FirstOrDefault(c => c.id == cliente_id);
        
        if(alocacao.quantidade >= this.quantidade){
            var vendas  = new Vendas(){
                data = this.data,
                quantidade = this.quantidade,
                total = this.total,
                alocacao  = alocacao,
                cliente = cliente
            };

            

            if(alocacao.quantidade >= quantidade){
                alocacao.quantidade -= quantidade;
            }

            alocacao.update();

            context.Vendas.Attach(vendas);
            context.Vendas.Add(vendas);
            context.SaveChanges();

            return vendas.id;
        }
        else{
            return 0;
        }
    }
}