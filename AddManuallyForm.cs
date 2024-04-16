namespace Lab16
{
    public partial class AddManuallyForm : Form
    {
        readonly ActionType actionType;
        readonly MainModel model;

        public AddManuallyForm(MainModel model, ActionType actionType, string nameGroupBox)
        {
            InitializeComponent();

            this.model = model;
            this.actionType = actionType;

            AddGroupBox.Text = nameGroupBox;

            if (actionType == ActionType.Delete)
            {
                WeightPanel.Visible = false;
                PricePanel.Visible = false;
            }
        }

        private bool ValidateFields(out string name, out double price, out double weight)
        {
            name = NameTextBox.Text.Trim();
            price = 0;
            weight = 0;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя товара.");
                return false;
            }

            if (actionType != ActionType.Delete)
            {
                if (!double.TryParse(PriceTextBox.Text, out price) || !double.TryParse(WeightTextBox.Text, out weight))
                {
                    MessageBox.Show("Введите корректные значения для цены и веса.");
                    return false;
                }

                if (price < 0 || weight < 0)
                {
                    MessageBox.Show("Значения цены и веса должны быть положительными числами.");
                    return false;
                }
            }

            return true;
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields(out var name, out var price, out var weight))
                return;

            string message;

            try
            {
                switch (actionType)
                {
                    case ActionType.Add:
                        model.Add(name, price, weight);
                        message = $"Товар {name} успешно добавлен";
                        break;
                    case ActionType.Modify:
                        model.Modify(name, price, weight);
                        message = $"Товар {name} успешно изменен";
                        break;
                    case ActionType.Delete:
                        if (model.Delete(name))
                            message = $"Товар {name} успешно удален";
                        else
                            message = $"Товар {name} не удалось удалить";
                        break;
                    default:
                        message = "Неизвестная команда";
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                message = ex.Message;
            }
            catch (Exception ex)
            {
                message = $"Произошла ошибка: {ex.Message}";
            }

            MessageBox.Show(message);
        }
    }
}
