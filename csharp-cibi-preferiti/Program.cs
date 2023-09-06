// See https://aka.ms/new-console-template for more information

string[] favouriteDishes = 
{ 
    "pizza",
    "carne alla brace",
    "sushi",
    "cheesecake",
    "carbonara",
    "pasta al sugo", //commentare per lista dispari
    "porchetta",
    "prova",
    "prova prova",
};

// numero di elementi
Console.WriteLine("La lista contiene " + favouriteDishes.Length + " elementi.");

// classifica intera
Console.WriteLine("Ecco la classifica:");
for (int i = 0; i < favouriteDishes.Length; i++)
{
    Console.WriteLine($"{i + 1} - {favouriteDishes[i]}");
}

// primo in lista
Console.WriteLine("Il mio cibo preferito in assoluto: " + favouriteDishes[0]);

// ultimo in lista
Console.WriteLine("Un mio cibo preferito (ma non troppo): " + favouriteDishes.Last());

// *** Bonus ***

Console.Write("A metà della classifica abbiamo ");

int listLength = favouriteDishes.Length;

if (listLength % 2 == 0)
{
    Console.WriteLine($"a pari merito: {favouriteDishes[(listLength / 2) - 1]} e {favouriteDishes[listLength / 2]}.");
} else
{
    Console.WriteLine(": " + favouriteDishes[listLength / 2]);
}
