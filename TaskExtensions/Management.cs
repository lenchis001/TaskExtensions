using System.Threading.Tasks;

namespace TaskExtensions
{
	public class Management
	{
		public static async Task<(A, B)> WhenAll<A, B>(Task<A> task1, Task<B> task2)
		{
			var resultBag1 = new ResultBag<A>();
			var resultBag2 = new ResultBag<B>();

			await Task.WhenAll(new Task[] {
				WrapTask(task1, resultBag1),
				WrapTask(task2, resultBag2)
			});

			return (resultBag1.Result, resultBag2.Result);
		}

		private static async Task WrapTask<T>(Task<T> task, ResultBag<T> result)
		{
			result.Result = await task;
		}
	}
}
