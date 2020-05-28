using System;
using System.Globalization;

namespace Game
{
    public class GameEngine
    {

        private bool isOn = false; // state of the game if started or not
        private bool halfTime = false; // the game is at halftime
        private bool pause = false; // the game is paused so the coach can make changes to the team
        private bool isFinished = false; // this will be used to see if a game has finished or not. Helper for injury time
        private bool foul = false; // in some occasion it will happen that there will be a foul
        private List<Team> teams;
        private Pitch uses;
       public GameEngine(){ }

       public void play(){
           isOn = true;
            //call the telecronaca
    

       }

        /*
          A secondda della posizione del campo in gioco ci sono diversi eventi.
          A seconda delle tattiche decisi, le propabibilita' aumentano
        */

        public void attack(Team f, Pitch p)
        {
          p.   
        }

       public void shortPlay(Team t, Tactics ta){
           if(t.midfield > 75 && ta._possession > 75){
               
           }
       }

       public static void main(){
        Team t = new Team();
        Tactics e = new Tactics();
        e._center_attack = 30;
        t.usesTactics(e);
        e._
       }
    }
}
