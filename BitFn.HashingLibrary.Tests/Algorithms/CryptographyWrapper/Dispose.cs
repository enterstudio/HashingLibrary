﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;
using Run00.MsTest;
using Crypto = System.Security.Cryptography;

namespace BitFn.HashingLibrary.Tests.Algorithms.CryptographyWrapper
{
	[TestClass]
	[CategorizeByConventionClass(typeof(Dispose))]
	public class Dispose
	{
		[TestMethod]
		[CategorizeByConvention]
		public void WhenDisposed_ShouldDisposeAlgorithm()
		{
			// Arrange
			var fixture = new Fixture();
			var values = fixture.Create<byte[]>();
			var expected = typeof(ObjectDisposedException);

			// TODO: Mock Crypto.HashAlgorithm?
			var hashAlgorithm = Crypto.MD5.Create();
			var algorithm = new HashingLibrary.Algorithms.CryptographyWrapper(hashAlgorithm);
			algorithm.Dispose();

			// Act
			var actual = ExceptionTest.Catch(() => hashAlgorithm.ComputeHash(values));

			// Assert
			Assert.IsInstanceOfType(actual, expected);
		}
	}
}
