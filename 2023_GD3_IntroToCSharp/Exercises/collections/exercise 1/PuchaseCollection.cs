using GD.Controller;
using GD.Core.Graphics;
using GD.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GD
{
    public class PurchaseCollection 
    {
        static public void Main(String[] args)
        {
            SortedSet<Purchase> list = new SortedSet<Purchase>(new PurchaseComparer());
            list.Add(new Purchase(4, 2, "amazing new coins"));
            list.Add(new Purchase(6, 5, " sparlking rare gems"));
            list.Add(new Purchase(8, 2, "powerful healing potions"));
            list.Add(new Purchase(2, 8, "warding amulet, common"));
            foreach(Purchase purchase in list)
            {
                Console.WriteLine(purchase.time+" "+purchase.price);

            }
            
        }

        private class PurchaseComparer : IComparer<Purchase> {
            public int Compare(Purchase x, Purchase y)
            {

                return (int)((x.time - y.time) * 100 + x.price - y.price);
            }
        }
      
    }

    
}