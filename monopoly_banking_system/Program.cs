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

    string playerName  = Console.ReadLine();

    Player player = new Player(i, playerName, startingBalance);

    players.Add(player);
}
