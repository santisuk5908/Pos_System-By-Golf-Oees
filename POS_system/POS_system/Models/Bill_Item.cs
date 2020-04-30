using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_system.Models
{
    public class Bill_Item
    {
        public string เลขที่ใบเสร็จ { get; set; }
        public string ผู้ขาย { get; set; }
        public string ลูกค้า { get; set; }
        public string เวลา { get; set; }
        public string จำนวน { get; set; }
        public string ราคา { get; set; }
        public string ส่วนลด { get; set; }
        public float รวมทั้งสิ้น { get; set; }
    }
}
