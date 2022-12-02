namespace Model;
public class Concessionaria
{
    public int id { get; set; }
    public string nome { get; set; }

    public int save(){
        int Id = 0;
        using (var context = new Context()){
            var concessionaria  = new Concessionaria(){
                nome = this.nome
            };
            context.Concessionaria.Add(concessionaria);
            context.SaveChanges();
            Id = concessionaria.id;
        }
        return Id;
    }

    public void update(Concessionaria Concessionaria, int id)
    {
        using (var context = new Context())
        {
            var concessionaria = context.Concessionaria.FirstOrDefault(i => i.id == id);
            if(concessionaria.nome != null)
            {
                concessionaria.nome = Concessionaria.nome;
            }
            context.SaveChanges();
        }
    }

    public static object delete(int id)
    {
        using (var context = new Context())
        {
            var concessionaria = context.Concessionaria.FirstOrDefault(i => i.id == id);

            context.Concessionaria.Remove(concessionaria);
            context.SaveChanges();

            return concessionaria;
        }
    }

    public static object findId(int id)
    {
        using (var context = new Context())
        {
            var concessionaria = context.Concessionaria.FirstOrDefault(a => a.id == id);
            return new
            {
                nome = concessionaria.nome
            };
        }
    }

    public static List<object> findAll()
    {
        using (var context = new Context())
        {
            var concessionaria = context.Concessionaria;
            
            List<object> dados = new List<object>();
            foreach(var i in concessionaria){
                dados.Add(i);
            }
            return dados;
        }
    }
}
