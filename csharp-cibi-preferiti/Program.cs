// See https://aka.ms/new-console-template for more information

string[] favourite_dishes = 
{ 
    "pizza",
    "carne alla brace",
    "sushi",
    "cheesecake",
    "carbonara",
    "pasta al sugo", //commentare per lista dispari
};

// numero di elementi
Console.WriteLine("La lista contiene " + favourite_dishes.Length + " elementi.");

// classifica intera
Console.WriteLine("Ecco la classifica:");
for (int i = 0; i < favourite_dishes.Length; i++)
{
    Console.WriteLine($"{i + 1} - {favourite_dishes[i]}");
}

// primo in lista
Console.WriteLine("Il mio cibo preferito in assoluto: " + favourite_dishes[0]);

// ultimo in lista
Console.WriteLine("Un mio cibo preferito (ma non troppo): " + favourite_dishes[(favourite_dishes.Length - 1)]);

// *** Bonus ***

Console.Write("A metà della classifica abbiamo ");

int list_length = favourite_dishes.Length;

if (list_length % 2 == 0)
{
    Console.WriteLine($"a pari merito: {favourite_dishes[(list_length / 2) - 1]} e {favourite_dishes[list_length / 2]}.");
} else
{
    Console.WriteLine(": " + favourite_dishes[list_length / 2]);
}
