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
            if (NumberTest == true || player.name.Length <= 3){
                while (NumberTest == true || player.name.Length <= 3){
                    if (NumberTest == true && player.name.Length > 3){
                        WriteLine("Name cannot exclusively contain numbers.");
                    }
                    else if (NumberTest == false && player.name.Length <= 3){
                        WriteLine("Name cannot be shorter than or equal to 3 characters.");
                    }
                    else if (NumberTest == true && player.name.Length <= 3){
                        WriteLine("Name cannot contain numbers or be shorter than or equal to 3 characters.");
                    }
                    player.name = ReadLine();
                    NumberTest = int.TryParse(player.name, out IntTest);
                }
            }
            if (player.name is string){
                WriteLine("right");
                ReadLine();
            }
        }
    }
}