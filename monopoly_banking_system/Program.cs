using monopoly_banking_system;

Console.WriteLine("Enter number of players");

string playerCount = Console.ReadLine();

int numberOfPlayers = Convert.ToInt32(playerCount);

List<Player> players = new List<Player>();

Console.WriteLine("Please enter starting balance of players");

string balance = Console.ReadLine();

int startingBalance = Convert.ToInt32(balance) * 100;

for (int i = 1; i <= numberOfPlayers; i++)
{
    Console.WriteLine($"Please enter player {i}");

    string playerName = Console.ReadLine();

    Player player = new Player(i, playerName, startingBalance);

    players.Add(player);
}

bool running = true;

while (running)
{
    Console.WriteLine("Please enter a command");

    Console.WriteLine("1. Print player details");

    Console.WriteLine("2. Issue go pass credits");

    Console.WriteLine("3. Collect rent for player");

    Console.WriteLine("4. Sell property");

    Console.WriteLine("5. Sell house");

    string command = Console.ReadLine();
    
    Console.WriteLine(command);
}