using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_IComparable_Sorting_
{
    internal class WalletComparePockets : IComparer<Wallet>
    {
        public int Compare(Wallet? x, Wallet? y)
        {
            return x.NumberOfPockets.CompareTo(y.NumberOfPockets);
        }
    }
}
