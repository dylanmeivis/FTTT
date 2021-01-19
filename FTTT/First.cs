using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FTTT
{
    public static class First
    {
        public static async Task<T> This<T>(Task<T> callBack)
        {
            var returnValue = await callBack;
            return returnValue;
        }
    }
}
