using System;
using System.Collections.Generic;
using System.Text;

namespace Reimbesrment_System
{
    public class Datareimbusrtment : Kalkulator
    {
        public Datareimbusrtment(int Id, string Nama_karyawan, string Nama_reimburstment, int qty, int harga)
        {
            this.Id = Id;
            this.Nama_karyawan = Nama_karyawan;
            this.Nama_reimburstment = Nama_reimburstment;
            this.qty = qty;
            this.harga = harga;

            Console.WriteLine("ID : " + Id + "\n");
            Console.WriteLine("Nama Karyawan : " + Nama_karyawan + "\n");
            Console.WriteLine("Nama reimbusrtment : " + Nama_reimburstment + "\n");
            Console.WriteLine("Qty : " + qty + "\n");
            Console.WriteLine("Harga : " + harga + "\n");
        }
        public int Id { get; protected set; }
        public string Nama_karyawan { get; private set; }
        public string Nama_reimburstment { get; private set; }
        public int qty { get; private set; }
        public int harga { get; private set; }
        public override void totalharga(int qty, int price)
        {
            int total = qty * price;
            Console.WriteLine("Total Harga : "+total);
        }

    }
}
