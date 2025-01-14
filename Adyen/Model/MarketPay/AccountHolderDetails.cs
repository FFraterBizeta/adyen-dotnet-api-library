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
    /// AccountHolderDetails
    /// </summary>
    [DataContract]
        public class AccountHolderDetails :  IEquatable<AccountHolderDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountHolderDetails" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="bankAccountDetails">Each of the bank accounts associated with the account holder. &gt; Each array entry should represent one bank account. &gt; For comprehensive detail regarding the required &#x60;BankAccountDetail&#x60; fields, please refer to the [KYC Verification documentation](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks)..</param>
        /// <param name="businessDetails">businessDetails.</param>
        /// <param name="email">The email address of the account holder. (required).</param>
        /// <param name="fullPhoneNumber">The phone number of the account holder provided as a single string. It will be handled as a landline phone. **Examples:** \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot; (required).</param>
        /// <param name="individualDetails">individualDetails.</param>
        /// <param name="merchantCategoryCode">The Merchant Category Code of the account holder. &gt; If not specified in the request, this will be derived from the platform account (which is configured by Adyen)..</param>
        /// <param name="metadata">A set of key and value pairs for general use by the account holder or merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; The values being stored have a maximum length of eighty (80) characters and will be truncated if necessary. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs..</param>
        /// <param name="payoutMethods">Each of the card tokens associated with the account holder. &gt; Each array entry should represent one card token. &gt; For comprehensive detail regarding the required &#x60;CardToken&#x60; fields, please refer to the [KYC Verification documentation](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks)..</param>
        /// <param name="webAddress">The URL of the website of the account holder. (required).</param>
        public AccountHolderDetails(ViasAddress address = default(ViasAddress), List<BankAccountDetail> bankAccountDetails = default(List<BankAccountDetail>), BusinessDetails businessDetails = default(BusinessDetails), string email = default(string), string fullPhoneNumber = default(string), IndividualDetails individualDetails = default(IndividualDetails), string merchantCategoryCode = default(string), Object metadata = default(Object), List<PayoutMethod> payoutMethods = default(List<PayoutMethod>), string webAddress = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for AccountHolderDetails and cannot be null");
            }

            Email = email;
            WebAddress = webAddress;
            FullPhoneNumber = fullPhoneNumber;
            Address = address;
            BankAccountDetails = bankAccountDetails;
            BusinessDetails = businessDetails;
            IndividualDetails = individualDetails;
            MerchantCategoryCode = merchantCategoryCode;
            Metadata = metadata;
            PayoutMethods = payoutMethods;
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public ViasAddress Address { get; set; }

        /// <summary>
        /// Each of the bank accounts associated with the account holder. &gt; Each array entry should represent one bank account. &gt; For comprehensive detail regarding the required &#x60;BankAccountDetail&#x60; fields, please refer to the [KYC Verification documentation](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks).
        /// </summary>
        /// <value>Each of the bank accounts associated with the account holder. &gt; Each array entry should represent one bank account. &gt; For comprehensive detail regarding the required &#x60;BankAccountDetail&#x60; fields, please refer to the [KYC Verification documentation](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks).</value>
        [DataMember(Name="bankAccountDetails", EmitDefaultValue=false)]
        public List<BankAccountDetail> BankAccountDetails { get; set; }

        /// <summary>
        /// Gets or Sets BusinessDetails
        /// </summary>
        [DataMember(Name="businessDetails", EmitDefaultValue=false)]
        public BusinessDetails BusinessDetails { get; set; }

        /// <summary>
        /// The email address of the account holder.
        /// </summary>
        /// <value>The email address of the account holder.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the account holder provided as a single string. It will be handled as a landline phone. **Examples:** \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;
        /// </summary>
        /// <value>The phone number of the account holder provided as a single string. It will be handled as a landline phone. **Examples:** \&quot;0031 6 11 22 33 44\&quot;, \&quot;+316/1122-3344\&quot;, \&quot;(0031) 611223344\&quot;</value>
        [DataMember(Name="fullPhoneNumber", EmitDefaultValue=false)]
        public string FullPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets IndividualDetails
        /// </summary>
        [DataMember(Name="individualDetails", EmitDefaultValue=false)]
        public IndividualDetails IndividualDetails { get; set; }

        /// <summary>
        /// The Merchant Category Code of the account holder. &gt; If not specified in the request, this will be derived from the platform account (which is configured by Adyen).
        /// </summary>
        /// <value>The Merchant Category Code of the account holder. &gt; If not specified in the request, this will be derived from the platform account (which is configured by Adyen).</value>
        [DataMember(Name="merchantCategoryCode", EmitDefaultValue=false)]
        public string MerchantCategoryCode { get; set; }

        /// <summary>
        /// A set of key and value pairs for general use by the account holder or merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; The values being stored have a maximum length of eighty (80) characters and will be truncated if necessary. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.
        /// </summary>
        /// <value>A set of key and value pairs for general use by the account holder or merchant. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; The values being stored have a maximum length of eighty (80) characters and will be truncated if necessary. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Each of the card tokens associated with the account holder. &gt; Each array entry should represent one card token. &gt; For comprehensive detail regarding the required &#x60;CardToken&#x60; fields, please refer to the [KYC Verification documentation](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks).
        /// </summary>
        /// <value>Each of the card tokens associated with the account holder. &gt; Each array entry should represent one card token. &gt; For comprehensive detail regarding the required &#x60;CardToken&#x60; fields, please refer to the [KYC Verification documentation](https://docs.adyen.com/marketpay/onboarding-and-verification/verification-checks).</value>
        [DataMember(Name="payoutMethods", EmitDefaultValue=false)]
        public List<PayoutMethod> PayoutMethods { get; set; }

        /// <summary>
        /// The URL of the website of the account holder.
        /// </summary>
        /// <value>The URL of the website of the account holder.</value>
        [DataMember(Name="webAddress", EmitDefaultValue=false)]
        public string WebAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountHolderDetails {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BankAccountDetails: ").Append(BankAccountDetails).Append("\n");
            sb.Append("  BusinessDetails: ").Append(BusinessDetails).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FullPhoneNumber: ").Append(FullPhoneNumber).Append("\n");
            sb.Append("  IndividualDetails: ").Append(IndividualDetails).Append("\n");
            sb.Append("  MerchantCategoryCode: ").Append(MerchantCategoryCode).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PayoutMethods: ").Append(PayoutMethods).Append("\n");
            sb.Append("  WebAddress: ").Append(WebAddress).Append("\n");
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
            return Equals(input as AccountHolderDetails);
        }

        /// <summary>
        /// Returns true if AccountHolderDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountHolderDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountHolderDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    Address == input.Address ||
                    (Address != null &&
                    Address.Equals(input.Address))
                ) && 
                (
                    BankAccountDetails == input.BankAccountDetails ||
                    BankAccountDetails != null &&
                    input.BankAccountDetails != null &&
                    BankAccountDetails.SequenceEqual(input.BankAccountDetails)
                ) && 
                (
                    BusinessDetails == input.BusinessDetails ||
                    (BusinessDetails != null &&
                    BusinessDetails.Equals(input.BusinessDetails))
                ) && 
                (
                    Email == input.Email ||
                    (Email != null &&
                    Email.Equals(input.Email))
                ) && 
                (
                    FullPhoneNumber == input.FullPhoneNumber ||
                    (FullPhoneNumber != null &&
                    FullPhoneNumber.Equals(input.FullPhoneNumber))
                ) && 
                (
                    IndividualDetails == input.IndividualDetails ||
                    (IndividualDetails != null &&
                    IndividualDetails.Equals(input.IndividualDetails))
                ) && 
                (
                    MerchantCategoryCode == input.MerchantCategoryCode ||
                    (MerchantCategoryCode != null &&
                    MerchantCategoryCode.Equals(input.MerchantCategoryCode))
                ) && 
                (
                    Metadata == input.Metadata ||
                    (Metadata != null &&
                    Metadata.Equals(input.Metadata))
                ) && 
                (
                    PayoutMethods == input.PayoutMethods ||
                    PayoutMethods != null &&
                    input.PayoutMethods != null &&
                    PayoutMethods.SequenceEqual(input.PayoutMethods)
                ) && 
                (
                    WebAddress == input.WebAddress ||
                    (WebAddress != null &&
                    WebAddress.Equals(input.WebAddress))
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
                if (Address != null)
                    hashCode = hashCode * 59 + Address.GetHashCode();
                if (BankAccountDetails != null)
                    hashCode = hashCode * 59 + BankAccountDetails.GetHashCode();
                if (BusinessDetails != null)
                    hashCode = hashCode * 59 + BusinessDetails.GetHashCode();
                if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                if (FullPhoneNumber != null)
                    hashCode = hashCode * 59 + FullPhoneNumber.GetHashCode();
                if (IndividualDetails != null)
                    hashCode = hashCode * 59 + IndividualDetails.GetHashCode();
                if (MerchantCategoryCode != null)
                    hashCode = hashCode * 59 + MerchantCategoryCode.GetHashCode();
                if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                if (PayoutMethods != null)
                    hashCode = hashCode * 59 + PayoutMethods.GetHashCode();
                if (WebAddress != null)
                    hashCode = hashCode * 59 + WebAddress.GetHashCode();
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
