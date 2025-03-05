namespace FluentDP
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("BEFORE Fluent Interface (Traditional Way)");
			ReportGenerator report = new ReportGenerator();
			report.SetTitle("Design Patterns");
			report.SetAuthor("John Doe");
			report.SetContent("Fluent Interface Pattern Explained");
			report.Print();

			Console.WriteLine("AFTER Fluent Interface (Method Chaining)");
			FluentReportGenerator fluentReport = new FluentReportGenerator()
				.SetTitle("Design Patterns")
				.SetAuthor("John Doe")
				.SetContent("Fluent Interface Pattern Explained");
			fluentReport.Print();
		}
	}
}