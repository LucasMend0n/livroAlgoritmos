namespace Exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 3, 5, 7, 9};

            Console.WriteLine(BuscaBinaria(values, 9)); 
            Console.WriteLine(BuscaBinaria(values, -1)); 
        }

        static int BuscaBinaria(int[] lista, int item)
        {
            int menor = 0; 
            int maior = lista.Length -1;

            while (menor <= maior)
            {
                int mid = (menor + maior) / 2; 
                int chute = lista[mid];

                if(chute == item) return mid;

                if (chute > item) maior = mid - 1;

                else
                {
                    menor = mid + 1;
                }
            }

            return -1; 
        }

    }
}
