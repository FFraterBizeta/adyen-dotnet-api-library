using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// CloseAccountHolderRequest
    /// </summary>
    [DataContract]
        public class CloseAccountHolderRequest :  IEquatable<CloseAccountHolderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloseAccountHolderRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of the Account Holder to be closed. (required).</param>
        public CloseAccountHolderRequest(string accountHolderCode = default(string))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for CloseAccountHolderRequest and cannot be null");
            }

            AccountHolderCode = accountHolderCode;
        }
        
        /// <summary>
        /// The code of the Account Holder to be closed.
        /// </summary>
        /// <value>The code of the Account Holder to be closed.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloseAccountHolderRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
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
            return Equals(input as CloseAccountHolderRequest);
        }

        /// <summary>
        /// Returns true if CloseAccountHolderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CloseAccountHolderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloseAccountHolderRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    AccountHolderCode == input.AccountHolderCode ||
                    (AccountHolderCode != null &&
                    AccountHolderCode.Equals(input.AccountHolderCode))
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
                if (AccountHolderCode != null)
                    hashCode = hashCode * 59 + AccountHolderCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
