namespace Exemplo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arrayteste = new int[] { 5, 3, 6, 2, 10 };

            Console.WriteLine(OrdenacaoPorSelecao(arrayteste)); 
        }

        static int BuscaMenor(int[] array)
        {
            int menor = array[0];
            int menorIndice = 0; 

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < menor)
                {
                    menor = array[i];
                    menorIndice = i;
                } 
            }
            return menorIndice;
        }

        static int[] OrdenacaoPorSelecao(int[] array)
        {
             var newArr = new int[] { };
            
            for (int i = 0; i < array.Length; i++)
            {
                int menor = BuscaMenor(array);
                newArr.Append(array[i]); 
            }
            return newArr;
        }
    }
}
