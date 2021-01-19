using System;

namespace FTTT
{
    public class First<T>
    {
        public First<TD> Then<TD>()
        {
            return new First<TD>();
        }

        public TD Then<TD>(TD v)
        {
            throw new NotImplementedException();
        }
    }
}