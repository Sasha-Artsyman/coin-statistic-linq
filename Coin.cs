namespace CoinStatistic
{
    internal class Coin
    {
        int sideUp;
        Random rnd = new Random();

        public void toss()
        {
            // Get a random value, 0 or 1.
            this.sideUp = rnd.Next(2);
        }
        public int getSideUp()
        {
            return sideUp;
        }
    }
}