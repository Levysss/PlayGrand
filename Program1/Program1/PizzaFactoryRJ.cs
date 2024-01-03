public class PizzaFactoryRJ:PizzaFactoryMethod
{
    protected override Pizza CriarPizza(string tipo)
    {
        if(tipo.Equals("M"))
        {
            return new PizzaMussarelaRJ();
        }
        if(tipo.Equals("C"))
        {
            return new PizzaCalabrezaRJ();
        }
        else return null;
    }
}