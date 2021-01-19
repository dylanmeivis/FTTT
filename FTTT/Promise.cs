using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FTTT
{
    public class Promise<T>
    {
        private Func<T, Task> p;

        private Task<T> FirstMethod{ get; }
        public Promise(Task<T> firstMethod)
        {
            FirstMethod = firstMethod;
        }

        public Promise(Func<object, Task> p)
        {
            this.p = p;
        }

        public async Task Then(Func<T,Task> callBackMethod)
        {
            var result = await FirstMethod;
            callBackMethod(result).Wait();
        }

        public async Task<T1> Then<T1>(Func<T1, Task<T1>> p)
        {
            return await p;
        }
    }
}
