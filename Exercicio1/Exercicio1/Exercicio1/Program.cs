namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Informe o primeiro valor: ");
                var valorA = Int32.Parse(Console.ReadLine());
                Console.Write("Informe o segundo valor: ");
                var valorB = Int32.Parse(Console.ReadLine());
                var calc = new Calculos();
                Console.WriteLine($"Soma dos valores: {calc.Somar(valorA, valorB)}");
                Console.WriteLine($"Diferença dos valores: {calc.Subtrair(valorA, valorB)}");
                Console.WriteLine($"Produto dos valores: {calc.Multiplicar(valorA, valorB)}");
                Console.WriteLine($"Divisão dos valores: {calc.Dividir(valorA, valorB)}");
                Console.WriteLine($"O valor {valorA} é {calc.ValorParImpar(valorA)}.");
                Console.WriteLine($"O valor {valorB} é {calc.ValorParImpar(valorB)}.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}