/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ThreeDSRequestData
    /// </summary>
    [DataContract(Name = "ThreeDSRequestData")]
    public partial class ThreeDSRequestData : IEquatable<ThreeDSRequestData>, IValidatableObject
    {
        /// <summary>
        /// Dimensions of the 3DS2 challenge window to be displayed to the cardholder.  Possible values:  * **01** - size of 250x400  * **02** - size of 390x400 * **03** - size of 500x600 * **04** - size of 600x400 * **05** - Fullscreen
        /// </summary>
        /// <value>Dimensions of the 3DS2 challenge window to be displayed to the cardholder.  Possible values:  * **01** - size of 250x400  * **02** - size of 390x400 * **03** - size of 500x600 * **04** - size of 600x400 * **05** - Fullscreen</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChallengeWindowSizeEnum
        {
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01 = 1,

            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 2,

            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")]
            _03 = 3,

            /// <summary>
            /// Enum _04 for value: 04
            /// </summary>
            [EnumMember(Value = "04")]
            _04 = 4,

            /// <summary>
            /// Enum _05 for value: 05
            /// </summary>
            [EnumMember(Value = "05")]
            _05 = 5

        }


        /// <summary>
        /// Dimensions of the 3DS2 challenge window to be displayed to the cardholder.  Possible values:  * **01** - size of 250x400  * **02** - size of 390x400 * **03** - size of 500x600 * **04** - size of 600x400 * **05** - Fullscreen
        /// </summary>
        /// <value>Dimensions of the 3DS2 challenge window to be displayed to the cardholder.  Possible values:  * **01** - size of 250x400  * **02** - size of 390x400 * **03** - size of 500x600 * **04** - size of 600x400 * **05** - Fullscreen</value>
        [DataMember(Name = "challengeWindowSize", EmitDefaultValue = false)]
        public ChallengeWindowSizeEnum? ChallengeWindowSize { get; set; }
        /// <summary>
        /// Flag for data only flow.
        /// </summary>
        /// <value>Flag for data only flow.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataOnlyEnum
        {
            /// <summary>
            /// Enum False for value: false
            /// </summary>
            [EnumMember(Value = "false")]
            False = 1,

            /// <summary>
            /// Enum True for value: true
            /// </summary>
            [EnumMember(Value = "true")]
            True = 2

        }


        /// <summary>
        /// Flag for data only flow.
        /// </summary>
        /// <value>Flag for data only flow.</value>
        [DataMember(Name = "dataOnly", EmitDefaultValue = false)]
        public DataOnlyEnum? DataOnly { get; set; }
        /// <summary>
        /// Indicates if [native 3D Secure authentication](https://docs.adyen.com/online-payments/3d-secure/native-3ds2) should be used when available.  Possible values: * **preferred**: Use native 3D Secure authentication when available.
        /// </summary>
        /// <value>Indicates if [native 3D Secure authentication](https://docs.adyen.com/online-payments/3d-secure/native-3ds2) should be used when available.  Possible values: * **preferred**: Use native 3D Secure authentication when available.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NativeThreeDSEnum
        {
            /// <summary>
            /// Enum Preferred for value: preferred
            /// </summary>
            [EnumMember(Value = "preferred")]
            Preferred = 1

        }


        /// <summary>
        /// Indicates if [native 3D Secure authentication](https://docs.adyen.com/online-payments/3d-secure/native-3ds2) should be used when available.  Possible values: * **preferred**: Use native 3D Secure authentication when available.
        /// </summary>
        /// <value>Indicates if [native 3D Secure authentication](https://docs.adyen.com/online-payments/3d-secure/native-3ds2) should be used when available.  Possible values: * **preferred**: Use native 3D Secure authentication when available.</value>
        [DataMember(Name = "nativeThreeDS", EmitDefaultValue = false)]
        public NativeThreeDSEnum? NativeThreeDS { get; set; }
        /// <summary>
        /// The version of 3D Secure to use.  Possible values:  * **2.1.0** * **2.2.0**
        /// </summary>
        /// <value>The version of 3D Secure to use.  Possible values:  * **2.1.0** * **2.2.0**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ThreeDSVersionEnum
        {
            /// <summary>
            /// Enum _10 for value: 2.1.0
            /// </summary>
            [EnumMember(Value = "2.1.0")]
            _10 = 1,

            /// <summary>
            /// Enum _20 for value: 2.2.0
            /// </summary>
            [EnumMember(Value = "2.2.0")]
            _20 = 2

        }


        /// <summary>
        /// The version of 3D Secure to use.  Possible values:  * **2.1.0** * **2.2.0**
        /// </summary>
        /// <value>The version of 3D Secure to use.  Possible values:  * **2.1.0** * **2.2.0**</value>
        [DataMember(Name = "threeDSVersion", EmitDefaultValue = false)]
        public ThreeDSVersionEnum? ThreeDSVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSRequestData" /> class.
        /// </summary>
        /// <param name="challengeWindowSize">Dimensions of the 3DS2 challenge window to be displayed to the cardholder.  Possible values:  * **01** - size of 250x400  * **02** - size of 390x400 * **03** - size of 500x600 * **04** - size of 600x400 * **05** - Fullscreen.</param>
        /// <param name="dataOnly">Flag for data only flow..</param>
        /// <param name="nativeThreeDS">Indicates if [native 3D Secure authentication](https://docs.adyen.com/online-payments/3d-secure/native-3ds2) should be used when available.  Possible values: * **preferred**: Use native 3D Secure authentication when available..</param>
        /// <param name="threeDSVersion">The version of 3D Secure to use.  Possible values:  * **2.1.0** * **2.2.0**.</param>
        public ThreeDSRequestData(ChallengeWindowSizeEnum? challengeWindowSize = default(ChallengeWindowSizeEnum?), DataOnlyEnum? dataOnly = default(DataOnlyEnum?), NativeThreeDSEnum? nativeThreeDS = default(NativeThreeDSEnum?), ThreeDSVersionEnum? threeDSVersion = default(ThreeDSVersionEnum?))
        {
            this.ChallengeWindowSize = challengeWindowSize;
            this.DataOnly = dataOnly;
            this.NativeThreeDS = nativeThreeDS;
            this.ThreeDSVersion = threeDSVersion;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ThreeDSRequestData {\n");
            sb.Append("  ChallengeWindowSize: ").Append(ChallengeWindowSize).Append("\n");
            sb.Append("  DataOnly: ").Append(DataOnly).Append("\n");
            sb.Append("  NativeThreeDS: ").Append(NativeThreeDS).Append("\n");
            sb.Append("  ThreeDSVersion: ").Append(ThreeDSVersion).Append("\n");
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
            return this.Equals(input as ThreeDSRequestData);
        }

        /// <summary>
        /// Returns true if ThreeDSRequestData instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDSRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDSRequestData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChallengeWindowSize == input.ChallengeWindowSize ||
                    this.ChallengeWindowSize.Equals(input.ChallengeWindowSize)
                ) && 
                (
                    this.DataOnly == input.DataOnly ||
                    this.DataOnly.Equals(input.DataOnly)
                ) && 
                (
                    this.NativeThreeDS == input.NativeThreeDS ||
                    this.NativeThreeDS.Equals(input.NativeThreeDS)
                ) && 
                (
                    this.ThreeDSVersion == input.ThreeDSVersion ||
                    this.ThreeDSVersion.Equals(input.ThreeDSVersion)
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
                hashCode = (hashCode * 59) + this.ChallengeWindowSize.GetHashCode();
                hashCode = (hashCode * 59) + this.DataOnly.GetHashCode();
                hashCode = (hashCode * 59) + this.NativeThreeDS.GetHashCode();
                hashCode = (hashCode * 59) + this.ThreeDSVersion.GetHashCode();
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