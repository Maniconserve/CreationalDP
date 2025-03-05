namespace Singleton
{
	public sealed class LazyInitialization
	{
		private static int Counter = 0;

		private static readonly Lazy<LazyInitialization> Instance = new Lazy<LazyInitialization>(() => new LazyInitialization());
		private LazyInitialization()
		{
			Counter++;
			Console.WriteLine("LazyInitialization Instance Created. Counter Value: " + Counter);
		}

		public static LazyInitialization GetInstance()
		{
			return Instance.Value;
		}

		public string GetSetting(string key)
		{
			return $"Value for {key}";
		}
	}
}