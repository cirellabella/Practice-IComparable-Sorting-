namespace Practice_IComparable_Sorting_
{
    internal class Program
    {
        List<Wallet> _wallets;
        static void Main(string[] args)
        {
            List<Wallet> _wallets = new List<Wallet>();
            _wallets.Add(new Wallet("pink", 3, 8, 15, 2, "infiniti", "Forever Wallets", "snakeskin", "checkbook"));
            _wallets.Add(new Wallet("purple", 4, 4, 5, 1, "star", "Galaxy Wallets", "polyester", "bill-fold"));
            _wallets.Add(new Wallet("brown", 3, 3, 8, 0, "lasso", "Cowboy Wallets", "leather", "bill-fold"));
            _wallets.Add(new Wallet("black", 3, 3, 8, 1, "briefcase", "Prof Wallets", "metal", "tri-fold"));
            _wallets.Add(new Wallet("black", 3, 8, 18, 3, "stripes", "Guess Wallets", "fabric", "zippered"));

            DisplayWallets(_wallets, "Unsorted");
            _wallets.Sort();
            DisplayWallets(_wallets, "By Width");

            WalletSort.Pockets wsp = new WalletSort.Pockets();
            _wallets.Sort(wsp);
            DisplayWallets(_wallets, "By Pockets");


            WalletSort.Logo wsl = new WalletSort.Logo();
            _wallets.Sort(wsl);
            DisplayWallets(_wallets, "By Logo");

        }

        public static void DisplayWallets(List<Wallet> wallets, string typeOfSort)
        {
            Console.WriteLine(typeOfSort);
            foreach(Wallet wallet in wallets)
            {
                Console.WriteLine(wallet);
            }
            Console.WriteLine("\n----------------------------\n");
        }
    }
}