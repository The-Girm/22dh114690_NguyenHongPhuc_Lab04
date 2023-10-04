using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22dh114690_NguyenHongPhuc_Lab04
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            MyList List=new MyList();
            int choice;
            bool input=false;
            while(true)
            {
                Console.Clear();
                Console.WriteLine("1.Khoi Tao Danh Sach.");
                Console.WriteLine("2.Xuat Danh Sach.");
                Console.WriteLine("3.Them Vao Dau.");
                Console.WriteLine("4.Them Vao Cuoi.");
                Console.WriteLine("5.So Phan Tu Trong Danh Sach.");
                Console.WriteLine("6.Tim Phan Tu Trong Danh Sach.");
                Console.WriteLine("7.Tim Phan Tu Co Gia Tri Lon Nhat.");
                Console.WriteLine("8.Tim Phan Tu Co Gia Tri Nho Nhat.");
                Console.WriteLine("9.Xuat Danh Sach So Chan.");
                Console.WriteLine("10.Xuat Danh Sach So Le.");
               
                Console.WriteLine("\n\n0.Thoat");
                Console.Write("Chon Chuc Nang:");choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0: return;
                    case 1:
                        {
                            input = true;
                            Console.WriteLine("Danh Sach Khoi Tao Thanh Cong.");
                            break;
                        }
                    case 2:
                        {
                            if (input)
                            {
                                Console.WriteLine("Danh Sach Co Noi Dung La: ");
                                List.ShowList();
                                break;
                            }
                            Console.WriteLine("Xin Hay Khoi Tao Danh Sach Truoc.");
                            break ;
                        }
                    case 3:
                        {
                            if (input)
                            {
                                Console.Write("Nhap Gia Tri Phan Tu:");int x=int.Parse(Console.ReadLine());
                                IntNode NewNode = new IntNode(x);
                                List.AddFirst(NewNode);
                                break;
                            }
                            Console.WriteLine("Xin Hay Khoi Tao Danh Sach Truoc.");
                            break;
                        }
                    case 4:
                        {
                            if (input)
                            {
                                Console.Write("Nhap Gia Tri Phan Tu:"); int x = int.Parse(Console.ReadLine());
                                IntNode NewNode = new IntNode(x);
                                List.AddLast(NewNode);
                                break;
                            }
                            Console.WriteLine("Xin Hay Khoi Tao Danh Sach Truoc.");
                            break;
                        }
                    case 5:
                        {
                            if (input)
                            {
                                Console.Write($"Danh Sach Co {List.Count} Phan Tu.");
                                break;
                            }
                            Console.WriteLine("Xin Hay Khoi Tao Danh Sach Truoc.");
                            break;
                        }
                    case 6:
                        {
                            if (input)
                            {
                                Console.Write("Nhap Gia Tri Phan Tu Can Tim:"); int x = int.Parse(Console.ReadLine());
                                IntNode Pos = List.SearchX(x);
                                if (Pos == null)
                                {
                                    Console.WriteLine("Phan Tu Khong Ton Tai.");
                                    break;
                                }
                                Console.WriteLine($"Phan Tu Ton Tai");

                            }
                            Console.WriteLine("Xin Hay Khoi Tao Danh Sach Truoc.");
                            break;
                        }
                    case 7:
                        {
                            if (input)
                            {
                                Console.Write("Phan Tu Lon Nhat La:" + List.GetMax().Data) ;
                                break;
                            }
                            Console.WriteLine("Xin Hay Khoi Tao Danh Sach Truoc.");
                            break;
                        }
                    case 8:
                        {
                            if (input)
                            {
                                Console.Write("Phan Tu Nho Nhat La:" + List.GetMin().Data);
                                break;
                            }
                            Console.WriteLine("Xin Hay Khoi Tao Danh Sach Truoc.");
                            break;
                        }
                    case 9:
                        {
                            if (input)
                            {
                                Console.WriteLine("Danh Sach Cac So Chan:");
                                List.GetEvenList(List).ShowList();
                            }
                            Console.WriteLine("Xin Hay Khoi Tao Danh Sach Truoc.");
                            break;
                        }
                    case 10:
                        {
                            if (input)
                            {
                                Console.WriteLine("Danh Sach Cac So Le:");
                                List.GetOddList(List).ShowList();
                            }
                            Console.WriteLine("Xin Hay Khoi Tao Danh Sach Truoc.");
                            break;
                        }
                }
                Console.ReadLine();
            }

        }
    }
}
