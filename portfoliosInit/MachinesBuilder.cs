using System.Collections.Generic;

namespace portfoliosInit
{
    class MachinesBuilder
    {
        public static List<Machine> build(List<MachineForm> forms)
        {
            List<Machine> machines = new List<Machine>();

            foreach (var form in forms) {
                if (form.isValid())
                {
                    form.applyChanges();
                    machines.AddRange(form.asMachines());
                }
            }
            return machines;
        }
    }
}
