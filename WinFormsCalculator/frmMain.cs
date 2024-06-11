namespace WinFormsCalculator
{
    public partial class FrmMain : Form
    {
        private decimal _Buffer = 0;
        private char _operation;
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void CmdNumberButtonPressed(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (Screen_Display.Text == "")
            {
                Screen_Display.Text = button.Text;
            }
            else
            {
                Screen_Display.Text += button.Text;
            }
        }

        private void CmdClearPressed(object sender, EventArgs e)
        {

        }

        private void CmdEqualButtonPressed(object sender, EventArgs e)
        {
            decimal currentValue = decimal.Parse(Screen_Display.Text);
            Screen_Display.Text = _operation switch
            {
                '+' => (_Buffer + currentValue).ToString(),
                '-' => (_Buffer - currentValue).ToString(),
                '/' => (_Buffer / currentValue).ToString(),
                '*' => (_Buffer * currentValue).ToString(),
            };
            
        }

        private void CmdOperationButtonPressed(object sender, EventArgs e)
        {
            var button = sender as Button;
            _Buffer = decimal.Parse(Screen_Display.Text);
            _operation = char.Parse(button.Text);
            Screen_Display.Text = "";

        }
    }
}
