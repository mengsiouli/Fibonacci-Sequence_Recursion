using FibonacciSequence.Logic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FibonacciSequenceTest
{
	#region CalculateFiboTest

	[TestClass]
	public class CalculateFiboTest
	{
		readonly FiboCalculator m_fiboCalculator = new FiboCalculator();

		[DataRow( 0 )]
		[DataRow( 47 )]

		[TestMethod]
		public void CalculateFibo_WhenInputIsSmallerThan1OrLargerThan46_ShouldThrowArgumentOutOfRangeException( int nFiboInput )
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>( () => m_fiboCalculator.CalculateFibo( nFiboInput ) );
		}

		[DataRow( 1, 1 )]
		[DataRow( 5, 5 )]
		[DataRow( 20, 6765 )]
		[DataRow( 46, 1836311903 )]

		[TestMethod]
		public void CalculateFibo_WhenInputIsBetween1And46_ShouldReturnMatchValue( int nFiboInput, int nFiboCalculatorExpected )
		{
			int nFiboCalculatorActual = m_fiboCalculator.CalculateFibo( nFiboInput );
			nFiboCalculatorExpected.Should().Be( nFiboCalculatorActual );
		}
	}

	#endregion

	#region FiboInputCheckerTest

	[TestClass]
	public class FiboInputCheckerTest
	{
		readonly FiboInputChecker m_fiboInputChecker = new FiboInputChecker();

		[DataRow( "0" )]
		[DataRow( "31" )]

		[TestMethod]
		public void IsValidInt_WhenInputIsSmallerThan1OrLargerThan30_ShouldReturnFalse( string szInput )
		{
			bool isValid = m_fiboInputChecker.IsValidInt( szInput, out _ );
			isValid.Should().BeFalse();
		}

		[DataRow( "1.5" )]
		[DataRow( "abc" )]
		[DataRow( "" )]

		[TestMethod]
		public void IsValidInt_WhenInputIsNotInteger_ShouldReturnFalse( string szInput )
		{
			bool isValid = m_fiboInputChecker.IsValidInt( szInput, out _ );
			isValid.Should().BeFalse();
		}

		[DataRow( "1" )]
		[DataRow( "7" )]
		[DataRow( "13" )]
		[DataRow( "30" )]

		[TestMethod]
		public void IsValidInt_WhenInputIsBetween1And30_ShouldReturnTrue( string szInput )
		{
			bool isValid = m_fiboInputChecker.IsValidInt( szInput, out _ );
			isValid.Should().BeTrue();
		}
	}

	#endregion
}