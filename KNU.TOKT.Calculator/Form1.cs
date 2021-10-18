using System;
using System.Data;
using System.Windows.Forms;

namespace KNU.TOKT.Calculator
{
    public partial class FormMain : Form
    {
        private const int tabulatedValuesNumber = 10;
        private const int plotValuesNumber = 100;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (textBoxArgument.Text.Equals(string.Empty))
            {
                textBoxArgument.Text = 0.ToString();
            }

            var expressionText = textBoxExpression.Text;
            var x = textBoxArgument.Text;

            if (!double.TryParse(x, out var doubleValue))
            {
                HandleInvalidInput(textBoxArgument, GetNumericErrorMessage("Argument"));
            }

            var expression = expressionText
                .Replace(nameof(x), x)
                .Replace(" ", string.Empty);

            try
            {
                var result = Calculator.Evaluate(expression);
                label1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                HandleInvalidInput(textBoxExpression, ex.Message);
            }
        }

        private void buttonVisualize_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxX1.Text, out var x1))
            {
                HandleInvalidInput(textBoxX1, GetNumericErrorMessage("Lower boundary"));
            }

            if (!double.TryParse(textBoxX2.Text, out var x2))
            {
                HandleInvalidInput(textBoxX1, GetNumericErrorMessage("Upper boundary"));
            }

            if (x1 >= x2)
            {
                HandleInvalidInput(textBoxX1, "Insufficient boundaries.");
            }

            var table = new DataTable();
            table.Columns.AddRange(new DataColumn[3]
            {
                new DataColumn("#", typeof(int)),
                new DataColumn("x", typeof(double)),
                new DataColumn("f(x)",typeof(double))
            });

            var step = (x2 - x1) / tabulatedValuesNumber;
            var expressionText = textBoxExpression.Text;
            var x = x1;

            for (int i = 0; i < tabulatedValuesNumber; ++i)
            {
                var expression = expressionText
                    .Replace(nameof(x), x.ToString())
                    .Replace(" ", string.Empty);

                table.Rows.Add(i, Math.Round(x, 5), Calculator.Evaluate(expression));
                x += step;
            }

            dataGridTabulation.DataSource = table;
        }

        private void HandleInvalidInput(TextBox textBox, string reason)
        {
            MessageBox.Show($"Invalid input, please resubmit. Reason: {reason}");
        }

        private string GetNumericErrorMessage(string issuer)
        {
            return $"{issuer} should be numeric.";
        }
    }
}
