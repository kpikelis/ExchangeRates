﻿using System;

namespace SEB.WebServiceIntegration.Models
{
    public class IntgrExchangeRatesItem
    {
        public DateTime Date { get; set; }
        public string Currency { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public string Unit { get; set; }
    }
}
