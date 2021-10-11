using OOAD.Chapter2;
using System;
using System.Threading;

namespace OOAD
{
    class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();

            Console.WriteLine("\nFido has gone outside...");
           

            Console.WriteLine("\nFido's all done...");
            
            try
            {
                Thread.Sleep(4000);
            }
            catch(Exception e)
            {
                
            }

            Console.WriteLine("...but it is stuck outside");
            Console.WriteLine("Fido starts barking...");


            Console.WriteLine("...So Gina graps the remote control.");
            remote.PressButton();
            Console.WriteLine("\nFido's back inside...");

            try
            {
                Thread.Sleep(1005);
            }
            catch (Exception e)
            {

            }
        }
    }
}
