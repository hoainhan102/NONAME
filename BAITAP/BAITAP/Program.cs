using System;
using System.Text;
namespace P01_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        
        // 1.Viết chương trình tìm UCLN
        static int UCLN( int a, int b)
        {
            int ucln = 1;
            for (int i = 1; i <=a && i<=b; i++)
            {
                if(a%i==0 && b%i == 0)
                {
                    ucln = i;
                }
            }
            return ucln;
        }
        // 1.BCNN của hai số tự nhiên
        static int BCNN(int a, int b)
        {
            int ucln = 1;
            for (int i = 1; i <= a && i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    ucln = i;
                }
            }
            int bcnn = (a * b) / ucln;
            return bcnn;
        }
        //2.Viết chương trình tìm tổng các chữ số của một số nguyên
        static void bai2_tongsonguyen()
        {
            Console.WriteLine("\nNhap vao mot so nguyen lon hon 0: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = x;
            int tong = 0;
            while (x <= 0)
            {
                Console.WriteLine("\nVui long nhap lai: ");
                x = Convert.ToInt32(Console.ReadLine());
                y = x;

            }
            while (x > 0)
            {

                tong += x % 10;
                x /= 10;
            }
            Console.WriteLine("\nSo nguyen la " + y);
            Console.WriteLine("\nTong so nguyen la: " + tong);
        }

        //3.Viết chương trình nhận vào một số nguyên và
        //trả về cách phân tích số đó ra tích của thừa số nguyên tố.
        //Ví dụ nhập vào 600 thì cần phải trả về 2 * 2 * 2 * 3 * 5 * 5
        static void bai3()
        {
            int a = 600;
            for (int i = 2; i <= a;)
            {
                if (a % i == 0)
                {

                    Console.Write(i);
                    if (a != i)
                    {
                        Console.Write("*");
                    }
                    a = a / i;

                }
                else
                {
                    i++;
                }
            }
        }
        // Bai4.Số fibonaci

        static int fibo(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
            if (n < 0)
            {
                return -1;
            }
            else if(n==0 || n==1){
                return n;
            }
            else
            {
                for (int i = 2; i< n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                    
                }



            }
            return fn;

        }

        //Bai6 Viết phương trình nhập vào n và in ra tổng của dãy số
    
        static int bai6(int x)
        {
            int a = 0;
            int b = a+1;
            int c = a * b;
            int sum = a * b;
            for(int i = 1; i <= x; i++)
            {
                a = b;
                b = a+1;
                c = a * b;
                sum += c;
                
            }
            return sum;
        }
        //Bai7 Viết phương trình tính giai thừa n! của một số
        static int giaithua(int n)
        {
            int giaithua = 1;
            for(int i = 1; i <= n; i++)
            {
                giaithua = giaithua * i;    
            }
            return giaithua;
        }

        //Bai8 Viết chương trình tính pi với độ sai số 0.0001 bằng công thức
        static double tinhpi()
        {
            //Console.WriteLine(Math.Round(tinhpi(), 5));

            double picong = 0;
            double pitru = 0;
            double pi= 0;

            for (int i = 1; i <= 100;)
            {
                picong += (4f / i);
                i = i + 4;
            }
            for (int i = 3; i <= 100;)
            {
                pitru += (4f / i);
                i = i + 4;
            }
            return pi = picong - pitru;
        }
    }

}