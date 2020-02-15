using System;

namespace battle_ship_in_the_oo_way_a_m
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the game");
            Console.Write("We start the game?");
            string Play = Console.ReadLine();
            Console.WriteLine("We start ships ready for battle!");
            Ship();
            printOcean();
            printBoard(); 

        }
        static void Ship(){
            Ship Destroyer = new Ship ("Destroyer-xx","Destroyer is in the vertical position");
            Ship Submarine = new Ship ("Submarine-xx","Submarine is in the horizontal position");
            Ship Cruiser = new Ship ("Cruiser-xxx","Cruiser is in the vertical position");
            Ship Battleship = new Ship ("Battelship-xxxx","Battelship is in the horizontal position");
            Ship Carrier = new Ship ("Carrier-xxxxx","Carrier is in the vertical position");
            Console.WriteLine();
            Console.WriteLine(Destroyer.name);
            Console.WriteLine(Destroyer.field);
            Console.WriteLine();
            Console.WriteLine(Submarine.name);
            Console.WriteLine(Submarine.field);
            Console.WriteLine();
            Console.WriteLine(Cruiser.name);
            Console.WriteLine(Cruiser.field);
            Console.WriteLine();
            Console.WriteLine(Battleship.name);
            Console.WriteLine(Battleship.field);
            Console.WriteLine();
            Console.WriteLine(Carrier.name);
            Console.WriteLine(Carrier.field);
        }
        static void printOcean(){
            Console.WriteLine("{0}","___________________________________________");
            Console.WriteLine("{0}","1 | A | B | C | D | E | F | G | H | I | K |");
            Console.WriteLine("{0}","  |---|---|---|---|---|---|---|---|---|---|");
            Console.WriteLine("{0}","2 |   | x | x | x | x |   |   |   |   |   |");
            Console.WriteLine("{0}","  |---|---|---|---|---|---|---|---|---|---|");
            Console.WriteLine("{0}","3 |   |   |   |   |   |   |   | x |   |   |");
            Console.WriteLine("{0}","  |---|---|---|---|---|---|---|---|---|---|");
            Console.WriteLine("{0}","4 | x | x |   |   |   |   |   | x |   |   |");
            Console.WriteLine("{0}","  |---|---|---|---|---|---|---|---|---|---|");
            Console.WriteLine("{0}","5 |   |   |   |   |   |   |   | x |   |   |");
            Console.WriteLine("{0}","  |---|---|---|---|---|---|---|---|---|---|");
            Console.WriteLine("{0}","6 | x |   |   | x |   |   |   | x |   |   |");
            Console.WriteLine("{0}","  |---|---|---|---|---|---|---|---|---|---|");
            Console.WriteLine("{0}","7 | x |   |   | x |   |   |   | x |   |   |");
            Console.WriteLine("{0}","  |---|---|---|---|---|---|---|---|---|---|");
            Console.WriteLine("{0}","8 |   |   |   | x |   |   |   |   |   |   |");
            Console.WriteLine("{0}","  |---|---|---|---|---|---|---|---|---|---|");
            Console.WriteLine("{0}","9 |   |   |   |   |   |   |   |   |   |   |");
            Console.WriteLine("{0}","  |---|---|---|---|---|---|---|---|---|---|");
            Console.WriteLine("{0}","10|   |   |   |   |   |   |   |   |   |   |");
            Console.WriteLine("{0}","__|___|___|___|___|___|___|___|___|___|___|");
            Console.WriteLine();
            Console.WriteLine();
        
        }   
            
        static void printBoard()
        {
            Ocean ocean =new Ocean(10,10);
            Square empty = new Square(1,1," ");
            Square full = new Square (1,1,"x");
            char[] letters = { ' ','A',' ', 'B',' ', 'C',' ','D',' ', 'E',' ', 'F',' ', 'G',' ', 'H',' ', 'I',' ', 'K' };
            string str = new string(letters);
            Console.WriteLine(str);
        
                for (int j = 1; j <= ocean.height; j++)
        {
            
            Console.WriteLine("|_|_|_|_|_|_|_|_|_|_| {0}",j);
            
        }
            Console.WriteLine();
            Console.WriteLine();
            
        }
        public void Play()
        {
            String player = new String("*");

        }
    }
}
