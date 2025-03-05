namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			//Configuration config1 = Configuration.GetInstance();
			//Console.WriteLine(config1.GetSetting("DatabaseConnectionString"));

			//Configuration config2 = Configuration.GetInstance();
			//Console.WriteLine(config2.GetSetting("ApiKey"));

			//when we run this we will get counter value as 2 which means constructor is executed 2 times.
			//so, to make it threadsafe wecan use other methods like locking and lazy initialization etc 
			//Parallel.Invoke(
			//				() => Configuration.GetInstance(),
			//				() => Configuration.GetInstance()
			//				);

			//Parallel.Invoke(
			//				() => LazyInitialization.GetInstance(),
			//				() => LazyInitialization.GetInstance()
			//				);
			Parallel.Invoke(
							() => Lock.GetInstance(),
							() => Lock.GetInstance()
							);
			//Console.ReadLine();
		}
	}
}