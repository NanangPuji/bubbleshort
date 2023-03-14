using System;

namespace mengurutkandata  
{
    class Program
    {
        /// <summary>
        /// Deklarasi array int dengan uk
        /// <\summary>
        private int[] a = new int[20];

        /// <summary>
        /// Deklarasi variabel int untuk menyimpan banyaknya data pada array
        /// <\summary>
        private int n;

        /// <summary>
        /// Fungsi / Method untuk menerima masukan
        /// <\summary>
        public void read()
        {
            /// <summary>
            /// Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            /// <\summary>
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukan elemen array ");
            Console.WriteLine("-----------------------");

            /// <summary>
            /// Pengguna memasukan elemen pada array
            /// <\summary>
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            /// <summary>
            /// Menampilkan array yang tersusun
            /// <\summary>
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element array yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            /// <summary>
            /// for n - 1 passes
            /// <\summary>
            for (int i = 1; i < n; i++)
            {
                /// <summary>
                /// Pada pass i,bandingkan n - i elemen pertama dengan elemen
                /// <summary>
                for (int j = 0; j < n - i; j++)
                {
                    /// <summary>
                    /// Jika elemen tidak dalam urutan yang benar
                    /// <\summary>
                    if (a[j] > a[j + 1])
                    {
                        /// <summary>
                        /// Tukar elemen
                        /// <\summary>
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            /// <summary>
            /// Creating the object of the BubbleSort class
            /// <\summary>
            Program mylist = new Program();

            /// <summary>
            /// Pemanggilan funsi untuk menerima elemen array
            /// <\summary>
            mylist.read();

            /// <summary>
            // Pemanggilan fungsi untuk mengurutkan array
            /// <\summary>
            mylist.BubbleSortArray();

            /// <summary>
            /// Pemanggilan fungsi untuk menampilkan array yang tersusun
            /// <\summary>
            mylist.display();

            /// <summary>
            /// Exit
            /// <\summary>
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar. ");
        }
    }
}
