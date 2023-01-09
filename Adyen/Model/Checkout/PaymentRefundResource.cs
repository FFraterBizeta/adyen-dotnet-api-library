/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 69
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PaymentRefundResource
    /// </summary>
    [DataContract(Name = "PaymentRefundResource")]
    public partial class PaymentRefundResource : IEquatable<PaymentRefundResource>, IValidatableObject
    {
        /// <summary>
        /// The status of your request. This will always have the value **received**.
        /// </summary>
        /// <value>The status of your request. This will always have the value **received**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Received for value: received
            /// </summary>
            [EnumMember(Value = "received")]
            Received = 1

        }


        /// <summary>
        /// The status of your request. This will always have the value **received**.
        /// </summary>
        /// <value>The status of your request. This will always have the value **received**.</value>
        [DataMember(Name = "status", IsRequired = false, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRefundResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentRefundResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRefundResource" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="lineItems">Price and product information of the refunded items, required for [partial refunds](https://docs.adyen.com/online-payments/refund#refund-a-payment). &gt; This field is required for partial refunds with 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, Zip and Atome..</param>
        /// <param name="merchantAccount">The merchant account that is used to process the payment. (required).</param>
        /// <param name="paymentPspReference">The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment to refund.  (required).</param>
        /// <param name="pspReference">Adyen&#39;s 16-character reference associated with the refund request. (required).</param>
        /// <param name="reference">Your reference for the refund request..</param>
        /// <param name="splits">An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information)..</param>
        /// <param name="status">The status of your request. This will always have the value **received**. (required).</param>
        public PaymentRefundResource(Amount amount = default(Amount), List<LineItem> lineItems = default(List<LineItem>), string merchantAccount = default(string), string paymentPspReference = default(string), string pspReference = default(string), string reference = default(string), List<Split> splits = default(List<Split>), StatusEnum status = default(StatusEnum))
        {
            this.Amount = amount;
            this.MerchantAccount = merchantAccount;
            this.PaymentPspReference = paymentPspReference;
            this.PspReference = pspReference;
            this.Status = status;
            this.LineItems = lineItems;
            this.Reference = reference;
            this.Splits = splits;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = false, EmitDefaultValue = true)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Price and product information of the refunded items, required for [partial refunds](https://docs.adyen.com/online-payments/refund#refund-a-payment). &gt; This field is required for partial refunds with 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, Zip and Atome.
        /// </summary>
        /// <value>Price and product information of the refunded items, required for [partial refunds](https://docs.adyen.com/online-payments/refund#refund-a-payment). &gt; This field is required for partial refunds with 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, Zip and Atome.</value>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// The merchant account that is used to process the payment.
        /// </summary>
        /// <value>The merchant account that is used to process the payment.</value>
        [DataMember(Name = "merchantAccount", IsRequired = false, EmitDefaultValue = true)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment to refund. 
        /// </summary>
        /// <value>The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment to refund. </value>
        [DataMember(Name = "paymentPspReference", IsRequired = false, EmitDefaultValue = true)]
        public string PaymentPspReference { get; set; }

        /// <summary>
        /// Adyen&#39;s 16-character reference associated with the refund request.
        /// </summary>
        /// <value>Adyen&#39;s 16-character reference associated with the refund request.</value>
        [DataMember(Name = "pspReference", IsRequired = false, EmitDefaultValue = true)]
        public string PspReference { get; set; }

        /// <summary>
        /// Your reference for the refund request.
        /// </summary>
        /// <value>Your reference for the refund request.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information).
        /// </summary>
        /// <value>An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information).</value>
        [DataMember(Name = "splits", EmitDefaultValue = false)]
        public List<Split> Splits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentRefundResource {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  PaymentPspReference: ").Append(PaymentPspReference).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Splits: ").Append(Splits).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentRefundResource);
        }

        /// <summary>
        /// Returns true if PaymentRefundResource instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentRefundResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentRefundResource input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.PaymentPspReference == input.PaymentPspReference ||
                    (this.PaymentPspReference != null &&
                    this.PaymentPspReference.Equals(input.PaymentPspReference))
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Splits == input.Splits ||
                    this.Splits != null &&
                    input.Splits != null &&
                    this.Splits.SequenceEqual(input.Splits)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hashCode = (hashCode * 59) + this.LineItems.GetHashCode();
                }
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                if (this.PaymentPspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentPspReference.GetHashCode();
                }
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.Splits != null)
                {
                    hashCode = (hashCode * 59) + this.Splits.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
