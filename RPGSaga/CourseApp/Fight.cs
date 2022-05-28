namespace CourseApp
{
    using System;

    public class Fight
    {
        public Player Start(Player man1, Player man2)
        {
            while (true)
            {
                Move(man1, man2);

                if (man2.HP <= 0)
                {
                    Console.WriteLine($"{man2.Name} ПРОИГРАЛ!!!");
                    return man2;
                }

                Move(man2, man1);

                if (man1.HP <= 0)
                {
                    Console.WriteLine($"{man1.Name} ПРОИГРАЛ!!!");
                    return man1;
                }
            }
        }

        public void Move(Player man1, Player man2)
        {
            IAbbility attack = man1.Attack();
            man2.GetAttack(attack);
            Console.WriteLine($"{man1.Name} использует {attack.Name}, наносит урон {attack.Damage} противнику {man2.Name} и оставляет ему {man2.HP} здоровья");
        }
    }
}
