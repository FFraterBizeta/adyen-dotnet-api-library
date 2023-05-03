/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// CapitalBalance
    /// </summary>
    [DataContract(Name = "CapitalBalance")]
    public partial class CapitalBalance : IEquatable<CapitalBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CapitalBalance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapitalBalance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapitalBalance" /> class.
        /// </summary>
        /// <param name="currency">The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes). (required).</param>
        /// <param name="fee">Fee amount. (required).</param>
        /// <param name="principal">Principal amount. (required).</param>
        /// <param name="total">Total amount. A sum of principal amount and fee amount. (required).</param>
        public CapitalBalance(string currency = default(string), long? fee = default(long?), long? principal = default(long?), long? total = default(long?))
        {
            this.Currency = currency;
            this.Fee = fee;
            this.Principal = principal;
            this.Total = total;
        }

        /// <summary>
        /// The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        /// <value>The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes).</value>
        [DataMember(Name = "currency", IsRequired = false, EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Fee amount.
        /// </summary>
        /// <value>Fee amount.</value>
        [DataMember(Name = "fee", IsRequired = false, EmitDefaultValue = false)]
        public long? Fee { get; set; }

        /// <summary>
        /// Principal amount.
        /// </summary>
        /// <value>Principal amount.</value>
        [DataMember(Name = "principal", IsRequired = false, EmitDefaultValue = false)]
        public long? Principal { get; set; }

        /// <summary>
        /// Total amount. A sum of principal amount and fee amount.
        /// </summary>
        /// <value>Total amount. A sum of principal amount and fee amount.</value>
        [DataMember(Name = "total", IsRequired = false, EmitDefaultValue = false)]
        public long? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CapitalBalance {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Principal: ").Append(Principal).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as CapitalBalance);
        }

        /// <summary>
        /// Returns true if CapitalBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of CapitalBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapitalBalance input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Fee == input.Fee ||
                    this.Fee.Equals(input.Fee)
                ) && 
                (
                    this.Principal == input.Principal ||
                    this.Principal.Equals(input.Principal)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
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
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                hashCode = (hashCode * 59) + this.Principal.GetHashCode();
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
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
