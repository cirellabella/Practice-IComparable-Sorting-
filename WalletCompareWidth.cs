using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_IComparable_Sorting_
{
    internal class WalletCompareWidth : IComparable<Wallet>
    {
        public WalletCompareWidth()
        {
        }

        public int width { get; set; }

        public int CompareTo(Wallet? other)
        {
            return this.width.CompareTo(other.width) * -1;
        }
    }
}
