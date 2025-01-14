/*
* Management API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.Management;

namespace Adyen.Service.Management
{
    /// <summary>
    /// TerminalActionsCompanyLevelService Interface
    /// </summary>
    public interface ITerminalActionsCompanyLevelService
    {
        /// <summary>
        /// Get a list of Android apps
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AndroidAppsResponse"/>.</returns>
        AndroidAppsResponse ListAndroidApps(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of Android apps
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AndroidAppsResponse"/>.</returns>
        Task<AndroidAppsResponse> ListAndroidAppsAsync(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a list of Android certificates
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AndroidCertificatesResponse"/>.</returns>
        AndroidCertificatesResponse ListAndroidCertificates(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of Android certificates
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AndroidCertificatesResponse"/>.</returns>
        Task<AndroidCertificatesResponse> ListAndroidCertificatesAsync(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a list of terminal actions
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
        /// <param name="status"><see cref="string"/> - Returns terminal actions with the specified status.  Allowed values: **pending**, **successful**, **failed**, **cancelled**, **tryLater**.</param>
        /// <param name="type"><see cref="string"/> - Returns terminal actions of the specified type.  Allowed values: **InstallAndroidApp**, **UninstallAndroidApp**, **InstallAndroidCertificate**, **UninstallAndroidCertificate**.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ListExternalTerminalActionsResponse"/>.</returns>
        ListExternalTerminalActionsResponse ListTerminalActions(string companyId, int? pageNumber = default, int? pageSize = default, string status = default, string type = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of terminal actions
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
        /// <param name="status"><see cref="string"/> - Returns terminal actions with the specified status.  Allowed values: **pending**, **successful**, **failed**, **cancelled**, **tryLater**.</param>
        /// <param name="type"><see cref="string"/> - Returns terminal actions of the specified type.  Allowed values: **InstallAndroidApp**, **UninstallAndroidApp**, **InstallAndroidCertificate**, **UninstallAndroidCertificate**.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ListExternalTerminalActionsResponse"/>.</returns>
        Task<ListExternalTerminalActionsResponse> ListTerminalActionsAsync(string companyId, int? pageNumber = default, int? pageSize = default, string status = default, string type = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get terminal action
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="actionId"><see cref="string"/> - The unique identifier of the terminal action.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ExternalTerminalAction"/>.</returns>
        ExternalTerminalAction GetTerminalAction(string companyId, string actionId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get terminal action
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="actionId"><see cref="string"/> - The unique identifier of the terminal action.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ExternalTerminalAction"/>.</returns>
        Task<ExternalTerminalAction> GetTerminalActionAsync(string companyId, string actionId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the TerminalActionsCompanyLevelService API endpoints
    /// </summary>
    public class TerminalActionsCompanyLevelService : AbstractService, ITerminalActionsCompanyLevelService
    {
        private readonly string _baseUrl;
        
        public TerminalActionsCompanyLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public AndroidAppsResponse ListAndroidApps(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            return ListAndroidAppsAsync(companyId, pageNumber, pageSize, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<AndroidAppsResponse> ListAndroidAppsAsync(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            var endpoint = _baseUrl + $"/companies/{companyId}/androidApps" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<AndroidAppsResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public AndroidCertificatesResponse ListAndroidCertificates(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            return ListAndroidCertificatesAsync(companyId, pageNumber, pageSize, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<AndroidCertificatesResponse> ListAndroidCertificatesAsync(string companyId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            var endpoint = _baseUrl + $"/companies/{companyId}/androidCertificates" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<AndroidCertificatesResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public ListExternalTerminalActionsResponse ListTerminalActions(string companyId, int? pageNumber = default, int? pageSize = default, string status = default, string type = default, RequestOptions requestOptions = default)
        {
            return ListTerminalActionsAsync(companyId, pageNumber, pageSize, status, type, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ListExternalTerminalActionsResponse> ListTerminalActionsAsync(string companyId, int? pageNumber = default, int? pageSize = default, string status = default, string type = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            if (status != null) queryParams.Add("status", status);
            if (type != null) queryParams.Add("type", type);
            var endpoint = _baseUrl + $"/companies/{companyId}/terminalActions" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ListExternalTerminalActionsResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public ExternalTerminalAction GetTerminalAction(string companyId, string actionId, RequestOptions requestOptions = default)
        {
            return GetTerminalActionAsync(companyId, actionId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ExternalTerminalAction> GetTerminalActionAsync(string companyId, string actionId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/terminalActions/{actionId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ExternalTerminalAction>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
    }
}