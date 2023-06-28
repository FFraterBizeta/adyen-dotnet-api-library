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
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Management
{
    /// <summary>
    /// ReceiptPrinting
    /// </summary>
    [DataContract(Name = "ReceiptPrinting")]
    public partial class ReceiptPrinting : IEquatable<ReceiptPrinting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptPrinting" /> class.
        /// </summary>
        /// <param name="merchantApproved">Print a merchant receipt when the payment is approved..</param>
        /// <param name="merchantCancelled">Print a merchant receipt when the transaction is cancelled..</param>
        /// <param name="merchantCaptureApproved">Print a merchant receipt when capturing the payment is approved..</param>
        /// <param name="merchantCaptureRefused">Print a merchant receipt when capturing the payment is refused..</param>
        /// <param name="merchantRefundApproved">Print a merchant receipt when the refund is approved..</param>
        /// <param name="merchantRefundRefused">Print a merchant receipt when the refund is refused..</param>
        /// <param name="merchantRefused">Print a merchant receipt when the payment is refused..</param>
        /// <param name="merchantVoid">Print a merchant receipt when a previous transaction is voided..</param>
        /// <param name="shopperApproved">Print a shopper receipt when the payment is approved..</param>
        /// <param name="shopperCancelled">Print a shopper receipt when the transaction is cancelled..</param>
        /// <param name="shopperCaptureApproved">Print a shopper receipt when capturing the payment is approved..</param>
        /// <param name="shopperCaptureRefused">Print a shopper receipt when capturing the payment is refused..</param>
        /// <param name="shopperRefundApproved">Print a shopper receipt when the refund is approved..</param>
        /// <param name="shopperRefundRefused">Print a shopper receipt when the refund is refused..</param>
        /// <param name="shopperRefused">Print a shopper receipt when the payment is refused..</param>
        /// <param name="shopperVoid">Print a shopper receipt when a previous transaction is voided..</param>
        public ReceiptPrinting(bool merchantApproved = default(bool), bool merchantCancelled = default(bool), bool merchantCaptureApproved = default(bool), bool merchantCaptureRefused = default(bool), bool merchantRefundApproved = default(bool), bool merchantRefundRefused = default(bool), bool merchantRefused = default(bool), bool merchantVoid = default(bool), bool shopperApproved = default(bool), bool shopperCancelled = default(bool), bool shopperCaptureApproved = default(bool), bool shopperCaptureRefused = default(bool), bool shopperRefundApproved = default(bool), bool shopperRefundRefused = default(bool), bool shopperRefused = default(bool), bool shopperVoid = default(bool))
        {
            this.MerchantApproved = merchantApproved;
            this.MerchantCancelled = merchantCancelled;
            this.MerchantCaptureApproved = merchantCaptureApproved;
            this.MerchantCaptureRefused = merchantCaptureRefused;
            this.MerchantRefundApproved = merchantRefundApproved;
            this.MerchantRefundRefused = merchantRefundRefused;
            this.MerchantRefused = merchantRefused;
            this.MerchantVoid = merchantVoid;
            this.ShopperApproved = shopperApproved;
            this.ShopperCancelled = shopperCancelled;
            this.ShopperCaptureApproved = shopperCaptureApproved;
            this.ShopperCaptureRefused = shopperCaptureRefused;
            this.ShopperRefundApproved = shopperRefundApproved;
            this.ShopperRefundRefused = shopperRefundRefused;
            this.ShopperRefused = shopperRefused;
            this.ShopperVoid = shopperVoid;
        }

        /// <summary>
        /// Print a merchant receipt when the payment is approved.
        /// </summary>
        /// <value>Print a merchant receipt when the payment is approved.</value>
        [DataMember(Name = "merchantApproved", EmitDefaultValue = false)]
        public bool MerchantApproved { get; set; }

        /// <summary>
        /// Print a merchant receipt when the transaction is cancelled.
        /// </summary>
        /// <value>Print a merchant receipt when the transaction is cancelled.</value>
        [DataMember(Name = "merchantCancelled", EmitDefaultValue = false)]
        public bool MerchantCancelled { get; set; }

        /// <summary>
        /// Print a merchant receipt when capturing the payment is approved.
        /// </summary>
        /// <value>Print a merchant receipt when capturing the payment is approved.</value>
        [DataMember(Name = "merchantCaptureApproved", EmitDefaultValue = false)]
        public bool MerchantCaptureApproved { get; set; }

        /// <summary>
        /// Print a merchant receipt when capturing the payment is refused.
        /// </summary>
        /// <value>Print a merchant receipt when capturing the payment is refused.</value>
        [DataMember(Name = "merchantCaptureRefused", EmitDefaultValue = false)]
        public bool MerchantCaptureRefused { get; set; }

        /// <summary>
        /// Print a merchant receipt when the refund is approved.
        /// </summary>
        /// <value>Print a merchant receipt when the refund is approved.</value>
        [DataMember(Name = "merchantRefundApproved", EmitDefaultValue = false)]
        public bool MerchantRefundApproved { get; set; }

        /// <summary>
        /// Print a merchant receipt when the refund is refused.
        /// </summary>
        /// <value>Print a merchant receipt when the refund is refused.</value>
        [DataMember(Name = "merchantRefundRefused", EmitDefaultValue = false)]
        public bool MerchantRefundRefused { get; set; }

        /// <summary>
        /// Print a merchant receipt when the payment is refused.
        /// </summary>
        /// <value>Print a merchant receipt when the payment is refused.</value>
        [DataMember(Name = "merchantRefused", EmitDefaultValue = false)]
        public bool MerchantRefused { get; set; }

        /// <summary>
        /// Print a merchant receipt when a previous transaction is voided.
        /// </summary>
        /// <value>Print a merchant receipt when a previous transaction is voided.</value>
        [DataMember(Name = "merchantVoid", EmitDefaultValue = false)]
        public bool MerchantVoid { get; set; }

        /// <summary>
        /// Print a shopper receipt when the payment is approved.
        /// </summary>
        /// <value>Print a shopper receipt when the payment is approved.</value>
        [DataMember(Name = "shopperApproved", EmitDefaultValue = false)]
        public bool ShopperApproved { get; set; }

        /// <summary>
        /// Print a shopper receipt when the transaction is cancelled.
        /// </summary>
        /// <value>Print a shopper receipt when the transaction is cancelled.</value>
        [DataMember(Name = "shopperCancelled", EmitDefaultValue = false)]
        public bool ShopperCancelled { get; set; }

        /// <summary>
        /// Print a shopper receipt when capturing the payment is approved.
        /// </summary>
        /// <value>Print a shopper receipt when capturing the payment is approved.</value>
        [DataMember(Name = "shopperCaptureApproved", EmitDefaultValue = false)]
        public bool ShopperCaptureApproved { get; set; }

        /// <summary>
        /// Print a shopper receipt when capturing the payment is refused.
        /// </summary>
        /// <value>Print a shopper receipt when capturing the payment is refused.</value>
        [DataMember(Name = "shopperCaptureRefused", EmitDefaultValue = false)]
        public bool ShopperCaptureRefused { get; set; }

        /// <summary>
        /// Print a shopper receipt when the refund is approved.
        /// </summary>
        /// <value>Print a shopper receipt when the refund is approved.</value>
        [DataMember(Name = "shopperRefundApproved", EmitDefaultValue = false)]
        public bool ShopperRefundApproved { get; set; }

        /// <summary>
        /// Print a shopper receipt when the refund is refused.
        /// </summary>
        /// <value>Print a shopper receipt when the refund is refused.</value>
        [DataMember(Name = "shopperRefundRefused", EmitDefaultValue = false)]
        public bool ShopperRefundRefused { get; set; }

        /// <summary>
        /// Print a shopper receipt when the payment is refused.
        /// </summary>
        /// <value>Print a shopper receipt when the payment is refused.</value>
        [DataMember(Name = "shopperRefused", EmitDefaultValue = false)]
        public bool ShopperRefused { get; set; }

        /// <summary>
        /// Print a shopper receipt when a previous transaction is voided.
        /// </summary>
        /// <value>Print a shopper receipt when a previous transaction is voided.</value>
        [DataMember(Name = "shopperVoid", EmitDefaultValue = false)]
        public bool ShopperVoid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReceiptPrinting {\n");
            sb.Append("  MerchantApproved: ").Append(MerchantApproved).Append("\n");
            sb.Append("  MerchantCancelled: ").Append(MerchantCancelled).Append("\n");
            sb.Append("  MerchantCaptureApproved: ").Append(MerchantCaptureApproved).Append("\n");
            sb.Append("  MerchantCaptureRefused: ").Append(MerchantCaptureRefused).Append("\n");
            sb.Append("  MerchantRefundApproved: ").Append(MerchantRefundApproved).Append("\n");
            sb.Append("  MerchantRefundRefused: ").Append(MerchantRefundRefused).Append("\n");
            sb.Append("  MerchantRefused: ").Append(MerchantRefused).Append("\n");
            sb.Append("  MerchantVoid: ").Append(MerchantVoid).Append("\n");
            sb.Append("  ShopperApproved: ").Append(ShopperApproved).Append("\n");
            sb.Append("  ShopperCancelled: ").Append(ShopperCancelled).Append("\n");
            sb.Append("  ShopperCaptureApproved: ").Append(ShopperCaptureApproved).Append("\n");
            sb.Append("  ShopperCaptureRefused: ").Append(ShopperCaptureRefused).Append("\n");
            sb.Append("  ShopperRefundApproved: ").Append(ShopperRefundApproved).Append("\n");
            sb.Append("  ShopperRefundRefused: ").Append(ShopperRefundRefused).Append("\n");
            sb.Append("  ShopperRefused: ").Append(ShopperRefused).Append("\n");
            sb.Append("  ShopperVoid: ").Append(ShopperVoid).Append("\n");
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
            return this.Equals(input as ReceiptPrinting);
        }

        /// <summary>
        /// Returns true if ReceiptPrinting instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceiptPrinting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceiptPrinting input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantApproved == input.MerchantApproved ||
                    this.MerchantApproved.Equals(input.MerchantApproved)
                ) && 
                (
                    this.MerchantCancelled == input.MerchantCancelled ||
                    this.MerchantCancelled.Equals(input.MerchantCancelled)
                ) && 
                (
                    this.MerchantCaptureApproved == input.MerchantCaptureApproved ||
                    this.MerchantCaptureApproved.Equals(input.MerchantCaptureApproved)
                ) && 
                (
                    this.MerchantCaptureRefused == input.MerchantCaptureRefused ||
                    this.MerchantCaptureRefused.Equals(input.MerchantCaptureRefused)
                ) && 
                (
                    this.MerchantRefundApproved == input.MerchantRefundApproved ||
                    this.MerchantRefundApproved.Equals(input.MerchantRefundApproved)
                ) && 
                (
                    this.MerchantRefundRefused == input.MerchantRefundRefused ||
                    this.MerchantRefundRefused.Equals(input.MerchantRefundRefused)
                ) && 
                (
                    this.MerchantRefused == input.MerchantRefused ||
                    this.MerchantRefused.Equals(input.MerchantRefused)
                ) && 
                (
                    this.MerchantVoid == input.MerchantVoid ||
                    this.MerchantVoid.Equals(input.MerchantVoid)
                ) && 
                (
                    this.ShopperApproved == input.ShopperApproved ||
                    this.ShopperApproved.Equals(input.ShopperApproved)
                ) && 
                (
                    this.ShopperCancelled == input.ShopperCancelled ||
                    this.ShopperCancelled.Equals(input.ShopperCancelled)
                ) && 
                (
                    this.ShopperCaptureApproved == input.ShopperCaptureApproved ||
                    this.ShopperCaptureApproved.Equals(input.ShopperCaptureApproved)
                ) && 
                (
                    this.ShopperCaptureRefused == input.ShopperCaptureRefused ||
                    this.ShopperCaptureRefused.Equals(input.ShopperCaptureRefused)
                ) && 
                (
                    this.ShopperRefundApproved == input.ShopperRefundApproved ||
                    this.ShopperRefundApproved.Equals(input.ShopperRefundApproved)
                ) && 
                (
                    this.ShopperRefundRefused == input.ShopperRefundRefused ||
                    this.ShopperRefundRefused.Equals(input.ShopperRefundRefused)
                ) && 
                (
                    this.ShopperRefused == input.ShopperRefused ||
                    this.ShopperRefused.Equals(input.ShopperRefused)
                ) && 
                (
                    this.ShopperVoid == input.ShopperVoid ||
                    this.ShopperVoid.Equals(input.ShopperVoid)
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
                hashCode = (hashCode * 59) + this.MerchantApproved.GetHashCode();
                hashCode = (hashCode * 59) + this.MerchantCancelled.GetHashCode();
                hashCode = (hashCode * 59) + this.MerchantCaptureApproved.GetHashCode();
                hashCode = (hashCode * 59) + this.MerchantCaptureRefused.GetHashCode();
                hashCode = (hashCode * 59) + this.MerchantRefundApproved.GetHashCode();
                hashCode = (hashCode * 59) + this.MerchantRefundRefused.GetHashCode();
                hashCode = (hashCode * 59) + this.MerchantRefused.GetHashCode();
                hashCode = (hashCode * 59) + this.MerchantVoid.GetHashCode();
                hashCode = (hashCode * 59) + this.ShopperApproved.GetHashCode();
                hashCode = (hashCode * 59) + this.ShopperCancelled.GetHashCode();
                hashCode = (hashCode * 59) + this.ShopperCaptureApproved.GetHashCode();
                hashCode = (hashCode * 59) + this.ShopperCaptureRefused.GetHashCode();
                hashCode = (hashCode * 59) + this.ShopperRefundApproved.GetHashCode();
                hashCode = (hashCode * 59) + this.ShopperRefundRefused.GetHashCode();
                hashCode = (hashCode * 59) + this.ShopperRefused.GetHashCode();
                hashCode = (hashCode * 59) + this.ShopperVoid.GetHashCode();
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