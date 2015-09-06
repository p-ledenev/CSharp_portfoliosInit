using System;
using System.Collections.Generic;

namespace portfoliosInit
{
    class MachineFormsBuilder
    {
        public static List<MachineForm> build(Portfolio portfolio)
        {
            List<MachineForm> machinesForms = new List<MachineForm>();

            int index = 0;
            Dictionary<Int32, List<Machine>> map = collect(portfolio);
            foreach (var depth in map.Keys)
            {
                List<Machine> machines;
                map.TryGetValue(depth, out machines);

                machinesForms.Add(MachineForm.createFrom(depth, index++, machines));
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
    }
}
