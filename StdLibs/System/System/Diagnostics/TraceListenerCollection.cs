using System.Collections;

namespace System.Diagnostics
{
    public class TraceListenerCollection : IList
    {
    
        public TraceListener this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public TraceListener this[string name]
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public int Add(TraceListener listener)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(TraceListener[] value)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddRange(TraceListenerCollection value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(TraceListener listener)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(TraceListener[] listeners, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public int IndexOf(TraceListener listener)
        {
             throw new NotImplementedException();
        }
        
        
        public void Insert(int index, TraceListener listener)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(TraceListener listener)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveAt(int index)
        {
             throw new NotImplementedException();
        }



        int IList.Add(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Clear()
        {
            throw new NotImplementedException();
        }

        bool IList.Contains(object value)
        {
            throw new NotImplementedException();
        }

        int IList.IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        bool IList.IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        bool IList.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        void IList.Remove(object value)
        {
            throw new NotImplementedException();
        }

        void IList.RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        object IList.this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        int ICollection.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection.IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        object ICollection.SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
