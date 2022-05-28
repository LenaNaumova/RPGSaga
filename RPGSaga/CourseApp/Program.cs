namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            RPGSaga rPGSaga = new RPGSaga();
            rPGSaga.StartGame();
            Console.ReadKey();
        }
    }
}
