using System.Text;

namespace BookImpresion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Ingrese el numero de paginas de su pdf: ");
            int numPaginas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ConfiguracionImpresion(numPaginas));
        }

        private static string ConfiguracionImpresion(int numPaginas)
        {
            var cadenaConfig = new StringBuilder();
            int k = (numPaginas % 2 == 0) ? numPaginas + 2  : numPaginas + 3;
            for (int i = 1; i <= (k / 4);)
            {
                string hoja = $"Hoja no. {i}: Paginas en anverso -> {i} y {k} | Paginas en reverso -> {i + 1} y {k - 1}\n";
                cadenaConfig.Append(hoja);
                i += 2;
                k -= 2;

            }

            return cadenaConfig.ToString();
        }
    }
}
