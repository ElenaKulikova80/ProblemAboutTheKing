namespace ProblemAboutTheKing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bitboard king = new Bitboard(Console.ReadLine());
            Console.Clear();
            king.Print();
            Console.ReadKey();
        }
    }
}
