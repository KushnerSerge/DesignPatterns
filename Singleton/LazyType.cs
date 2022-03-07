
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class LazyType
    {
        private LazyType()
        {
        }
        private static readonly Lazy<LazyType> lazy = new Lazy<LazyType>(() => new LazyType());
        public static LazyType Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
