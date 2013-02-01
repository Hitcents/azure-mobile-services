﻿// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Windows.Data.Json;

namespace Microsoft.WindowsAzure.MobileServices
{
    /// <summary>
    /// Provides operations on tables for a Mobile Service.
    /// </summary>
    public partial interface IMobileServiceTable
    {
        /// <summary>
        /// Excute a query against a table.
        /// </summary>
        /// <param name="query">
        /// An OData query to execute.
        /// </param>
        /// <returns>
        /// A task that will return with results when the query finishes.
        /// </returns>
        Task<IJsonValue> ReadAsync(string query);

        /// <summary>
        /// Excute a query against a table.
        /// </summary>
        /// <param name="query">
        /// An OData query to execute.
        /// </param>
        /// <param name="parameters">
        /// A dictionary of user-defined parameters and values to include in the request URI query string.
        /// </param>
        /// <returns>
        /// A task that will return with results when the query finishes.
        /// </returns>
        Task<IJsonValue> ReadAsync(string query, IDictionary<string, string> parameters);

        /// <summary>
        /// Insert a new object into a table.
        /// </summary>
        /// <param name="instance">
        /// The instance to insert into the table.
        /// </param>
        /// <returns>
        /// A task that will complete when the insert finishes.
        /// </returns>
        Task<IJsonValue> InsertAsync(JsonObject instance);

        /// <summary>
        /// Insert a new object into a table.
        /// </summary>
        /// <param name="instance">
        /// The instance to insert into the table.
        /// </param>
        /// <param name="parameters">
        /// A dictionary of user-defined parameters and values to include in the request URI query string.
        /// </param>
        /// <returns>
        /// A task that will complete when the insert finishes.
        /// </returns>
        Task<IJsonValue> InsertAsync(JsonObject instance, IDictionary<string, string> parameters);

        /// <summary>
        /// Update an object in a given table.
        /// </summary>
        /// <param name="instance">
        /// The instance to update in the table.
        /// </param>
        /// <returns>
        /// A task that will complete when the update finishes.
        /// </returns>
        Task<IJsonValue> UpdateAsync(JsonObject instance);

        /// <summary>
        /// Update an object in a given table.
        /// </summary>
        /// <param name="instance">
        /// The instance to update in the table.
        /// </param>
        /// <param name="parameters">
        /// A dictionary of user-defined parameters and values to include in the request URI query string.
        /// </param>
        /// <returns>
        /// A task that will complete when the update finishes.
        /// </returns>
        Task<IJsonValue> UpdateAsync(JsonObject instance, IDictionary<string, string> parameters);

        /// <summary>
        /// Delete an object from a given table.
        /// </summary>
        /// <param name="instance">
        /// The instance to delete from the table.
        /// </param>
        /// <returns>
        /// A task that will complete when the delete finishes.
        /// </returns>
        Task DeleteAsync(JsonObject instance);

        /// <summary>
        /// Delete an object from a given table.
        /// </summary>
        /// <param name="instance">
        /// The instance to delete from the table.
        /// </param>
        /// <param name="parameters">
        /// A dictionary of user-defined parameters and values to include in the request URI query string.
        /// </param>
        /// <returns>
        /// A task that will complete when the delete finishes.
        /// </returns>
        Task DeleteAsync(JsonObject instance, IDictionary<string, string> parameters);

        /// <summary>
        /// Execute a lookup against a table.
        /// </summary>
        /// <param name="id">
        /// The id of the object to lookup.
        /// </param>
        /// <returns>
        /// A task that will return with a result when the lookup finishes.
        /// </returns>
        Task<IJsonValue> LookupAsync(object id);

        /// <summary>
        /// Execute a lookup against a table.
        /// </summary>
        /// <param name="id">
        /// The id of the object to lookup.
        /// </param>
        /// <param name="parameters">
        /// A dictionary of user-defined parameters and values to include in the request URI query string.
        /// </param>
        /// <returns>
        /// A task that will return with a result when the lookup finishes.
        /// </returns>
        Task<IJsonValue> LookupAsync(object id, IDictionary<string, string> parameters);
    }
}
