namespace FluentDP
{
	class ReportGenerator
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public string Content { get; set; }

		public void SetTitle(string title) { Title = title; }
		public void SetAuthor(string author) { Author = author; }
		public void SetContent(string content) { Content = content; }

		public void Print()
		{
			Console.WriteLine("\n--- Report ---");
			Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nContent: {Content}\n");
		}
	}

}
