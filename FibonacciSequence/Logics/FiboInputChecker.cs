namespace FibonacciSequence.Logic
{
	public partial class FiboInputChecker
	{
		// validate whether szInput is an integer within the allowed range
		public bool IsValidInt( string szInput, out int nInput )
		{
			bool isValid = int.TryParse( szInput, out nInput );
			return isValid && nInput >= MIN_FIBO_INPUT && nInput <= MAX_FIBO_INPUT;
		}

		// define the input range for fibonacci calculation
		const int MIN_FIBO_INPUT = 1;
		const int MAX_FIBO_INPUT = 30;

	}
}