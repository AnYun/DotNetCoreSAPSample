using DotNetCoreSAPSample;
using DotNetCoreSAPSample.Model;
using System.Text;

// AppServerHost=MY_SERVER_HOST; SystemNumber=00; User=MY_SAP_USER; Password=SECRET; Client=100; Language=EN; PoolSize=5; Trace=8
var connectionString = "";
var sapService = new SAPService(connectionString);
var input = GenEchoDemoItems();
var result = sapService.EchoDemo(input);

PrintResult(result);

void PrintResult(EchoDemoOutput output)
{
    Console.WriteLine(output.ResponseText);
    Console.WriteLine("RfcFloat\tRfcChar1\tRfcChar2\tRfcChar4\tRfcHEX3\tRfcDate\tRfcData1");

    foreach (var item in result.RFCTable)
    {
        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\r\n",
            item.RfcFloat, item.RfcChar1, item.RfcChar2, 
            item.RfcChar4, Encoding.ASCII.GetString(item.RfcHEX3), item.RfcDate, item.RfcData1);
    }
}
/// <summary>
/// 產生假資料
/// </summary>
/// <returns></returns>
EchoDemoInput GenEchoDemoItems()
{
    var demoInput = new EchoDemoInput();
    var items = new List<EchoDemoItem>();

    for (int i = 0; i < 5; i++)
    {
        var item = new EchoDemoItem()
        {
            RfcFloat = 12345.6789,
            RfcChar1 = "AnYun",
            RfcChar2 = "AB",
            RfcChar4 = "NCO3",
            RfcHEX3 = new byte[] { 0x41, 0x42, 0x43 },
            RfcDate = DateTime.Today,
            RfcData1 = "Hello World"
        };

        items.Add(item);
    }
    demoInput.RFCTable = items.ToArray();

    return demoInput;
}