using SapNwRfc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreSAPSample.Model
{
/// <summary>
/// Echo Demo Output
/// </summary>
internal class EchoDemoOutput
{
    /// <summary>
    /// Response Text
    /// </summary>
    [SapName("RESPTEXT")]
    public string ResponseText { get; set; }
    /// <summary>
    /// RFCTable
    /// </summary>
    [SapName("RFCTABLE")]
    public EchoDemoItem[] RFCTable { get; set; }
}
}
