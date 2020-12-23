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
    /// BacsDirectDebitDetails
    /// </summary>
    [DataContract]
    public partial class BacsDirectDebitDetails : IEquatable<BacsDirectDebitDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BacsDirectDebitDetails" /> class.
        /// </summary>
        /// <param name="bankAccountNumber">The bank account number (without separators). (required).</param>
        /// <param name="bankLocationId">The bank routing number of the account. (required).</param>
        /// <param name="holderName">The name of the bank account holder. (required).</param>
        /// <param name="type">**directdebit_GB** (default to &quot;directdebit_GB&quot;).</param>
        public BacsDirectDebitDetails(string bankAccountNumber = default(string),
            string bankLocationId = default(string), string holderName = default(string),
            string type = "directdebit_GB")
        {
            // to ensure "bankAccountNumber" is required (not null)
            if (bankAccountNumber == null)
            {
                throw new InvalidDataException(
                    "bankAccountNumber is a required property for BacsDirectDebitDetails and cannot be null");
            }
            else
            {
                this.BankAccountNumber = bankAccountNumber;
            }
            // to ensure "bankLocationId" is required (not null)
            if (bankLocationId == null)
            {
                throw new InvalidDataException(
                    "bankLocationId is a required property for BacsDirectDebitDetails and cannot be null");
            }
            else
            {
                this.BankLocationId = bankLocationId;
            }
            // to ensure "holderName" is required (not null)
            if (holderName == null)
            {
                throw new InvalidDataException(
                    "holderName is a required property for BacsDirectDebitDetails and cannot be null");
            }
            else
            {
                this.HolderName = holderName;
            }
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "directdebit_GB";
            }
            else
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// The bank account number (without separators).
        /// </summary>
        /// <value>The bank account number (without separators).</value>
        [DataMember(Name = "bankAccountNumber", EmitDefaultValue = false)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The bank routing number of the account.
        /// </summary>
        /// <value>The bank routing number of the account.</value>
        [DataMember(Name = "bankLocationId", EmitDefaultValue = false)]
        public string BankLocationId { get; set; }

        /// <summary>
        /// The name of the bank account holder.
        /// </summary>
        /// <value>The name of the bank account holder.</value>
        [DataMember(Name = "holderName", EmitDefaultValue = false)]
        public string HolderName { get; set; }

        /// <summary>
        /// **directdebit_GB**
        /// </summary>
        /// <value>**directdebit_GB**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BacsDirectDebitDetails {\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("  BankLocationId: ").Append(BankLocationId).Append("\n");
            sb.Append("  HolderName: ").Append(HolderName).Append("\n");
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
            return this.Equals(input as BacsDirectDebitDetails);
        }

        /// <summary>
        /// Returns true if BacsDirectDebitDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of BacsDirectDebitDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BacsDirectDebitDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BankAccountNumber == input.BankAccountNumber ||
                    this.BankAccountNumber != null &&
                    this.BankAccountNumber.Equals(input.BankAccountNumber)
                ) &&
                (
                    this.BankLocationId == input.BankLocationId ||
                    this.BankLocationId != null &&
                    this.BankLocationId.Equals(input.BankLocationId)
                ) &&
                (
                    this.HolderName == input.HolderName ||
                    this.HolderName != null &&
                    this.HolderName.Equals(input.HolderName)
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
                if (this.BankAccountNumber != null)
                    hashCode = hashCode * 59 + this.BankAccountNumber.GetHashCode();
                if (this.BankLocationId != null)
                    hashCode = hashCode * 59 + this.BankLocationId.GetHashCode();
                if (this.HolderName != null)
                    hashCode = hashCode * 59 + this.HolderName.GetHashCode();
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