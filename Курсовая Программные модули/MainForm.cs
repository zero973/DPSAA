using Newtonsoft.Json;
using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_Программные_модули
{

    public partial class MainForm : Form
    {

        private CustomLinkedList<SmallProgram> SmallProgramms;
        private CustomLinkedList<Module> Modules;
        private ArrayStek<MyProgram> MyPrograms;

        public MainForm()
        {
            InitializeComponent();

            SmallProgramms = new CustomLinkedList<SmallProgram>();
            Modules = new CustomLinkedList<Module>();
            MyPrograms = new ArrayStek<MyProgram>(10);

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

            SmallProgramms.AddLast(new SmallProgram(tbSmallProgramName.Text, (int)nudSmallProgramRowsCount.Value));

            UpdateUI();
        }

        private void btnEditSmallProg_Click(object sender, EventArgs e)
        {
            if ((int)nudSmallProgramsId.Value >= SmallProgramms.Count)
            {
                ShowMessage("Не удалось найти подпрограмму по заданному Id.");
                return;
            }

            var smallProg = SmallProgramms.ElementAt((int)nudSmallProgramsId.Value);
            smallProg.Name = tbSmallProgramName.Text;
            smallProg.CountOfRows = (int)nudSmallProgramRowsCount.Value;

            UpdateUI();
        }

        private void btnSmallProgramDelete_Click(object sender, EventArgs e)
        {
            if ((int)nudSmallProgramsId.Value >= Modules.Count)
            {
                ShowMessage("Не удалось найти подпрограмму по заданному Id.");
                return;
            }

            SmallProgramms.Remove(SmallProgramms.ElementAt((int)nudSmallProgramsId.Value));

            UpdateUI();
        }

        private void btnSmallProgrammsClear_Click(object sender, EventArgs e)
        {
            SmallProgramms = new CustomLinkedList<SmallProgram>();
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

            if (!CheckModuleData(false))
                return;

            Modules.AddLast(new Module(tbModuleName.Text, SmallProgramms));
            SmallProgramms = new CustomLinkedList<SmallProgram>();

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
            SmallProgramms = new CustomLinkedList<SmallProgram>();

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

            if (SmallProgramms.Count == 0)
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
            if (MyPrograms.Peek() == null)
            {
                ShowMessage("В стеке нет программ");
                return;
            }

            var program = MyPrograms.Peek();
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

            if (!CheckProgramData())
                return;

            if (!MyPrograms.Add(new MyProgram(tbProgramName.Text, Modules)))
            {
                ShowMessage("Программа с таким названием уже есть или в стеке закончилось место");
                return;
            }
            Modules = new CustomLinkedList<Module>();

            UpdateUI();
        }

        private void btnProgramEdit_Click(object sender, EventArgs e)
        {
            if (MyPrograms.Peek() == null)
            {
                ShowMessage("В стеке нет программ");
                return;
            }

            if (!CheckProgramData())
                return;

            var program = MyPrograms.Peek();
            program.Name = tbProgramName.Text;
            program.Modules = Modules;
            Modules = new CustomLinkedList<Module>();

            UpdateUI();
        }

        private void btnProgramDelete_Click(object sender, EventArgs e)
        {
            if (MyPrograms.Peek() == null)
            {
                ShowMessage("В стеке нет программ");
                return;
            }

            MyPrograms.Remove();

            UpdateUI();
        }

        private bool CheckProgramData()
        {
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

            MyPrograms = JsonConvert.DeserializeObject<ArrayStek<MyProgram>>(File.ReadAllText(tbFilePath.Text));
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

        #region Other

        private void UpdateUI()
        {
            lbSmallPrograms.Text = $"Подпрограммы:{Environment.NewLine}{SmallProgramms.Print(Environment.NewLine)}";
            lbModules.Text = $"Модули:{Environment.NewLine}{Modules.Print(Environment.NewLine)}";
            lbMyPrograms.Text = $"Программы ({MyPrograms.CountOfNotNullElements()}/10):{Environment.NewLine}{MyPrograms.Print(Environment.NewLine)}";
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
            SmallProgramms.AddLast(new SmallProgram("Подпрога1", 10));
            SmallProgramms.AddLast(new SmallProgram("Подпрога2", 21));
            SmallProgramms.AddLast(new SmallProgram("Подпрога3", 30));
            Modules.AddLast(new Module("Модуль1", SmallProgramms));
            SmallProgramms = new CustomLinkedList<SmallProgram>();
            SmallProgramms.AddLast(new SmallProgram("Подпрога4", 13));
            SmallProgramms.AddLast(new SmallProgram("Подпрога5", 25));
            SmallProgramms.AddLast(new SmallProgram("Подпрога6", 36));
            Modules.AddLast(new Module("Модуль2", SmallProgramms));
            SmallProgramms = new CustomLinkedList<SmallProgram>();
            SmallProgramms.AddLast(new SmallProgram("Подпрога7", 21));
            SmallProgramms.AddLast(new SmallProgram("Подпрога8", 45));
            SmallProgramms.AddLast(new SmallProgram("Подпрога9", 64));
            Modules.AddLast(new Module("Модуль3", SmallProgramms));
            SmallProgramms = new CustomLinkedList<SmallProgram>();
            MyPrograms.Add(new MyProgram("Программа1", Modules));
            Modules = new CustomLinkedList<Module>();
        }

        #endregion

    }

}