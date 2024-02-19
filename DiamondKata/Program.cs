using DiamondKata;

if (args.Length == 0)
    Console.WriteLine("Please provide a letter from A to Z");
else
    Console.WriteLine(new Diamond(args[0][0]));