﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CSharp.src
{
    //Lớp lưu trữ các biến toàn cục
    public static class Globals
    {
        //quyền truy cập
        public static bool isAdmin = false;

        //tài khoản hiện hành
        public static string currentAccount = "";

        //lưu trữ tên bảng trong db
        public static string tableAdminAccount = "TkAdmin";
        public static string tableStudentAccount = "TkSinhVien";
        public static string tableStudent = "SinhVien";
        public static string tableClass = "Lop";
        public static string tableScore = "Diem";
        public static string tableCourse = "MonHoc";
    }
}
