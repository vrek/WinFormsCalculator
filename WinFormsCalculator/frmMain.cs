namespace WinFormsCalculator
{
    public partial class FrmMain : Form
    {

        Calculator_Controller.Calculator_Controller Calc_Controller = new();
        

        public FrmMain()
        {
            InitializeComponent();
        }
        public void CmdNumberButtonPressed(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Calc_Controller.InterpetNumber(button.Text);
            UpdateDisplay();

        }
        public void UpdateDisplay()
        {
            Screen_Display.Text = Calc_Controller.GetExpression();
        }
        public void CmdClearPressed(object sender, EventArgs e)
        {
            
        }
        public void CmdEqualButtonPressed(object sender, EventArgs e)
        {
            //string result = Calc_Controller.CalculateExpression();
            //UpdateDisplay();
        }
        public void CmdOperationButtonPressed(object sender, EventArgs e)
        {

            var button = (sender as Button).Text;
            Calc_Controller.SetOperator(button);
            UpdateDisplay();

        }
    }
}
