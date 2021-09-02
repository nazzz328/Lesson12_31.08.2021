using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
           Player player = new Player ();

           System.Console.WriteLine("What action you would like to take?\n1.Play;\n2.Record;\n3.Pause;\nStop.");
           int selection = int.Parse(Console.ReadLine());

           switch (selection)
           {

           case 1: player.Play(); break;
           case 2: player.Record(); break;
           case 3: player.Pause(); break;
           case 4: player.Stop(); break; 
           }


        }
    }

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();

        
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    
    }

    class Player: IPlayable, IRecordable

    {
        public void Play()
        {
            System.Console.WriteLine("Play");
        }

        public void Pause()
        {
            System.Console.WriteLine("Pause");
        }

        public void Stop()
        {
            System.Console.WriteLine("Stop");
        }

        public void Record()
        {
            System.Console.WriteLine("Record");
        }


    }


}
