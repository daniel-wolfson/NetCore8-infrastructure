using Isrotel.Framework.Cache;
using Isrotel.Framework.Configuration;
using Isrotel.Framework.Contracts;
using Isrotel.Framework.Exceptions;
using Isrotel.Framework.Helpers;
using Isrotel.Framework.Models.Base;
using Isrotel.Framework.StaticData;
using Isrotel.Framework.StaticData.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Isrotel.Framework.Repositoty
{
    public class ApiBase(IHttpContextAccessor httpContextAccessor)
    {
        private ILogger _logger;
        private IServiceScope _serviceScope;
        private IBlobStorage? _blobStorage = default;
        private IRedisCache? _redisCache = default; 
        private StaticDataCollection<EntityData>? _staticData = default;
        private IConfiguration? _configuration = default;
        private IApiHttpClientFactory? _httpClientFactory = default;
        private IServiceScopeFactory _serviceScopeFactory;
        protected ApiSettings _appSettings;

        //public required IServiceScopeFactory ServiceScopeFactory { get; init; } = _serviceScopeFactory;

        protected virtual string RootCacheKey => $"{CacheKeys.StaticData}_{AppSettings.Version}";
        protected ApiSettings AppSettings => _appSettings ??= GetService<IOptions<ApiSettings>>().Value;
        protected IRedisCache RedisCache => _redisCache ??= GetService<IRedisCache>();
        protected StaticDataCollection<EntityData> StaticData => _staticData ??= GetService<IStaticDataService>().DataContext;
        protected IServiceScopeFactory ServiceScopeFactory => _serviceScopeFactory ??= GetService<IServiceScopeFactory>();
        protected IBlobStorage BlobStorage => _blobStorage ??= GetService<IBlobStorage>();
        protected ILogger Logger => _logger ??= GetService<ILogger>();
        protected IServiceScope ServiceScope => _serviceScope ??= ServiceScopeFactory.CreateScope();
        protected IConfiguration Config => _configuration ??= GetService<IConfiguration>();
        protected IApiHttpClientFactory HttpClientFactory => _httpClientFactory ??= GetService<IApiHttpClientFactory>();
        
        public HttpContext HttpContext => httpContextAccessor.HttpContext!;

        protected T GetService<T>()
        {
            T service;
            if (HttpContext != null)
            {
                service = (T?)HttpContext.RequestServices.GetService(typeof(T))
                    ?? throw new ApiException(new NullReferenceException($"{ApiHelper.LogTitle()} error: {typeof(T).Name} not registered"));
                return service;
            }
            else
            {
                service = (T?)ServiceScope.ServiceProvider.GetService(typeof(T))
                    ?? throw new ApiException(new NullReferenceException($"{ApiHelper.LogTitle()} error: {typeof(T).Name} not registered"));
                return service;
            }

            throw new ApiException(new NullReferenceException($"{ApiHelper.LogTitle()} error: {typeof(T).Name} not registered"));
        }
    }
}