using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class NoThreatSafeSingleton
    {
        private NoThreatSafeSingleton() { }
        private static NoThreatSafeSingleton instance = null;
        public static NoThreatSafeSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NoThreatSafeSingleton();
                }
                return instance;
            }
        }
    }
}

/*
The following code is not thread-safe.
Two different threads could both have evaluated the test (if instance == null) and found it to be true, 
    then both create instances, which violates the singleton pattern.
*/
