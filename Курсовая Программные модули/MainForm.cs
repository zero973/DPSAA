using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
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
            UpdateUI();
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

            UpdateUI();
        }

        private void btnSmallProgramDelete_Click(object sender, EventArgs e)
        {
            if (!SmallProgramms.Remove())
                ShowMessage("Не удалось удалить элемент. Стек пуст.");

            UpdateUI();
        }

        private void btnSmallProgrammsClear_Click(object sender, EventArgs e)
        {
            SmallProgramms = new ArrayStek<SmallProgram>(10);
            tbSmallProgramName.Text = "";
            nudSmallProgramRowsCount.Value = nudSmallProgramRowsCount.Minimum;

            UpdateUI();
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

            UpdateUI();
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            if (!ValidateField(tbModuleName))
            {
                ShowMessage("Название модуля пустое. Пожалуйста, заполните его.");
                return;
            }

            CheckModuleData(false);

            Modules.AddLast(new LinkedListNode<Module>(new Module(tbModuleName.Text, SmallProgramms)));
            SmallProgramms = new ArrayStek<SmallProgram>(10);

            UpdateUI();
        }

        private void btnModuleEdit_Click(object sender, EventArgs e)
        {
            if ((int)nudModuleId.Value >= Modules.Count)
            {
                ShowMessage("Не удалось найти модуль по заданному Id.");
                return;
            }

            if (!CheckModuleData(true))
                return;

            var module = Modules.ElementAt((int)nudModuleId.Value);
            module.Name = tbModuleName.Text;
            module.SmallPrograms = SmallProgramms;
            SmallProgramms = new ArrayStek<SmallProgram>(10);

            UpdateUI();
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            if ((int)nudModuleId.Value >= Modules.Count)
            {
                ShowMessage("Не удалось найти модуль по заданному Id.");
                return;
            }

            Modules.Remove(Modules.ElementAt((int)nudModuleId.Value));

            UpdateUI();
        }

        private bool CheckModuleData(bool isCheckYourself)
        {
            if (Modules.Where(x => isCheckYourself ? x != Modules.ElementAt((int)nudModuleId.Value) : true)
                .Any(x => x.Name == tbModuleName.Text))
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
            if ((int)nudProgramId.Value >= MyPrograms.Count)
            {
                ShowMessage("Не удалось найти программу по заданному Id.");
                return;
            }

            var program = MyPrograms.ElementAt((int)nudProgramId.Value);
            tbProgramName.Text = program.Name;
            Modules = program.Modules;
            SmallProgramms = Modules.First().SmallPrograms;

            UpdateUI();
        }

        private void btnProgramAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateField(tbProgramName))
            {
                ShowMessage("Название программы пустое. Пожалуйста, заполните его.");
                return;
            }

            if (!CheckProgramData(false))
                return;

            MyPrograms.AddLast(new LinkedListNode<MyProgram>(new MyProgram(tbProgramName.Text, Modules)));
            Modules = new LinkedList<Module>();

            UpdateUI();
        }

        private void btnProgramEdit_Click(object sender, EventArgs e)
        {
            if ((int)nudProgramId.Value >= MyPrograms.Count)
            {
                ShowMessage("Не удалось найти программу по заданному Id.");
                return;
            }

            if (!CheckProgramData(true))
                return;

            var program = MyPrograms.ElementAt((int)nudProgramId.Value);
            program.Name = tbProgramName.Text;
            program.Modules = Modules;
            Modules = new LinkedList<Module>();

            UpdateUI();
        }

        private void btnProgramDelete_Click(object sender, EventArgs e)
        {
            if ((int)nudProgramId.Value >= MyPrograms.Count)
            {
                ShowMessage("Не удалось найти программу по заданному Id.");
                return;
            }

            MyPrograms.Remove(MyPrograms.ElementAt((int)nudProgramId.Value));

            UpdateUI();
        }

        private bool CheckProgramData(bool isCheckYourself)
        {
            if (MyPrograms.Where(x => isCheckYourself ? x != MyPrograms.ElementAt((int)nudProgramId.Value) : true)
                .Any(x => x.Name == tbProgramName.Text))
            {
                ShowMessage("Программа с таким названием уже есть. Введите другое название");
                return false;
            }

            if (!Modules.Any())
            {
                ShowMessage("Отсутствуют модули в программе. Добавьте их");
                return false;
            }

            return true;
        }

        #endregion

        #region Загрузка и выгрузка

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilePath.Text))
            {
                ShowMessage("Не выбран файл для импорта");
                return;
            }

            MyPrograms = JsonConvert.DeserializeObject<LinkedList<MyProgram>>(File.ReadAllText(tbFilePath.Text));
            UpdateUI();
            ShowMessage("Данные успешно загружены");
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilePath.Text))
            {
                ShowMessage("Не выбран файл для экспорта");
                return;
            }

            File.WriteAllText(tbFilePath.Text, JsonConvert.SerializeObject(MyPrograms));
            ShowMessage("Данные успешно экспортированы");
        }

        #endregion

        private void UpdateUI()
        {
            lbSmallPrograms.Text = $"Подпрограммы:{Environment.NewLine}{SmallProgramms.Print(Environment.NewLine)}";
            lbModules.Text = $"Модули:{Environment.NewLine}{string.Join(Environment.NewLine, Modules)}";
            lbMyPrograms.Text = $"Программы:{Environment.NewLine}{string.Join(Environment.NewLine, MyPrograms)}";
        }

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
            MyPrograms.AddFirst(new LinkedListNode<MyProgram>(new MyProgram("Программа1", Modules)));
            Modules = new LinkedList<Module>();
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
            return other?.Name.Equals(Name) ?? false;
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
            MyProgram other = obj as MyProgram;
            return other?.Name.Equals(Name) ?? false;
        }

        public override string ToString()
        {
            return $"{Name}: ({string.Join(". ", Modules)})";
        }

    }

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
            return string.Join(delimeter, Items.Where(x => x != null));
        }

    }

}