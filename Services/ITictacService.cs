namespace TICTAC.Services
{
    public interface ITictacService
    {
        bool CheckTac(int value);
        bool CheckTic(int value);
        bool CheckTicTac(int value);
        string CheckValue(int value);
    }
}