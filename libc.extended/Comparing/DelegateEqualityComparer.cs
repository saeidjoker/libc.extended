﻿using System;
using System.Collections.Generic;

namespace libc.extended.Comparing
{
    public class DelegateEqualityComparer<T> : IEqualityComparer<T>
    {
        private readonly Func<T, T, bool> equals;
        private readonly Func<T, int> getHashCode;

        public DelegateEqualityComparer(Func<T, T, bool> equals, Func<T, int> getHashCode)
        {
            this.equals = equals;
            this.getHashCode = getHashCode;
        }

        public bool Equals(T x, T y)
        {
            return equals(x, y);
        }

        public int GetHashCode(T obj)
        {
            return getHashCode(obj);
        }
    }
}