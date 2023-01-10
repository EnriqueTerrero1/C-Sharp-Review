using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewBasicConceptsCSharp
{
    public class CollectionInitializer<T>
    {
        private T[] collection;

        public CollectionInitializer(int collectionLenght)
        {
            collection = new T[collectionLenght];
        }

        public void AddElementsToCollection(params T[] elements)
        {
            for(int i = 0; i < elements.Length; i++)
            {
                collection[i] = elements[i];
            }
        }

        public T[] RetrieveAllElements()
        {
            return collection;
        }

        public T RetrieveElementOnIndex(int index)
        {
            return collection[index];
        }
    }
}
