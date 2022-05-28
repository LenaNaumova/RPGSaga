namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class RPGSaga
    {
        private Queue<Player> players = new Queue<Player>(); // Очередь

        private List<string> names = new List<string>()
        {
            "Vlad", "Misha", "Nikita", "Kirill", "SterLena",
        };

        private Random rand = new Random();

        public void Choice(string name, int hp, int strength, int role)
        {
            switch (role)
            {
                case 1:
                    {
                        players.Enqueue(new Archer(name, hp, strength));
                        break;
                    }

                case 2:
                    {
                        players.Enqueue(new Knight(name, hp, strength));
                        break;
                    }

                case 3:
                    {
                        players.Enqueue(new Wizard(name, hp, strength));
                        break;
                    }
            }
        }

        public void StartGame()
        {
            for (int i = 0; i < 2; i++)
            {
                Choice(names[rand.Next(names.Count)], 66, 3, rand.Next(3));
            }

            Fight fight = new Fight();

            while (players.Count > 1)
            {
                players.Enqueue(fight.Start(players.Dequeue(), players.Dequeue()));
            }
        }
    }
}
