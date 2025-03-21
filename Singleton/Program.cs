namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			//Configuration config1 = Configuration.GetInstance();
			//Console.WriteLine(config1.GetSetting("databaseconnectionstring"));

			//Configuration config2 = Configuration.GetInstance();
			//Console.WriteLine(config2.GetSetting("apikey"));

			//when we run this we will get counter value as 2 which means constructor is executed 2 times.
			//so, to make it threadsafe we can use other methods like locking and lazy initialization etc 
			//Parallel.Invoke(
			//				() => Configuration.GetInstance(),
			//				() => Configuration.GetInstance()
			//				);

			//Parallel.Invoke(
			//				() => LazyInitialization.GetInstance(),
			//				() => LazyInitialization.GetInstance()
			//				);
			Parallel.Invoke(
							() => Lock.GetInstance("Thread 1"),
							() => Lock.GetInstance("Thread 2"),
							() => Lock.GetInstance("Thread 3")
							);
			//Console.ReadLine();
		}
	}
}