string name;

Console.WriteLine("Vad heter du?");
name = Console.ReadLine();


string country;

Console.WriteLine("Vilket land bor du i?");
country = Console.ReadLine();


string freeTime;

Console.WriteLine("Vad gillar du att göra på fritiden?");
freeTime = Console.ReadLine();



Console.WriteLine($"Hej! Jag heter {name} och jag bor i {country}. På fritiden så brukar jag {freeTime}!");
// Console.WriteLine(name);

Console.ReadLine();

