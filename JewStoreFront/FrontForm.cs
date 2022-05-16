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
            listBox.Items.Clear();
            comboBoxType.SelectedIndex = 0;
            comboBoxSorting.SelectedIndex = 0;
        }

        // Обновить список товаров в левой части экрана
        private void UpdateItemsList()
        {
            
        }

        private void comboBoxType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateItemsList();
        }

        private void comboBoxSorting_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateItemsList();
        }
    }
}
