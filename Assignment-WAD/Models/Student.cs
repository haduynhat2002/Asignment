using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_WAD.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int MaSinhVien { get; set; }
        public int HinhThucNopPhat { get; set; }
        public string SoTienNopPhat { get; set; }
        public DateTime NgayNopPhat { get; set; }
    }
}