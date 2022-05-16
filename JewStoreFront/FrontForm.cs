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
            this.labelItemName.Text = item.Name;
            this.labelItemDescription.Text = $"Вес: {item.Weight}";
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
