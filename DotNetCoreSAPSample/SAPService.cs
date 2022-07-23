using DotNetCoreSAPSample.Model;
using SapNwRfc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreSAPSample
{
    internal class SAPService
    {
        private SapConnection sapConnection;

        public SAPService(string connectionString)
        {
            sapConnection = new SapConnection(connectionString);
            sapConnection.Connect();
        }

        /// <summary>
        /// 呼叫 Echo Demo
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sapFunction">SAP Function</param>
        /// <returns></returns>
        public EchoDemoOutput EchoDemo(EchoDemoInput input)
        {
            using var sapFunctionClient = sapConnection.CreateFunction("STFC_STRUCTURE");
            return sapFunctionClient.Invoke<EchoDemoOutput>(input);
        }
    }
}
