using System;

namespace portfoliosInit
{
    public class Machine
    {
        public static String buy = "B";
        public static String sell = "S";
        public static String neutral = "N";

        public Int32 depth;
        public String position;
        public Boolean blocked;

        public Machine(Int32 depth, string position, Boolean blocked)
        {
            this.depth = depth;
            this.position = position;
            this.blocked = blocked;
        }

        public String print()
        {
            return depth + ";" + position + ";" + (blocked ? "1" : "0");
        }
    }
}
