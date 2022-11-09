using System;

namespace single_linked_list
{
    class Node
    {
        public int noMhs;
        public string nama;
        public Node next;
    }
    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        public void addNode()/*Method untuk menambahkan sebuah Node ke dalam list*/
        {
            int nim;
            string nm;
            Console.Write("\nMasukkan nomor Mahasiswa : ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMasukkan nama Mahasiswa : ");
            nm = Console.ReadLine();
            Node nodeBaru = new Node();
            nodeBaru.noMhs = nim;
            nodeBaru.nama = nm;

            if (START == null || nim <= START.noMhs)
            {
                if ((START == null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nNomer Mahasiswa sama tidak diijinkan\n");
                    return;
                }
                nodeBaru.next = START;
                START = nodeBaru;
                return;
            }
            Node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (nim <= current.noMhs))
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("/nNomer mahasiswa tidak diijinkan\n");
                    return ;
                }
                previous = current;
                current = current.next;
            }

            nodeBaru.next = current;
            previous.next = nodeBaru;
        }
        /*Method untuk menghapus node tertentu di dalam list*/
        public bool delNode(int nim)
        {
            Node previous, current;
            previous = current = null;
            /*check apakah node yang di maksud ada di dalam list atau tidak*/
            if(Search(nim, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
                START = START.next;
            return true;
        }
        /*Method untuk menge-check apakah node yang dimaksud ada di dalam list*/
        public bool Search(int nim, ref Node previous, ref Node current)
        {
            previous = START;
            current = START;

            while ((current != null) && (nim != current.noMhs))
            {
                previous = current;
                current = current.next;
            }

            if (current == null)
                return (false);
            else
                return (true);
        }

        /*Method untuk Travers/mengunjungi dan membaca isi list*/
        public void traverse()
        {
            if (listEmpty())
                Console.WriteLine("\nList Kosong. \n");
            else
            {
                Console.WriteLine("\nData di dalam list adalah : \n");
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                    Console.Write(currentNode.noMhs + " " + currentNode + "\n");
                Console.WriteLine();
            }
        }
        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }

         class Program
        {
            static void Main(string[] args)
            {
                List obj = new List();
                while (true)
                {

                }
            }
        }
    }
}