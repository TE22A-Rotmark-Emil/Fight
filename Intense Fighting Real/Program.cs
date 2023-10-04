namespace StandardRPG{
    using System.Formats.Asn1;
    using System.Reflection.Metadata.Ecma335;
    using static System.Console;
    class StandardRPGRunState{
        public static Enemy player = new Enemy();
        static void Main(string[] args){
            Start();
        }
        static void Start(){
            WriteLine("What's your username?");
            player.name = ReadLine();
            int IntTest;
            bool NumberTest = int.TryParse(player.name, out IntTest);
            if (NumberTest == true || player.name.Length < 4 || player.name.Length > 17){
                while (NumberTest == true || player.name.Length < 4 || player.name.Length > 17){
                    if (NumberTest == true && player.name.Length < 4){
                        WriteLine("Name cannot exclusively contain numbers or be less than 4 characters.");
                    }
                    else if (NumberTest == true && player.name.Length > 17){
                        WriteLine("Name cannot exclusively contain numbers or exceed 16 characters.");
                    }   
                    else if (NumberTest == true){
                        WriteLine("Name cannot exclusively contain numbers.");
                    }
                    else if (player.name.Length < 4){
                        WriteLine("Name cannot be less than 4 characters.");
                    }
                    else if (player.name.Length >= 16){
                        WriteLine("Name cannot exceed 16 characters.");
                    }
                    player.name = ReadLine();
                    NumberTest = int.TryParse(player.name, out IntTest);
                }
            }
            if (player.name is string){
                WriteLine($"Welcome, '{}'");
                ReadLine();
            }
        }
    }
}