namespace FootballLib;

class Football : Sport
{
	// Properties
	int LeagueDivision;
	int ClubNetworth;
	int LeagueYear;
	int Fixture;
	
	// Constructor
	Football(int leaguedivision, int clubnetworth, int leagueyear, int fixture)
	{
		LeagueDivision = leaguedivision;
		ClubNetworth = clubnetworth;
		LeagueYear = leagueyear;
		Fixture = fixture;
	}
	
	// Methods
	void Information()
	{
		
	}
}