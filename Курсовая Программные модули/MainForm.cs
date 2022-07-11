using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_Программные_модули
{

    public partial class MainForm : Form
    {

        private ArrayStek<SmallProgram> SmallProgramms;
        private LinkedList<Module> Modules;
        private LinkedList<MyProgram> MyPrograms;

        public MainForm()
        {
            InitializeComponent();

            SmallProgramms = new ArrayStek<SmallProgram>(10);
            Modules = new LinkedList<Module>();
            MyPrograms = new LinkedList<MyProgram>();

            MakeTestData();
            ModulesUpdateUI();
        }

        #region Подпрограммы

        private void btnSmallProgramAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateField(tbSmallProgramName))
            {
                ShowMessage("Название Подпрограммы пустое. Пожалуйста, заполните его.");
                return;
            }

            if (!SmallProgramms.Add(new SmallProgram(tbSmallProgramName.Text, (int)nudSmallProgramRowsCount.Value)))
                ShowMessage("Не удалось добавить элемент. Стек полон или элемент с таким названием уже имеется в стеке.");

            SmallProgramUpdateUI();
        }

        private void btnSmallProgramDelete_Click(object sender, EventArgs e)
        {
            if (!SmallProgramms.Remove())
                ShowMessage("Не удалось удалить элемент. Стек пуст.");

            SmallProgramUpdateUI();
        }

        private void btnSmallProgrammsClear_Click(object sender, EventArgs e)
        {
            SmallProgramms = new ArrayStek<SmallProgram>(10);
            tbSmallProgramName.Text = "";
            nudSmallProgramRowsCount.Value = nudSmallProgramRowsCount.Minimum;

            SmallProgramUpdateUI();
        }

        private void SmallProgramUpdateUI()
        {
            lbSmallPrograms.Text = $"Подпрограммы:{Environment.NewLine}{SmallProgramms.Print(Environment.NewLine)}";
        }

        #endregion

        #region Модули

        private void btnLoadModule_Click(object sender, EventArgs e)
        {
            if ((int)nudModuleId.Value >= Modules.Count)
            {
                ShowMessage("Не удалось найти модуль по заданному Id.");
                return;
            }

            var module = Modules.ElementAt((int)nudModuleId.Value);
            tbModuleName.Text = module.Name;
            SmallProgramms = module.SmallPrograms;

            ModulesUpdateUI();
            SmallProgramUpdateUI();
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            if (!ValidateField(tbModuleName))
            {
                ShowMessage("Название модуля пустое. Пожалуйста, заполните его.");
                return;
            }

            CheckModuleData();

            Modules.AddLast(new LinkedListNode<Module>(new Module(tbModuleName.Text, SmallProgramms)));
            SmallProgramms = new ArrayStek<SmallProgram>(10);

            ModulesUpdateUI();
            SmallProgramUpdateUI();
        }

        private void btnModuleEdit_Click(object sender, EventArgs e)
        {
            if ((int)nudModuleId.Value >= Modules.Count)
            {
                ShowMessage("Не удалось найти модуль по заданному Id.");
                return;
            }

            CheckModuleData();

            var module = Modules.ElementAt((int)nudModuleId.Value);
            module.Name = tbModuleName.Text;
            module.SmallPrograms = SmallProgramms;
            SmallProgramms = new ArrayStek<SmallProgram>(10);

            ModulesUpdateUI();
            SmallProgramUpdateUI();
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            if ((int)nudModuleId.Value >= Modules.Count)
            {
                ShowMessage("Не удалось найти модуль по заданному Id.");
                return;
            }

            Modules.Remove(Modules.ElementAt((int)nudModuleId.Value));

            ModulesUpdateUI();
        }

        private void ModulesUpdateUI()
        {
            lbModules.Text = $"Модули:{Environment.NewLine}{string.Join(Environment.NewLine, Modules)}";
        }

        private bool CheckModuleData()
        {
            if (Modules.Where(x => x != Modules.ElementAt((int)nudModuleId.Value)).Any(x => x.Name == tbModuleName.Text))
            {
                ShowMessage("Модуль с таким названием уже есть. Введите другое название");
                return false;
            }

            if (SmallProgramms.IsEmpty())
            {
                ShowMessage("Отсутствуют подпрограммы в модуле. Добавьте их");
                return false;
            }

            return true;
        }

        #endregion

        #region Программы

        private void btnProgramLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnProgramAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnProgramEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnProgramDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private bool ValidateField(TextBox field)
        {
            if (string.IsNullOrEmpty(field.Text) || string.IsNullOrWhiteSpace(field.Text))
                return false;
            return true;
        }

        private void ShowMessage(string text)
        {
            MessageBox.Show(text, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MakeTestData()
        {
            SmallProgramms.Add(new SmallProgram("Подпрога1", 10));
            SmallProgramms.Add(new SmallProgram("Подпрога2", 21));
            SmallProgramms.Add(new SmallProgram("Подпрога3", 30));
            Modules.AddLast(new LinkedListNode<Module>(new Module("Модуль1", SmallProgramms)));
            SmallProgramms = new ArrayStek<SmallProgram>(10);
            SmallProgramms.Add(new SmallProgram("Подпрога4", 13));
            SmallProgramms.Add(new SmallProgram("Подпрога5", 25));
            SmallProgramms.Add(new SmallProgram("Подпрога6", 36));
            Modules.AddLast(new LinkedListNode<Module>(new Module("Модуль2", SmallProgramms)));
            SmallProgramms = new ArrayStek<SmallProgram>(10);
            SmallProgramms.Add(new SmallProgram("Подпрога7", 21));
            SmallProgramms.Add(new SmallProgram("Подпрога8", 45));
            SmallProgramms.Add(new SmallProgram("Подпрога9", 64));
            Modules.AddLast(new LinkedListNode<Module>(new Module("Модуль3", SmallProgramms)));
            SmallProgramms = new ArrayStek<SmallProgram>(10);
        }

    }

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
            var other = obj as SmallProgram;
            return Name.Equals(other.Name);
        }

    }

    public class Module
    {

        public string Name { get; set; }

        public ArrayStek<SmallProgram> SmallPrograms { get; set; }

        public Module(string name, ArrayStek<SmallProgram> smallPrograms)
        {
            Name = name;
            SmallPrograms = smallPrograms;
        }

        public override bool Equals(object obj)
        {
            Module other = obj as Module;
            return other.Name.Equals(Name);
        }

        public override string ToString()
        {
            return $"{Name}: ({SmallPrograms.Print("; ")})";
        }

    }

    public class MyProgram
    {

        public string Name { get; set; }

        public LinkedList<Module> Modules { get; set; }

        public MyProgram(string name, LinkedList<Module> modules)
        {
            Name = name;
            Modules = modules;
        }

        public override bool Equals(object obj)
        {
            Module other = obj as Module;
            return other.Name.Equals(Name);
        }

        public override string ToString()
        {
            return $"{Name}: ({string.Join(". ", Modules)})";
        }

    }

    public class ArrayStek<T>
    {

        private T[] Items;

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
            if (CurIndex == Items.Length-1 || Items.Contains(item))
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
            return string.Join(delimeter, Items.Where(x =>
            {
                return x == null ? false : true;
            }));
        }

    }

}