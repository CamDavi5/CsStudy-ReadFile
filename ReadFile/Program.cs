
string[] readText = System.IO.File.ReadAllLines(/*"CoolStoryBro.txt pathname*/);
System.Console.WriteLine("Contents of CoolStoryBro.txt = ");
foreach (string text in readText)
{
    Console.WriteLine("\t" + text);
}
