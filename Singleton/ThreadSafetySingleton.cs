using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class ThreadSafetySingleton
    {
        ThreadSafetySingleton() { }
        private static readonly object locked = new object();
        private static ThreadSafetySingleton instance = null;
        public static ThreadSafetySingleton Instance
        {
            get
            {
                lock (locked)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafetySingleton();
                    }
                    return instance;
                }
            }
        }
    }
}

/*
The following code is thread-safe.
In the code, the thread is locked on a shared object and checks whether an instance has been created or not. 
It takes care of the memory barrier issue and ensures that only one thread will create an instance. For example: 
Since only one thread can be in that part of the code at a time, by the time the second thread enters it, the first 
    thread will have created the instance, so the expression will evaluate as false.
The biggest problem with this is performance; performance suffers since a lock is required every time an instance
    is requested.
*/

