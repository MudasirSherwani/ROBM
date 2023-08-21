using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ROBM.Models
{
    public class RCO
    {
        public int RCO_Id { get; set; }
        public string Ref_No { get; set; }
        public int ERO_No { get; set; }
        public DateTime ERO_Issue_Date { get; set; }
        public int ERO_Amount { get; set; }
        public DateTime ERO_Implement_Date { get; set; }
        public int Arrear { get; set; }
        public int RCO_Fee { get; set; }
        public string CRC_Remarks { get; set; }
        public string User_Name { get; set; }
        public DateTime Create_Date { get; set; }
        public DateTime Create_Time { get; set; }
    }
}