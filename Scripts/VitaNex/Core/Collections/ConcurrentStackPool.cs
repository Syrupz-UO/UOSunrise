using System.Collections.Concurrent;

namespace VitaNex.Collections
{
	public sealed class ConcurrentStackPool<T> : ObjectPool<ConcurrentStack<T>>
	{
		public ConcurrentStackPool()
		{ }

		public ConcurrentStackPool(int capacity)
			: base(capacity)
		{ }
	}
}