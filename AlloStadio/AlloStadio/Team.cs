using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlloStadio
{
    public class Team 
    {

        private string name;
        private int attack;
        private int midfield;
        private int defense;
        //private List<Player> players;
     //   private string module;

        private Tactics uses;
        

        public string _name { get; set; }
        public int _attack { get; set; }
        public int _midfield { get; set; }
        public int _defense { get; set; }


        // method that will be us once players have been added
        public int calculateAttack(List<Player> players){
            int overall = 0;
            foreach (Player p in players)
            {
                overall += p.overall; 
            }
            return Team.setAttack(overall);
        }

        public int calculateMidfield(List<Player> players){
            int overall = 0;
            foreach (Player p in players)
            {
                overall += p.overall; 
            }
            return Team.setAttack(overall);
        }

        public int calculateDefense(List<Player> players){
            int overall = 0;
            foreach (Player p in players)
            {
                overall += p.overall; 
            }
            return Team.setAttack(overall);
        }

        // Each Team will Tactics related to their team
        public void usesTactics(Tactics uses){
            this.uses = uses;
        }

        public void getTactics(){
            uses._center_attack;
        }
    }
}
