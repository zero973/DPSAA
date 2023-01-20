using Newtonsoft.Json;

namespace Курсовая_Программные_модули
{
    public class ArrayStek<T>
    {

        [JsonProperty]
        private T[] Items;

        [JsonProperty]
        private int CurIndex;

        public ArrayStek(int size)
        {
            Items = new T[size];
            CurIndex = -1;
        }

        public bool IsEmpty()
        {
            return CurIndex == -1;
        }

        public T Peek()
        {
            if (IsEmpty())
                return default(T);

            return Items[CurIndex];
        }

        public bool Add(T item)
        {
            if (CurIndex == Items.Length - 1 || Contains(item))
                return false;

            CurIndex++;
            Items[CurIndex] = item;

            return true;
        }

        public bool Remove()
        {
            if (IsEmpty())
                return false;

            Items[CurIndex] = default(T);
            CurIndex--;

            return true;
        }

        public string Print(string delimeter)
        {
            return string.Join(delimeter, GetNotNullItems());
        }

        public int CountOfNotNullElements()
        {
            int countOfNotNullItems = 0;
            for (int i = 0; i < Items.Length; i++)
                if (!Items[i]?.Equals(default(T)) ?? false)
                    countOfNotNullItems++;

            return countOfNotNullItems;
        }

        private bool Contains(T item)
        {
            foreach (var e in Items)
                if (e?.Equals(item) ?? false)
                    return true;
            return false;
        }

        private T[] GetNotNullItems()
        {
            int index = 0;
            T[] result = new T[CountOfNotNullElements()];
            for (int i = 0; i < Items.Length; i++)
            {
                if (!Items[i]?.Equals(default(T)) ?? false)
                {
                    result[index] = Items[i];
                    index++;
                }
            }

            return result;
        }
    }
}