namespace Model;
public class Vendas
{
    public int id { get; set; }
    public DateTime data { get; set; }
    public Alocacao alocacao { get; set; }
    public Cliente cliente { get; set; }
}