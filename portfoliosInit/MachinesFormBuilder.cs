using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portfoliosInit
{
    class MachinesFormBuilder
    {
        public static List<MachinesForm> build(Portfolio portfolio)
        {
            List<MachinesForm> machinesForms = new List<MachinesForm>();

            int index = 0;
            Dictionary<Int32, List<Machine>> map = collect(portfolio);
            foreach (var depth in map.Keys)
            {
                List<Machine> machines;
                map.TryGetValue(depth, out machines);

                machinesForms.Add(new MachinesForm(depth.ToString(), machines.Count.ToString(), info(machines), index++));
            }

            return machinesForms;
        }

        private static Dictionary<Int32, List<Machine>> collect(Portfolio portfolio)
        {
            Dictionary<Int32, List<Machine>> map  = new Dictionary<int, List<Machine>>();

            foreach (var machine in portfolio.machines)
            {
                if (!map.ContainsKey(machine.depth))
                    map.Add(machine.depth, new List<Machine>());

                List<Machine> list;
                map.TryGetValue(machine.depth, out list);
                list.Add(machine);
            }

            return map;
        }

        private static String info(List<Machine> machines)
        {
            int buyCounter = 0, sellCounter = 0, neutralCounter = 0, blockedCounter = 0;
            foreach (var machine in machines)
            {
                if (machine.position == "S")
                    sellCounter++;

                if (machine.position == "B")
                    buyCounter++;

                if (machine.position == "N")
                    neutralCounter++;

                if (machine.blocked)
                    blockedCounter++;
            }

            String response = "";

            if (buyCounter != 0)
                response += buyCounter + "Buy ";

            if (sellCounter != 0)
                response += sellCounter + "Sell ";

            if (neutralCounter != 0)
                response += neutralCounter + "Neutral ";

            if (blockedCounter != 0)
                response += blockedCounter + "Blocked";

            return response;
        }
    }
}
