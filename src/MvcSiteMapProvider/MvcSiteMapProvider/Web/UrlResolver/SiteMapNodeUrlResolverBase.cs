﻿using System;
using System.Collections.Generic;

namespace MvcSiteMapProvider.Web.UrlResolver
{
    /// <summary>
    /// Base class to make it easier to implement a custom Url Resolver.
    /// </summary>
    public abstract class SiteMapNodeUrlResolverBase
        : ISiteMapNodeUrlResolver
    {
        #region ISiteMapNodeUrlResolver Members

        /// <summary>
        /// Resolves the URL. Override this member to provide alternate implementations of UrlResolver.
        /// </summary>
        /// <param name="node">The site map node.</param>
        /// <param name="area">The area.</param>
        /// <param name="controller">The controller.</param>
        /// <param name="action">The action.</param>
        /// <param name="routeValues">The route values.</param>
        /// <returns>The resolved URL.</returns>
        public abstract string ResolveUrl(ISiteMapNode node, string area, string controller, string action, IDictionary<string, object> routeValues);


        /// <summary>
        /// Determines whether the provider instance matches the name
        /// </summary>
        /// <param name="providerName">The name of the URL resolver. This can be any string, but for backward compatibility the type name is used.</param>
        /// <returns>
        /// <c>true</c> if the provider name matches; otherwise <c>false</c>.
        /// </returns>
        public virtual bool AppliesTo(string providerName)
        {
            if (string.IsNullOrEmpty(providerName))
                return false;

            return this.GetType().Equals(Type.GetType(providerName, false));
        }

        #endregion
    }
}
