using System;

namespace FTTT
{
    public static class First
    {
        public static That<T> This<T>(Func<T> v, out T result)
        {
            result = v();
            return new That<T>
            {
                Result = v()
            };
        }

        public static That<T> This<T>(T v, out T result)
        {
            result = v;
            return new That<T>
            {
                Result = v
            };
        }

        public static That<T> This<T>(Func<T> v)
        {
            return new That<T>
            {
                Result = v()
            };
        }
        public static That<T> This<T>(T v)
        {
            return new That<T>
            {
                Result = v
            };
        }
    }
}
