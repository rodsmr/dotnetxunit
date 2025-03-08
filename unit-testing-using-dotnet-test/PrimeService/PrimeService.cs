namespace PrimeService;

public class PrimeService
{
    // Un numero primo è un numero divisibile solo per 1 e per se stesso.
    // Nella definizione del dizionario, un numero primo è “un numero naturale, maggiore di 1, che non può essere rappresentato
    // come prodotto di due numeri naturali più piccoli di lui”.
    //
    // I numeri primi sono i mattoni della matematica. Un numero primo è un numero intero maggiore di 1 che può essere
    // diviso solo per 1 e per se stesso. In altre parole, quando provi a dividere un numero primo per qualsiasi altro numero,
    // otterrai sempre un resto. Qualsiasi numero naturale può essere assemblato da numeri primi tramite moltiplicazione.
    
    public bool IsPrime(int number)
    {
        if (number < 2) return false;
        
        if (number == 2) return true;

        for (var divisor = 2; divisor < number; divisor++)
        {
            if (number % divisor == 0)
                return false;
        }

        return true;
    }
}
