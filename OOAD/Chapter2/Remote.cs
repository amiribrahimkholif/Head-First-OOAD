using System;
using System.Threading.Tasks;
using System.Timers;

namespace OOAD.Chapter2
{
    public class Remote
    {
        private DogDoor _door;

        Timer timer;
        public Remote(DogDoor door)
        {
            this._door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing The Remote Controle Button.");
            if (_door.IsOpen())
            {
                _door.Close();
                
            }
            else
            {
                _door.Open();
                SetTimer();
            }

        }

        private void SetTimer()
        {
            timer = new Timer(1000);
            timer.Elapsed += Run;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        public void Run(Object sender, ElapsedEventArgs e)
        {
          if(_door.IsOpen())
          {
            _door.Close();
            Console.WriteLine("automatically.");
            timer.Stop();
            timer.Dispose();
          }
        }
    }
}
