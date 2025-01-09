// See https://aka.ms/new-console-template for more information


 static int soma(int[] lista)
{
    if(lista == null || lista.Length == 0)
    {
        return 0;
    }

    return lista[0] + soma(lista);
}

Console.WriteLine(soma([1, 5, 4]));