
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq;
using System.Reflection.Emit;
using System;
using System.Collections.Generic;

namespace stockhouse
{
    public partial class Stock : Form
    {

        private readonly List<Tovar> tovarList;
        private readonly BindingSource bindingSource;
        //private decimal totalSum = 0;
        public Stock()
        {
            InitializeComponent();
            tovarList = new List<Tovar>();
            bindingSource = new BindingSource();
            bindingSource.DataSource = tovarList;
            DGV.DataSource = bindingSource;
            DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void CalculateStats()
        {
            countStrip.Text = $"Общее количество: {tovarList.Count}";
            withoutStrip.Text = $"Сумма: {tovarList.Sum(x=>x.price * x.count)} ₽";
            sumStrip.Text = $"С НДС: {tovarList.Sum(x => x.price * x.count + (x.price * x.count * 0.2m))} ₽";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addMenu_Click(sender, e);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var target = (Tovar)DGV.Rows[DGV.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show("Вы действительно собираетесь удалить товар?",
                "Удаление товара",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tovarList.Remove(target);
                bindingSource.ResetBindings(false);
                CalculateStats();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
           var target = (Tovar)DGV.Rows[DGV.SelectedRows[0].Index].DataBoundItem;
            var infoform = new infoForm(target);
            infoform.Text = "Редактирование товара"; 

            if (infoform.ShowDialog(this) == DialogResult.OK)
            {
                target.Name = infoform.Tovar.Name;
                target.Size = infoform.Tovar.Size;
                target.Material = infoform.Tovar.Material;
                target.count = infoform.Tovar.count;
                target.minCount = infoform.Tovar.minCount;
                target.price = infoform.Tovar.price;
                bindingSource.ResetBindings(false);
                CalculateStats();
            }
        }

        private void addMenu_Click(object sender, EventArgs e)
        {
            var infoform = new infoForm();
            infoform.Text = "Добавление товара";
            if (infoform.ShowDialog(this) == DialogResult.OK)
            {
                tovarList.Add(infoform.Tovar);
                bindingSource.ResetBindings(false);
                CalculateStats();
            }
        }

        private void changeMenu_Click(object sender, EventArgs e)
        {
            editBtn_Click(sender, e); 
        }

        private void deleteMenu_Click(object sender, EventArgs e)
        {
            deleteBtn_Click(sender, e);
        }
        private void exitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (DGV.Columns[e.ColumnIndex].Name == "sumCol")
            {
                decimal totalSum = 0;
                var target = (Tovar)DGV.Rows[e.RowIndex].DataBoundItem;
                totalSum += (target.count * target.price);
                e.Value = totalSum;
            }
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            editBtn.Enabled =
            deleteBtn.Enabled =
            changeMenu.Enabled =
            deleteMenu.Enabled =
            DGV.SelectedRows.Count == 1;
        }
    }
}