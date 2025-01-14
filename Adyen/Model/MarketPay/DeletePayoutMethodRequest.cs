using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// DeletePayoutMethodRequest
    /// </summary>
    [DataContract]
        public class DeletePayoutMethodRequest :  IEquatable<DeletePayoutMethodRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeletePayoutMethodRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of the account holder, from which to delete the payout methods. (required).</param>
        /// <param name="payoutMethodCodes">The codes of the payout methods to be deleted. (required).</param>
        public DeletePayoutMethodRequest(string accountHolderCode = default(string), List<string> payoutMethodCodes = default(List<string>))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for DeletePayoutMethodRequest and cannot be null");
            }

            AccountHolderCode = accountHolderCode;
            // to ensure "payoutMethodCodes" is required (not null)
            if (payoutMethodCodes == null)
            {
                throw new InvalidDataException("payoutMethodCodes is a required property for DeletePayoutMethodRequest and cannot be null");
            }

            PayoutMethodCodes = payoutMethodCodes;
        }
        
        /// <summary>
        /// The code of the account holder, from which to delete the payout methods.
        /// </summary>
        /// <value>The code of the account holder, from which to delete the payout methods.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// The codes of the payout methods to be deleted.
        /// </summary>
        /// <value>The codes of the payout methods to be deleted.</value>
        [DataMember(Name="payoutMethodCodes", EmitDefaultValue=false)]
        public List<string> PayoutMethodCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletePayoutMethodRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  PayoutMethodCodes: ").Append(PayoutMethodCodes).Append("\n");
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
            return Equals(input as DeletePayoutMethodRequest);
        }

        /// <summary>
        /// Returns true if DeletePayoutMethodRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeletePayoutMethodRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeletePayoutMethodRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    AccountHolderCode == input.AccountHolderCode ||
                    (AccountHolderCode != null &&
                    AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    PayoutMethodCodes == input.PayoutMethodCodes ||
                    PayoutMethodCodes != null &&
                    input.PayoutMethodCodes != null &&
                    PayoutMethodCodes.SequenceEqual(input.PayoutMethodCodes)
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
                if (PayoutMethodCodes != null)
                    hashCode = hashCode * 59 + PayoutMethodCodes.GetHashCode();
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
