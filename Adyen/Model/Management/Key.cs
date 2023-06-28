/*
* Management API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// Key
    /// </summary>
    [DataContract(Name = "Key")]
    public partial class Key : IEquatable<Key>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Key" /> class.
        /// </summary>
        /// <param name="identifier">The unique identifier of the shared key..</param>
        /// <param name="passphrase">The secure passphrase to protect the shared key..</param>
        /// <param name="version">The version number of the shared key..</param>
        public Key(string identifier = default(string), string passphrase = default(string), int? version = default(int?))
        {
            this.Identifier = identifier;
            this.Passphrase = passphrase;
            this.Version = version;
        }

        /// <summary>
        /// The unique identifier of the shared key.
        /// </summary>
        /// <value>The unique identifier of the shared key.</value>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// The secure passphrase to protect the shared key.
        /// </summary>
        /// <value>The secure passphrase to protect the shared key.</value>
        [DataMember(Name = "passphrase", EmitDefaultValue = false)]
        public string Passphrase { get; set; }

        /// <summary>
        /// The version number of the shared key.
        /// </summary>
        /// <value>The version number of the shared key.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Key {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Passphrase: ").Append(Passphrase).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as Key);
        }

        /// <summary>
        /// Returns true if Key instances are equal
        /// </summary>
        /// <param name="input">Instance of Key to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Key input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Passphrase == input.Passphrase ||
                    (this.Passphrase != null &&
                    this.Passphrase.Equals(input.Passphrase))
                ) && 
                (
                    this.Version == input.Version ||
                    this.Version.Equals(input.Version)
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
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                if (this.Passphrase != null)
                {
                    hashCode = (hashCode * 59) + this.Passphrase.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Version.GetHashCode();
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