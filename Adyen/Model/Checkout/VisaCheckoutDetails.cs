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
    /// VisaCheckoutDetails
    /// </summary>
    [DataContract(Name = "VisaCheckoutDetails")]
    public partial class VisaCheckoutDetails : IEquatable<VisaCheckoutDetails>, IValidatableObject
    {
        /// <summary>
        /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.
        /// </summary>
        /// <value>The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FundingSourceEnum
        {
            /// <summary>
            /// Enum Debit for value: debit
            /// </summary>
            [EnumMember(Value = "debit")]
            Debit = 1

        }


        /// <summary>
        /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.
        /// </summary>
        /// <value>The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.</value>
        [DataMember(Name = "fundingSource", EmitDefaultValue = false)]
        public FundingSourceEnum? FundingSource { get; set; }
        /// <summary>
        /// **visacheckout**
        /// </summary>
        /// <value>**visacheckout**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Visacheckout for value: visacheckout
            /// </summary>
            [EnumMember(Value = "visacheckout")]
            Visacheckout = 1

        }


        /// <summary>
        /// **visacheckout**
        /// </summary>
        /// <value>**visacheckout**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VisaCheckoutDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VisaCheckoutDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VisaCheckoutDetails" /> class.
        /// </summary>
        /// <param name="fundingSource">The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**..</param>
        /// <param name="type">**visacheckout** (default to TypeEnum.Visacheckout).</param>
        /// <param name="visaCheckoutCallId">The Visa Click to Pay Call ID value. When your shopper selects a payment and/or a shipping address from Visa Click to Pay, you will receive a Visa Click to Pay Call ID. (required).</param>
        public VisaCheckoutDetails(FundingSourceEnum? fundingSource = default(FundingSourceEnum?), TypeEnum? type = TypeEnum.Visacheckout, string visaCheckoutCallId = default(string))
        {
            this.VisaCheckoutCallId = visaCheckoutCallId;
            this.FundingSource = fundingSource;
            this.Type = type;
        }

        /// <summary>
        /// The Visa Click to Pay Call ID value. When your shopper selects a payment and/or a shipping address from Visa Click to Pay, you will receive a Visa Click to Pay Call ID.
        /// </summary>
        /// <value>The Visa Click to Pay Call ID value. When your shopper selects a payment and/or a shipping address from Visa Click to Pay, you will receive a Visa Click to Pay Call ID.</value>
        [DataMember(Name = "visaCheckoutCallId", IsRequired = false, EmitDefaultValue = true)]
        public string VisaCheckoutCallId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VisaCheckoutDetails {\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VisaCheckoutCallId: ").Append(VisaCheckoutCallId).Append("\n");
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
            return this.Equals(input as VisaCheckoutDetails);
        }

        /// <summary>
        /// Returns true if VisaCheckoutDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of VisaCheckoutDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VisaCheckoutDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FundingSource == input.FundingSource ||
                    this.FundingSource.Equals(input.FundingSource)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.VisaCheckoutCallId == input.VisaCheckoutCallId ||
                    (this.VisaCheckoutCallId != null &&
                    this.VisaCheckoutCallId.Equals(input.VisaCheckoutCallId))
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
                hashCode = (hashCode * 59) + this.FundingSource.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.VisaCheckoutCallId != null)
                {
                    hashCode = (hashCode * 59) + this.VisaCheckoutCallId.GetHashCode();
                }
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
