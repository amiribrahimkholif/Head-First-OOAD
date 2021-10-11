using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD.Chapter2
{
    public class DogDoor
    {
        private bool open;

        public DogDoor()
        {
            this.open = false;
        }
        public void Open()
        {
            Console.WriteLine("The Dog Door Opens.");
            open = true;
        }
        public void Close()
        {
            Console.WriteLine("The Dog Door Closes.");
            open = false;
        }

        public bool IsOpen()
        {
            return open;
        }
    }
}
