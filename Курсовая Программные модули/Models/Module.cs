namespace Курсовая_Программные_модули
{
    public class Module
    {

        public string Name { get; set; }

        public CustomLinkedList<SmallProgram> SmallPrograms { get; set; }

        public Module(string name, CustomLinkedList<SmallProgram> smallPrograms)
        {
            Name = name;
            SmallPrograms = smallPrograms;
        }

        public override bool Equals(object obj)
        {
            Module other = obj as Module;
            return other?.Name.Equals(Name) ?? false;
        }

        public override string ToString()
        {
            return $"{Name}: ({SmallPrograms.Print("; ")})";
        }

    }
}