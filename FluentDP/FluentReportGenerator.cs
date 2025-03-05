namespace FluentDP
{
	class FluentReportGenerator
	{
		private string Title;
		private string Author;
		private string Content;

		public FluentReportGenerator SetTitle(string title)
		{
			Title = title;
			return this;
		}

		public FluentReportGenerator SetAuthor(string author)
		{
			Author = author;
			return this;
		}

		public FluentReportGenerator SetContent(string content)
		{
			Content = content;
			return this;
		}

		public void Print()
		{
			Console.WriteLine("\n--- Fluent Report ---");
			Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nContent: {Content}\n");
		}
	}
}
