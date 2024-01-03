public class PizzaSimpleFactory
{
    public static PizzaFactoryMethod CriarPizzaria(string local)
    {
        PizzaFactoryMethod pizzaria;
        switch (local)
        {
            case "S":
                pizzaria = new PizzaFactorySP();
            break;
            case "R":
                pizzaria = new PizzaFactoryRJ();
            break;
            default:
                throw new ApplicationException($"A Pizzaria {local} não foi encontrada");
        }
        return pizzaria;
    }
}