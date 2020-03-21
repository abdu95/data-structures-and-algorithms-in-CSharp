using System;
using System.Collections;

namespace FirstChapter
{
    public class Collection : CollectionBase
    {
        public void Add(Object item)
        {
            InnerList.Add(item);
        }

        public void Remove(Object item)
        {
            InnerList.Remove(item);
        }
        public new int Count()
        {
            return InnerList.Count;
        }
        public new void Clear()
        {
            InnerList.Clear();
        }
    }
}
