using FibonacciSequence.Logic;
using System;
using System.Windows.Forms;

namespace FibonacciSequence
{
	public partial class FrmFibo : Form
	{
		// create FiboCalculator and FiboInputChecker instance
		readonly FiboCalculator m_fiboCalculator = new FiboCalculator();
		readonly FiboInputChecker m_fiboInputChecker = new FiboInputChecker();

		public FrmFibo()
		{
			InitializeComponent();
		}

		void m_btnCalculate_Click( object sender, EventArgs e )
		{
			SetFiboSequenceNumber();
		}

		void SetFiboSequenceNumber()
		{
			string szFiboInput = m_txbFiboSeqItem.Text;
			bool isValid = m_fiboInputChecker.IsValidInt( szFiboInput, out int nFiboInput );

			if( !isValid ) {
				RestoreInvalidInput();
				return;
			}
			string szFiboSeqOutput = m_fiboCalculator.GenerateSequenceText( nFiboInput );
			m_txbFiboSeqOutput.Text = $"The first {nFiboInput} terms of the Fibonacci sequence are: {szFiboSeqOutput}";
			m_txbFiboSeqItem.Text = nFiboInput.ToString();
		}

		void RestoreInvalidInput()
		{
			m_txbFiboSeqOutput.Text = ERROR_MESSAGE;
			m_txbFiboSeqItem.Text = string.Empty;
		}
		const string ERROR_MESSAGE = "Please enter a number between 1 and 30.";
	}
}