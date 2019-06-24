using Radio.Core.Context;
using Radio.Core.Enum;
using Radio.Core.Factory;
using System;
using System.Windows.Forms;

namespace Radio.App
{
    public partial class MainForm : Form
    {
        private IRadioContext _context;

        public MainForm(IRadioContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            _context = context;

            InitializeComponent();

            btnEnterNumber.Hide();
            lblNumber.Hide();
            tbxNumber.Hide();
            lblStatus.Hide();
        }

        private void btnEnterLimit_Click(object sender, EventArgs e)
        {
            var limitNumber = 0;
            if (int.TryParse(tbxNumberLimit.Text, out limitNumber))
            {
                if (limitNumber >= 1)
                {
                    _context.SetUpperLimit(limitNumber);
                }

                btnEnterLimit.Hide();
                lblUpperLimit.Hide();
                tbxNumberLimit.Hide();
                btnEnterNumber.Show();
                lblNumber.Show();
                tbxNumber.Show();
            }
        }

        private void btnEnterNumber_Click(object sender, EventArgs e)
        {
            var enteredNumber = 0;
            if (int.TryParse(tbxNumber.Text, out enteredNumber))
            {
                if (enteredNumber >= 1)
                {
                    _context.SetEnteredNumber(enteredNumber);
                    RadioOperationFactory.Instance.Operation(RadioOperation.GuessNumber)
                       .Execute(_context);

                    switch (_context.State)
                    {
                        case NumberState.Bigger:
                            lblStatus.ForeColor = System.Drawing.Color.Red;
                            lblStatus.Text = "Bigger";
                            break;
                        case NumberState.Smaller:
                            lblStatus.ForeColor = System.Drawing.Color.Blue;
                            lblStatus.Text = "Smaller";
                            break;
                        case NumberState.Bullseye:
                            MessageBox.Show($"Congratulations, number was: " + _context.TargetNumber);
                            Application.Exit();
                            break;
                        case NumberState.GameOver:
                            MessageBox.Show($"Game over, number was: " + _context.TargetNumber);
                            this.Close();
                            break;
                    }

                    lblStatus.Show();
                }
            }
        }
    }
}
