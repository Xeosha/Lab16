using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventBinaryTree;
using Lab_10lib;

namespace Lab16
{
    public partial class AddManuallyForm : Form
    {
        readonly ActionType actionType;
        readonly MainForm mainForm;

        public AddManuallyForm(MainForm mainForm, ActionType actionType, string nameGroupBox)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.actionType = actionType;

            AddGroupBox.Text = nameGroupBox;

            if (actionType == ActionType.Delete)
            {
                WeightPanel.Visible = false;
                PricePanel.Visible = false;
            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || PriceTextBox.Text == "" || WeightTextBox.Text == "")
            {
                MessageBox.Show("Введите все поля.");
                return;
            }

            var flag = Double.TryParse(PriceTextBox.Text, out double price) &
                       Double.TryParse(WeightTextBox.Text, out double weight);

            if (!flag || price < 0 || weight < 0)
            {
                MessageBox.Show("Значения веса и цены должны быть double и > 0 ");
                return;
            }

            var product = new Goods(NameTextBox.Text, price, weight);

            var binaryTree = mainForm.binaryTree;

            string message;
            switch (actionType)
            {
                case ActionType.Add:
                    try
                    {
                        binaryTree.Add(product);
                        message = $"Товар {product.Name} успешно добавлен";
                    }
                    catch (Exception)
                    {
                        message = $"Товар {product.Name} уже есть в дереве";
                    }
                    break;
                case ActionType.Modify:
                    try
                    {
                        binaryTree[product.Name] = new Goods("", price, weight);
                        message = $"Атрибуты товара {product.Name} успешно изменены";
                    }
                    catch (Exception)
                    {
                        message = $"Товар не удалось найти";
                    }

                    break;
                case ActionType.Delete:
                    if (binaryTree.Remove(product))
                        message = $"Товар {product.Name} успешно удален";
                    else
                        message = $"Товар {product.Name} не удалось найти";
                    break;
                default:
                    message = "Неизвестная команда";
                    break;
            }
            MessageBox.Show(message);
        }
    }
}
