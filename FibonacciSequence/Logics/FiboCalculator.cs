using System;

namespace FibonacciSequence.Logic
{
	public partial class FiboCalculator
	{
		public int CalculateFibo( int nFiboCalInput )
		{
			// calculate nFiboCalInput fibonacci value
			if( nFiboCalInput <= 0 || nFiboCalInput > MAX_FIBO_CAL_VALUE ) {
				throw new ArgumentOutOfRangeException( nameof( nFiboCalInput ) );
			}
			if( nFiboCalInput == 1 || nFiboCalInput == 2 ) {
				return 1;
			}
			if( m_fibonacciCache[ nFiboCalInput ] != 0 )
				return m_fibonacciCache[ nFiboCalInput ];

			m_fibonacciCache[ nFiboCalInput ] = CalculateFibo( nFiboCalInput - 1 ) + CalculateFibo( nFiboCalInput - 2 );
			return m_fibonacciCache[ nFiboCalInput ];
		}

		// generate and display fibonacci sequence
		public string GenerateSequenceText( int nFiboCalInput )
		{
			if( nFiboCalInput <= 0 || nFiboCalInput > MAX_FIBO_CAL_VALUE ) {
				throw new ArgumentOutOfRangeException( nameof( nFiboCalInput ) );
			}

			int[] nFiboArray = new int[ nFiboCalInput ];
			for( int i = 0; i < nFiboCalInput; i++ ) {
				nFiboArray[ i ] = CalculateFibo( i + 1 );
			}

			return string.Join( ",", nFiboArray );
		}

		// set min and max fibonacci calculation value to avoid int overflow
		const int MAX_FIBO_CAL_VALUE = 46;
		int[] m_fibonacciCache = new int[ MAX_FIBO_CAL_VALUE + 1 ];
	}
}