using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_IComparable_Sorting_
{
    internal class WalletCompareZippers : IComparable<Wallet>
    {
        public int numberOfZippers;

        public WalletCompareZippers()
        {

        }

        public int CompareTo(Wallet? other)
        {
            if (numberOfZippers > other.numberOfZippers)
            {
                return -1;
            }
            else if (numberOfZippers < other.numberOfZippers)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            //return this.numberOfZippers.CompareTo(other.numberOfZippers);
        }
    }
}
