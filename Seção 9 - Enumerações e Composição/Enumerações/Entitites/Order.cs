﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerações.Entitites.Enums;


namespace Enumerações.Entitites
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }

        public  OrderStatus Status { get; set; }


        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }
    }

}
