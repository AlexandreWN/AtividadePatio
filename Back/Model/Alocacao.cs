namespace Model;
public class Alocacao
{
    public int id { get; set; }
    public int quantidade { get; set; }
    public int area { get; set; }
    public Concessionaria concessionaria { get; set; }
    public Automoveis automoveis { get; set; }

    public int save(){
        int Id = 0;
        using (var context = new Context()){
            var alocacao  = new Alocacao(){
                quantidade = this.quantidade,
                area = this.area,
                concessionaria = this.concessionaria,
                automoveis = this.automoveis
            };
            context.Alocacao.Add(alocacao);
            context.SaveChanges();
            Id = alocacao.id;
        }
        return Id;
    }

    public void update(Alocacao Alocacao, int id)
    {
        using (var context = new Context())
        {
            var alocacao = context.Alocacao.FirstOrDefault(i => i.id == id);
            if(alocacao.quantidade != null)
            {
                alocacao.quantidade = Alocacao.quantidade;
            }
            if(alocacao.area != null)
            {
                alocacao.area = Alocacao.area;
            }
            if(alocacao.concessionaria != null)
            {
                alocacao.concessionaria = Alocacao.concessionaria;
            }
            if(alocacao.automoveis != null)
            {
                alocacao.automoveis = Alocacao.automoveis;
            }
            context.SaveChanges();
        }
    }

    public void delete(int id)
    {
        using (var context = new Context())
        {
            var alocacao = context.Alocacao.FirstOrDefault(i => i.id == id);

            context.Alocacao.Remove(alocacao);
            context.SaveChanges();
        }
    }

    public static object findId(int id)
    {
        using (var context = new Context())
        {
            var alocacao = context.Alocacao.FirstOrDefault(a => a.id == id);
            return new
            {
                area = alocacao.area,
                automoveis = alocacao.automoveis,
                quantidade = alocacao.quantidade,
                concessionaria = alocacao.concessionaria
            };
        }
    }
}
