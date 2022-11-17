using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using ComboBox = System.Windows.Forms.ComboBox;

namespace stockhouse
{
    public partial class infoForm : Form
    {
        public Tovar Tovar => tovar;

        public readonly Tovar tovar;
        public infoForm()
        {
            InitializeComponent();
            SetMateriaL();
            tovar = new Tovar
            {
                Material = material.Железо,
            };
            materialCB.SelectedItem = tovar.Material;
        }

        public infoForm(Tovar sourse)
            : this()
        {
            nameTB.Text = sourse.Name;
            sizeUD.Value = sourse.Size;
            materialCB.SelectedItem = sourse.Material;
            countUD.Value= sourse.count;
            minUD.Value = sourse.minCount;
            priceUD.Value = sourse.price;
        }

        private void SetMateriaL()
        {
            foreach (var item in Enum.GetValues(typeof(material)))
            {
                materialCB.Items.Add(item);
            }
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            tovar.Name = nameTB.Text.Trim();
            Validate();
        }

        private void MaterialCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialCB.SelectedIndex >= 0)
            {
                tovar.Material =  (material)materialCB.SelectedIndex;
            }
        }

        private void SizeUD_ValueChanged(object sender, EventArgs e)
        {
            tovar.Size = sizeUD.Value;
            Validate();
        }

        private void CountUD_ValueChanged(object sender, EventArgs e)
        {
            tovar.count = countUD.Value;
            Validate();
        }

        private void MinUD_ValueChanged(object sender, EventArgs e)
        {
            tovar.minCount = minUD.Value;
            Validate();
        }

        private void PriceUD_ValueChanged(object sender, EventArgs e)
        {
            tovar.price = priceUD.Value;
            Validate();
        }

        
        public new void Validate()
        {
            SaveButton.Enabled = !string.IsNullOrWhiteSpace(tovar.Name);
        }
    }
}
