using System;

namespace portfoliosInit
{
    public class Machine
    {
        public Int32 depth;
        public String position;
        public Boolean blocked;

        public Machine(Int32 depth, string position, Boolean blocked)
        {
            this.depth = depth;
            this.position = position;
            this.blocked = blocked;
        }
    }
}
