using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class ThreadSafeSingletonWithoutUsingLocks
    {
        private static readonly ThreadSafeSingletonWithoutUsingLocks instance = new ThreadSafeSingletonWithoutUsingLocks();
        static ThreadSafeSingletonWithoutUsingLocks()
        {
        }
        private ThreadSafeSingletonWithoutUsingLocks()
        {
        }
        public static ThreadSafeSingletonWithoutUsingLocks Instance
        {
            get
            {
                return instance;
            }
        }

    }
}
/*
The preceding implementation looks like a very simple code.
This type of implementation has a static constructor, so it executes only once per Application Domain.
It is not as lazy as the other implementation.
*/