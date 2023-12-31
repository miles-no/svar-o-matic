/*
 * Swagger - Svar-o-Matic
 *
 * This is the backend for a solution that allows employees of Miles AS to efficiently match incoming project requests with existing consultant expertise.  Some useful links: - [The Svar-o-Matic repository](https://github.com/miles-no/svar-o-matic)
 *
 * OpenAPI spec version: 1.0.11
 * Contact: drift@miles.no
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SvarOMatic.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Svar : IEquatable<Svar>
    { 
        /// <summary>
        /// Gets or Sets KravId
        /// </summary>

        [DataMember(Name="kravId")]
        public long? KravId { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>

        [DataMember(Name="text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets GeneratedOn
        /// </summary>

        [DataMember(Name="generatedOn")]
        public DateTime? GeneratedOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Svar {\n");
            sb.Append("  KravId: ").Append(KravId).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  GeneratedOn: ").Append(GeneratedOn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Svar)obj);
        }

        /// <summary>
        /// Returns true if Svar instances are equal
        /// </summary>
        /// <param name="other">Instance of Svar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Svar other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    KravId == other.KravId ||
                    KravId != null &&
                    KravId.Equals(other.KravId)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    GeneratedOn == other.GeneratedOn ||
                    GeneratedOn != null &&
                    GeneratedOn.Equals(other.GeneratedOn)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (KravId != null)
                    hashCode = hashCode * 59 + KravId.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                    if (GeneratedOn != null)
                    hashCode = hashCode * 59 + GeneratedOn.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Svar left, Svar right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Svar left, Svar right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
