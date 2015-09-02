using System;
using System.Collections.Generic;

namespace portfoliosInit
{
    public class Portfolio
    {
        public String security;
        public String strategy;
        public double sieveParam;

        public List<Machine> machines { get; set; }

        public Portfolio(String security, String strategy, double sieveParam)
        {
            this.strategy = strategy;
            this.security = security;
            this.sieveParam = sieveParam;

            machines = new List<Machine>();
        }

        public void add(Machine machine)
        {
            machines.Add(machine);
        }
    }
}
