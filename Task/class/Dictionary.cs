using System.Collections.Generic;
namespace Foobar;

public class RuleDictionary
{
	private Dictionary<int, string> rules;

	public RuleDictionary()
	{
		rules = new Dictionary<int, string>()
		{
			{ 3, "foo" },
			{ 5, "bar" },
			{ 7, "fizz" },
			{ 9, "buzz" }
		};
	}

	public Dictionary<int, string> GetRules()
	{
		return rules;
	}
}