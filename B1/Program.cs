using System;

class Program
{
    static void Main(string[] args)
    {
        int[] mangBanDau = {1,2,3,4,5};
        int doiChieu = -3;
        mangBanDau = DichChuyenMang(mangBanDau, doiChieu);
        foreach (int i in mangBanDau)
        {
            Console.Write(i + " ");
        }
    }

    static int[] DichChuyenMang(int[] mang, int doiChieu)
    {
        int doDai = mang.Length;
        int[] mangDichChuyen = new int[doDai];
        for(int i = 0; i < doDai; i++)
        {
            int chiSoDichChuyen = (i + doiChieu) % doDai;
            if(chiSoDichChuyen < 0)
            {
                chiSoDichChuyen += doDai;
            }
            mangDichChuyen[i] = mang[chiSoDichChuyen];
        }
        return mangDichChuyen;
    }
}
