namespace Курсовая_Программные_модули
{
    public class SmallProgram
    {

        public string Name { get; set; }

        public int CountOfRows { get; set; }


        public SmallProgram(string name, int countOfRows)
        {
            Name = name;
            CountOfRows = countOfRows;
        }

        public override string ToString()
        {
            return $"{Name} - {CountOfRows}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var other = obj as SmallProgram;
            return Name.Equals(other.Name);
        }

    }
}