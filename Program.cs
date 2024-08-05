using System.Threading;

Menu();
Start(10);

static void Menu() {
    Console.Clear();
    Console.WriteLine("[S] = seconds => 10s = 10 seconds");
    Console.WriteLine("[M] = minutes => 1m = 1 minute");
    Console.WriteLine("[0] = exit");
    Console.WriteLine("How long do you want to count?");
    
    string data = Console.ReadLine().ToLower();
    Console.WriteLine(data);
}

static void Start(int time)
{
    int currentTime = 0;

    while(currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("StopWatch finalized.");
    Thread.Sleep(2500);
}