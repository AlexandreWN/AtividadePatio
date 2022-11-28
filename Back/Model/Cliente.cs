namespace Model;
public class Cliente
{
    public int id { get; set; }
    public string nome { get; set; }

    public int save(){
        int Id = 0;
        using (var context = new Context()){
            var cliente  = new Cliente(){
                nome = this.nome,
            };
            context.Cliente.Add(cliente);
            context.SaveChanges();
            Id = cliente.id;
        }
        return Id;
    }
}