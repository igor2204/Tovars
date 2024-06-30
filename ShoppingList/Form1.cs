using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class Form1 : Form
    {
        private List<Item> items = new List<Item>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            string newItem = textBoxItem.Text.Trim();
            int quantity;
            double price;

            if (!string.IsNullOrEmpty(newItem) && int.TryParse(textBoxQuantity.Text, out quantity) && double.TryParse(textBoxPrice.Text, out price))
            {
                items.Add(new Item(newItem, quantity, price));
                listBoxItems.Items.Add($"{newItem} x{quantity} ({price:C})");
                textBoxItem.Clear();
                textBoxQuantity.Clear();
                textBoxPrice.Clear();
                textBoxItem.Focus();
                UpdateTotalCost();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное название товара, количество и цену.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex != -1)
            {
                items.RemoveAt(listBoxItems.SelectedIndex);
                listBoxItems.Items.RemoveAt(listBoxItems.SelectedIndex);
                UpdateTotalCost();
            }
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            items.Clear();
            listBoxItems.Items.Clear();
            UpdateTotalCost();
        }

        private void textBoxItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (Item item in items)
                        {
                            writer.WriteLine($"{item.Name},{item.Quantity},{item.Price}");
                        }
                    }
                    MessageBox.Show("Список успешно сохранен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении списка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    items.Clear();
                    listBoxItems.Items.Clear();
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length == 3 && int.TryParse(parts[1], out int quantity) && double.TryParse(parts[2], out double price))
                            {
                                items.Add(new Item(parts[0], quantity, price));
                                listBoxItems.Items.Add($"{parts[0]} x{quantity} ({price:C})");
                            }
                        }
                    }
                    UpdateTotalCost();
                    MessageBox.Show("Список успешно загружен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке списка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateTotalCost()
        {
            double totalCost = 0;
            foreach (Item item in items)
            {
                totalCost += item.Quantity * item.Price;
            }
            labelTotalCost.Text = $"Общая стоимость: {totalCost:C}";
        }

        // Класс для представления товара
        private class Item
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }

            public Item(string name, int quantity, double price)
            {
                Name = name;
                Quantity = quantity;
                Price = price;
            }
            public override string ToString()
            {
                return $"{Name} x{Quantity} ({Price:C})";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
