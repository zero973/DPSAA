using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class MainForm : Form
    {

        private readonly string NL = Environment.NewLine;

        private Task1 _Task1 { get; set; }
        private Task2 _Task2 { get; set; }
        private Task5 _Task5 { get; set; }
        private Task6 _Task6 { get; set; }
        private Task21 _Task21 { get; set; }
        private Task24 _Task24 { get; set; }

        public MainForm()
        {
            InitializeComponent();
            _Task1 = new Task1();
            _Task2 = new Task2();
            _Task5 = new Task5();
            _Task6 = new Task6();
            _Task21 = new Task21();
            _Task24 = new Task24();

            cbTask21AddVariant.SelectedIndex = 0;
            cbTask24AddVariant.SelectedIndex = 0;
        }

        #region Task 1

        private void btnTask1GetItemsCount_Click(object sender, EventArgs e)
        {
            ShowMessage($"Кол-во элементов в стеке: {_Task1.GetItemsCount()}");
            Task1UpdateUI();
        }

        private void btnTask1AddElement_Click(object sender, EventArgs e)
        {
            if (!_Task1.AddElements((int)nudTask1AddElement.Value, AskUser("Вы хотите взять элементы из стека удалённых элементов ?")))
                ShowMessage("Нельзя добавить элемент(ы) - нет места.");
            Task1UpdateUI();
        }

        private void btnTask1DeleteElement_Click(object sender, EventArgs e)
        {
            if (!_Task1.DeleteElements((int)nudTask1DeleteElement.Value, AskUser("Вы хотите поместить удаляемые элементы в стек удалённых элементов ?")))
                ShowMessage("Нельзя удалить элемент(ы) - стек пуст или превышает кол-во удаляемых элементов.");
            Task1UpdateUI();
        }

        private void Task1UpdateUI()
        {
            lbTask1DeletedItems.Text = $"Стек удалённых элементов:{NL}{_Task1.PrintDeletedItems()}";
            lbTask1.Text = $"Стек:{NL}{_Task1.PrintMainItems()}";
        }

        #endregion

        #region Task 2

        private void btnTask2GetItemsCount_Click(object sender, EventArgs e)
        {
            ShowMessage($"Кол-во элементов в стеке: {_Task2.GetItemsCount()}");
            Task2UpdateUI();
        }

        private void btnTask2AddItem_Click(object sender, EventArgs e)
        {
            if (!_Task2.AddElements((int)nudTask2AddElement.Value, AskUser("Вы хотите взять элементы из стека удалённых элементов ?")))
                ShowMessage("Нельзя добавить элемент(ы) - нет места.");
            Task2UpdateUI();
        }

        private void btnTask2DeleteItem_Click(object sender, EventArgs e)
        {
            if (!_Task2.DeleteElements((int)nudTask2DeleteElement.Value, AskUser("Вы хотите поместить удаляемые элементы в стек удалённых элементов ?")))
                ShowMessage("Нельзя удалить элемент(ы) - стек пуст или превышает кол-во удаляемых элементов.");
            Task2UpdateUI();
        }

        private void Task2UpdateUI()
        {
            lbTask2DeletedItems.Text = $"Стек удалённых элементов:{NL}{_Task2.PrintDeletedItems()}";
            lbTask2.Text = $"Стек:{NL}{_Task2.PrintMainItems()}";
        }

        #endregion

        #region Task 5

        private void btnTask5IsEmpty_Click(object sender, EventArgs e)
        {
            if (_Task5.IsEmpty())
                ShowMessage("Да, ты пустой.");
            else
                ShowMessage("Нет, в тебе что-то есть.");
        }

        private void btnTask5IsFull_Click(object sender, EventArgs e)
        {
            if (_Task5.IsFull())
                ShowMessage("Да, ты полный.");
            else
                ShowMessage("Нет, ты не полный.");
        }

        private void btnTask5AddElement_Click(object sender, EventArgs e)
        {
            if (!_Task5.AddItem())
                ShowMessage("Нельзя добавить элемент - нет места.");
            Task5UpdateUI();
        }

        private void btnTask5DeleteElement_Click(object sender, EventArgs e)
        {
            if (!_Task5.DeleteItem())
                ShowMessage("Нельзя удалить элемент - очередь пуста.");
            Task5UpdateUI();
        }

        private void Task5UpdateUI()
        {
            lbTask5.Text = $"Очередь:{NL}{_Task5.PrintElements()}";
        }

        #endregion

        #region Task 6

        private void btnTask6IsEmpty_Click(object sender, EventArgs e)
        {
            if (_Task6.IsEmpty())
                ShowMessage("Да, ты пустой.");
            else
                ShowMessage("Нет, в тебе что-то есть.");
        }

        private void btnTask6IsFull_Click(object sender, EventArgs e)
        {
            if (_Task6.IsFull())
                ShowMessage("Да, ты полный.");
            else
                ShowMessage("Нет, ты не полный.");
        }

        private void btnTask6AddItem_Click(object sender, EventArgs e)
        {
            if (!_Task6.AddItem())
                ShowMessage("Нельзя добавить элемент - нет места.");
            Task6UpdateUI();
        }

        private void btnTask6DeleteItem_Click(object sender, EventArgs e)
        {
            if (!_Task6.DeleteItem())
                ShowMessage("Нельзя удалить элемент - очередь пуста.");
            Task6UpdateUI();
        }

        private void Task6UpdateUI()
        {
            lbTask6.Text = $"Очередь:{NL}{_Task6.PrintElements()}";
        }

        #endregion

        #region Task 2 - 1

        private void btnTask21FindElement_Click(object sender, EventArgs e)
        {
            var index = _Task21.FindElement((int)nudTask21Element.Value);
            if (index != -1)
                ShowMessage($"Элемент найден и его индекс {index}.");
            else
                ShowMessage($"Элемент не найден.");
        }

        private void btnTask21AddElement_Click(object sender, EventArgs e)
        {
            var variant = (AddVariants) Enum.ToObject(typeof(AddVariants), cbTask21AddVariant.SelectedIndex);
            if (!_Task21.AddElement((int)nudTask21Element.Value, variant))
                ShowMessage("Нельзя добавить элемент - нет места или заданный элемент не найден.");
            Task21UpdateUI();
        }

        private void btnTask21DeleteElement_Click(object sender, EventArgs e)
        {
            if (!_Task21.DeleteElement((int)nudTask21Element.Value))
                ShowMessage("Нельзя удалить элемент - список пуст или заданный элемент не найден.");
            Task21UpdateUI();
        }

        private void Task21UpdateUI()
        {
            lbTask21.Text = $"Список:{NL}{_Task21.PrintElements()}";
        }

        #endregion

        #region Task 2 - 4

        private void btnTask24_Click(object sender, EventArgs e)
        {
            var index = _Task24.FindElement((int)nudTask24Element.Value);
            if (index != -1)
                ShowMessage($"Элемент найден и его индекс {index}.");
            else
                ShowMessage($"Элемент не найден.");
        }

        private void btnTask24AddElement_Click(object sender, EventArgs e)
        {
            var variant = (AddVariants)Enum.ToObject(typeof(AddVariants), cbTask24AddVariant.SelectedIndex);
            if (!_Task24.AddElement((int)nudTask24Element.Value, variant))
                ShowMessage("Нельзя добавить элемент - нет места или заданный элемент не найден.");
            Task24UpdateUI();
        }

        private void btnTask24DeleteElement_Click(object sender, EventArgs e)
        {
            if (!_Task24.DeleteElement((int)nudTask24Element.Value))
                ShowMessage("Нельзя удалить элемент - список пуст или заданный элемент не найден.");
            Task24UpdateUI();
        }

        private void Task24UpdateUI()
        {
            lbTask24.Text = $"Список:{NL}{_Task24.PrintElements()}";
        }

        #endregion

        private void ShowMessage(string text)
        {
            MessageBox.Show(text, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool AskUser(string text)
        {
            if (MessageBox.Show(text, "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            return false;
        }

    }

    public class Task1
    {

        private int[] mainItems;

        private int[] deletedItems;

        private Random _Random;

        private int CurIndex, CurDelIndex;

        private readonly int EmptyElement;

        public Task1()
        {
            mainItems = new int[10];
            deletedItems = new int[10];
            _Random = new Random();
            CurIndex = CurDelIndex  = - 1;
            EmptyElement = 0;
        }

        public int GetItemsCount()
        {
            return CurIndex+1;
        }

        public bool AddElements(int count, bool takeFromDeleted)
        {
            if(count + GetItemsCount() > mainItems.Length)
                return false;

            int i = 0;
            if (takeFromDeleted)
            {
                for (; i < count && CurDelIndex != -1; i++)
                {
                    CurIndex++;
                    mainItems[CurIndex] = PopDelItem();
                }
            }

            for (; i < count; i++)
            {
                CurIndex++;
                mainItems[CurIndex] = _Random.Next(1000, 9999);
            }

            return true;
        }

        public bool DeleteElements(int count, bool putToDeleted)
        {
            if (count > GetItemsCount())
                return false;

            if (putToDeleted)
                for (int i = 0; i < count; i++)
                    AddItemToDeletedStack(mainItems[GetItemsCount() - 1 - i]);
            
            for(int i = 0; i < count; i++)
            {
                mainItems[CurIndex] = EmptyElement;
                CurIndex--;
            }

            return true;
        }

        private void AddItemToDeletedStack(int value)
        {
            if(CurDelIndex == deletedItems.Length)
                return;

            CurDelIndex++;
            deletedItems[CurDelIndex] = value;
        }

        private int PopDelItem()
        {
            if (CurDelIndex == -1)
                return EmptyElement;

            int result = deletedItems[CurDelIndex];
            deletedItems[CurDelIndex] = EmptyElement;
            CurDelIndex--;

            return result;
        }

        public string PrintMainItems()
        {
            return string.Join(Environment.NewLine, mainItems.Where(x => x != EmptyElement));
        }

        public string PrintDeletedItems()
        {
            return string.Join(Environment.NewLine, deletedItems.Where(x => x != EmptyElement));
        }

    }

    public class Task2
    {

        private List<int> mainItems;

        private List<int> deletedItems;

        private Random _Random;

        private readonly int MaxItemsCount;

        public Task2()
        {
            mainItems = new List<int>();
            deletedItems = new List<int>();
            _Random = new Random();
            MaxItemsCount = 10;
        }

        public int GetItemsCount()
        {
            return mainItems.Count;
        }

        public bool AddElements(int count, bool takeFromDeleted)
        {
            if (count + GetItemsCount() > MaxItemsCount)
                return false;

            int i = 0;
            if (takeFromDeleted)
                for (; i < count && deletedItems.Any(); i++)
                    mainItems.Add(PopDelItem());

            for (; i < count; i++)
                mainItems.Add(_Random.Next(1000, 9999));

            return true;
        }

        public bool DeleteElements(int count, bool putToDeleted)
        {
            if (count > GetItemsCount())
                return false;

            if (putToDeleted)
                for (int i = 0; i < count; i++)
                    AddItemToDeletedStack(mainItems[GetItemsCount() - 1 - i]);

            for (int i = 0; i < count; i++)
                mainItems.RemoveAt(mainItems.Count-1);

            return true;
        }

        private void AddItemToDeletedStack(int value)
        {
            if (MaxItemsCount == deletedItems.Count)
                return;

            deletedItems.Add(value);
        }

        private int PopDelItem()
        {
            if (!deletedItems.Any())
                return 0;

            int result = deletedItems.Last();
            deletedItems.RemoveAt(deletedItems.Count-1);

            return result;
        }

        public string PrintMainItems()
        {
            return string.Join(Environment.NewLine, mainItems);
        }

        public string PrintDeletedItems()
        {
            return string.Join(Environment.NewLine, deletedItems);
        }


    }

    public class Task5
    {

        private int[] mainItems;

        private Random _Random;

        private int HeadIndex, LastIndex;

        private readonly int EmptyElement;

        public Task5()
        {
            mainItems = new int[10];
            _Random = new Random();
            HeadIndex = LastIndex = 0;
            EmptyElement = 0;
        }

        public bool IsEmpty()
        {
            return !mainItems.Any(x => x != EmptyElement);
        }

        public bool IsFull()
        {
            return !mainItems.Any(x => x == EmptyElement);
        }

        public bool AddItem()
        {
            if (IsFull())
                return false;

            LastIndex = CheckIndex(LastIndex);

            mainItems[LastIndex] = _Random.Next(1000, 9999);
            LastIndex++;

            return true;
        }

        public bool DeleteItem()
        {
            if (IsEmpty())
                return false;

            HeadIndex = CheckIndex(HeadIndex);

            mainItems[HeadIndex] = EmptyElement;
            HeadIndex++;

            return true;
        }

        private int CheckIndex(int index)
        {
            if (index == -1)
                index = mainItems.Length - 1;
            else if (index == mainItems.Length)
                index = 0;
            return index;
        }

        public string PrintElements()
        {
            return string.Join(Environment.NewLine, mainItems);
        }

    }

    public class Task6
    {

        private List<int> mainItems;

        private Random _Random;

        private readonly int MaxItems;

        public Task6()
        {
            mainItems = new List<int>();
            _Random = new Random();
            MaxItems = 10;
        }

        public bool IsEmpty()
        {
            return !mainItems.Any();
        }

        public bool IsFull()
        {
            return mainItems.Count == MaxItems;
        }

        public bool AddItem()
        {
            if (IsFull())
                return false;

            mainItems.Add(_Random.Next(1000, 9999));

            return true;
        }

        public bool DeleteItem()
        {
            if (IsEmpty())
                return false;

            mainItems.RemoveAt(0);

            return true;
        }

        public string PrintElements()
        {
            return string.Join(Environment.NewLine, mainItems);
        }

    }

    public class Task21
    {

        private int[] mainItems;

        private Random _Random;

        private int CurIndex;

        private readonly int EmptyElement;

        public Task21()
        {
            mainItems = new int[10];
            _Random = new Random();
            CurIndex = -1;
            EmptyElement = 0;
        }

        public int FindElement(int value)
        {
            for (int i = 0; i < mainItems.Length; i++)
                if (mainItems[i] == value)
                    return i;
            return -1;
        }

        public bool AddElement(int element, AddVariants variant)
        {
            if (CurIndex == mainItems.Length-1)
                return false;

            int randomValue = _Random.Next(1000, 9999);
            int[] rightArrayPart;
            CurIndex++;
            switch (variant)
            {
                case AddVariants.BeforeElement:
                    if (!mainItems.Contains(element))
                        return false;

                    if (FindElement(element) == 0)
                    {
                        rightArrayPart = CutArray(mainItems, 0, mainItems.Length-1);
                        var firstElement = mainItems[0];
                        mainItems[0] = randomValue;
                        for (int i = 1, j = 0; i < mainItems.Length; i++, j++)
                            mainItems[i] = rightArrayPart[j];
                        return true;
                    }
                    rightArrayPart = CutArray(mainItems, FindElement(element) - 1, mainItems.Length);
                    rightArrayPart[0] = randomValue;
                    for (int i = FindElement(element), j = 0; i < mainItems.Length; i++, j++)
                        mainItems[i] = rightArrayPart[j];
                    break;
                case AddVariants.AfterElement:
                    if (!mainItems.Contains(element))
                        return false;
                    rightArrayPart = CutArray(mainItems, FindElement(element) + 1, mainItems.Length);
                    mainItems[FindElement(element) + 1] = randomValue;
                    for (int i = FindElement(element) + 2, j = 0; i < mainItems.Length; i++, j++)
                        mainItems[i] = rightArrayPart[j];
                    break;
                case AddVariants.AfterAll: mainItems[CurIndex] = randomValue; break;
            }

            return true;
        }

        public bool DeleteElement(int element)
        {
            if (CurIndex == -1 || !mainItems.Contains(element))
                return false;

            int foundIndex = FindElement(element);

            var rightArrayPart = CutArray(mainItems, foundIndex+1, mainItems.Length);
            for (int i = foundIndex, j = 0; j < rightArrayPart.Length; i++, j++)
                mainItems[i] = rightArrayPart[j];
            mainItems[mainItems.Length - 1] = EmptyElement;

            CurIndex--;
            return true;
        }

        private int[] CutArray(int[] source, int startIndex, int endIndex)
        {
            var result = new int[endIndex-startIndex];
            for (int i = startIndex, j = 0; i < endIndex; i++, j++)
                result[j] = source[i];
            return result;
        }

        public string PrintElements()
        {
            return string.Join(Environment.NewLine, mainItems) + $"{Environment.NewLine}({CurIndex+1}/{mainItems.Length})";
        }

    }

    public class Task24
    {

        private List<int> mainItems;

        private Random _Random;

        private readonly int MaxItems;

        public Task24()
        {
            mainItems = new List<int>();
            _Random = new Random();
            MaxItems = 10;
        }

        public int FindElement(int value)
        {
            for (int i = 0; i < mainItems.Count; i++)
                if (mainItems[i] == value)
                    return i;
            return -1;
        }

        public bool AddElement(int element, AddVariants variant)
        {
            if (mainItems.Count == MaxItems)
                return false;

            int randomValue = _Random.Next(1000, 9999);
            int elIndex = FindElement(element);

            switch (variant)
            {
                case AddVariants.BeforeElement: 
                    if (!mainItems.Contains(element))
                        return false;
                    mainItems.Insert(elIndex, randomValue);
                    break;
                case AddVariants.AfterElement:
                    if (!mainItems.Contains(element))
                        return false;
                    if (elIndex == mainItems.Count - 1)
                    {
                        mainItems.Add(randomValue);
                        return true;
                    }
                    mainItems.Insert(elIndex+1, randomValue);
                    break;
                case AddVariants.AfterAll: mainItems.Add(randomValue); break;
            }

            return true;
        }

        public bool DeleteElement(int element)
        {
            if (!mainItems.Any() || !mainItems.Contains(element))
                return false;

            mainItems.Remove(element);
            return true;
        }

        public string PrintElements()
        {
            return string.Join(Environment.NewLine, mainItems) + $"{Environment.NewLine}({mainItems.Count}/{MaxItems})";
        }

    }

    public class Task33
    {

        private List<List<int>> mainItems;

        public Task33()
        {
            mainItems = new List<List<int>>();
        }

        public int FindElement(int element)
        {
            for (int i = 0; i < mainItems.Count; i++)
                for (int j = 0; j < mainItems[i].Count; j++)
                    if (mainItems[i][j] == element)
                        return mainItems[i][j];
            return -1;
        }

        /// <summary>
        /// Добавляет элемент в новый список либо в список с заданным <paramref name="index"/>
        /// </summary>
        /// <param name="element">Добавляемый элемент</param>
        /// <param name="isNew">Создаём новый список или используем существующий</param>
        /// <param name="index">Индекс списка, в который будем добавлять элемент</param>
        public void AddElement(int element, bool isNew, int index)
        {
            if (!isNew)
            {

                return;
            }
            mainItems.Add(new List<int>() { element });
        }

    }

    public enum AddVariants
    {

        BeforeElement = 0, AfterElement = 1, AfterAll = 2

    }

}