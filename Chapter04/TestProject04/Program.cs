class Program
{
    static void Main(string[] args)
    {
        Random random                       = new Random();
        string playerName                   = "";
        string playerOccupation             = "";
        string[] npcList                    = ["John", "Jack", "Sussie", "Guillermo"];
        string[] financialOperationNature   = ["Trade Goods", "Trade Stocks", "Trade Crypto", "Trade Real Estate", "Order Production Of Goods", "Order Creative Activity"];
        string[] financialOperationType     = ["Buy", "Sell"];
        
        AskUserForTheirName();

        Entrepreneur newPlayer = new Entrepreneur{ Name = playerName };

        CreatePlayer();

        while (newPlayer.Energy > 0)
        {
            RandomActivity(newPlayer);
            int consumeEnergy = random.Next(10, 31);
            newPlayer.Energy -= consumeEnergy;
        }

        Console.WriteLine("");
        Console.WriteLine($"You are too tired, your energy is {newPlayer.Energy}");






        void AskUserForTheirName()
        {
            Console.WriteLine("Enter your name: ");
            playerName = Console.ReadLine();
            Console.WriteLine("");

            while (playerName == "")
            {
                Console.WriteLine("Well, we MUST call you somehow... What will it be?");
                Console.WriteLine("Enter your name: ");
                playerName = Console.ReadLine();
                Console.WriteLine("");
            }
        }


        void CreatePlayer()
        {
            Console.WriteLine("Choose your desired occupation:");
            Console.WriteLine("1 - Goods Trader");
            Console.WriteLine("2 - Stocks Trader");
            Console.WriteLine("3 - Crypto Trader");
            Console.WriteLine("4 - Real Estate");
            Console.WriteLine("5 - Production");
            Console.WriteLine("6 - Creator");
            playerOccupation = Console.ReadLine();
            Console.WriteLine("");


            switch (Int32.Parse(playerOccupation))
            {
                case 1:
                    newPlayer.TradingGoods      += 10;
                    break;
                case 2:
                    newPlayer.TradingStocks     += 10;
                    break;
                case 3:
                    newPlayer.TradingCrypto     += 10;
                    break;
                case 4:
                    newPlayer.RealEstateSkill   += 10;
                    break;
                case 5:
                    newPlayer.ProductionSkill   += 10;
                    break;
                case 6:
                    newPlayer.CreativitySkill   += 10;
                    break;
                default:
                    newPlayer.CheckStats();
                    break;
            }

            newPlayer.CheckStats();
            Console.WriteLine("");
        }


        void RandomActivity(Entrepreneur player)
        {
            int nameIndex   = random.Next(0, npcList.Length);
            string npcName  = npcList[nameIndex];

            int operationNatureIndex = random.Next(0, financialOperationNature.Length);
            string operationNature = financialOperationNature[operationNatureIndex];

            int operationTypeIndex = random.Next(0, financialOperationType.Length);
            string operationType = financialOperationType[operationTypeIndex];

            int price = random.Next(0, 101);
            
            Console.Write($"Hello, {player.Name}! ");
            Console.Write($"{npcName} wants to {operationNature} with you. He wants to {operationType} for {price}\n");
            Console.WriteLine("Do you agree? Y/N");
            Console.WriteLine($"Your funds: {player.Score}");
            Console.WriteLine($"Your energy: {player.Energy}");
            string tradeAnswer = Console.ReadLine();

            if (tradeAnswer.ToLower() == "y")
            {
                if (operationType == "Buy")
                {
                    player.Score += price;
                    Console.WriteLine($"New Score after BUY trade: {player.Score}\n");
                }
                else if (operationType == "Sell" && player.Score >= price)
                {
                    player.Score -= price;
                    Console.WriteLine($"New score after SELL trade: {player.Score}\n");
                }
                else if (operationType == "Sell" && player.Score <= price)
                {
                    Console.WriteLine($"Not enough money! Score: {player.Score}\n");
                }
            }
            else if (tradeAnswer.ToLower() == "n")
            {
                Console.WriteLine("Sure. You're the boss!");
                Console.WriteLine($"You refused to trade. Score: {player.Score}\n");
            }

        }
    }
}



// Random random = new Random();

// Console.WriteLine("Enter your name: ");
// string playerName = Console.ReadLine();
// Console.WriteLine("");



// Entrepreneur newPlayer = new Entrepreneur{ Name = playerName };



// Console.WriteLine("Choose your desired occupation:");
// Console.WriteLine("1 - Goods Trader");
// Console.WriteLine("2 - Stocks Trader");
// Console.WriteLine("3 - Crypto Trader");
// Console.WriteLine("4 - Real Estate");
// Console.WriteLine("5 - Production");
// Console.WriteLine("6 - Creator");
// string playerOccupation = Console.ReadLine();
// Console.WriteLine("");


// switch (Int32.Parse(playerOccupation))
// {
//     case 1:
//         newPlayer.TradingGoods      += 10;
//         break;
//     case 2:
//         newPlayer.TradingStocks     += 10;
//         break;
//     case 3:
//         newPlayer.TradingCrypto     += 10;
//         break;
//     case 4:
//         newPlayer.RealEstateSkill   += 10;
//         break;
//     case 5:
//         newPlayer.ProductionSkill   += 10;
//         break;
//     case 6:
//         newPlayer.CreativitySkill   += 10;
//         break;
//     default:
//         newPlayer.CheckStats();
//         break;
// }


// Console.WriteLine("Choose difficulty:");
// Console.WriteLine("1 - Easy");
// Console.WriteLine("2 - Medium");
// Console.WriteLine("3 - Hard");
// string playerDifficulty = Console.ReadLine();
// Console.WriteLine("");



// newPlayer.CheckStats();
// Console.WriteLine("");




class Entrepreneur
{
    private string _name                = "";
    private int _energy;
    private int _score;               
    private int _tradingGoods           = 0;
    private int _tradingStocks          = 0;
    private int _tradingCrypto          = 0;
    private int _realEstateSkill        = 0;
    // private int _retailSkill         = 0;
    private int _productionSkill        = 0;
    private int _creativitySkills       = 0;

    public string Name          { get; set; }
    public int Energy           { get; set; } = 100;
    public int Score            { get; set; } = 200;
    public int TradingGoods     { get; set; }
    public int TradingStocks    { get; set; }
    public int TradingCrypto    { get; set; }
    public int RealEstateSkill  { get; set; }
    // public int RetailSkill { get; set; }
    public int ProductionSkill  { get; set; }
    public int CreativitySkill  { get; set; }

    public void CheckStats() => Console.WriteLine($"Name: {Name}\nTrading:\n\tGoods: {TradingGoods}\n\tStocks: {TradingStocks}\n\tCrypto: {TradingCrypto}\nReal Estate: {RealEstateSkill}\nProduction: {ProductionSkill}\nCreativity: {CreativitySkill}");
    public void CheckEnergy() => Console.WriteLine($"You have {Energy} left");
    public void CheckScore() => Console.WriteLine($"Current score is: {Score}");
}

enum TradingOperation
{
    Buy,
    Sell
}