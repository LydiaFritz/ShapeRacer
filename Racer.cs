using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//simulate a racer
namespace ShapeRacer
{
    internal class Racer
    {
        private String name;
        //switch to ints to match points on canvas
        private int totDistanceCovered = 0;
        private int distanceCoverdThisInterval = 0;
        private int maxSpeed, minSpeed;

        public Racer(String n, int min, int max)
        {
            this.name = n;
            this.maxSpeed = max;
            this.minSpeed = min;
        }

        //run for the given interval
        //update the total distance covered
        //return the distance covered in this interval
        public int run(int interval)
        {
            int avgSpeed = (maxSpeed + minSpeed)/2;
            distanceCoverdThisInterval = avgSpeed * interval;
            totDistanceCovered += distanceCoverdThisInterval;
            return distanceCoverdThisInterval;

        }

        //return the total distance covered by this racer
        public int getDistanceCovered() { return  totDistanceCovered; }

        public override String ToString()
        {
            return this.name;
        }
    }
}
