using System;
using System.Collections.Generic;

namespace portfoliosInit
{
    class MachineAmount
    {
        public Int32 amount { get; set; }
        private String position;

        public static MachineAmount buy()
        {
            return new MachineAmount(0, Machine.buy);
        }

        public static MachineAmount sell()
        {
            return new MachineAmount(0, Machine.sell);
        }

        public static MachineAmount neutral()
        {
            return new MachineAmount(0, Machine.neutral);
        }

        public MachineAmount()
            : this(0, Machine.neutral)
        {
        }

        public MachineAmount(Int32 amount, String position)
        {
            this.amount = amount;
            this.position = position;
        }

        public List<Machine> asMachines(Int32 depth)
        {
            List<Machine> machines = new List<Machine>();

            for (int i = 0; i < amount; i++)
                machines.Add(new Machine(depth, position, false));

            return machines;
        }

        public bool isZero()
        {
            return amount == 0;
        }

        public void increment()
        {
            add(1);
        }

        public String print()
        {
            if (isZero())
                return "";

            return amount + position;
        }

        public void add(int amount)
        {
            this.amount += amount;
        }

        public bool decrease()
        {
            if (amount == 0)
                return false;

            add(-1);

            return true;
        }
    }
}
