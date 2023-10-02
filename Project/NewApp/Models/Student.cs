namespace NewApp.Models{
    public class Student{
        public string MaSV {get; set;}
        public string HoTen {get; set; }
        public string DiaChi{get; set;}
     
       public void ThongTin(string MaSV, string HoTen, string DiaChi)
    {
         System.Console.WriteLine("{0} - {1} - {2} ", MaSV,HoTen, DiaChi);
           }

    }
}