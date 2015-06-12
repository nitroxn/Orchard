using System;
using System.Web.Caching;

namespace IDeliverable.Licensing.Orchard.Models
{
    public class CacheInvalidationContext
    {
        public CacheDependency CacheDependency { get; set; }
        public TimeSpan? ValidFor { get; set; }
    }
}