using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace TestUngDung.MoaHoaMD5
{
    public static class MyString
    {
        /*
     * MÃ Hóa Mật khẩu
     * <summary>
     * Má hóa MD5
     * </summary>
     * <param> chuỗi cần mã hóa</param>
     * <return>chuỗi base 64 chứa MD5 </return>
     */
        public static String ToMD5(this String s)
        {
            var bytes = Encoding.UTF8.GetBytes(s);
            var hash = MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}