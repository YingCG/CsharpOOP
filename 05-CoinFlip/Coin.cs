using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class Coin
    {
        public bool isHead { get; set; }
        
        // constructor for a new coint
        public Coin(bool head)
        {
            this.isHead = head;
        }
        public void flipCoin(Random r)
        {
            // randomly choose a new heads or tails value for this coin

            //Random r = new Random();
            if (r.Next(10) > 5)
            {
                this.isHead = true;
            } else
            {
                this.isHead = false;
            }
        }
    }
}
