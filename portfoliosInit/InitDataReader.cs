using System;
using System.Collections.Generic;
using System.IO;

namespace portfoliosInit
{
    class InitDataReader
    {
        // TODO create default list if not exist

        public static List<Portfolio> read()
        {
            String[] lines = File.ReadAllLines("data/init.dat");

            List<Portfolio> portfolios = new List<Portfolio>();
            Portfolio portfolio = null;
            foreach (var line in lines)
            {
                if (String.IsNullOrEmpty(line))
                    continue;

                String[] attrs = line.Split(';');

                int value;
                if (!Int32.TryParse(attrs[0], out value))
                {
                    portfolio = new Portfolio(attrs[0], attrs[1], Double.Parse(attrs[2]));
                    portfolios.Add(portfolio);
                }

                portfolio.add(new Machine(value, attrs[1], (Int32.Parse(attrs[2]) == 1)));
            }

            return portfolios;
        }
    }
}
