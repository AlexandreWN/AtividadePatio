namespace Model;
public class Alocacao
{
    public int id { get; set; }
    public int quantidade { get; set; }
    public int area { get; set; }
    public Concessionaria concessionaria { get; set; }
    public Automoveis automoveis { get; set; }
}
