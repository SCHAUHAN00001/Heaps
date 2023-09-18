using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    internal class Program
    {
        class Heap
        {
            int[] data;
            int maxsize;
            int csize;
            public Heap()
            {
                maxsize = 10;
                data = new int[maxsize];
                csize = 0;
                for(int i = 0;i<data.Length;i++)
                {
                    data[i] = 0;
                }
                
            }
            public int length()
            {
                return csize;
            }
            public bool isEmpty()
            {
                return csize == 0;
            }
            public void heap_insert(int e)
            {
                if(csize == maxsize)
                {
                    Console.WriteLine("No Space");
                    return;
                }
                csize = csize + 1;
                int hi = csize;
                while(hi>1 && e > data[hi/2]) 
                {
                    data[hi] = data[hi/2];
                    hi = hi / 2;
                }
                data[hi] = e;
            }
            public void heap_delete()
            {
                int e = data[1];
                data[1] = data[csize];
                data[csize] = 0;
                csize = csize - 1;
                int i = 1;
                int j = i * 2;
                while(j<= csize)
                {
                    if (data[j]< data[j + 1])
                    {
                        j = j + 1;
                    }
                    if (data[i] < data[j])
                    {
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                        i = j;
                        j = i * 2;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            public int max()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Heap is Empty");
                    return -1;
                }
                return data[1];
            }
            public void display()
            {
                for(int i = 0; i < data.Length; i++)
                {
                    Console.Write(data[i]+" ");

                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Heap h = new Heap();
            Console.WriteLine("Creating a heap by inserting object: ");
            h.heap_insert(25);
            h.heap_insert(14);
            h.heap_insert(2);
            h.heap_insert(20);
            h.heap_insert(10);
            h.heap_insert(40);
            h.display();
            Console.WriteLine();
            Console.WriteLine("Deletion :");
            h.heap_delete();
            h.display();
            Console.ReadLine();

        }
    }
}
