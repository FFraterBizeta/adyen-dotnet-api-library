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
    /// PaymentsService Interface
    /// </summary>
    public interface IPaymentsService
    {
        /// <summary>
        /// Get the list of brands on the card
        /// </summary>
        /// <param name="cardDetailsRequest"><see cref="CardDetailsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CardDetailsResponse"/>.</returns>
        CardDetailsResponse CardDetails(CardDetailsRequest cardDetailsRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get the list of brands on the card
        /// </summary>
        /// <param name="cardDetailsRequest"><see cref="CardDetailsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CardDetailsResponse"/>.</returns>
        Task<CardDetailsResponse> CardDetailsAsync(CardDetailsRequest cardDetailsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Start a transaction for donations
        /// </summary>
        /// <param name="paymentDonationRequest"><see cref="PaymentDonationRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="DonationResponse"/>.</returns>
        DonationResponse Donations(PaymentDonationRequest paymentDonationRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Start a transaction for donations
        /// </summary>
        /// <param name="paymentDonationRequest"><see cref="PaymentDonationRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="DonationResponse"/>.</returns>
        Task<DonationResponse> DonationsAsync(PaymentDonationRequest paymentDonationRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a list of available payment methods
        /// </summary>
        /// <param name="paymentMethodsRequest"><see cref="PaymentMethodsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentMethodsResponse"/>.</returns>
        PaymentMethodsResponse PaymentMethods(PaymentMethodsRequest paymentMethodsRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of available payment methods
        /// </summary>
        /// <param name="paymentMethodsRequest"><see cref="PaymentMethodsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentMethodsResponse"/>.</returns>
        Task<PaymentMethodsResponse> PaymentMethodsAsync(PaymentMethodsRequest paymentMethodsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Start a transaction
        /// </summary>
        /// <param name="paymentRequest"><see cref="PaymentRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentResponse"/>.</returns>
        PaymentResponse Payments(PaymentRequest paymentRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Start a transaction
        /// </summary>
        /// <param name="paymentRequest"><see cref="PaymentRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentResponse"/>.</returns>
        Task<PaymentResponse> PaymentsAsync(PaymentRequest paymentRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Submit details for a payment
        /// </summary>
        /// <param name="detailsRequest"><see cref="DetailsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentDetailsResponse"/>.</returns>
        PaymentDetailsResponse PaymentsDetails(DetailsRequest detailsRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Submit details for a payment
        /// </summary>
        /// <param name="detailsRequest"><see cref="DetailsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentDetailsResponse"/>.</returns>
        Task<PaymentDetailsResponse> PaymentsDetailsAsync(DetailsRequest detailsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create a payment session
        /// </summary>
        /// <param name="createCheckoutSessionRequest"><see cref="CreateCheckoutSessionRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CreateCheckoutSessionResponse"/>.</returns>
        CreateCheckoutSessionResponse Sessions(CreateCheckoutSessionRequest createCheckoutSessionRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create a payment session
        /// </summary>
        /// <param name="createCheckoutSessionRequest"><see cref="CreateCheckoutSessionRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CreateCheckoutSessionResponse"/>.</returns>
        Task<CreateCheckoutSessionResponse> SessionsAsync(CreateCheckoutSessionRequest createCheckoutSessionRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the PaymentsService API endpoints
    /// </summary>
    public class PaymentsService : AbstractService, IPaymentsService
    {
        private readonly string _baseUrl;
        
        public PaymentsService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://checkout-test.adyen.com/v70");
        }
        
        public CardDetailsResponse CardDetails(CardDetailsRequest cardDetailsRequest, RequestOptions requestOptions = default)
        {
            return CardDetailsAsync(cardDetailsRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CardDetailsResponse> CardDetailsAsync(CardDetailsRequest cardDetailsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/cardDetails";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CardDetailsResponse>(cardDetailsRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public DonationResponse Donations(PaymentDonationRequest paymentDonationRequest, RequestOptions requestOptions = default)
        {
            return DonationsAsync(paymentDonationRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<DonationResponse> DonationsAsync(PaymentDonationRequest paymentDonationRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/donations";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<DonationResponse>(paymentDonationRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public PaymentMethodsResponse PaymentMethods(PaymentMethodsRequest paymentMethodsRequest, RequestOptions requestOptions = default)
        {
            return PaymentMethodsAsync(paymentMethodsRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PaymentMethodsResponse> PaymentMethodsAsync(PaymentMethodsRequest paymentMethodsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/paymentMethods";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentMethodsResponse>(paymentMethodsRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public PaymentResponse Payments(PaymentRequest paymentRequest, RequestOptions requestOptions = default)
        {
            return PaymentsAsync(paymentRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PaymentResponse> PaymentsAsync(PaymentRequest paymentRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/payments";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentResponse>(paymentRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public PaymentDetailsResponse PaymentsDetails(DetailsRequest detailsRequest, RequestOptions requestOptions = default)
        {
            return PaymentsDetailsAsync(detailsRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PaymentDetailsResponse> PaymentsDetailsAsync(DetailsRequest detailsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/payments/details";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentDetailsResponse>(detailsRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public CreateCheckoutSessionResponse Sessions(CreateCheckoutSessionRequest createCheckoutSessionRequest, RequestOptions requestOptions = default)
        {
            return SessionsAsync(createCheckoutSessionRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CreateCheckoutSessionResponse> SessionsAsync(CreateCheckoutSessionRequest createCheckoutSessionRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/sessions";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CreateCheckoutSessionResponse>(createCheckoutSessionRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}