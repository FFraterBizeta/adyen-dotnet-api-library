#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// PayPalDetails
    /// </summary>
    [DataContract]
    public partial class PayPalDetails : IEquatable<PayPalDetails>, IValidatableObject
    {
        /// <summary>
        /// The type of flow to initiate.
        /// </summary>
        /// <value>The type of flow to initiate.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubtypeEnum
        {
            /// <summary>
            /// Enum Redirect for value: redirect
            /// </summary>
            [EnumMember(Value = "redirect")] Redirect = 1,

            /// <summary>
            /// Enum Sdk for value: sdk
            /// </summary>
            [EnumMember(Value = "sdk")] Sdk = 2
        }

        /// <summary>
        /// The type of flow to initiate.
        /// </summary>
        /// <value>The type of flow to initiate.</value>
        [DataMember(Name = "subtype", EmitDefaultValue = false)]
        public SubtypeEnum? Subtype { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalDetails" /> class.
        /// </summary>
        /// <param name="orderID">orderID.</param>
        /// <param name="payerID">payerID.</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="subtype">The type of flow to initiate..</param>
        /// <param name="type">**paypal** (required) (default to &quot;paypal&quot;).</param>
        public PayPalDetails(string orderID = default(string), string payerID = default(string),
            string recurringDetailReference = default(string), string storedPaymentMethodId = default(string),
            SubtypeEnum? subtype = default(SubtypeEnum?), string type = "paypal")
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for PayPalDetails and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.OrderID = orderID;
            this.PayerID = payerID;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.Subtype = subtype;
        }

        /// <summary>
        /// Gets or Sets OrderID
        /// </summary>
        [DataMember(Name = "orderID", EmitDefaultValue = false)]
        public string OrderID { get; set; }

        /// <summary>
        /// Gets or Sets PayerID
        /// </summary>
        [DataMember(Name = "payerID", EmitDefaultValue = false)]
        public string PayerID { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        public string StoredPaymentMethodId { get; set; }


        /// <summary>
        /// **paypal**
        /// </summary>
        /// <value>**paypal**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayPalDetails {\n");
            sb.Append("  OrderID: ").Append(OrderID).Append("\n");
            sb.Append("  PayerID: ").Append(PayerID).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
            sb.Append("  Subtype: ").Append(Subtype).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PayPalDetails);
        }

        /// <summary>
        /// Returns true if PayPalDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PayPalDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayPalDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.OrderID == input.OrderID ||
                    this.OrderID != null &&
                    this.OrderID.Equals(input.OrderID)
                ) &&
                (
                    this.PayerID == input.PayerID ||
                    this.PayerID != null &&
                    this.PayerID.Equals(input.PayerID)
                ) &&
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference)
                ) &&
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    this.StoredPaymentMethodId != null &&
                    this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId)
                ) &&
                (
                    this.Subtype == input.Subtype ||
                    this.Subtype != null &&
                    this.Subtype.Equals(input.Subtype)
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    this.Type.Equals(input.Type)
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
                if (this.OrderID != null)
                    hashCode = hashCode * 59 + this.OrderID.GetHashCode();
                if (this.PayerID != null)
                    hashCode = hashCode * 59 + this.PayerID.GetHashCode();
                if (this.RecurringDetailReference != null)
                    hashCode = hashCode * 59 + this.RecurringDetailReference.GetHashCode();
                if (this.StoredPaymentMethodId != null)
                    hashCode = hashCode * 59 + this.StoredPaymentMethodId.GetHashCode();
                if (this.Subtype != null)
                    hashCode = hashCode * 59 + this.Subtype.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}