using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_system.Models
{
    public class CartItem
    {
        public string บาร์โค้ด { get; set; }
        public string ชื่อสินค้า { get; set; }
        public string ประเภทสินค้า { get; set; }
        public int จำนวน { get; set; }
        public string หน่วยนับ { get; set; }
        public float ราคาต่อหน่วย { get; set; }
        public float ราคารวม { get; set; }
    }
}
