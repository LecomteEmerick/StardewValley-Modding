﻿/*
    Copyright 2016 Cody R. (Demmonic)

    Storm is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Storm is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Storm.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using Storm.StardewValley.Wrapper;

namespace Storm.Collections
{
    public class DualProxyDictionary<TOKey, TKey, TOValue, TValue> : System.Collections.Generic.IDictionary<TKey, TValue> where TKey : Wrapper where TValue : Wrapper
    {
        public delegate W Wrap<V, W>(V val);

        private readonly IDictionary real;

        private readonly Wrap<TOKey, TKey> keyWrapper;
        private readonly Wrap<TOValue, TValue> valueWrapper;

        public DualProxyDictionary(IDictionary real, Wrap<TOKey, TKey> keyWrapper, Wrap<TOValue, TValue> valueWrapper)
        {
            this.real = real;
            this.keyWrapper = keyWrapper;
            this.valueWrapper = valueWrapper;
        }

        public ICollection<TKey> Keys
        {
            get
            {
                var list = new List<TKey>();
                foreach (var key in real.Keys)
                {
                    list.Add(keyWrapper((TOKey)key));
                }
                return list;
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                var list = new List<TValue>();
                foreach (var value in real.Values)
                {
                    list.Add(valueWrapper((TOValue)value));
                }
                return list;
            }
        }

        public int Count
        {
            get
            {
                return real.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                return valueWrapper((TOValue)real[key.Underlying]);
            }

            set
            {
                real[key.Underlying] = value.Underlying;
            }
        }

        public bool ContainsKey(TKey key)
        {
            return real.Contains(key.Underlying);
        }

        public void Add(TKey key, TValue value)
        {
            real.Add(key.Underlying, value.Underlying);
        }

        public bool Remove(TKey key)
        {
            if (!ContainsKey(key)) return false;
            real.Remove(key.Underlying);
            return true;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            if (!ContainsKey(key))
            {
                value = default(TValue);
                return false;
            }
            value = this[key];
            return true;
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            real.Add(item.Key.Underlying, item.Value.Underlying);
        }

        public void Clear()
        {
            real.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            foreach (var key in real.Keys)
            {
                if (key.Equals(item.Key.Underlying) && real[key].Equals(item.Value.Underlying))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            foreach (var key in real.Keys)
            {
                if (key.Equals(item.Key.Underlying) && real[key].Equals(item.Value.Underlying))
                {
                    real.Remove(key);
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}