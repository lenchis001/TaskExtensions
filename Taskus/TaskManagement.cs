using System.Threading.Tasks;

namespace Taskus
{
	public static class TaskManagement
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

		public static async Task<(A, B, C)> WhenAll<A, B, C>(Task<A> task1, Task<B> task2, Task<C> task3)
		{
			var (result1, result2) = await WhenAll(task1, WhenAll(task2, task3));

			return (result1, result2.Item1, result2.Item2);
		}

		public static async Task<(A, B, C, D)> WhenAll<A, B, C, D>(Task<A> task1, Task<B> task2, Task<C> task3, Task<D> task4)
		{
			var (result1, result2) = await WhenAll(task1, WhenAll(task2, task3, task4));

			return (result1, result2.Item1, result2.Item2, result2.Item3);
		}

		public static async Task<(A, B, C, D, E)> WhenAll<A, B, C, D, E>(Task<A> task1, Task<B> task2, Task<C> task3, Task<D> task4, Task<E> task5)
		{
			var (result1, result2) = await WhenAll(task1, WhenAll(task2, task3, task4, task5));

			return (result1, result2.Item1, result2.Item2, result2.Item3, result2.Item4);
		}

		private static async Task WrapTask<T>(Task<T> task, ResultBag<T> result)
		{
			result.Result = await task;
		}
	}
}
