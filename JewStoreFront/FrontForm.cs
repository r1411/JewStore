using JewStoreFS;
using System.Windows.Forms;
using Microsoft.FSharp.Collections;
using System;
using Microsoft.FSharp.Core;

namespace JewStoreFront
{
    public partial class FrontForm : Form
    {
        private JsonDB db;
        private FSharpList<JewelryItemBase> selectedItems;

        public FrontForm(string dbPath)
        {
            this.db = new JsonDB(dbPath);
            
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            comboBoxSorting.SelectedIndex = 3;
        }

        // Отобразить товар в правой части экрана
        private void DisplayItem(JewelryItemBase item)
        {
            string desc = $"Вес: {item.Weight} г\n" +
                $"Материал: {FormatUtils.MaterialToString(item.Material)}\n" +
                $"Проба: {item.MaterialSample}\n";

            if (item is Ring)
            {
                Ring ring = (Ring)item;
                desc += $"Размер: {ring.Size}\n";
            }

            if (item is Earring)
            {
                Earring earring = (Earring)item;
                desc += $"Длина: {earring.Length} мм\n" +
                    "С замком: " + (earring.HasLock ? "Да" : "Нет") + "\n";
            }

            if (item is Chain)
            {
                Chain chain = (Chain)item;
                desc += $"Размер: {chain.Size}\n" +
                    $"Тип плетения: {chain.WeavingName}\n" +
                    $"Толщина проволоки: {chain.WireThickness}\n";
            }

            if (item is Watch)
            {
                Watch watch = (Watch)item;
                desc += $"Диаметр циферблата: {watch.FaceDiameter} мм\n" +
                    $"Длина ремешка: {watch.BandLength} мм\n" +
                    $"Подсветка: " + (watch.HasLights ? "Есть" : "Нет") + "\n";
            }

            if (OptionModule.IsSome(item.GemData))
            {
                desc += $"\nДрагоценный камень: {FormatUtils.GemTypeToString(item.GemData.Value.GemType)}\n" +
                    $"Количество: {item.GemData.Value.GemCount} шт.\n" +
                    $"Суммарный вес: {item.GemData.Value.GemWeight * item.GemData.Value.GemCount} карат\n";
            }

            desc += $"\nАртикул: {item.Article}\n" +
                $"Цена: {item.Price} ₽";


            this.labelItemName.Text = item.Name;
            this.labelItemDescription.Text = desc;
        }

        // Обновить список товаров в левой части экрана
        private void UpdateItemsList()
        {
            FSharpList<JewelryItemBase> list = FSharpList<JewelryItemBase>.Empty;
            switch (comboBoxType.SelectedIndex)
            {
                case 0:
                    list = db.GetAllJewelry();
                    break;
                case 1:
                    list = db.GetRings();
                    break;
                case 2:
                    list = db.GetEarrings();
                    break;
                case 3:
                    list = db.GetChains();
                    break;
                case 4:
                    list = db.GetWatches();
                    break;
            }

            Func<JewelryItemBase, JewelryItemBase, int> sortingFunc = (a, b) => 0;
            switch (comboBoxSorting.SelectedIndex)
            {
                case 0:
                    sortingFunc = (a, b) => a.Name.CompareTo(b.Name);
                    break;
                case 1:
                    sortingFunc = (a, b) => b.Name.CompareTo(a.Name);
                    break;
                case 2:
                    sortingFunc = (a, b) => a.Price.CompareTo(b.Price);
                    break;
                case 3:
                    sortingFunc = (a, b) => b.Price.CompareTo(a.Price);
                    break;
            }
            this.selectedItems = JsonDB.Sorted(list, FuncConvert.FromFunc(sortingFunc));

            listBox.Items.Clear();
            ListModule.Iterate(FuncConvert.FromAction<JewelryItemBase>(x => listBox.Items.Add(x.Name)), selectedItems);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateItemsList();
        }

        private void comboBoxSorting_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateItemsList();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayItem(selectedItems[listBox.SelectedIndex]);
        }
    }
}
