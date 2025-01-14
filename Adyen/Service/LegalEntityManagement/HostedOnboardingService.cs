/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
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
using Adyen.Model.LegalEntityManagement;

namespace Adyen.Service.LegalEntityManagement
{
    /// <summary>
    /// HostedOnboardingService Interface
    /// </summary>
    public interface IHostedOnboardingService
    {
        /// <summary>
        /// Get a list of hosted onboarding page themes
        /// </summary>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="OnboardingThemes"/>.</returns>
        OnboardingThemes ListHostedOnboardingPageThemes(RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of hosted onboarding page themes
        /// </summary>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="OnboardingThemes"/>.</returns>
        Task<OnboardingThemes> ListHostedOnboardingPageThemesAsync(RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get an onboarding link theme
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the theme</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="OnboardingTheme"/>.</returns>
        OnboardingTheme GetOnboardingLinkTheme(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get an onboarding link theme
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the theme</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="OnboardingTheme"/>.</returns>
        Task<OnboardingTheme> GetOnboardingLinkThemeAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a link to an Adyen-hosted onboarding page
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity</param>
        /// <param name="onboardingLinkInfo"><see cref="OnboardingLinkInfo"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="OnboardingLink"/>.</returns>
        OnboardingLink GetLinkToAdyenhostedOnboardingPage(string id, OnboardingLinkInfo onboardingLinkInfo, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a link to an Adyen-hosted onboarding page
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity</param>
        /// <param name="onboardingLinkInfo"><see cref="OnboardingLinkInfo"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="OnboardingLink"/>.</returns>
        Task<OnboardingLink> GetLinkToAdyenhostedOnboardingPageAsync(string id, OnboardingLinkInfo onboardingLinkInfo, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the HostedOnboardingService API endpoints
    /// </summary>
    public class HostedOnboardingService : AbstractService, IHostedOnboardingService
    {
        private readonly string _baseUrl;
        
        public HostedOnboardingService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://kyc-test.adyen.com/lem/v3");
        }
        
        public OnboardingThemes ListHostedOnboardingPageThemes(RequestOptions requestOptions = default)
        {
            return ListHostedOnboardingPageThemesAsync(requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<OnboardingThemes> ListHostedOnboardingPageThemesAsync(RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/themes";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<OnboardingThemes>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public OnboardingTheme GetOnboardingLinkTheme(string id, RequestOptions requestOptions = default)
        {
            return GetOnboardingLinkThemeAsync(id, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<OnboardingTheme> GetOnboardingLinkThemeAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/themes/{id}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<OnboardingTheme>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public OnboardingLink GetLinkToAdyenhostedOnboardingPage(string id, OnboardingLinkInfo onboardingLinkInfo, RequestOptions requestOptions = default)
        {
            return GetLinkToAdyenhostedOnboardingPageAsync(id, onboardingLinkInfo, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<OnboardingLink> GetLinkToAdyenhostedOnboardingPageAsync(string id, OnboardingLinkInfo onboardingLinkInfo, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/legalEntities/{id}/onboardingLinks";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<OnboardingLink>(onboardingLinkInfo.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}