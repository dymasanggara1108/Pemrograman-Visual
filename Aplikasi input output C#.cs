using System;
using System.Collections.Generic;

class Program
{
    static List<string> dataList = new List<string>();
    
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Tambah Data");
            Console.WriteLine("2. Tampilkan Data");
            Console.WriteLine("3. Hapus Data");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilih opsi: ");
            
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    TambahData();
                    break;
                case "2":
                    TampilkanData();
                    break;
                case "3":
                    HapusData();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Pilihan tidak valid. Coba lagi.");
                    break;
            }
        }
    }
    
    static void TambahData()
    {
        Console.Write("Masukkan data baru: ");
        string data = Console.ReadLine();
        dataList.Add(data);
        Console.WriteLine("Data berhasil ditambahkan.");
    }
    
    static void TampilkanData()
    {
        if (dataList.Count == 0)
        {
            Console.WriteLine("Tidak ada data.");
            return;
        }
        Console.WriteLine("\nDaftar Data:");
        for (int i = 0; i < dataList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {dataList[i]}");
        }
    }
    
    static void HapusData()
    {
        TampilkanData();
        Console.Write("Masukkan nomor data yang ingin dihapus: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= dataList.Count)
        {
            dataList.RemoveAt(index - 1);
            Console.WriteLine("Data berhasil dihapus.");
        }
        else
        {
            Console.WriteLine("Nomor tidak valid.");
        }
    }
}
