public class Pizzaria
{
    public static void SolicitarPizza(){
        Console.WriteLine("========Pizzaria==========");
        Console.WriteLine("Informe a Pizza (C)alabraza ou (M)ussarela \n");
        var tipo = Console.ReadLine().ToUpper();
        try
        {
            Pizza pizza = PizzaSimplesFactory.criarPizza(tipo);
            pizza.Preparar();
            pizza.Assar(10);
            pizza.Embalar();
        }
        catch (Exception ex)
        {
            
            Console.WriteLine("Erro :" +ex.Message);
        }
    }
}