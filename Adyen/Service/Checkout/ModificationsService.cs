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
    /// ModificationsService Interface
    /// </summary>
    public interface IModificationsService
    {
        /// <summary>
        /// Cancel an authorised payment
        /// </summary>
        /// <param name="createStandalonePaymentCancelRequest"><see cref="CreateStandalonePaymentCancelRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="StandalonePaymentCancelResource"/>.</returns>
        StandalonePaymentCancelResource CancelAuthorisedPayment(CreateStandalonePaymentCancelRequest createStandalonePaymentCancelRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Cancel an authorised payment
        /// </summary>
        /// <param name="createStandalonePaymentCancelRequest"><see cref="CreateStandalonePaymentCancelRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="StandalonePaymentCancelResource"/>.</returns>
        Task<StandalonePaymentCancelResource> CancelAuthorisedPaymentAsync(CreateStandalonePaymentCancelRequest createStandalonePaymentCancelRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update an authorised amount
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment.</param>
        /// <param name="createPaymentAmountUpdateRequest"><see cref="CreatePaymentAmountUpdateRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentAmountUpdateResource"/>.</returns>
        PaymentAmountUpdateResource UpdateAuthorisedAmount(string paymentPspReference, CreatePaymentAmountUpdateRequest createPaymentAmountUpdateRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update an authorised amount
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment.</param>
        /// <param name="createPaymentAmountUpdateRequest"><see cref="CreatePaymentAmountUpdateRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentAmountUpdateResource"/>.</returns>
        Task<PaymentAmountUpdateResource> UpdateAuthorisedAmountAsync(string paymentPspReference, CreatePaymentAmountUpdateRequest createPaymentAmountUpdateRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Cancel an authorised payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to cancel. </param>
        /// <param name="createPaymentCancelRequest"><see cref="CreatePaymentCancelRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentCancelResource"/>.</returns>
        PaymentCancelResource CancelAuthorisedPaymentByPspReference(string paymentPspReference, CreatePaymentCancelRequest createPaymentCancelRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Cancel an authorised payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to cancel. </param>
        /// <param name="createPaymentCancelRequest"><see cref="CreatePaymentCancelRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentCancelResource"/>.</returns>
        Task<PaymentCancelResource> CancelAuthorisedPaymentByPspReferenceAsync(string paymentPspReference, CreatePaymentCancelRequest createPaymentCancelRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Capture an authorised payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to capture.</param>
        /// <param name="createPaymentCaptureRequest"><see cref="CreatePaymentCaptureRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentCaptureResource"/>.</returns>
        PaymentCaptureResource CaptureAuthorisedPayment(string paymentPspReference, CreatePaymentCaptureRequest createPaymentCaptureRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Capture an authorised payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to capture.</param>
        /// <param name="createPaymentCaptureRequest"><see cref="CreatePaymentCaptureRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentCaptureResource"/>.</returns>
        Task<PaymentCaptureResource> CaptureAuthorisedPaymentAsync(string paymentPspReference, CreatePaymentCaptureRequest createPaymentCaptureRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Refund a captured payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to refund.</param>
        /// <param name="createPaymentRefundRequest"><see cref="CreatePaymentRefundRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentRefundResource"/>.</returns>
        PaymentRefundResource RefundCapturedPayment(string paymentPspReference, CreatePaymentRefundRequest createPaymentRefundRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Refund a captured payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to refund.</param>
        /// <param name="createPaymentRefundRequest"><see cref="CreatePaymentRefundRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentRefundResource"/>.</returns>
        Task<PaymentRefundResource> RefundCapturedPaymentAsync(string paymentPspReference, CreatePaymentRefundRequest createPaymentRefundRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Refund or cancel a payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to reverse. </param>
        /// <param name="createPaymentReversalRequest"><see cref="CreatePaymentReversalRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentReversalResource"/>.</returns>
        PaymentReversalResource RefundOrCancelPayment(string paymentPspReference, CreatePaymentReversalRequest createPaymentReversalRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Refund or cancel a payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to reverse. </param>
        /// <param name="createPaymentReversalRequest"><see cref="CreatePaymentReversalRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentReversalResource"/>.</returns>
        Task<PaymentReversalResource> RefundOrCancelPaymentAsync(string paymentPspReference, CreatePaymentReversalRequest createPaymentReversalRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the ModificationsService API endpoints
    /// </summary>
    public class ModificationsService : AbstractService, IModificationsService
    {
        private readonly string _baseUrl;
        
        public ModificationsService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://checkout-test.adyen.com/v70");
        }
        
        public StandalonePaymentCancelResource CancelAuthorisedPayment(CreateStandalonePaymentCancelRequest createStandalonePaymentCancelRequest, RequestOptions requestOptions = default)
        {
            return CancelAuthorisedPaymentAsync(createStandalonePaymentCancelRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<StandalonePaymentCancelResource> CancelAuthorisedPaymentAsync(CreateStandalonePaymentCancelRequest createStandalonePaymentCancelRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/cancels";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<StandalonePaymentCancelResource>(createStandalonePaymentCancelRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public PaymentAmountUpdateResource UpdateAuthorisedAmount(string paymentPspReference, CreatePaymentAmountUpdateRequest createPaymentAmountUpdateRequest, RequestOptions requestOptions = default)
        {
            return UpdateAuthorisedAmountAsync(paymentPspReference, createPaymentAmountUpdateRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PaymentAmountUpdateResource> UpdateAuthorisedAmountAsync(string paymentPspReference, CreatePaymentAmountUpdateRequest createPaymentAmountUpdateRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/amountUpdates";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentAmountUpdateResource>(createPaymentAmountUpdateRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public PaymentCancelResource CancelAuthorisedPaymentByPspReference(string paymentPspReference, CreatePaymentCancelRequest createPaymentCancelRequest, RequestOptions requestOptions = default)
        {
            return CancelAuthorisedPaymentByPspReferenceAsync(paymentPspReference, createPaymentCancelRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PaymentCancelResource> CancelAuthorisedPaymentByPspReferenceAsync(string paymentPspReference, CreatePaymentCancelRequest createPaymentCancelRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/cancels";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentCancelResource>(createPaymentCancelRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public PaymentCaptureResource CaptureAuthorisedPayment(string paymentPspReference, CreatePaymentCaptureRequest createPaymentCaptureRequest, RequestOptions requestOptions = default)
        {
            return CaptureAuthorisedPaymentAsync(paymentPspReference, createPaymentCaptureRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PaymentCaptureResource> CaptureAuthorisedPaymentAsync(string paymentPspReference, CreatePaymentCaptureRequest createPaymentCaptureRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/captures";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentCaptureResource>(createPaymentCaptureRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public PaymentRefundResource RefundCapturedPayment(string paymentPspReference, CreatePaymentRefundRequest createPaymentRefundRequest, RequestOptions requestOptions = default)
        {
            return RefundCapturedPaymentAsync(paymentPspReference, createPaymentRefundRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PaymentRefundResource> RefundCapturedPaymentAsync(string paymentPspReference, CreatePaymentRefundRequest createPaymentRefundRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/refunds";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentRefundResource>(createPaymentRefundRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public PaymentReversalResource RefundOrCancelPayment(string paymentPspReference, CreatePaymentReversalRequest createPaymentReversalRequest, RequestOptions requestOptions = default)
        {
            return RefundOrCancelPaymentAsync(paymentPspReference, createPaymentReversalRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PaymentReversalResource> RefundOrCancelPaymentAsync(string paymentPspReference, CreatePaymentReversalRequest createPaymentReversalRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/reversals";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentReversalResource>(createPaymentReversalRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}