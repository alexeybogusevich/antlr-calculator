using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KNU.TOKT.Calculator
{
    public partial class FormMain : Form
    {
        private const int tabulatedValuesNumber = 10;
        private const int plotValuesNumber = 100;
        private const int precision = 5;

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

            if (!double.TryParse(x, NumberStyles.Any, CultureInfo.InvariantCulture, out var doubleValue))
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
            var expressionText = textBoxExpression.Text;

            if (!double.TryParse(textBoxX1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var x1))
            {
                HandleInvalidInput(textBoxX1, GetNumericErrorMessage("Lower boundary"));
            }

            if (!double.TryParse(textBoxX2.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var x2))
            {
                HandleInvalidInput(textBoxX1, GetNumericErrorMessage("Upper boundary"));
            }

            if (x1 >= x2)
            {
                HandleInvalidInput(textBoxX1, "Insufficient boundaries.");
            }

            VisualizeTabulation(x1, x2, expressionText);

            VisualizePlot(x1, x2, expressionText);
        }

        private string VisualizeTabulation(double x1, double x2, string expressionText)
        {
            var table = new DataTable();
            table.Columns.AddRange(new DataColumn[3]
            {
                new DataColumn("#", typeof(int)),
                new DataColumn("x", typeof(double)),
                new DataColumn("f(x)",typeof(double))
            });

            var step = (x2 - x1) / tabulatedValuesNumber;
            var x = x1;

            for (int i = 0; i <= tabulatedValuesNumber; ++i)
            {
                var expression = expressionText
                    .Replace(nameof(x), x.ToString())
                    .Replace(" ", string.Empty);

                table.Rows.Add(i, Math.Round(x, precision), Calculator.Evaluate(expression));
                x += step;
            }

            dataGridTabulation.DataSource = table;
            return expressionText;
        }

        private void VisualizePlot(double x1, double x2, string expressionText)
        {
            var plotSource = new DataTable();
            plotSource.Columns.Add("X", typeof(double));
            plotSource.Columns.Add("Y", typeof(double));

            var step = (x2 - x1) / plotValuesNumber;
            var x = x1;

            for (int i = 0; i <= plotValuesNumber; ++i)
            {
                var expression = expressionText
                    .Replace(nameof(x), x.ToString())
                    .Replace(" ", string.Empty);

                plotSource.Rows.Add(Math.Round(x, precision), Calculator.Evaluate(expression));
                x += step;
            }

            chartPlot.DataSource = plotSource;
            chartPlot.Series["Series1"].XValueMember = "X";
            chartPlot.Series["Series1"].YValueMembers = "Y";
            chartPlot.Series["Series1"].ChartType = SeriesChartType.Line;

            chartPlot.ChartAreas[0].AxisY.LabelStyle.Format = string.Empty;
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
