namespace StandardRPG{
    using System.Formats.Asn1;
    using System.Reflection.Metadata.Ecma335;
    using System.Runtime.InteropServices;
    using static System.Console;
    class StandardRPGRunState{
        public static Enemy player = new Enemy();
        static void Main(string[] args){
            Start();
        }
        static void Start(){
            WriteLine("What's your username?");
            player.name = ReadLine();
            bool NumberTest = player.name.Any(Char.IsDigit);
            WriteLine(NumberTest);
            if (NumberTest == true || player.name.Length < 4 || player.name.Length > 16){
                while (NumberTest == true || player.name.Length < 4 || player.name.Length > 16){
                    if (NumberTest == true && player.name.Length < 4){
                        WriteLine("Name cannot contain numbers or be less than 4 characters.");
                    }
                    if (NumberTest == true && player.name.Length > 16){
                        WriteLine("Name cannot contain numbers or exceed 16 characters.");
                    }   
                    else if (NumberTest == true){
                        WriteLine("Name cannot contain numbers.");
                    }
                    else if (player.name.Length < 4){
                        WriteLine("Name cannot be less than 4 characters.");
                    }
                    else if (player.name.Length > 16){
                        WriteLine("Name cannot exceed 16 characters.");
                    }
                    player.name = ReadLine();
                    NumberTest = player.name.Any(Char.IsDigit);
                }
            }
            if (player.name is string){
                WriteLine($"Welcome, '{player.name}'");
                ReadLine();
            }
        }
    }
}