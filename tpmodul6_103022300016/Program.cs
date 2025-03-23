using System;
namespace tpmodul6_103022300016
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SayaTubeVideo video = new SayaTubeVideo("Tutorial Design by Contract - Edsel Septa Haryanto");
                video.printVideoDetail();
                Console.WriteLine();
                for (int i = 0; i < 1000; i++)
                //Perulangan untuk menambahkan jumlah view sebanyak 1000 kali
                {
                    video.increasePlayCount(10000000);
                    video.printVideoDetail();
                    Console.WriteLine();

                    if(video.getPlayCount() == int.MaxValue)
                    // untuk menghentikan perulangan ketika jumlah view mencapai batas maksimum
                    {
                        break;
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!! " + e.Message);
            }
            
        }
    }
}