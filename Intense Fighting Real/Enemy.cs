namespace StandardRPG
{
    class Enemy
    {
        public static Enemy player;

        public string? name;
        public float enemyPower;
        public int Health = 20;
        public int Attack = 1;
        public int Defence = 1;
        public float DodgeChance = 0.25f;
        Random generator = new Random();

        public void EnemyController()
        {
            if (this != player)
            {
                enemyPower = generator.Next(2,5) * 0.1f;
                Health = (int)(Health * enemyPower);
                Attack = (int)(Attack * enemyPower);
                Defence = 0;
                DodgeChance *= enemyPower;
                
            }
        }
    }
}