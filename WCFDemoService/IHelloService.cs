using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFDemoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloService" in both code and config file together.
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        int  Addition(int x,int y);

        [OperationContract]
        string Message(string msg);
    }
}
