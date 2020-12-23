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
    /// LianLianPayDetails
    /// </summary>
    [DataContract]
    public partial class LianLianPayDetails : IEquatable<LianLianPayDetails>, IValidatableObject
    {
        /// <summary>
        /// **lianlianpay**
        /// </summary>
        /// <value>**lianlianpay**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Enterprise for value: lianlianpay_ebanking_enterprise
            /// </summary>
            [EnumMember(Value = "lianlianpay_ebanking_enterprise")] Enterprise = 1,

            /// <summary>
            /// Enum Credit for value: lianlianpay_ebanking_credit
            /// </summary>
            [EnumMember(Value = "lianlianpay_ebanking_credit")] Credit = 2,

            /// <summary>
            /// Enum Debit for value: lianlianpay_ebanking_debit
            /// </summary>
            [EnumMember(Value = "lianlianpay_ebanking_debit")] Debit = 3
        }

        /// <summary>
        /// **lianlianpay**
        /// </summary>
        /// <value>**lianlianpay**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LianLianPayDetails" /> class.
        /// </summary>
        /// <param name="telephoneNumber">telephoneNumber (required).</param>
        /// <param name="type">**lianlianpay** (required).</param>
        public LianLianPayDetails(string telephoneNumber = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "telephoneNumber" is required (not null)
            if (telephoneNumber == null)
            {
                throw new InvalidDataException(
                    "telephoneNumber is a required property for LianLianPayDetails and cannot be null");
            }
            else
            {
                this.TelephoneNumber = telephoneNumber;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for LianLianPayDetails and cannot be null");
            }
            else
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// Gets or Sets TelephoneNumber
        /// </summary>
        [DataMember(Name = "telephoneNumber", EmitDefaultValue = false)]
        public string TelephoneNumber { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LianLianPayDetails {\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
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
            return this.Equals(input as LianLianPayDetails);
        }

        /// <summary>
        /// Returns true if LianLianPayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of LianLianPayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LianLianPayDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.TelephoneNumber == input.TelephoneNumber ||
                    this.TelephoneNumber != null &&
                    this.TelephoneNumber.Equals(input.TelephoneNumber)
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
                if (this.TelephoneNumber != null)
                    hashCode = hashCode * 59 + this.TelephoneNumber.GetHashCode();
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