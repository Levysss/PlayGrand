public class PizzaDeMusarela : Pizza
{
    public PizzaDeMusarela()
    {
    Nome = "Pizza De Mussarela";    
    }
    public override void Preparar()
    {
        Console.WriteLine($"Preparando Pizza de {Nome}");
    }
    public override void Assar(int tempo)
    {
        Console.WriteLine($"Pizza de {Nome} assando por{tempo} min.");
    }
    public override void Embalar()
    {
        Console.WriteLine($"Embalando Pizza de {Nome}");
    }
}