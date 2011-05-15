using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BUS;
using DTO;
using System.Collections;

namespace TestLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            CongTyBUS bus = new CongTyBUS();
            IList l = bus.LayDanhSach();
            Console.WriteLine(l.Count);            
            foreach(CongTy congty in l)
            {
                Console.WriteLine(congty.Mact + congty.NguoiDaiDien + congty.Tenct + congty.WebsiteUrl + congty.Fax + congty.GioiThieu);
                
            }
        }
    }
}
