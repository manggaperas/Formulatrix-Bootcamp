namespace BasketballLib;

class Basketball : Sport
{
	// Properties
	int	LeagueDivision;
	int LeagueYear;
	string? ConferenceSide;
	
	// Constructors
	Basketball(string conferenceside, int leaguedivision, int leagueyear)
	{
		ConferenceSide = conferenceside;
		LeagueDivision = leaguedivision;
		LeagueYear = leagueyear;
	}
	
	// Methods
	void Information()
	{
		Console.WriteLine();
	}
}