using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_Программные_модули
{
    public class MyProgram
    {

        public string Name { get; set; }

        public CustomLinkedList<Module> Modules { get; set; }

        public MyProgram(string name, CustomLinkedList<Module> modules)
        {
            Name = name;
            Modules = modules;
        }

        public override bool Equals(object obj)
        {
            MyProgram other = obj as MyProgram;
            return other?.Name.Equals(Name) ?? false;
        }

        public override string ToString()
        {
            return $"{Name}: ({Modules.Print(". ")})";
        }

    }
}