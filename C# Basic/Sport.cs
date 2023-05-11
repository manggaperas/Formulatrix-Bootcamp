class Sport
{
	bool Status;
	int NumberofPlayer;
	string? ClubLocation;
	int Position;
	string? SportType;
	string? OwnerCountry;
	string? OwnerName;
	string? ClubName;
	string? LeagueName;
	
	Sport(bool status, string ownername, string ownercountry,
	string clubname, string clublocation, string sporttype, string leaguename, int position)
	{
		Status = status;
		OwnerName = ownername;
		OwnerCountry = ownercountry;
		ClubName = clubname;
		ClubLocation = clublocation;
		SportType = sporttype;
	}
}