using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_IComparable_Sorting_
{
    public static class WalletSort
    {
        public class Pockets : IComparer<Wallet>
        {
            int IComparer<Wallet>.Compare(Wallet? x, Wallet? y)
            {
                return x.NumberOfPockets.CompareTo(y.NumberOfPockets);
            }
        }//pockets

        public class Logo : IComparer<Wallet>
        {
            int IComparer<Wallet>.Compare(Wallet? x, Wallet? y)
            {
                return -(x.Logo.CompareTo(y.Logo));
            }
        }


    }//class
}//namespace
