public sealed class PizzaSimplesFactory
{
    public static Pizza criarPizza(string tipo)
    {
        Pizza pizza;
        switch (tipo)
        {
            case "C":
                pizza = new PizzaDeCalabreza();
            break;
            case "M":
                pizza = new PizzaDeMusarela();
            break;
            default:
                throw new ApplicationException($"A pizza de {tipo} não foi criada");
        }
        return pizza;
    }
}