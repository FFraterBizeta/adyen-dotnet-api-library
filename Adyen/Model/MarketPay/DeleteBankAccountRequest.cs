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
    /// DeleteBankAccountRequest
    /// </summary>
    [DataContract]
        public class DeleteBankAccountRequest :  IEquatable<DeleteBankAccountRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBankAccountRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of the Account Holder from which to delete the Bank Account(s). (required).</param>
        /// <param name="bankAccountUUIDs">The code(s) of the Bank Accounts to be deleted. (required).</param>
        public DeleteBankAccountRequest(string accountHolderCode = default(string), List<string> bankAccountUUIDs = default(List<string>))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for DeleteBankAccountRequest and cannot be null");
            }

            AccountHolderCode = accountHolderCode;
            // to ensure "bankAccountUUIDs" is required (not null)
            if (bankAccountUUIDs == null)
            {
                throw new InvalidDataException("bankAccountUUIDs is a required property for DeleteBankAccountRequest and cannot be null");
            }

            BankAccountUUIDs = bankAccountUUIDs;
        }
        
        /// <summary>
        /// The code of the Account Holder from which to delete the Bank Account(s).
        /// </summary>
        /// <value>The code of the Account Holder from which to delete the Bank Account(s).</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// The code(s) of the Bank Accounts to be deleted.
        /// </summary>
        /// <value>The code(s) of the Bank Accounts to be deleted.</value>
        [DataMember(Name="bankAccountUUIDs", EmitDefaultValue=false)]
        public List<string> BankAccountUUIDs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteBankAccountRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  BankAccountUUIDs: ").Append(BankAccountUUIDs).Append("\n");
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
            return Equals(input as DeleteBankAccountRequest);
        }

        /// <summary>
        /// Returns true if DeleteBankAccountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteBankAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteBankAccountRequest input)
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
                    BankAccountUUIDs == input.BankAccountUUIDs ||
                    BankAccountUUIDs != null &&
                    input.BankAccountUUIDs != null &&
                    BankAccountUUIDs.SequenceEqual(input.BankAccountUUIDs)
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
                if (BankAccountUUIDs != null)
                    hashCode = hashCode * 59 + BankAccountUUIDs.GetHashCode();
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
