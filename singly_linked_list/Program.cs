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
        
    }
}