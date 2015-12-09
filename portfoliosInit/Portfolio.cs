using System;
using System.Collections.Generic;

namespace portfoliosInit
{
    public class Portfolio
    {
        public enum Strategy
        {
            AveragingStrategy,
            ApproximationStrategy
        };

        public String security { get; set; }
        public String strategy { get; set; }
        public double sieveParam { get; set; }
        public int fillingGapsNumber { get; set; }
        public List<Machine> machines { get; set; }

        public Portfolio()
        {
            machines = new List<Machine>();
            security = "USD-9.16";
            strategy = "";
            sieveParam = 0.0145;
            fillingGapsNumber = 2000;
        }

        public Portfolio(String security, String strategy, double sieveParam, int fillingGapsNumber) : this()
        {
            this.strategy = strategy;
            this.security = security;
            this.sieveParam = sieveParam;
            this.fillingGapsNumber = fillingGapsNumber;
        }

        public void add(Machine machine)
        {
            machines.Add(machine);
        }

        public String print()
        {
            return security + ";" + strategy + ";" + sieveParam.ToString().Replace(',', '.') + ";" + fillingGapsNumber;
        }

        public void unblockAllMachines()
        {
            foreach (var machine in machines)
                machine.blocked = false;
        }

        public String getPortfolioTitle()
        {
            return security + "; " + strategy + "; sieve: " + sieveParam +
                   "; gaps: " + fillingGapsNumber;
        }
    }
}
