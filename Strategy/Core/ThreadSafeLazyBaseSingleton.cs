
using System;

namespace Strategy.Core
{
    public abstract class ThreadSafeLazyBaseSingleton<T>
        where T : new()
    {
        private static readonly Lazy<T> Lazy = new Lazy<T>(() => new T());
    
        public static T Instance
        {
            get
            {
                return Lazy.Value;
            }
        }
    }
}