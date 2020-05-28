public class Pitch
{


	private Dictionary<int, string> zones; 

	private string[] fields = { "opponentArea", "teamArea", "defensiveMidfield", "offensiveMidfield", "left", "right", "trequartiDifensiva", "trequartiOffensiva"};
    
	for(int i = o; fields.lenght(); i++){
		zones.add(i, fields[i]);
	}

    // take the boolean that describes in which part of the pitch the ball is
    // return true to the new 
    private bool going_forward(bool init, bool final){
    	init = true;
    	final = false;
    	if(opponentArea == init){
    		final = true;
    	}else if(teamArea == init)
    	{
    		teamArea = false;
    		final = true;
    		trequartiDifensiva = final;
    	}else if(trequartiDifensiva = init){
    		trequartiDifensiva = false;
    		final = true;
    		defensiveMidfield = final;
    	}else if(defensiveMidfield = init){
    		defensiveMidfield = false;
    		final = true;

    	}
    }

    public void returnPitch(){

    } 

}