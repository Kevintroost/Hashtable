using System.Collections;

Hashtable myHashTable = new Hashtable();

myHashTable["Alice"] = 25;
myHashTable["Bob"] = 30;
myHashTable["Charlie"] = 35;
myHashTable["Henk"] = 40;

Console.WriteLine("Charlie's age: " + (int?)myHashTable["Charlie"]);


if (myHashTable.ContainsKey("Alice"))
{
    Console.WriteLine("Alice is found, Age: " + (int?)myHashTable["Alice"]);
}


myHashTable.Remove("Bob");


Console.WriteLine("\nAll Entries:");
foreach (DictionaryEntry pair in myHashTable)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();