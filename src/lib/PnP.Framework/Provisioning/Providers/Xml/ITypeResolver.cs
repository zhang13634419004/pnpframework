﻿using System;
using System.Collections.Generic;

namespace PnP.Framework.Provisioning.Providers.Xml
{
    /// <summary>
    /// Handles custom type resolving rules for PnPObjectsMapper
    /// </summary>
    public interface ITypeResolver : IResolver
    {
        /// <summary>
        /// Resolves a source type into a result
        /// </summary>
        /// <param name="source">The full source object to resolve</param>
        /// <param name="resolvers"></param>
        /// <param name="recursive">Defines whether to apply the mapping recursively, optional and by default false</param>
        Object Resolve(Object source, Dictionary<String, IResolver> resolvers = null, Boolean recursive = false);

        /// <summary>
        /// Declares whether the Type Resolver handles a collection in a custom way
        /// </summary>
        Boolean CustomCollectionResolver { get; }
    }
}
