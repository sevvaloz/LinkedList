using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Liste
    {
        Node head;
        public Liste()
        {
            head = null;
        }

        public void sonaEkle(int data)
        {
            Node eleman = new Node(data);
            if(head == null)
            {
                head = eleman;
            }           
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = eleman;
            }
        }

        public void basaEkle(int data)
        {
            Node eleman = new Node(data);
            if (head == null)
            {
                head = eleman;
            }         
            else
            {
                Node temp = head;
                head = eleman;
                eleman.next = temp;
            }
        }

        public void arayaEkle(int indis, int data)
        {
            Node eleman = new Node(data);
            if(head == null || indis == 0)
            {
                basaEkle(data);
            }
            else
            {
                Node temp = head; //temp, araya eklenecek sayıdan sonra gelen elemandır.
                Node temp2 = temp; //temp2, araya eklenecek sayıdan önce gelen elemandır.
                int i = 0;
                while (temp.next != null) //while döngüsü, son elemana girmez.
                {
                    if(i == indis)
                    {
                        temp2.next = eleman;
                        eleman.next = temp;
                        i++;
                        break;
                    }
                    i++;
                    temp2 = temp;
                    temp = temp.next;
                }
                if (i == indis) //while'ın girmediği son eleman için de aynı işlemler yapılır.
                {
                    temp2.next = eleman;
                    eleman.next = temp;
                }
            }
        }

        public void sondanSil()
        {
             Node temp = head;
             Node temp2 = temp;
             while (temp.next != null)
             {
                 temp2 = temp; //sondan önceki elemanı tutar.
                 temp = temp.next; //sonuncu elemanı tutar.
             }
             temp2.next = null; //son eleman silindi.
        }

        public void bastanSil()
        {
            head = head.next;
        }

        public void aradanSil(int indis)
        {
            if (indis == 0)
            {
                bastanSil();
            }

            Node temp = head;
            Node temp2 = temp; //temp2, temp'ten önceki elemandır.
            int i = 0;
            while (temp.next != null) //while döngüsü, son elemana girmez.
            {
                if (i == indis)
                {
                    temp2.next = temp.next;
                    i++;
                    break;
                }
                i++;
                temp2 = temp;
                temp = temp.next;
            }
            if (i == indis) //son eleman için aynı sondanSil metodu çağrılır.
            {
                sondanSil();
            }
        }

        string mesaj;
        public string elemanlariYazdir()
        {
            mesaj = "";
            Node temp = head;
            while(temp.next != null) //son elemanı yazdırmaz.
            {
                mesaj += temp.data.ToString() + " -> ";
                temp = temp.next;
            }
            mesaj += temp.data.ToString(); //son elemanı burada yazdırırız.
            return mesaj;
        }
    }
}
