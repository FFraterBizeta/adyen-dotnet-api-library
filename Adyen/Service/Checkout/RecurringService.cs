/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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
using Adyen.Model.Checkout;

namespace Adyen.Service.Checkout
{
    /// <summary>
    /// RecurringService Interface
    /// </summary>
    public interface IRecurringService
    {
        /// <summary>
        /// Delete a token for stored payment details
        /// </summary>
        /// <param name="recurringId"><see cref="string"/> - The unique identifier of the token.</param>
        /// <param name="shopperReference"><see cref="string"/> - Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.</param>
        /// <param name="merchantAccount"><see cref="string"/> - Your merchant account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="StoredPaymentMethodResource"/>.</returns>
        StoredPaymentMethodResource DeleteTokenForStoredPaymentDetails(string recurringId, string shopperReference = default, string merchantAccount = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Delete a token for stored payment details
        /// </summary>
        /// <param name="recurringId"><see cref="string"/> - The unique identifier of the token.</param>
        /// <param name="shopperReference"><see cref="string"/> - Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.</param>
        /// <param name="merchantAccount"><see cref="string"/> - Your merchant account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="StoredPaymentMethodResource"/>.</returns>
        Task<StoredPaymentMethodResource> DeleteTokenForStoredPaymentDetailsAsync(string recurringId, string shopperReference = default, string merchantAccount = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get tokens for stored payment details
        /// </summary>
        /// <param name="shopperReference"><see cref="string"/> - Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.</param>
        /// <param name="merchantAccount"><see cref="string"/> - Your merchant account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ListStoredPaymentMethodsResponse"/>.</returns>
        ListStoredPaymentMethodsResponse GetTokensForStoredPaymentDetails(string shopperReference = default, string merchantAccount = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get tokens for stored payment details
        /// </summary>
        /// <param name="shopperReference"><see cref="string"/> - Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.</param>
        /// <param name="merchantAccount"><see cref="string"/> - Your merchant account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ListStoredPaymentMethodsResponse"/>.</returns>
        Task<ListStoredPaymentMethodsResponse> GetTokensForStoredPaymentDetailsAsync(string shopperReference = default, string merchantAccount = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RecurringService : AbstractService, IRecurringService
    {
        private readonly string _baseUrl;
        
        public RecurringService(Client client) : base(client)
        {
            _baseUrl = client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion;
        }
        
        public StoredPaymentMethodResource DeleteTokenForStoredPaymentDetails(string recurringId, string shopperReference = default, string merchantAccount = default, RequestOptions requestOptions = default)
        {
            return DeleteTokenForStoredPaymentDetailsAsync(recurringId, shopperReference, merchantAccount, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<StoredPaymentMethodResource> DeleteTokenForStoredPaymentDetailsAsync(string recurringId, string shopperReference = default, string merchantAccount = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (shopperReference != null) queryParams.Add("shopperReference", shopperReference);
            if (merchantAccount != null) queryParams.Add("merchantAccount", merchantAccount);
            var endpoint = _baseUrl + $"/storedPaymentMethods/{recurringId}" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<StoredPaymentMethodResource>(null, requestOptions, new HttpMethod("DELETE"), cancellationToken);
        }
        
        public ListStoredPaymentMethodsResponse GetTokensForStoredPaymentDetails(string shopperReference = default, string merchantAccount = default, RequestOptions requestOptions = default)
        {
            return GetTokensForStoredPaymentDetailsAsync(shopperReference, merchantAccount, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<ListStoredPaymentMethodsResponse> GetTokensForStoredPaymentDetailsAsync(string shopperReference = default, string merchantAccount = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (shopperReference != null) queryParams.Add("shopperReference", shopperReference);
            if (merchantAccount != null) queryParams.Add("merchantAccount", merchantAccount);
            var endpoint = _baseUrl + "/storedPaymentMethods" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ListStoredPaymentMethodsResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken);
        }
    }
}