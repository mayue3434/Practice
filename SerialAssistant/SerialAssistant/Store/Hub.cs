﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SerialAssistant
{
    [Table("Hub")]
    public class Hub
    {
        public int id { get; set; }
        public string WifiMac { get; set; }
        public string BtMac { get; set; }
        public string PCBACPU { get; set; }
        public string PCBAETH0 { get; set; }
        public string PCBAWiFi { get; set; }
        public string PCBABT { get; set; }
        public string PCBAIMEI { get; set; }
        public string PCBACCID { get; set; }
        public string TFCardCap { get; set; }
        public string ADCDC { get; set; }
        public string ADCBAT { get; set; }
        public string ADCLTE { get; set; }
        public string ETH0PING { get; set; }
        public string LTEPWR  { get; set; }
        public string LTEWDIS  { get; set; }
        public string LTECOMM { get; set; }
        public string ZWAVEPWR { get; set; }
        public string ZWAVECOMM { get; set; }
        public string ZWAVENVR { get; set; }
        public string WiFiPING  { get; set; }
        public string BTSCAN { get; set; }
        public string RESULTTIME { get; set; }
    }
}
