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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class StyleGuide : IEquatable<StyleGuide>
    { 
        /// <summary>
        /// Gets or Sets Content
        /// </summary>

        [DataMember(Name="content")]
        public byte[] Content { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>

        [DataMember(Name="modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Gets or Sets IsInUse
        /// </summary>

        [DataMember(Name="isInUse")]
        public bool? IsInUse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StyleGuide {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  IsInUse: ").Append(IsInUse).Append("\n");
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
            return obj.GetType() == GetType() && Equals((StyleGuide)obj);
        }

        /// <summary>
        /// Returns true if StyleGuide instances are equal
        /// </summary>
        /// <param name="other">Instance of StyleGuide to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StyleGuide other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Content == other.Content ||
                    Content != null &&
                    Content.Equals(other.Content)
                ) && 
                (
                    Modified == other.Modified ||
                    Modified != null &&
                    Modified.Equals(other.Modified)
                ) && 
                (
                    IsInUse == other.IsInUse ||
                    IsInUse != null &&
                    IsInUse.Equals(other.IsInUse)
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
                    if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                    if (Modified != null)
                    hashCode = hashCode * 59 + Modified.GetHashCode();
                    if (IsInUse != null)
                    hashCode = hashCode * 59 + IsInUse.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(StyleGuide left, StyleGuide right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StyleGuide left, StyleGuide right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}