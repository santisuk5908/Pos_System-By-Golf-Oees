using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_system
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loginpage());
        }
        public static string My_ip; //IP เครื่องตัวเอง
        public static string ip; //IP เครื่องที่มีฐานข้อมูล
        public static string globalSQLConnect;// = "host=localhost;user=pos_admin;password=123456;database=pos_db";
        public static string id_login;
        public static string status_login;
        public static string name_login;
        public static string IDshopDB;
        public static string IDshopForPos; //เก็บไอดีร้าน
        public static string NameshopForPos;//ชื่อร้าน
        public static string IDtexForPos;//เลขประจำตัวเสียภาษี
        public static string AddressForPos;//ที่อยู่ร้าน
        public static string TelForPos;//เบอร์โทรศัพท์
        public static string ImageLogoLocation;
        public static string ImageLogoLocationForPos; //ตำแหน่งรูป
        public static string Receipt_NO; //เลขที่ใบเสร็จ
        // เกี่ยวกับ POS System
        public static string BarcodeForPrint;
        public static string NameForPrint;
        public static string ManyForPrint;
        public static string CountForPrint;
        public static string PriceForPrint;
        public static string TotalForPrint;
        public static string CategoryForPrint;
        
    }
}
