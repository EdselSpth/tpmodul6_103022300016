using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300016
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        Random random = new Random(); // random untuk menambahkan id video

        public SayaTubeVideo(String title)
        // Constructor meminta input title dan menginisialisasi id dan playCount
        {
            Debug.Assert(title != null, "Judul tidak boleh kosong");
            Debug.Assert(title.Length <= 100, "Judul tidak boleh lebih dari 100 kata");
            this.id = random.Next(10000, 99999); // id diinisialisasi dengan random number
            this.title = title; 
            this.playCount = 0; // play count awal di set 0
        }

        public void increasePlayCount(int views)
        {
            // Pre-condition: Memastikan nilai views dalam rentang yang benar
            Debug.Assert(views <= 10000000, "Jumlah view harus antara 1 hingga 10.000.000"); 

            try
            {
                checked  // Memastikan jika terjadi overflow, akan dilempar exception
                {   
                    if (this.playCount > int.MaxValue - views)
                    {
                        throw new OverflowException(); // Melempar exception jika playcount melebihi batas maksimum int
                    }
                        this.playCount += views; // Menambahkan views ke playCount
                }
            }
            catch (OverflowException) // exception untuk menghentikan jika penjumlah playcount melebih batas maksimum int
            {
                Console.WriteLine("Error!!! Sudah Mencapai Batas Maksimum Views.");
                this.playCount = int.MaxValue; // Set playCount ke batas maksimal agar tidak melebihi batas dan tetap jumlah view sampai ke max value int
            }
        }


        public void printVideoDetail()
        // Method untuk menampilkan detail video
        {
            Console.WriteLine("ID Video: " + this.id);
            Console.WriteLine("Judul Video: " + this.title);
            Console.WriteLine("Jumlah View: " + this.playCount);
        }

        public int getPlayCount()
        // getter untuk menadapatkan nilai playcount
        {
            return this.playCount;
        }

    }
}
