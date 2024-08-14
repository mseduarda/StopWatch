using System.Threading;

Menu();

static void Menu() {
    Console.Clear();
    Console.WriteLine("ﾟ･✻･ﾟ･✻･ﾟﾟ･✻･ﾟ･✻･ﾟﾟ･✻･ﾟ･✻･ﾟﾟ･✻･ﾟ");
    Console.WriteLine("          STOP WATCH          ");
    Console.WriteLine("ﾟ･✻･ﾟ･✻･ﾟﾟ･✻･ﾟ･✻･ﾟﾟ･✻･ﾟ･✻･ﾟﾟ･✻･ﾟ");
    Console.WriteLine("");
    Console.WriteLine("VOCABULARY:");
    Console.WriteLine("");
    Console.WriteLine("S = seconds => 10s = 10 seconds");
    Console.WriteLine("M = minutes => 1m = 1 minute");
    Console.WriteLine("0 = exit");
    Console.WriteLine("How long do you want to count: ");
    
    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1)); // Take the last caracter (m or s) 
    int time = int.Parse(data.Substring(0, data.Length - 1)); // Take just the numbers of the time
    int multiplier = 1; // Converting variable 

    if (type == 'm') {
        multiplier = 60;
    } if (time == 0) {
        System.Environment.Exit(0);
    }
    PreStart(time * multiplier);
}

static void PreStart(int time) {
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("GO!");
    Thread.Sleep(1000);

    Start(time);
}

static void Start(int time)
{
    int currentTime = 0;

    while(currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(700);
    }

    Console.Clear();
    Console.WriteLine("StopWatch finalized.");
    Thread.Sleep(1500);
    Menu();
}