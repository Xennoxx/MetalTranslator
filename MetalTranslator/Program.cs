//SCREEEEAAAAAAAAAAAAAAMMMMMMMMMMMMMM!!!!!
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Hello! ... ");
Console.ReadKey();
Console.WriteLine("Today i will show you how you can Scream in C#! ...");
Console.ReadKey();
Console.Write("Okay... just write a little bit about you toughts: ");
string input = Convert.ToString(Console.ReadLine());
Console.Clear();

       input.ToUpper();
Console.WriteLine("Nice ... thanks ... just give me a couple of sec's");
Console.ReadKey();
Console.WriteLine(" ... ");
Console.ReadKey();
if (input == "")
{
    do
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Ą̶̱͈̲̮̩͚̮͚̼͖̣̝̾̈́͊̆̿̾͐̇̓̆̉̎r̷̡̡͎̗͓̜̗͙̹͈͔̙̥͚̓͂̿͛ê̷̛̹̬̯̈́̚ ̵̭͎̺̰̀͌̏͂͗͌̑͝y̷̛̼̘͇̍̃̇̉̋̃̋͆̽͊̌̆͝͝ǫ̶̨̘͇͖̗͉̜̤̱̦̙͚̞̾̈́̒̏̈̊́̆̽͜͠u̵̧̨̡̳̻͔̤͕̻̙͕̯͒̍̋͆̂̒̅̃͘͜ ̶̢͈̮̼͍͚̱̹̣̑͒͆̍̿̆̇̕ķ̷̧̧̛̛̹̥̟̟̤̻͙̘̯͎̿̄̄̆ͅi̵̧̨͚͈̲͎̣̼̘̟̳̠̟͗̿͛̅̿͆̄̎́͘͘͜͝d̵̻́̋̄̊̑͊̑̈́͝͠ͅd̸̡̛̳̱͙͇̮͚̠̪͔̃̉̄͑̓̅̏̽̓͆̚į̶̤̹͖̩̘͉̥̈́́̄̄́̃̐͑̕̚n̴̨̲͚̹̱̗̆͊̔̑̈́͗̕̕͠ǵ̷̛͕̹̻̂́̇ ̶͕͉̰̂̐͋̈́̈́̇̓̒͜ͅm̸͚̺̗͚͕͎̳̙͆̃͝e̵̢̛̯͔͓̹̩̪͖͍̙̜͛͑̈́͗̾͋̌̈́̾͜͝͝ͅͅ?̴̨͈̭̩̞͎̾͗͋̀́̉̚!̵̨̧̛̳͕̲̔̀̿̏͆̃͐͝");
    } while (true);
}

else
{
    Console.WriteLine("Okay... ");
    Console.ReadKey();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(input + "!");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Thankys <3");
    Console.ReadKey();
}