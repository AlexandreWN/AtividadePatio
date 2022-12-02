using Microsoft.EntityFrameworkCore;

namespace Model;
public class Alocacao
{
    public int id { get; set; }
    public int quantidade { get; set; }
    public int area { get; set; }
    public int concessionariaId { get; set; }
    public int automoveisId { get; set; }
    public Concessionaria concessionaria { get; set; }
    public Automoveis automoveis { get; set; }

    public int save(){
        using var context = new Context();

        context.Alocacao.Add(this);
        context.SaveChanges();
        
        return this.id;
    }

    public void update()
    {
        using var context = new Context();

        context.Update(this);
        
        context.SaveChanges();
    }

    public static object delete(int id)
    {
        using (var context = new Context())
        {
            var alocacao = context.Alocacao.FirstOrDefault(i => i.id == id);

            context.Alocacao.Remove(alocacao);
            context.SaveChanges();

            return alocacao;
        }
    }

    public static Alocacao findId(int id)
    {
        using var context = new Context();

        return context.Alocacao.Where(a => a.id == id)
        .Include(a => a.automoveis)
        .Include(a => a.concessionaria).Single();
    }

    public static List<object> findAll()
    {
        using var context = new Context();
        
        var alocacao = context.Alocacao
            .Include(a => a.automoveis)
            .Include(a => a.concessionaria);
          
        List<object> dados = new List<object>();
        foreach(var i in alocacao){
            dados.Add(i);
        }
        return dados;
    }
}
