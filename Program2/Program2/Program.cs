class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Tecle algo para iniciar...\n");
        Console.ReadKey();
        await Aguardar(5);
        Console.WriteLine("Já se passou 5 segundos");
        Console.WriteLine("Fim");
        Console.ReadLine();
    }
    static async Task Aguardar(int tempo)
    {
        Console.WriteLine("Iniciando espera....");
        await Task.Delay(TimeSpan.FromSeconds(tempo));
        Console.WriteLine("Tempo de espera acabou!");
    }
}