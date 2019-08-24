using System.Collections.Concurrent;

namespace VitaNex.Collections
{
	public sealed class ConcurrentBagPool<T> : ObjectPool<ConcurrentBag<T>>
	{
		public ConcurrentBagPool()
		{ }

		public ConcurrentBagPool(int capacity)
			: base(capacity)
		{ }
	}
}