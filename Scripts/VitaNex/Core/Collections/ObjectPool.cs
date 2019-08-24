#region Header
//   Vorspire    _,-'/-'/  ObjectPool.cs
//   .      __,-; ,'( '/
//    \.    `-.__`-._`:_,-._       _ , . ``
//     `:-._,------' ` _,`--` -: `_ , ` ,' :
//        `---..__,,--'  (C) 2018  ` -'. -'
//        #  Vita-Nex [http://core.vita-nex.com]  #
//  {o)xxx|===============-   #   -===============|xxx(o}
//        #        The MIT License (MIT)          #
#endregion

#region References
using System;
using System.Collections;
using System.Collections.Concurrent;
#endregion

namespace VitaNex.Collections
{
	public static class ObjectPool
	{
		public static T Acquire<T>()
			where T : new()
		{
			return ObjectPool<T>.AcquireObject();
		}

		public static void Acquire<T>(out T o)
			where T : new()
		{
			ObjectPool<T>.AcquireObject(out o);
		}

		public static void Free<T>(T o)
			where T : new()
		{
			ObjectPool<T>.FreeObject(o);
		}

		public static void Free<T>(ref T o)
			where T : new()
		{
			ObjectPool<T>.FreeObject(ref o);
		}
	}

	public class ObjectPool<T>
		where T : new()
	{
		private static readonly ObjectPool<T> _Instance;

		static ObjectPool()
		{
			_Instance = new ObjectPool<T>();
		}

		public static T AcquireObject()
		{
			return _Instance.Acquire();
		}

		public static void AcquireObject(out T o)
		{
			o = _Instance.Acquire();
		}

		public static void FreeObject(T o)
		{
			_Instance.Free(o);
		}

		public static void FreeObject(ref T o)
		{
			_Instance.Free(ref o);
		}

		protected readonly ConcurrentQueue<T> _Pool;

		private volatile int _Capacity;

		public int Capacity
		{
			get
			{
				return _Capacity;
			}
			set
			{
				if (value < 0)
				{
					value = DefaultCapacity;
				}

				_Capacity = value;
			}
		}

		public int Count { get { return _Pool.Count; } }

		public bool IsEmpty { get { return _Pool.IsEmpty; } }
		public bool IsOverflow { get { return _Pool.Count > _Capacity; } }
		public bool IsFull { get { return _Capacity > 0 && _Pool.Count >= _Capacity; } }

		public virtual int DefaultCapacity { get { return 64; } }

		public ObjectPool()
		{
			_Capacity = DefaultCapacity;

			_Pool = new ConcurrentQueue<T>();
		}

		public ObjectPool(int capacity)
		{
			_Capacity = capacity;

			_Pool = new ConcurrentQueue<T>();
		}

		public virtual T Acquire()
		{
			T o;

			if (!_Pool.TryDequeue(out o) || o == null)
			{
				o = new T();
			}

			return o;
		}

		public virtual void Free(T o)
		{
			if (o == null)
			{
				return;
			}

			try
			{
				if (o is IList)
				{
					var l = (IList)o;

					if (l.Count > 0)
					{
						l.Clear();
					}
				}
				else
				{
					o.CallMethod("Clear");
				}
			}
			catch
			{
				return;
			}

			if (!IsFull)
			{
				_Pool.Enqueue(o);
			}
		}

		public void Free(ref T o)
		{
			Free(o);

			o = default(T);
		}

		public void Clear()
		{
			T o;

			while (!IsEmpty)
			{
				_Pool.TryDequeue(out o);
			}
		}

		public virtual int Trim()
		{
			var c = 0;

			T o;

			while (IsOverflow)
			{
				_Pool.TryDequeue(out o);

				++c;
			}

			return c;
		}

		public virtual int Fill()
		{
			var c = 0;

			while (!IsFull)
			{
				_Pool.Enqueue(new T());

				++c;
			}

			return c;
		}
		
		public virtual void Free()
		{
			Clear();
		}
	}
}