namespace Singleton
{
	class Lock
	{
		private static int Counter = 0;

		private static Lock Instance = null;

		private static readonly object Instancelock = new object();
		private Lock()
		{
			Counter++;
			Console.WriteLine("Lock Instance Created. Counter Value: " + Counter);
		}

		public static Lock GetInstance(string name)
		{
			//This is thread-safe
			//As long as one thread locks the resource, no other thread can access the resource
			//As long as one thread enters into the Critical Section, 
			//no other threads are allowed to enter the critical section
			lock (Instancelock)
			{ //Critical Section Start
				if (Instance == null)
				{
					Instance = new Lock();
				}
			}
			return Instance;
		 }

		public string GetSetting(string key)
		{
			return $"Value for {key}";
		}
	}
}
