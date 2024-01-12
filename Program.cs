using Classes;
static void End() => System.Environment.Exit(0);

static void Start()
{
    Console.WriteLine("Welcome to Blackjack");
    Console.WriteLine("Blackjack pays 3/2");
    Console.WriteLine("--------------------------\n");
    Console.WriteLine("Are you 21? Y/N");
    string age = Console.ReadLine();
    if (age.ToUpper() == "Y")
    {
        Console.WriteLine("Great! Let's PLay.");
    }
    else
    {
        Console.WriteLine("Sorry :( You need to be 21 to play.");
        End();
    }
}


static void GamePlay()
{

    string x = "X";
    Random rnd = new Random();
    double bet = 0.0;
    double winnings = 0.0;
    double blackJack = 0.0;
    int cardOne = rnd.Next(1, 12);
    int cardTwo = rnd.Next(1, 12);
    int hand = cardOne + cardTwo;
    int dealerCardOne = rnd.Next(1, 12);
    int dealerCardTwo = rnd.Next(1, 12);
    int dealerHand = dealerCardTwo + dealerCardOne;
    Class Bet = new Class();
    Bet.Bet = bet;
    Class Winnings = new Class();
    Winnings.Winnings = winnings;
    Class BlackJack = new Class();
    BlackJack.BlackJack = blackJack;
    Class player = new Class();
    player.Hand = hand;
    Class Dealer = new Class();
    Dealer.Dealer = dealerHand;

    Console.WriteLine("What is your bet?");
    bet = Convert.ToDouble(Console.ReadLine());
    winnings = bet + bet;
    blackJack = 1.5 * bet;
    Console.WriteLine("--------------------------");

    Console.WriteLine("Dealers hand:");
    Console.Write(dealerCardOne);
    Console.Write("\t" + x + "\n");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Your hand:");

    Console.Write(cardOne);
    Console.Write("\t" + cardTwo + "\n");

    Console.WriteLine("What would you like to do?");
    Console.WriteLine("\t h - Hit");
    Console.WriteLine("\t d - Double");
    Console.WriteLine("\t s - Stand");
    Console.WriteLine("Your choose: ");

    switch (Console.ReadLine())
    {
        case "h":
            int h = rnd.Next(1, 12);
            Console.Write(hand);
            Console.Write("\t" + h + "\n");
            hand += h;
                break;

        case "d":
            int d = rnd.Next(1, 12);
            Console.Write(hand);
            Console.Write("\t" + d + "\n");
            hand += d;
            winnings *= 2;
            break;

        case "s":
            break;

        default:
            Console.WriteLine("Error! Wrong key pressed.");
            End();
            break;
    }

    if (hand > 21)
    {
        Console.WriteLine(hand);
        Console.WriteLine("Bust :(");
        KeepPlaying();
    }
    else if (hand == 21)
    {
        Console.WriteLine(hand);
        Console.WriteLine($"Blackjack! Your winnings ${blackJack}");
        End();
    }
    Console.WriteLine($"Your hand: {hand}");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Dealer's hand");
    Console.Write(dealerCardOne);
    Console.Write("\t" + dealerCardTwo + "\n");
    Console.WriteLine(dealerHand);
    Console.WriteLine("--------------------------");
    Console.WriteLine("Dealer's hand");
    Console.WriteLine("--------------------------");
    switch (dealerHand)
    {
        case < 17:
            int h = rnd.Next(1, 12);
            Console.Write(dealerHand);
            Console.Write("\t" + h + "\n");
            dealerHand += h;
            Console.WriteLine(dealerHand);
            Console.WriteLine("--------------------------");
            break;
        case > 21:
            Console.WriteLine($"Win! :) Your winnings ${winnings}");
            Console.WriteLine("Dealer busts!");
            break;
        default:
            Console.WriteLine(dealerHand);
            break;
    }
    if (dealerHand > 21)
    {
        Console.WriteLine($"Win! :) Your winnings ${winnings}");
        Console.WriteLine("Dealer busts!");
    }
    else if (hand > dealerHand)
    {
        Console.WriteLine($"Your hand: {hand} Dealer's Hand: {dealerHand}");
        Console.WriteLine($"Win! :) Your winnings ${winnings}");
    }else if (hand == dealerHand)
    {
        Console.WriteLine($"Your hand: {hand} Dealer's Hand: {dealerHand}");
        Console.WriteLine("Push :/");
    }
    else
    {
        Console.WriteLine($"Your hand: {hand} Dealer's Hand: {dealerHand}");
        Console.WriteLine("Dealer wins :(");
    }
    
}
static void KeepPlaying()
{
    Console.WriteLine("--------------------------");
    Console.WriteLine("Would You like to continue playing?");
    Console.WriteLine("Y/N");
    string done = Console.ReadLine();
    if (done.ToUpper() == "Y") 
    {
        while(true)
        {
            Execute();
        } 
    }
    else
    {
        End();
    }
}

static void Execute()
{
    Start();
    GamePlay();
    KeepPlaying();
}

Execute();

do
{
    Execute();
} while (true);

