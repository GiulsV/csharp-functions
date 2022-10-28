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

//Esercizio Extra
//Si chiede di implementare due funzioni che eseguano le corrsipettive funzioni matematiche:
//1 - Fattoriale di un numero
//2 - La sequenza di fibonacci di un numero

//risolverle in modo RICORSIVO o anche in modo ITERATIVO (FOR)

//1) il fattoriale di un numero può essere calcolato solo su numeri positivi:
//0! = 1
//1! = 1
//2! = 2
//3! = 6
//4! = 24
//5! = 120
//N! = ???
Console.WriteLine("Bonus");

int FattorialeIterativo(int num) 
{
    int fattoriale;
    fattoriale = 1;
    for (int i = 1; i <= num; i++)
        fattoriale = fattoriale * i;
    return fattoriale;
}
Console.WriteLine("Fattoriale iterativo (5): " + FattorialeIterativo(5));

int FattorialeRicorsivo(int n)
{
    if (n > 0)
        return FattorialeRicorsivo(n - 1) * n;
    else
        return 1;
}

Console.WriteLine("Fattoriale ricorsivo (5): " + FattorialeRicorsivo(5) );

//2) Fibonacci
//n	Fn
//0	 0
//1	 1
//2	 1
//3	 2
//4	 3
//5	 5
//6	 8
//7	 13
//8	 21
//9	 34
//10 55
//fibonacci(10) = 55

int FibonacciIterativo(int num)
{
    int number = 1;
    int number2 = 1;
    int fib = 0;

    if (num == 0) 
        return 0;
    if (num == 1) 
        return 1;
    for (int i = 2; i < num; i++) {
        fib = number + number2;
        number = number2;
        number2 = fib;   
    }
    return fib;
}
Console.WriteLine("Fibonacci iterativo (10): " + FibonacciIterativo(10));

int FibonacciRicorsivo(int n)
{
    if (n == 0)
        return 0;
    else if (n == 1)
        return 1;
    else
        return FibonacciRicorsivo(n - 1) + FibonacciRicorsivo(n - 2);
}
Console.WriteLine("Fibonacci ricorsivo (10): " + FibonacciRicorsivo(10));