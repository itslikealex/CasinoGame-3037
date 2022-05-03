using System;

namespace Casino
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int Cash { get; set; }
        public Player(string name, int cash)
        {
            PlayerName = name;
            Cash = cash;
        }
        public void BetCash(int bet)
        {
            Cash -= bet;
        }
        public void PayoutCash(int payout)
        {
            Cash += payout;
        }
        public void Display()
        {
            Console.WriteLine(PlayerName);
            Console.WriteLine(Cash);
        }
    }
}
