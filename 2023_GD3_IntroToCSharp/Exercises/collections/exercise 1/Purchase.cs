using GD.Controller;
using GD.Core.Graphics;
using GD.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GD
{
    public class Purchase 
{
    private static int NEXT_ID= 0;
        public readonly int id;
        public readonly int price;
        public readonly int quantity;
        public readonly long time;
        public readonly string description;

        public Purchase(int price, int quantity, string description)
        {
            this.id = NEXT_ID++;
            this.price = price;
            this.quantity = quantity;
            this.time = DateTime.Now.Ticks;
            this.description = description;
        }
    } 


}