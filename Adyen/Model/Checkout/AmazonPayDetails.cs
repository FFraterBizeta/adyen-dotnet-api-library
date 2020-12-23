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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// AmazonPayDetails
    /// </summary>
    [DataContract]
    public partial class AmazonPayDetails : IEquatable<AmazonPayDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonPayDetails" /> class.
        /// </summary>
        /// <param name="amazonPayToken">amazonPayToken.</param>
        /// <param name="checkoutSessionId">checkoutSessionId.</param>
        /// <param name="type">**amazonpay** (default to &quot;amazonpay&quot;).</param>
        public AmazonPayDetails(string amazonPayToken = default(string), string checkoutSessionId = default(string),
            string type = "amazonpay")
        {
            this.AmazonPayToken = amazonPayToken;
            this.CheckoutSessionId = checkoutSessionId;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "amazonpay";
            }
            else
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// Gets or Sets AmazonPayToken
        /// </summary>
        [DataMember(Name = "amazonPayToken", EmitDefaultValue = false)]
        public string AmazonPayToken { get; set; }

        /// <summary>
        /// Gets or Sets CheckoutSessionId
        /// </summary>
        [DataMember(Name = "checkoutSessionId", EmitDefaultValue = false)]
        public string CheckoutSessionId { get; set; }

        /// <summary>
        /// **amazonpay**
        /// </summary>
        /// <value>**amazonpay**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AmazonPayDetails {\n");
            sb.Append("  AmazonPayToken: ").Append(AmazonPayToken).Append("\n");
            sb.Append("  CheckoutSessionId: ").Append(CheckoutSessionId).Append("\n");
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
            return this.Equals(input as AmazonPayDetails);
        }

        /// <summary>
        /// Returns true if AmazonPayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AmazonPayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AmazonPayDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AmazonPayToken == input.AmazonPayToken ||
                    this.AmazonPayToken != null &&
                    this.AmazonPayToken.Equals(input.AmazonPayToken)
                ) &&
                (
                    this.CheckoutSessionId == input.CheckoutSessionId ||
                    this.CheckoutSessionId != null &&
                    this.CheckoutSessionId.Equals(input.CheckoutSessionId)
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
                if (this.AmazonPayToken != null)
                    hashCode = hashCode * 59 + this.AmazonPayToken.GetHashCode();
                if (this.CheckoutSessionId != null)
                    hashCode = hashCode * 59 + this.CheckoutSessionId.GetHashCode();
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