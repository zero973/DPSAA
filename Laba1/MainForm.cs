using System;
using System.Data;
using System.Text;
using System.Linq;
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
            cbTask33SearchDirection.SelectedIndex = 0;
            cbTask33AddVariants.SelectedIndex = 0;
            cbTreeTask4PrintVariants.SelectedIndex = 0;

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
            var variant = (AddVariants)cbTask24AddVariant.SelectedIndex;
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
            int index = _Task33.FindElement((int)nudTask33FindElement.Value, cbTask33SearchDirection.SelectedIndex == 0);
            if (index != -1)
                ShowMessage($"Элемент находится в листе с индексом {index}.");
            else
                ShowMessage("Элемент не найден.");
        }

        private void btnTask33AddElement_Click(object sender, EventArgs e)
        {
            var variant = (AddVariants)cbTask33AddVariants.SelectedIndex;
            // добавить в существующий; иначе в новый лист
            if (cbTask33AddElementVariants.SelectedIndex == 0)
            {
                if (!_Task33.AddElement((int)nudTask33Element.Value, false, (int)nudTask33ListIndex.Value, variant))
                    ShowMessage("Не найден список с заданным индексом.");
            }
            else
                _Task33.AddElement((int)nudTask33Element.Value, true, 0, variant);
            
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
            _TreeTask4.AddElements((int)nudTreeCountOfAddingElements.Value);
            TreeTask4UpdateUI();
        }

        private void btnTreeTask4DeleteElement_Click(object sender, EventArgs e)
        {
            _TreeTask4.DeleteElement((int)nudTreeTask4Element.Value);
            TreeTask4UpdateUI();
        }

        private void cbTreeTask4PrintVariants_SelectedIndexChanged(object sender, EventArgs e)
        {
            var variant = (TreePrintVariants)cbTreeTask4PrintVariants.SelectedIndex;
            tbTreeTask4.Text = $"Дерево:{NL}{_TreeTask4.PrintElements(variant)}";
        }

        private void TreeTask4UpdateUI()
        {
            var variant = (TreePrintVariants)cbTreeTask4PrintVariants.SelectedIndex;
            tbTreeTask4.Text = $"Дерево:{NL}{_TreeTask4.PrintElements(variant)}";
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

        private CustomList<int> mainItems;

        private CustomList<int> deletedItems;

        private Random _Random;

        private readonly int MaxItemsCount;

        public Task2()
        {
            mainItems = new CustomList<int>();
            deletedItems = new CustomList<int>();
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
                    AddItemToDeletedStack(mainItems.ElementAt(GetItemsCount() - 1 - i));

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
            return mainItems.Print(Environment.NewLine);
        }

        public string PrintDeletedItems()
        {
            return deletedItems.Print(Environment.NewLine);
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

        private CustomList<int> mainItems;

        private Random _Random;

        private readonly int MaxItems;

        public Task6()
        {
            mainItems = new CustomList<int>();
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
            return mainItems.Print(Environment.NewLine);
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

            if (mainItems.Contains(element) || variant == AddVariants.AfterAll)
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

        private CustomList<int> mainItems;

        private Random _Random;

        private readonly int MaxItems;

        public Task24()
        {
            mainItems = new CustomList<int>();
            _Random = new Random();
            MaxItems = 10;
        }

        public int FindElement(int value)
        {
            for (int i = 0; i < mainItems.Count; i++)
                if (mainItems.ElementAt(i) == value)
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
            return mainItems.Print(Environment.NewLine) + $"{Environment.NewLine}({mainItems.Count}/{MaxItems})";
        }

    }

    public class Task33
    {

        private CustomLinkedList<CustomLinkedList<int>> mainItems;
        private Random _Random;

        public Task33()
        {
            _Random = new Random();
            mainItems = new CustomLinkedList<CustomLinkedList<int>>();
        }

        public int FindElement(int element, bool IsForwardDirection)
        {
            if (IsForwardDirection)
            {
                for (int i = 0; i < mainItems.Count; i++)
                    for (int j = 0; j < mainItems.ElementAt(i).Count; j++)
                        if (mainItems.ElementAt(i).ElementAt(j) == element)
                            return j;
            }
            else
            {
                for (int i = mainItems.Count-1; i > -1; i--)
                    for (int j = mainItems.ElementAt(i).Count - 1; j > -1; j--)
                        if (mainItems.ElementAt(i).ElementAt(j) == element)
                            return j;
            }
            
            return -1;
        }

        /// <summary>
        /// Добавляет элемент в новый список либо в список с заданным <paramref name="listIndex"/>
        /// </summary>
        /// <param name="element">Добавляемый элемент</param>
        /// <param name="isNew">Создаём новый список или используем существующий</param>
        /// <param name="listIndex">Индекс списка, в который будем добавлять элемент</param>
        public bool AddElement(int element, bool isNew, int listIndex, AddVariants variant)
        {
            int randomValue = _Random.Next(1000, 9999);
            if (!isNew)
            {
                if (listIndex >= mainItems.Count)
                    return false;

                int elIndex = FindElement(element, true);
                var list = mainItems.ElementAt(listIndex);
                switch (variant)
                {
                    case AddVariants.BeforeElement:
                        if (!list.Contains(element))
                            return false;
                        list.Insert(elIndex, randomValue);
                        break;
                    case AddVariants.AfterElement:
                        if (!list.Contains(element))
                            return false;
                        if (elIndex == list.Count - 1)
                        {
                            list.Add(randomValue);
                            return true;
                        }
                        list.Insert(elIndex + 1, randomValue);
                        break;
                    case AddVariants.AfterAll: list.Add(randomValue); break;
                }
            }
            else
                mainItems.Add(new CustomLinkedList<int>(randomValue));

            return true;
        }

        public bool DeleteElement(int element, int listIndex)
        {
            if (listIndex >= mainItems.Count)
                return false;

            if (!mainItems.ElementAt(listIndex).Any(x => x == element))
                return false;

            mainItems.ElementAt(listIndex).Remove(element);

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
                sb.Append(mainItems.ElementAt(i).Print(", "));
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

    }

    public class TreeTask4
    {

        private Random _Random;

        private BinaryTree<int> Tree;

        public TreeTask4()
        {
            _Random = new Random();
            Tree = new BinaryTree<int>();
        }

        private int[] cachedElements;
        public void AddElements(int count)
        {
            count--;
            var values = new CustomLinkedList<int>();
            cachedElements = new int[count];
            for (int i = 0; i < count; i++)
                values.Add(GetRandomElement());
            Tree.Add(values);
        }

        private int GetRandomElement()
        {
            int result = 0;
            do
            {
                result = _Random.Next(1, 10000);
            } while (cachedElements.Contains(result));

            return result;
        }

        public void DeleteElement(int value)
        {
            Tree.Remove(value);
        }

        public string PrintElements(TreePrintVariants variant)
        {
            return Tree.Print(variant);
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
            // берём не отсортированный 0 элемент и меняем местами с минимальным неотсротированным элементом справа
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

            // вставляем каждый следующий не отсортированный элемент в отсортированную последовательность
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
            return $"Сортировка шелла; прошло времени: {timer.Elapsed.TotalSeconds} сек; кол-во перестановок: {countOfReplacements}";
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

    public class CustomList<T>
    {

        protected IElement<T> RootElement { get; set; }

        public CustomList()
        {

        }

        public CustomList(T value)
        {
            RootElement = new CustomListElement<T>(value);
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

        public virtual void Add(T value)
        {
            if (RootElement == null)
            {
                RootElement = new CustomListElement<T>(value);
                return;
            }
            var curElement = RootElement;
            while (curElement.NextItem != null)
                curElement = curElement.NextItem;

            curElement.NextItem = new CustomListElement<T>(value, null);
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

        public virtual bool Remove(T value)
        {
            var curElement = RootElement;
            var prevElement = RootElement;
            bool isElementFound = false;
            for (int i = 0; i < Count; i++)
            {
                if (curElement.Value.Equals(value))
                {
                    isElementFound = true;
                    break;
                }
                prevElement = curElement;
                curElement = curElement.NextItem;
            }

            if (curElement == RootElement)
            {
                if (RootElement.NextItem != null)
                    RootElement = RootElement.NextItem;
                else
                    RootElement = null;
            }
            else
            {
                var nextElement = curElement.NextItem;
                prevElement.NextItem = nextElement;
            }

            return isElementFound;
        }

        public virtual void RemoveAt(int index)
        {
            Remove(ElementAt(index));
        }

        public T First()
        {
            return RootElement.Value;
        }

        public T Last()
        {
            var result = RootElement;
            while (result.NextItem != null)
                result = result.NextItem;
            return result.Value;
        }

        public bool Any()
        {
            return RootElement != null;
        }

        public virtual bool Any(Func<T, bool> predicate)
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

        public CustomList<T> Where(Func<T, bool> predicate)
        {
            var result = new CustomList<T>();
            var element = RootElement;
            for (int i = 0; i < Count; i++)
            {
                if (predicate(element.Value))
                    result.Add(element.Value);
                element = element.NextItem;
            }
            return result;
        }

        public bool Contains(T value)
        {
            return Any(x => x.Equals(value));
        }

        public virtual void Insert(int index, T value)
        {
            if (index >= Count)
                throw new IndexOutOfRangeException();

            if (index == 0)
            {
                var newItem = new CustomListElement<T>(value, RootElement);
                RootElement = newItem;
                return;
            }

            var curElement = RootElement;
            for (int i = 0; i < index-1; i++)
                curElement = curElement.NextItem;
            curElement.NextItem = new CustomListElement<T>(value, curElement.NextItem);
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

    public class CustomLinkedList<T> : CustomList<T>
    {

        public CustomLinkedList()
        {

        }

        public CustomLinkedList(T value)
        {
            RootElement = new CustomLinkedListElement<T>(value);
        }

        public override void Add(T value)
        {
            if (RootElement == null)
            {
                RootElement = new CustomListElement<T>(value);
                return;
            }
            var curElement = RootElement;
            while (curElement.NextItem != null)
                curElement = curElement.NextItem;

            curElement.NextItem = new CustomLinkedListElement<T>(value, null, curElement);
        }

        public override bool Remove(T value)
        {
            var element = new CustomLinkedListElement<T>(RootElement.Value, RootElement.NextItem, null);
            bool isElementFound = false;
            for (int i = 0; i < Count; i++)
            {
                if (element.Value.Equals(value))
                {
                    isElementFound = true;
                    break;
                }
                element = (CustomLinkedListElement<T>)element.NextItem;
            }

            if (RootElement.NextItem != null)
            {
                if (!element.Equals(RootElement))
                {
                    var prevElement = element.PrevItem;
                    var nextElement = (CustomLinkedListElement<T>)element.NextItem;
                    prevElement.NextItem = nextElement;
                    if (nextElement != null)
                        nextElement.PrevItem = prevElement;
                }
                else
                    RootElement = RootElement.NextItem;
            }
            else
                RootElement = null;

            return isElementFound;
        }

        public override void Insert(int index, T value)
        {
            if (index >= Count)
                throw new IndexOutOfRangeException();

            if (index == 0)
            {
                var newItem = new CustomLinkedListElement<T>(value, RootElement, null);
                RootElement = newItem;
                return;
            }

            var curElement = RootElement;
            for (int i = 0; i < index - 1; i++)
                curElement = curElement.NextItem;
            curElement.NextItem = new CustomLinkedListElement<T>(value, curElement.NextItem, curElement);
        }

        public T[] ToArray()
        {
            int countOfElements = 0;
            if (RootElement == null)
            {
                return null;
            }
            var curElement = RootElement;
            countOfElements++;
            while (curElement.NextItem != null)
            {
                curElement = curElement.NextItem;
                countOfElements++;
            }

            var result = new T[countOfElements];
            curElement = RootElement;
            for (int i = 0; i < countOfElements; i++)
            {
                result[i] = curElement.Value;
                curElement = curElement.NextItem;
            }
            return result;
        }

    }

    public interface IElement<T>
    {

        T Value { get; set; }

        IElement<T> NextItem { get; set; }

    }

    public class CustomListElement<T> : IElement<T>
    {

        public T Value { get; set; }

        public IElement<T> NextItem { get; set; }

        public CustomListElement(T value)
        {
            Value = value;
        }

        public CustomListElement(T value, IElement<T> nextItem)
        {
            Value = value;
            NextItem = nextItem;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override bool Equals(object obj)
        {
            var e = obj as IElement<T>;
            return e?.Value.Equals(Value) ?? false;
        }

    }

    public class CustomLinkedListElement<T> : IElement<T>
    {

        public T Value { get; set; }

        public IElement<T> NextItem { get; set; }

        public IElement<T> PrevItem { get; set; }

        public CustomLinkedListElement(T value) 
        {
            Value = value;
        }

        public CustomLinkedListElement(T value, IElement<T> nextItem, IElement<T> prevItem)
        {
            Value = value;
            NextItem = nextItem;
            PrevItem = prevItem;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override bool Equals(object obj)
        {
            var e = obj as IElement<T>;
            return e?.Value.Equals(Value) ?? false;
        }

    }

    public class BinaryTree<T>
    {

        private TreeElement<T> RootElement;

        public BinaryTree()
        {
            RootElement = null;
        }

        public void Add(CustomLinkedList<T> elements)
        {
            if (RootElement == null)
            {
                RootElement = new TreeElement<T>(elements.ElementAt(0));
                elements.RemoveAt(0);
            }
            Add(elements.ToArray(), RootElement);
        }

        private void Add(T[] elements, TreeElement<T> parent)
        {
            if (elements.Length == 0)
                return;

            var leftElement = new TreeElement<T>(elements[0], parent);

            if (elements.Length == 1)
            {
                parent.Left = leftElement;
                return;
            }

            int middle = elements.Length / 2;
            var rightElement = new TreeElement<T>(elements[middle], parent);

            parent.Left = leftElement;
            Add(CutArray(elements, 1, middle), leftElement);

            parent.Right = rightElement;
            Add(CutArray(elements, middle+1, elements.Length), rightElement);
        }

        private T[] CutArray(T[] source, int start, int end)
        {
            var result = new T[end - start];
            for (int i = start, j = 0; i < end; i++, j++)
                result[j] = source[i];
            return result;
        }

        public void Remove(T element)
        {
            if (RootElement == null)
                return;

            Remove(RootElement, element);
        }

        private void Remove(TreeElement<T> curElement, T searchValue)
        {
            if (curElement.Value.Equals(searchValue))
            {
                var parent = curElement.Parent;

                if (curElement.Left != null)
                {
                    var e = curElement.Left;
                    var side = Sides.Left;
                    while (!curElement.IsHaveChilds)
                    {
                        if (curElement.Left != null)
                        {
                            e = curElement.Left;
                            side = Sides.Left;
                        }
                        else if (curElement.Right != null)
                        {
                            e = curElement.Right;
                            side = Sides.Right;
                        }
                    }
                    curElement.Value = e.Value;
                    if (side == Sides.Left)
                        e.Parent.Left = null;
                    else if (side == Sides.Right)
                        e.Parent.Right = null;
                }
                else if (curElement.Right != null)
                {
                    var e = curElement.Right;
                    var side = Sides.Left;
                    while (!curElement.IsHaveChilds)
                    {
                        if (curElement.Left != null)
                        {
                            e = curElement.Left;
                            side = Sides.Left;
                        }
                        else if (curElement.Right != null)
                        {
                            e = curElement.Right;
                            side = Sides.Right;
                        }
                    }
                    curElement.Value = e.Value;
                    if (side == Sides.Left)
                        curElement.Parent.Left = null;
                    else if (side == Sides.Right)
                        curElement.Parent.Right = null;
                }
                else
                {
                    if (parent.Left == curElement)
                        parent.Left = null;
                    else if (parent.Right == curElement)
                        parent.Right = null;
                }
                return;
            }

            if (curElement.Left != null)
                Remove(curElement.Left, searchValue);

            if (curElement.Right != null)
                Remove(curElement.Right, searchValue);
        }

        public string Print(TreePrintVariants variant)
        {
            StringBuilder result = new StringBuilder();
            switch (variant)
            {
                case TreePrintVariants.Direct: result.Append(DirectPrint()); break;
                case TreePrintVariants.Symmetrial: result.Append(SymmetrialPrint()); break;
                case TreePrintVariants.RevertSymmetrial: result.Append(RevertSymmetrialPrint()); break;
            }
            return result.ToString();
        }

        private string DirectPrint()
        {
            string Print(TreeElement<T> element, int padding, string letter)
            {
                padding += 11;
                string r = $"{Environment.NewLine}{(letter+element.Value).PadLeft(padding)}";
                if (element.Left != null)
                    r += Print(element.Left, padding, "L:");
                if (element.Right != null)
                    r += Print(element.Right, padding, "R:");
                return r;
            }
            StringBuilder result = new StringBuilder();

            if (RootElement == null)
                return "";

            result.Append(Print(RootElement, 0, "S:"));

            return result.ToString();
        }

        private string SymmetrialPrint()
        {
            string Print(TreeElement<T> element, int padding, bool isRight = false)
            {
                padding += 8;
                string topPadding = Environment.NewLine;
                string bottomPadding = !isRight ? Environment.NewLine : "";
                string r = $"{bottomPadding}{element.Value.ToString().PadLeft(padding)}{topPadding}";
                if (element.Right != null)
                    r = r.Insert(0, Print(element.Right, padding, true)); 
                if (element.Left != null)
                    r += Print(element.Left, padding);
                return r;
            }
            StringBuilder result = new StringBuilder();

            result.Append(Print(RootElement, 0));

            return result.ToString();
        }

        private string RevertSymmetrialPrint()
        {
            string Print(TreeElement<T> element, int padding, bool isLeft = false)
            {
                padding += 8;
                string topPadding = Environment.NewLine;
                string bottomPadding = !isLeft ? Environment.NewLine : "";
                string r = $"{bottomPadding}{element.Value.ToString().PadLeft(padding)}{topPadding}";
                if (element.Left != null)
                    r = r.Insert(0, Print(element.Left, padding, true));
                if (element.Right != null)
                    r += Print(element.Right, padding);
                return r;
            }
            StringBuilder result = new StringBuilder();

            result.Append(Print(RootElement, 0));

            return result.ToString();
        }

    }

    public class TreeElement<T>
    {

        public T Value { get; set; }

        public TreeElement<T> Parent { get; set; }

        public TreeElement<T> Left { get; set; }

        public TreeElement<T> Right { get; set; }

        public bool IsHaveChilds 
        { 
            get 
            { 
                return Left != null || Right != null; 
            } 
        }

        public TreeElement(T value, TreeElement<T> parent = null)
        {
            Value = value;
            Parent = parent;
        }

        public override bool Equals(object obj)
        {
            var e = obj as TreeElement<T>;
            return Value.Equals(e.Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

    }

    public enum AddVariants
    {

        BeforeElement = 0, AfterElement = 1, AfterAll = 2

    }

    public enum TreePrintVariants
    {

        Direct = 0, Symmetrial = 1, RevertSymmetrial = 2

    }

    public enum Sides
    {
        Left = 0, Right = 1
    }

}