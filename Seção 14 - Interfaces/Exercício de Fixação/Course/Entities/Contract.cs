﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course.Entities
{
    internal class Contract
    {
        public int Number {  get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

       public void AddInstallemnt(Installment installment)
        {
            Installments.Add(installment);
        }

    }
}
