using System.Collections.Concurrent;

namespace VitaNex.Collections
{
	public sealed class ConcurrentQueuePool<T> : ObjectPool<ConcurrentQueue<T>>
	{
		public ConcurrentQueuePool()
		{ }

		public ConcurrentQueuePool(int capacity)
			: base(capacity)
		{ }

		public override void Free(ConcurrentQueue<T> o)
		{
			if (o != null)
			{
				T v;

				while (!o.IsEmpty)
				{
					o.TryDequeue(out v);
				}
			}

			base.Free(o);
		}
	}
}