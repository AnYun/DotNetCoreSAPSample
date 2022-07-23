using SapNwRfc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreSAPSample.Model
{
    /// <summary>
    /// Echo Demo Item
    /// </summary>
    internal class EchoDemoItem
    {
        /// <summary>
        /// RfcFloat
        /// </summary>
        [SapName("RFCFLOAT")]
        public double RfcFloat { get; set; }
        /// <summary>
        /// RfcChar1
        /// </summary>
        [SapName("RFCCHAR1")]
        public string RfcChar1 { get; set; }
        /// <summary>
        /// RfcChar2
        /// </summary>
        [SapName("RFCCHAR2")]
        public string RfcChar2 { get; set; }
        /// <summary>
        /// RfcChar4
        /// </summary>
        [SapName("RFCCHAR4")]
        public string RfcChar4 { get; set; }
        /// <summary>
        /// RfcHEX3
        /// </summary>
        [SapName("RFCHEX3")]
        public byte[] RfcHEX3 { get; set; }
        /// <summary>
        /// RfcDate
        /// </summary>
        [SapName("RFCDATE")]
        public DateTime? RfcDate { get; set; }
        /// <summary>
        /// RfcData1
        /// </summary>
        [SapName("RFCDATA1")]
        public string RfcData1 { get; set; }
    }
}
