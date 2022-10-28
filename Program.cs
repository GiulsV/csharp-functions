// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
 
int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };

//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma "[elemento 1, elemento 2, elemento 3, ...]"
void StampaArray(int[] array)
{
    Console.Write("[ ");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(", ");
    }
    Console.WriteLine("]");
}

//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
int Quadrato(int numero) 
{
    return numero * numero;

}

//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
//Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione!(vedi slide)

int[] ElevaArrayAlQuadrato(int[] array) 
{
    int[] arrayAlQuadrato = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayAlQuadrato[i] = Quadrato(array[i]);
    }
    return arrayAlQuadrato;
}

//int SommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
int SommaElementiArray(int[] array) 
{
    int sommaArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sommaArray += array[i];
    }
    return sommaArray;
}


//Stampare l’array di numeri fornito a video
Console.Write("Elementi array: ");
StampaArray(arrayNumeri);

//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato
//(Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
int[] arrayAlQuadrato = ElevaArrayAlQuadrato(arrayNumeri);
Console.Write("Elementi array elevati al quadrato: ");
StampaArray(arrayAlQuadrato);

//Stampare la somma di tutti i numeri
Console.WriteLine("Somma array: " + SommaElementiArray(arrayNumeri));

//Stampare la somma di tutti i numeri elevati al quadrati
Console.WriteLine("Somma array al quadrato: " + SommaElementiArray(arrayAlQuadrato));



