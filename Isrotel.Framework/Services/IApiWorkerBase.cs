using Isrotel.Framework.Models.Errors;

namespace Isrotel.Framework.Services
{
    public interface IApiWorkerBase
    {
        List<ErrorInfo>? GetErrors();

        public ErrorInfo? GetLatestError();
    }
}