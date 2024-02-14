using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//NOT USED

//simulate a race

namespace ShapeRacer
{
    /*   internal class Race
       {
           public const int RACE_DISTANCE = 100;
           private Racer[] racers = new Racer[2];
           private int currRacer;

           public Race() {
               //make some racers
               racers[0] = new Racer("Stanley", 3, 8);
               racers[1] = new Racer("Belinda", 4, 7);
               currRacer = 0;
           }

           public int runInterval(int interval)
           {
               int distanceCovered = racers[currRacer].run(interval);
               //go to next racer
               currRacer = (currRacer+1) % racers.Length;
               return distanceCovered;
           }



           public void runRace()
           {/*
               //let intervals all be 2 units
               int distanceCovered = 0;
               //run race, 1 runner at a time
               //return when there is a winner
               //let this racer go
               distanceCovered = racers[currRacer].run(2);
               Console.WriteLine("{0} covered {1} meters", racers[currRacer], distanceCovered);
               while (!isWinner(racers[currRacer]))
               {
                   //update curr racer
                   currRacer = (currRacer + 1) % racers.Length;
                   //run the racer
                   distanceCovered = racers[currRacer].run(2);
                   Console.WriteLine("{0} covered {1} meters", racers[currRacer], distanceCovered);
               }
               if (isWinner(racers[0])) Console.WriteLine("{0} is the winner\n", racers[0]);
               else if (isWinner(racers[1])) Console.WriteLine("{0} is the winner\n", racers[1]);
               else Console.WriteLine("This should not happen");
               */
    /*        }

            private bool isWinner(Racer r)
            {
                return r.getDistanceCovered() >= RACE_DISTANCE;
            }




        }*/
}
