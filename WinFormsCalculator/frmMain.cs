using Calculator_Controller;
using System.Globalization;

namespace WinFormsCalculator
{
    public partial class FrmMain : Form
    {
        private List<string> _Buffer = [];
        NumberOperations _numbers = new();
        OperatorOperations Operator = new();
        string currentValue = "0";

        public FrmMain()
        {
            InitializeComponent();
        }
        public void CmdNumberButtonPressed(object sender, EventArgs e)
        {
            var button = sender as Button;
            string value;
            value = _numbers.InterpetNumber(button.Text, currentValue);
            currentValue = value;
            UpdateDisplay(value);

        }
        public void UpdateDisplay(string value)
        {
            Screen_Display.Text = value;
        }
        public void CmdClearPressed(object sender, EventArgs e)
        {
            Screen_Display.Text = "";
            _Buffer.Clear();
            currentValue = "0";
        }
        public void CmdEqualButtonPressed(object sender, EventArgs e)
        {
            string result = Operator.CalculateExpression(_Buffer, currentValue);
            UpdateDisplay(result);
            currentValue = "0";
        }
        public void CmdOperationButtonPressed(object sender, EventArgs e)
        {

            var button = (sender as Button).Text;
            _Buffer = Operator.SetOperator(_Buffer, button, currentValue);
            UpdateDisplay("");
            currentValue = "0";
        }
    }
}
