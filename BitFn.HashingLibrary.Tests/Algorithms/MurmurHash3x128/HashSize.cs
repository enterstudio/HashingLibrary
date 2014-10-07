﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Run00.MsTest;

namespace BitFn.HashingLibrary.Tests.Algorithms.MurmurHash3x128
{
	[TestClass]
	[CategorizeByConventionClass(typeof(HashSize))]
	public class HashSize
	{
		[TestMethod]
		[CategorizeByConvention]
		public void WhenGotten_ShouldReturnConstant()
		{
			// Arrange
			const int expected = 128;
			var algorithm = new HashingLibrary.Algorithms.MurmurHash3x128();

			// Act
			var actual = ((IHashAlgorithm)algorithm).HashSize;

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
