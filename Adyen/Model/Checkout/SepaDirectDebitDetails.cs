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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// SepaDirectDebitDetails
    /// </summary>
    [DataContract]
    public partial class SepaDirectDebitDetails : IEquatable<SepaDirectDebitDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SepaDirectDebitDetails" /> class.
        /// </summary>
        /// <param name="iban">The International Bank Account Number (IBAN). (required).</param>
        /// <param name="ownerName">The name of the bank account holder. (required).</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="type">**sepadirectdebit** (default to &quot;sepadirectdebit&quot;).</param>
        public SepaDirectDebitDetails(string iban = default(string), string ownerName = default(string),
            string recurringDetailReference = default(string), string storedPaymentMethodId = default(string),
            string type = "sepadirectdebit")
        {
            // to ensure "iban" is required (not null)
            if (iban == null)
            {
                throw new InvalidDataException(
                    "iban is a required property for SepaDirectDebitDetails and cannot be null");
            }
            else
            {
                this.Iban = iban;
            }
            // to ensure "ownerName" is required (not null)
            if (ownerName == null)
            {
                throw new InvalidDataException(
                    "ownerName is a required property for SepaDirectDebitDetails and cannot be null");
            }
            else
            {
                this.OwnerName = ownerName;
            }
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "sepadirectdebit";
            }
            else
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// The International Bank Account Number (IBAN).
        /// </summary>
        /// <value>The International Bank Account Number (IBAN).</value>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        public string Iban { get; set; }

        /// <summary>
        /// The name of the bank account holder.
        /// </summary>
        /// <value>The name of the bank account holder.</value>
        [DataMember(Name = "ownerName", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

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
        /// **sepadirectdebit**
        /// </summary>
        /// <value>**sepadirectdebit**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SepaDirectDebitDetails {\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
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
            return this.Equals(input as SepaDirectDebitDetails);
        }

        /// <summary>
        /// Returns true if SepaDirectDebitDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SepaDirectDebitDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SepaDirectDebitDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Iban == input.Iban ||
                    this.Iban != null &&
                    this.Iban.Equals(input.Iban)
                ) &&
                (
                    this.OwnerName == input.OwnerName ||
                    this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName)
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
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.RecurringDetailReference != null)
                    hashCode = hashCode * 59 + this.RecurringDetailReference.GetHashCode();
                if (this.StoredPaymentMethodId != null)
                    hashCode = hashCode * 59 + this.StoredPaymentMethodId.GetHashCode();
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