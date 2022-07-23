using SapNwRfc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreSAPSample.Model
{
    /// <summary>
    /// Echo Demo Input
    /// </summary>
    internal class EchoDemoInput
    {
        /// <summary>
        /// RFC Table
        /// </summary>
        [SapName("RFCTABLE")]
        public EchoDemoItem[] RFCTable { get; set; }
    }
}
