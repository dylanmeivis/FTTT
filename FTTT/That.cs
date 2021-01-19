using System;
using System.Threading.Tasks;

namespace FTTT
{
    public class That<T>
    {
        internal T Result { get; set; }

        public That<TD> Then<TD>(Func<TD> v, out TD result)
        {
            result = v();
            return new That<TD>
            {
                Result = v()
            };
        }
        public That<TD> Then<TD>(TD v, out TD result)
        {
            result = v;
            return new That<TD>
            {
                Result = v
            };
        }

        public That<TD> Then<TD>(Func<TD> v)
        {
            return new That<TD>
            {
                Result = v()
            };
        }
        public That<TD> Then<TD>(TD v)
        {
            return new That<TD>
            {
                Result = v
            };
        }

        public T Resolve()
        {
            return Result;
        }
    }
}
