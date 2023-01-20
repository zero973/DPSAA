using Newtonsoft.Json;

namespace Курсовая_Программные_модули
{
    public class CustomListElement<T>
    {

        public T Value { get; set; }

        public CustomListElement<T> NextItem { get; set; }

        [JsonIgnore]
        public CustomListElement<T> PrevItem { get; set; }

        public CustomListElement()
        {

        }

        public CustomListElement(T value)
        {
            Value = value;
        }

        public CustomListElement(T value, CustomListElement<T> nextItem, CustomListElement<T> prevItem)
        {
            Value = value;
            NextItem = nextItem;
            PrevItem = prevItem;
        }

    }
}