using System;
namespace tpmodul6_103022300016
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design by Contract - Edsel Septa Haryanto");
            video.printVideoDetail();
            Console.WriteLine();
            video.increasePlayCount(1000000000);
            video.printVideoDetail();
        }
    }
}