using Isrotel.Framework.Core;

namespace Isrotel.Framework.Contracts
{
    public interface IApiHttpClientFactory
    {
        /// <summary> 
        /// Creates a typed client given an associated HttpClient. 
        /// where for parameter clientName maybe use ApiHttpClientNames
        /// </summary>
        ApiHttpClient CreateClient(string name);
    }

    public interface IApiHttpClientFactory<T>
        where T : ApiHttpClient
    {
        /// <summary> 
        /// Creates a typed client given an associated HttpClient. 
        /// where for parameter clientName maybe use ApiHttpClientNames
        /// </summary>
        T CreateClient(string name);
    }
}
