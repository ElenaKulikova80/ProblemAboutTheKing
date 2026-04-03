namespace ProblemAboutTheKing;

internal class Bitboard
{
    protected ulong bb = 0;
    public virtual void Steps() { }
    public Bitboard (ulong mask)
    {
        bb = mask;
    }
    public Bitboard(string s)
    {
        int point;
        s = s.ToUpper();
        try
        {
            point = int.Parse(s);
        }catch
        {
            try
            {
                point = (s[0] - 'A') + (s[1] - '1') * 8;
            }catch(Exception ex)
            {
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(ex.Message);
                return;
            }
            bb = (ulong)1 << point;
        }
    }
    public void Print(int row = 0)
    {
        Console.SetCursorPosition(0, row);
        bool color = false;
        for (int i = 8; i > 0; i--)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(i.ToString() + ": ");

            for (int j = 0; j < 8; j++)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                if (color)
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                else
                    Console.BackgroundColor = ConsoleColor.White;
                if ((bb & ((ulong)1 << ((i - 1) * 8 + j))) > 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write(" " + ((i - 1) * 8 + j).ToString().PadLeft(2, ' ') + " ");
                color = !color;
            }
            color = !color;
            Console.WriteLine();
        }
        Console.BackgroundColor = ConsoleColor.White;
        Console.Write("    ");
        for (int i = 0; i < 8; i++)
        {
            Console.Write((char)('A' + i) + "  ");
        }
        Console.WriteLine();
        Console.SetCursorPosition(0, 10 + row);
    }
    
}
