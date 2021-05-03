using NUnit.Framework;
using System.Threading.Tasks;

namespace Taskus.Tests
{
	public class TaskManagementTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public async Task TwoTasksShouldProcessSuccessfully()
		{
			var expectedResult1 = 123;
			var expectedResult2 = 456;

			var (result1, result2) = await TaskManagement.WhenAll(
				Task.FromResult(expectedResult1),
				Task.FromResult(expectedResult2));

			Assert.AreEqual(result1, expectedResult1);
			Assert.AreEqual(result2, expectedResult2);
		}

		[Test]
		public async Task ThreeTasksShouldProcessSuccessfully()
		{
			var expectedResult1 = 123;
			var expectedResult2 = 456;
			var expectedResult3 = 789;

			var (result1, result2, result3) = await TaskManagement.WhenAll(
				Task.FromResult(expectedResult1),
				Task.FromResult(expectedResult2),
				Task.FromResult(expectedResult3));

			Assert.AreEqual(result1, expectedResult1);
			Assert.AreEqual(result2, expectedResult2);
			Assert.AreEqual(result3, expectedResult3);
		}

		[Test]
		public async Task FourTasksShouldProcessSuccessfully()
		{
			var expectedResult1 = 123;
			var expectedResult2 = 456;
			var expectedResult3 = 789;
			var expectedResult4 = 147;

			var (result1, result2, result3, result4) = await TaskManagement.WhenAll(
				Task.FromResult(expectedResult1),
				Task.FromResult(expectedResult2),
				Task.FromResult(expectedResult3),
				Task.FromResult(expectedResult4));

			Assert.AreEqual(result1, expectedResult1);
			Assert.AreEqual(result2, expectedResult2);
			Assert.AreEqual(result3, expectedResult3);
			Assert.AreEqual(result4, expectedResult4);
		}

		[Test]
		public async Task FiveTasksShouldProcessSuccessfully()
		{
			var expectedResult1 = 123;
			var expectedResult2 = 456;
			var expectedResult3 = 789;
			var expectedResult4 = 147;
			var expectedResult5 = 258;

			var (result1, result2, result3, result4, result5) = await TaskManagement.WhenAll(
				Task.FromResult(expectedResult1),
				Task.FromResult(expectedResult2),
				Task.FromResult(expectedResult3),
				Task.FromResult(expectedResult4),
				Task.FromResult(expectedResult5));

			Assert.AreEqual(result1, expectedResult1);
			Assert.AreEqual(result2, expectedResult2);
			Assert.AreEqual(result3, expectedResult3);
			Assert.AreEqual(result4, expectedResult4);
			Assert.AreEqual(result5, expectedResult5);
		}
	}
}