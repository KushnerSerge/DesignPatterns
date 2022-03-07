using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Double_Check_Locking
    {
        Double_Check_Locking() { }
        private static readonly object locked = new object();
        private static Double_Check_Locking instance = null;
        public static Double_Check_Locking Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (locked)
                    {
                        if (instance == null)
                        {
                            instance = new Double_Check_Locking();
                        }
                    }
                }
                return instance;
            }
        }
    }
}

/*
In the following code, the thread is locked on a shared object and checks whether an instance has been 
    created or not with double checking.
*/