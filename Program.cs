// This is a comment to my code
// Rakendus küsib kasutajal sisestada tema nimi
// Rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:"); //Väljund

// String- SÕNE
string userName = Console.ReadLine(); //Sisend

Console.WriteLine("Hello" + ", " + userName + "!"); //Väljund

// String - interpolation
Console.WriteLine($"Hello, {userName}!"); //Väljund

