Console.WriteLine("======PIZARIA=======");
Console.WriteLine("Informe o local (S)São paulo (R)Rio de janeiro ");
var localEscolhido = Console.ReadLine().ToUpper();
Console.WriteLine("Escolha a Pizza (M)Mussarela (C)Calabreza");
var pizzaEscolhida = Console.ReadLine().ToUpper();

try
{
    PizzaFactoryMethod pizzaria = PizzaSimpleFactory.CriarPizzaria(localEscolhido);

    var pizza = pizzaria.MontarPizza(pizzaEscolhida);

    Console.WriteLine(pizza.Preparar());
    Console.WriteLine("\n Pizza Concluida com sucesso !");
}catch(Exception ex)
{
    Console.WriteLine("Erro : "+ex.Message);
}
Console.ReadLine();