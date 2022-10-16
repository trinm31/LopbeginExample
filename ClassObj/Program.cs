using System;

namespace ClassObj
{
    class Program
    {
        static void Main(string[] args)
        {
            // obj
            // People tri = new People();
            // tri.Name = "Nguyen Minh Tri";
            // tri.Age = 21;
            // tri.CCID = 4123413242314;
            // tri.DayOfBirth = new DateTime(2001, 8, 31);
            //
            // People son = new People();
            // son.Name = "Nguyen Tien Son";
            // son.Age = 21;
            // son.CCID = 41234132423143;
            // son.DayOfBirth = new DateTime(2001,12 , 17);

            People phong = new People(
                "Ngyen Xuan Phong", 
                18, 43124321434,
                new DateTime(2004, 1, 23));
            phong.PrintInfo();
            phong.Say("hello I'm phong");
            
            People hieu = new People("Ngyen Mai Hieu",
                18, 43124321434, 
                new DateTime(2004, 1, 24));
            hieu.PrintInfo();
            hieu.Say("hello son dey");

        }
    }
}