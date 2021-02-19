using System;
using System.Threading.Tasks;
using Refit;

namespace RefitSourceGeneratorTest
{
	public interface IGitHubApi
	{
		[Get ("/users/{user}")]
		Task DoSomething (string user);
	}

	class Program
	{
		static void Main (string[] args)
		{
			try {
				var gitHubApi = RestService.For<IGitHubApi> ("https://api.github.com");
				Console.WriteLine ("Done");
			} catch (Exception ex) {
				Console.WriteLine (ex);
			}
		}
	}
}
