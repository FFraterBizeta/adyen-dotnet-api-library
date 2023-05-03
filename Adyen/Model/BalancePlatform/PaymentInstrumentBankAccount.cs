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
using System.Reflection;

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// Contains the business account details. Returned when you create a payment instrument with &#x60;type&#x60; **bankAccount**.
    /// </summary>
    [JsonConverter(typeof(PaymentInstrumentBankAccountJsonConverter))]
    [DataContract(Name = "PaymentInstrument_bankAccount")]
    public partial class PaymentInstrumentBankAccount : AbstractOpenAPISchema, IEquatable<PaymentInstrumentBankAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInstrumentBankAccount" /> class
        /// with the <see cref="IbanAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IbanAccountIdentification.</param>
        public PaymentInstrumentBankAccount(IbanAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInstrumentBankAccount" /> class
        /// with the <see cref="USLocalAccountIdentification" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of USLocalAccountIdentification.</param>
        public PaymentInstrumentBankAccount(USLocalAccountIdentification actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(IbanAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(USLocalAccountIdentification))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: IbanAccountIdentification, USLocalAccountIdentification");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `IbanAccountIdentification`. If the actual instance is not `IbanAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IbanAccountIdentification</returns>
        public IbanAccountIdentification GetIbanAccountIdentification()
        {
            return (IbanAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `USLocalAccountIdentification`. If the actual instance is not `USLocalAccountIdentification`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of USLocalAccountIdentification</returns>
        public USLocalAccountIdentification GetUSLocalAccountIdentification()
        {
            return (USLocalAccountIdentification)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentInstrumentBankAccount {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, PaymentInstrumentBankAccount.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PaymentInstrumentBankAccount
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PaymentInstrumentBankAccount</returns>
        public static PaymentInstrumentBankAccount FromJson(string jsonString)
        {
            PaymentInstrumentBankAccount newPaymentInstrumentBankAccount = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPaymentInstrumentBankAccount;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(IbanAccountIdentification).GetProperty("AdditionalProperties") == null)
                {
                    newPaymentInstrumentBankAccount = new PaymentInstrumentBankAccount(JsonConvert.DeserializeObject<IbanAccountIdentification>(jsonString, PaymentInstrumentBankAccount.SerializerSettings));
                }
                else
                {
                    newPaymentInstrumentBankAccount = new PaymentInstrumentBankAccount(JsonConvert.DeserializeObject<IbanAccountIdentification>(jsonString, PaymentInstrumentBankAccount.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("IbanAccountIdentification");
                match++;
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(USLocalAccountIdentification).GetProperty("AdditionalProperties") == null)
                {
                    newPaymentInstrumentBankAccount = new PaymentInstrumentBankAccount(JsonConvert.DeserializeObject<USLocalAccountIdentification>(jsonString, PaymentInstrumentBankAccount.SerializerSettings));
                }
                else
                {
                    newPaymentInstrumentBankAccount = new PaymentInstrumentBankAccount(JsonConvert.DeserializeObject<USLocalAccountIdentification>(jsonString, PaymentInstrumentBankAccount.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("USLocalAccountIdentification");
                match++;
            }
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                    throw new Exception(string.Format("Failed to deserialize `{0}` into CheckoutThreeDS2Action: {1}", jsonString, ex.ToString()));
                }
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newPaymentInstrumentBankAccount;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentInstrumentBankAccount);
        }

        /// <summary>
        /// Returns true if PaymentInstrumentBankAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInstrumentBankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInstrumentBankAccount input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for PaymentInstrumentBankAccount
    /// </summary>
    public class PaymentInstrumentBankAccountJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PaymentInstrumentBankAccount).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return PaymentInstrumentBankAccount.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
