using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submarines
{
    class Submarine
    {
        //SUB PROPERTIES
        private bool reactorOn;
        private int speed;
        private string heading;
        private int depth;
        private string weaponsFire;
        private string gps;
        private string id;
        public string name;

        //GETTERS AND SETTERS

        public bool GetReactorOn()
        {
            return reactorOn;
        }

        public void SetReactorOn(bool setting)
        {
            reactorOn = setting;
        }

        public int GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(int speed)
        {
            try
            {
                this.speed = speed;
            }
            catch
            {
                Console.WriteLine("speed can only be a number");
            }
        }

        public string GetHeading()
        {
            return heading;
        }

        public void SetHeading(string heading)
        {
            this.heading = heading;
        }

        public int GetDepth()
        {
            return depth;
        }

        public void SetDepth(int depth)
        {
            this.depth = depth;
        }

        public string GetWeaponsFire()
        {
            return weaponsFire;
        }

        public void SetWeaponsFire(string fire)
        {
            this.weaponsFire = fire;
        }

        public string GetGps()
        {
            return gps;
        }

        public void SetGps(string gps)
        {
            this.gps = gps;
        }

        public string GetId()
        {
            return id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public string getName()
        {
            return name;
        }


        public void setName(string name)
        {
            this.name = name;
        }

        //CONSTRUCTORS

        public Submarine()
        {
            reactorOn = false;
            speed = 0;
            heading = "North";
            depth = 200;
            weaponsFire = "weapons system disarmed";
            gps = "pacific ocean";

        }

        public Submarine(string id, string name)
        {
            reactorOn = false;
            speed = 0;
            heading = "North";
            depth = 200;
            weaponsFire = "weapons system disarmed";
            gps = "pacific ocean";
            this.id = id;
            this.name = name;
        }

        //STRING REPRESENTATION/  FULL DESCRIPTION
        public string myString(Submarine sub)
        {            
            string mySub = ("" + sub.getName() +  "\n ID: " + sub.GetId());
            return mySub;
        }

        public string description(Submarine sub)
        {
            string summary =(@"Submarine: " +this.GetId() + "\n\n" +
                   "Reactor on? - " + this.GetReactorOn() + "\n" +
                   "Current speed: " + this.GetSpeed() + " knots. \n" +
                   "Current heading: " + this.GetHeading() + "\n" +
                   "Current depth: " + this.GetDepth() + "\n" +
                   "Weapon status: " + this.GetWeaponsFire() + "\n" +
                   "Current gps location: " + this.GetGps() + "\n");
            return summary;
        }

    }
}
