namespace Model;
public class Automoveis
{
    public int id { get; set; }
    public string modelo { get; set; }
    public float valor { get; set; }

    public int save(){
        int Id = 0;
        using (var context = new Context()){
            var automoveis  = new Automoveis(){
                modelo = this.modelo,
                valor = this.valor
            };
            context.Automoveis.Add(automoveis);
            context.SaveChanges();
            Id = automoveis.id;
        }
        return Id;
    }

    public void update(Automoveis Automoveis, int id)
    {
        using (var context = new Context())
        {
            var automoveis = context.Automoveis.FirstOrDefault(i => i.id == id);
            if(automoveis.modelo != null)
            {
                automoveis.modelo = Automoveis.modelo;
            }
            if(automoveis.valor != null)
            {
                automoveis.valor = Automoveis.valor;
            }
            context.SaveChanges();
        }
    }

    public static object delete(int id)
    {
        using (var context = new Context())
        {
            var automoveis = context.Automoveis.FirstOrDefault(i => i.id == id);

            context.Automoveis.Remove(automoveis);
            context.SaveChanges();

            return automoveis;
        }
    }

    public static object findId(int id)
    {
        using (var context = new Context())
        {
            var automoveis = context.Automoveis.FirstOrDefault(a => a.id == id);
            return new
            {
                modelo = automoveis.modelo,
                valor = automoveis.valor
            };
        }
    }

    public static List<object> findAll()
    {
        using (var context = new Context())
        {
            var automoveis = context.Automoveis;
            
            List<object> dados = new List<object>();
            foreach(var i in automoveis){
                dados.Add(i);
            }
            return dados;
        }
    }
}