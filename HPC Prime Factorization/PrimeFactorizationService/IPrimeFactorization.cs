using System.Collections.Generic;
using System.ServiceModel;

namespace Microsoft.Hpc.SOASample.RealTimeMode
{
    [ServiceContract]
    public interface IPrimeFactorization
    {
        [OperationContract]
        List<int> Factorize(int n);
    }
}