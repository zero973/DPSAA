using Newtonsoft.Json;
using System;
using System.Text;

namespace Курсовая_Программные_модули
{
    public class CustomLinkedList<T>
    {

        [JsonProperty]
        private CustomListElement<T> RootElement { get; set; }

        public CustomLinkedList()
        {

        }

        public int Count
        {
            get
            {
                if (RootElement == null)
                    return 0;
                int count = 1;
                var curElement = RootElement;
                for (; curElement.NextItem != null; count++)
                    curElement = curElement.NextItem;
                return count;
            }
        }

        public void AddLast(T value)
        {
            if (RootElement == null)
            {
                RootElement = new CustomListElement<T>(value);
                return;
            }
            var curElement = RootElement;
            while (curElement.NextItem != null)
                curElement = curElement.NextItem;

            curElement.NextItem = new CustomListElement<T>(value, null, curElement);
        }

        public void AddFirst(T value)
        {
            var t = RootElement;
            RootElement = new CustomListElement<T>(value, t, null);
        }

        public T ElementAt(int index)
        {
            if (index >= Count)
                throw new IndexOutOfRangeException();
            var element = RootElement;
            for (int i = 0; i < index; i++)
                element = element.NextItem;
            return element.Value;
        }

        public bool Remove(T value)
        {
            var element = RootElement;
            bool isElementFound = false;
            for (int i = 0; i < Count; i++)
            {
                if (element.Value.Equals(value))
                {
                    isElementFound = true;
                    break;
                }
                element = element.NextItem;
            }

            if (RootElement.NextItem != null)
            {
                if (element.PrevItem == null)
                {
                    RootElement = RootElement.NextItem;
                    RootElement.PrevItem = null;
                    return isElementFound;
                }
                var prevElement = element.PrevItem;
                var nextElement = element.NextItem;
                prevElement.NextItem = nextElement;
                if (nextElement != null)
                    nextElement.PrevItem = prevElement;
            }
            else
                RootElement = null;

            return isElementFound;
        }

        public T First()
        {
            return RootElement.Value;
        }

        public bool Any()
        {
            return RootElement != null;
        }

        public bool Any(Func<T, bool> predicate)
        {
            var element = RootElement;
            for (int i = 0; i < Count; i++)
            {
                if (predicate(element.Value))
                    return true;
                element = element.NextItem;
            }
            return false;
        }

        public CustomLinkedList<T> Where(Func<T, bool> predicate)
        {
            var result = new CustomLinkedList<T>();
            var element = RootElement;
            for (int i = 0; i < Count; i++)
            {
                if (predicate(element.Value))
                    result.AddLast(element.Value);
                element = element.NextItem;
            }
            return result;
        }

        public string Print(string delimeter)
        {
            if (RootElement == null)
                return "";

            StringBuilder result = new StringBuilder();
            var curElement = RootElement;
            while (curElement?.NextItem != null)
            {
                result.Append($"{curElement.Value}{delimeter}");
                curElement = curElement.NextItem;
            }
            result.Append($"{curElement.Value}");

            return result.ToString();
        }
    }
}