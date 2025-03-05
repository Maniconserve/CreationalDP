namespace Singleton
{
	public sealed class Configuration
	{
		// Counter to track instance creation
		private static int Counter = 0;

		// Singleton instance variable
		// It is private to restrict access from outside the class.
		// It is static because it is returned from a static method, and without being static, an instance of the class would be required to access it.
		// We can instantiate it directly here, eliminating the need for a null check in the `GetInstance` method and ensuring thread safety. However, if an instance of this class is never needed, it will result in resource wastage.		
		private static Configuration Instance = null;
		// Private constructor to prevent external instantiation
		private Configuration()
		{
			Counter++;
			Console.WriteLine("Configuration Instance Created. Counter Value: " + Counter);
		}

		// Static method to return the Singleton instance
		public static Configuration GetInstance()
		{
			if (Instance == null)
			{
				Instance = new Configuration();
			}
			return Instance;
		}

		// Example method to simulate fetching a configuration setting
		public string GetSetting(string key)
		{
			return $"Value for {key}";
		}
	}
}