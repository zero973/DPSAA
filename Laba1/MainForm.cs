using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        private Task33 _Task33 { get; set; }
        private TreeTask4 _TreeTask4 { get; set; }
        private SortTask5 _SortTask5 { get; set; }

        public MainForm()
        {
            InitializeComponent();
            _Task1 = new Task1();
            _Task2 = new Task2();
            _Task5 = new Task5();
            _Task6 = new Task6();
            _Task21 = new Task21();
            _Task24 = new Task24();
            _Task33 = new Task33();
            _TreeTask4 = new TreeTask4();
            _SortTask5 = new SortTask5((int)nudTask5SortCountOfElements.Value);

            cbTask21AddVariant.SelectedIndex = 0;
            cbTask24AddVariant.SelectedIndex = 0;
            cbTask33AddElementVariants.SelectedIndex = 0;
            cbTask33DeleteVariants.SelectedIndex = 0;
            cbSortTask5SortVariant.SelectedIndex = 0;

            TreeTask4UpdateUI();
            Task5SortUpdateUI();
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

        #region Task 3 - 3

        private void btnTask33FindElement_Click(object sender, EventArgs e)
        {
            int index = _Task33.FindElement((int)nudTask33FindElement.Value);
            if (index != -1)
                ShowMessage($"Элемент находится в листе с индексом {index}.");
            else
                ShowMessage("Элемент не найден.");
        }

        private void btnTask33AddElement_Click(object sender, EventArgs e)
        {
            // добавить в существующий; иначе в новый лист
            if(cbTask33AddElementVariants.SelectedIndex == 0)
            {
                if (!_Task33.AddElement((int)nudTask33Element.Value, false, (int)nudTask33ListIndex.Value))
                    ShowMessage("Не найден список с заданным индексом.");
            }
            else
                _Task33.AddElement((int)nudTask33Element.Value, true, 0);
            
            Task33UpdateUI();
        }

        private void btnTask33DeleteElement_Click(object sender, EventArgs e)
        {
            // удалить элемент; иначе удалить список
            if(cbTask33DeleteVariants.SelectedIndex == 0)
            {
                if (!_Task33.DeleteElement((int)nudTask33Element.Value, (int)nudTask33ListIndex.Value))
                    ShowMessage("Не найден список с заданным индексом или не найден заданный элемент.");
            }
            else
            {
                if (!_Task33.DeleteList((int)nudTask33ListIndex.Value))
                    ShowMessage("Не найден список с заданным индексом.");
            }

            Task33UpdateUI();
        }

        private void Task33UpdateUI()
        {
            lbTask33.Text = $"Список списков:{NL}{_Task33.PrintElements()}";
        }

        #endregion

        #region Task 4 - 1

        private void btnTreeTask4AddElement_Click(object sender, EventArgs e)
        {
            _TreeTask4.AddElement();
            TreeTask4UpdateUI();
        }

        private void btnTreeTask4DeleteElement_Click(object sender, EventArgs e)
        {
            if(!_TreeTask4.DeleteElement((int)nudTreeTask4Element.Value))
                ShowMessage("Не найден заданный элемент.");
            TreeTask4UpdateUI();
        }

        private void TreeTask4UpdateUI()
        {
            tbTreeTask4.Text = $"Дерево:{NL}{_TreeTask4.PrintElements()}";
        }

        #endregion

        #region Task 5

        private void btnSortTask5CreateNewArray_Click(object sender, EventArgs e)
        {
            _SortTask5 = new SortTask5((int)nudTask5SortCountOfElements.Value);
            Task5SortUpdateUI();
        }

        private void btnSortTask5Sort_Click(object sender, EventArgs e)
        {
            string msg = "";
            switch (cbSortTask5SortVariant.SelectedIndex)
            {
                case 0: msg = _SortTask5.SortBubble(); break;
                case 1: msg = _SortTask5.SortSelect(); break;
                case 2: msg = _SortTask5.SortPut(); break;
                case 3: msg = _SortTask5.SortShell(); break;
            }
            Task5SortUpdateUI();
            ShowMessage(msg);
        }

        private void Task5SortUpdateUI()
        {
            tbSortTask5.Text = $"Исходный массив: {_SortTask5.PrintMainElements()}{NL}Отсортированный массив: {_SortTask5.PrintSortedElements()}";
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
                        return i;
            return -1;
        }

        /// <summary>
        /// Добавляет элемент в новый список либо в список с заданным <paramref name="listIndex"/>
        /// </summary>
        /// <param name="element">Добавляемый элемент</param>
        /// <param name="isNew">Создаём новый список или используем существующий</param>
        /// <param name="listIndex">Индекс списка, в который будем добавлять элемент</param>
        public bool AddElement(int element, bool isNew, int listIndex)
        {
            if (!isNew)
            {
                if (listIndex >= mainItems.Count)
                    return false;

                mainItems[listIndex].Add(element);

                return true;
            }
            mainItems.Add(new List<int>() { element });
            return true;
        }

        public bool DeleteElement(int element, int listIndex)
        {
            if (listIndex >= mainItems.Count)
                return false;

            if (!mainItems[listIndex].Any(x => x == element))
                return false;

            mainItems[listIndex].Remove(element);

            return true;
        }

        public bool DeleteList(int listIndex)
        {
            if (listIndex >= mainItems.Count)
                return false;

            mainItems.RemoveAt(listIndex);

            return true;
        }

        public string PrintElements()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < mainItems.Count; i++)
            {
                sb.Append($"{i}. ");
                sb.Append(string.Join(",", mainItems[i]));
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

    }

    public class TreeTask4
    {

        private Random _Random;

        private List<int> CachedElements;

        private BinaryTree<int> _BinaryTree;

        public TreeTask4()
        {
            _Random = new Random();
            CachedElements = new List<int>();
            _BinaryTree = new BinaryTree<int>(GetRandomElement(), null);
        }

        public void AddElement()
        {
            _BinaryTree.add(GetRandomElement());
        }

        public bool DeleteElement(int value)
        {
            return _BinaryTree.remove(value);
        }

        public string PrintElements()
        {
            return _BinaryTree.print();
        }

        private int GetRandomElement()
        {
            int result;
            do
            {
                result = _Random.Next(1000, 9999);
            } while (CachedElements.Contains(result));
            CachedElements.Add(result);
            return result;
        }

        public class BinaryTree<T> where T : IComparable<T>
        {
            private BinaryTree<T> parent, left, right;
            private T val;

            public BinaryTree(T val, BinaryTree<T> parent)
            {
                this.val = val;
                this.parent = parent;
            }

            public void add(T val)
            {
                if (val.CompareTo(this.val) < 0)
                {
                    if (this.left == null)
                    {
                        this.left = new BinaryTree<T>(val, this);
                    }
                    else if (this.left != null)
                        this.left.add(val);
                }
                else
                {
                    if (this.right == null)
                    {
                        this.right = new BinaryTree<T>(val, this);
                    }
                    else if (this.right != null)
                        this.right.add(val);
                }
            }

            private BinaryTree<T> _search(BinaryTree<T> tree, T val)
            {
                if (tree == null) return null;
                switch (val.CompareTo(tree.val))
                {
                    case 1: return _search(tree.right, val);
                    case -1: return _search(tree.left, val);
                    case 0: return tree;
                    default: return null;
                }
            }

            public BinaryTree<T> search(T val)
            {
                return _search(this, val);
            }

            public bool remove(T val)
            {
                //Проверяем, существует ли данный узел
                BinaryTree<T> tree = search(val);
                if (tree == null)
                {
                    //Если узла не существует, вернем false
                    return false;
                }
                BinaryTree<T> curTree;

                //Если удаляем корень
                if (tree == this)
                {
                    if (tree.right != null)
                    {
                        curTree = tree.right;
                    }
                    else curTree = tree.left;

                    while (curTree.left != null)
                    {
                        curTree = curTree.left;
                    }
                    T temp = curTree.val;
                    this.remove(temp);
                    tree.val = temp;

                    return true;
                }

                //Удаление листьев
                if (tree.left == null && tree.right == null && tree.parent != null)
                {
                    if (tree == tree.parent.left)
                        tree.parent.left = null;
                    else
                    {
                        tree.parent.right = null;
                    }
                    return true;
                }

                //Удаление узла, имеющего левое поддерево, но не имеющее правого поддерева
                if (tree.left != null && tree.right == null)
                {
                    //Меняем родителя
                    tree.left.parent = tree.parent;
                    if (tree == tree.parent.left)
                    {
                        tree.parent.left = tree.left;
                    }
                    else if (tree == tree.parent.right)
                    {
                        tree.parent.right = tree.left;
                    }
                    return true;
                }

                //Удаление узла, имеющего правое поддерево, но не имеющее левого поддерева
                if (tree.left == null && tree.right != null)
                {
                    //Меняем родителя
                    tree.right.parent = tree.parent;
                    if (tree == tree.parent.left)
                    {
                        tree.parent.left = tree.right;
                    }
                    else if (tree == tree.parent.right)
                    {
                        tree.parent.right = tree.right;
                    }
                    return true;
                }

                //Удаляем узел, имеющий поддеревья с обеих сторон
                if (tree.right != null && tree.left != null)
                {
                    curTree = tree.right;

                    while (curTree.left != null)
                    {
                        curTree = curTree.left;
                    }

                    //Если самый левый элемент является первым потомком
                    if (curTree.parent == tree)
                    {
                        curTree.left = tree.left;
                        tree.left.parent = curTree;
                        curTree.parent = tree.parent;
                        if (tree == tree.parent.left)
                        {
                            tree.parent.left = curTree;
                        }
                        else if (tree == tree.parent.right)
                        {
                            tree.parent.right = curTree;
                        }
                        return true;
                    }
                    //Если самый левый элемент НЕ является первым потомком
                    else
                    {
                        if (curTree.right != null)
                        {
                            curTree.right.parent = curTree.parent;
                        }
                        curTree.parent.left = curTree.right;
                        curTree.right = tree.right;
                        curTree.left = tree.left;
                        tree.left.parent = curTree;
                        tree.right.parent = curTree;
                        curTree.parent = tree.parent;
                        if (tree == tree.parent.left)
                        {
                            tree.parent.left = curTree;
                        }
                        else if (tree == tree.parent.right)
                        {
                            tree.parent.right = curTree;
                        }

                        return true;
                    }
                }
                return false;
            }

            private void _print(BinaryTree<T> node, bool isRight, StringBuilder sb)
            {
                if (node == null) return;
                _print(node.left, false, sb);
                string s = isRight ? "R:" : "L:";
                Console.Write($"{s}{node} ");
                sb.Append($"{s}{node} ");
                if (node.right != null)
                    _print(node.right, true, sb);
            }

            public string print()
            {
                StringBuilder sb = new StringBuilder();
                _print(this, false, sb);
                return sb.ToString();
            }

            public override string ToString()
            {
                return val.ToString();
            }
        }

    }

    public class SortTask5
    {

        private int[] mainItems;
        private int[] sortedItems;

        private Random _Random;

        public SortTask5(int countOfElements)
        {
            _Random = new Random();
            mainItems = new int[countOfElements];
            sortedItems = new int[countOfElements];
            for (int i = 0; i < mainItems.Length; i++)
                mainItems[i] = _Random.Next(0, 100);
        }

        public string SortBubble()
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();

            Array.Copy(mainItems, sortedItems, mainItems.Length);

            long countOfReplacements = 0;
            int unsortedSituations, temp;

            do
            {
                unsortedSituations = 0;
                for (int i = 1; i < sortedItems.Length; i++)
                {
                    if (sortedItems[i - 1] > sortedItems[i])
                    {
                        temp = sortedItems[i - 1];
                        sortedItems[i - 1] = sortedItems[i];
                        sortedItems[i] = temp;
                        countOfReplacements++;
                        unsortedSituations++;
                    }
                }
            } while (unsortedSituations != 0);

            timer.Stop();
            return $"Сортировка пузырьком; прошло времени: {timer.Elapsed.TotalSeconds} сек; кол-во перестановок: {countOfReplacements}";
        }

        public string SortSelect()
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();

            Array.Copy(mainItems, sortedItems, mainItems.Length);

            long countOfReplacements = 0, indexOfMin = 0;
            int temp;

            for (int i = 0; i < sortedItems.Length-1; i++)
            {
                indexOfMin = i;
                for (int j = i+1; j < sortedItems.Length; j++)
                {
                    if (sortedItems[j] < sortedItems[indexOfMin])
                        indexOfMin = j;
                }
                temp = sortedItems[i];
                sortedItems[i] = sortedItems[indexOfMin];
                sortedItems[indexOfMin] = temp;
                countOfReplacements++;
            }

            timer.Stop();
            return $"Сортировка выбором; прошло времени: {timer.Elapsed.TotalSeconds} сек; кол-во перестановок: {countOfReplacements}";
        }

        public string SortPut()
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();

            Array.Copy(mainItems, sortedItems, mainItems.Length);

            long countOfReplacements = 0;

            for (int i = 0; i < mainItems.Length; i++)
            {
                int j = i;
                while (j > 0 && sortedItems[j - 1] > mainItems[i])
                {
                    sortedItems[j] = sortedItems[j - 1];
                    j--;
                    countOfReplacements++;
                }
                sortedItems[j] = mainItems[i];
                countOfReplacements++;
            }

            timer.Stop();
            return $"Сортировка вставкой; прошло времени: {timer.Elapsed.TotalSeconds} сек; кол-во перестановок: {countOfReplacements}";
        }

        public string SortShell()
        {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();

            Array.Copy(mainItems, sortedItems, mainItems.Length);

            long countOfReplacements = 0;

            for (int step = sortedItems.Length / 2; step > 0; step /= 2)
            {
                for (int i = step, j; i < sortedItems.Length; i++)
                {
                    int temp = sortedItems[i];
                    for (j = i; j >= step; j -= step)
                    {
                        if (temp < sortedItems[j - step])
                        {
                            sortedItems[j] = sortedItems[j - step];
                            countOfReplacements++;
                        }
                        else
                            break;
                    }
                    sortedItems[j] = temp;
                    countOfReplacements++;
                }
            }

            timer.Stop();
            return $"Сортировка вставкой; прошло времени: {timer.Elapsed.TotalSeconds} сек; кол-во перестановок: {countOfReplacements}";
        }

        public string PrintMainElements()
        {
            return string.Join(", ", mainItems);
        }

        public string PrintSortedElements()
        {
            return string.Join(", ", sortedItems);
        }

    }

    public enum AddVariants
    {

        BeforeElement = 0, AfterElement = 1, AfterAll = 2

    }

}