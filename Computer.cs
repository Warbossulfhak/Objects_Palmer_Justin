using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Palmer_Justin
{
    internal class Computer : IBootUp
    {
        // get; set; syntax

        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }
        public void PowerOnOff()
        {
            IsOn = !IsOn;

            if (IsOn == true)
            {   // prints to console The computer is booting up!
                Console.WriteLine("The computer is booting up!");
            }
            else
            {   // prints to console The computer is shutting down!
                Console.WriteLine("The computer is shutting down!");
            }


        }

            public override string ToString()
            {         // prints to the console The computer is made by apple and is a all in one computer, it is on!
            return $"The computer is made by {Brand} and is a {Type} computer, it is on: {IsOn}!";
            }


    }







}

