namespace Type
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var operationItems = new string[]
            {
                "+",
                "-",
                "*",
                "/",
                ">=<",
            };

            cmbOperator.DataSource = new List<string>(operationItems);
            cmbOperator.Text = operationItems[0];
        }
        private void Calculate()
        {
            try
            {
                var numerator1 = int.Parse(txtNumer1.Text);
                var denominator1 = int.Parse(txtDenom1.Text);

                var numerator2 = int.Parse(txtNumer2.Text);
                var denominator2 = int.Parse(txtDenom2.Text);

                var firstFraction = new Fraction(numerator1, denominator1);
                var secondFraction = new Fraction(numerator2, denominator2);

                Fraction fraction;
                string result = "";

                switch (cmbOperator.Text)
                {
                    case "+":
                        fraction = firstFraction + secondFraction;
                        txtResult.Text = fraction.FractionValue();
                        break;
                    case "-":
                        fraction = firstFraction - secondFraction;
                        txtResult.Text = fraction.FractionValue();
                        break;
                    case "*":
                        fraction = firstFraction * secondFraction;
                        txtResult.Text = fraction.FractionValue();
                        break;
                    case "/":
                        fraction = firstFraction / secondFraction;
                        txtResult.Text = fraction.FractionValue();
                        break;
                    case ">=<":
                        result = firstFraction.Compare(firstFraction, secondFraction);
                        txtResult.Text = result;
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void onValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
