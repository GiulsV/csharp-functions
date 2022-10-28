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
int[] arrayAlQuadrato = ElevaArrayAlQuadrato(arrayNumeri);

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
Console.Write("Elementi array elevati al quadrato: ");
StampaArray(arrayAlQuadrato);
Console.Write("Array originale: ");
StampaArray(arrayNumeri);

//Stampare la somma di tutti i numeri
Console.WriteLine("Somma array: " + SommaElementiArray(arrayNumeri));

//Stampare la somma di tutti i numeri elevati al quadrati
Console.WriteLine("Somma array al quadrato: " + SommaElementiArray(arrayAlQuadrato));

//BONUS: Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile,
//ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.
//A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.
//Rieseguire il programma con l’input preso esternamente dall’utente.
Console.WriteLine("Bonus");

Console.WriteLine("Quanti numeri vuoi inserire?");
int arrayInserito = Convert.ToInt32(Console.ReadLine());
int[] arrayUtente = new int[arrayInserito];
for (int i = 0; i < arrayInserito; i++)
{
    Console.WriteLine("Inserisci il numero " + (i + 1));
    arrayUtente[i] = Convert.ToInt32(Console.ReadLine());
}
//Stampa
Console.Write("Elementi array: ");
StampaArray(arrayUtente);

int[] arrayQuadrato = ElevaArrayAlQuadrato(arrayUtente);
Console.Write("Elementi array elevati al quadrato: ");
StampaArray(arrayQuadrato);
Console.Write("Array originale: ");
StampaArray(arrayUtente);

Console.WriteLine("Somma array: " + SommaElementiArray(arrayUtente));

Console.WriteLine("Somma array al quadrato: " + SommaElementiArray(arrayQuadrato));