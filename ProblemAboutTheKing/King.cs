namespace ProblemAboutTheKing;

internal class King:Bitboard
{
    public King(string s) : base(s) { }
    public King(ulong mask) : base(mask) { }
    public override void Steps()
    {
        ulong mask = (bb & 0x7F7F7F7F7F7F7F7F) << 1;
        mask |= (bb & 0xFEFEFEFEFEFEFEFE) >> 1;
        mask |= (bb << 8);
        mask |= (bb >> 8);
        mask |= (bb & 0xFEFEFEFEFEFEFEFE) >> 9;
        mask |= (bb & 0xFEFEFEFEFEFEFEFE) << 7;
        mask |= (bb & 0x7F7F7F7F7F7F7F7F) << 9;
        mask |= (bb & 0x7F7F7F7F7F7F7F7F) >> 7;
        bb = mask;
    }
}
