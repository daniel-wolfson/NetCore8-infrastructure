using Isrotel.Domain.Optima.Models.Base;
using Isrotel.Framework.Configuration;
using Isrotel.Framework.Models.Base;

namespace Isrotel.Framework.Contracts
{
    public interface IOptimaBaseRepository
    {
        Task<List<OptimaResult<List<TData>>>> SendBulkAsync<TData>(
            string apiHttpClientName, HttpMethod httpMethod, string path, OptimaRequest[] requests)
            where TData : OptimaData;

        Task<OptimaResult<TData>> SendAsync<TData>(string apiHttpClientName, HttpMethod httpMethod, string path, object request);
    }
}