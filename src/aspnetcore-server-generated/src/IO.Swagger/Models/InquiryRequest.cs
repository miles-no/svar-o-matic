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
    public partial class InquiryRequest : IEquatable<InquiryRequest>
    { 
        /// <summary>
        /// Gets or Sets Kunde
        /// </summary>

        [DataMember(Name="kunde")]
        public string Kunde { get; set; }

        /// <summary>
        /// Gets or Sets RecievedOn
        /// </summary>

        [DataMember(Name="recievedOn")]
        public DateTime? RecievedOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InquiryRequest {\n");
            sb.Append("  Kunde: ").Append(Kunde).Append("\n");
            sb.Append("  RecievedOn: ").Append(RecievedOn).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InquiryRequest)obj);
        }

        /// <summary>
        /// Returns true if InquiryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of InquiryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InquiryRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Kunde == other.Kunde ||
                    Kunde != null &&
                    Kunde.Equals(other.Kunde)
                ) && 
                (
                    RecievedOn == other.RecievedOn ||
                    RecievedOn != null &&
                    RecievedOn.Equals(other.RecievedOn)
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
                    if (Kunde != null)
                    hashCode = hashCode * 59 + Kunde.GetHashCode();
                    if (RecievedOn != null)
                    hashCode = hashCode * 59 + RecievedOn.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InquiryRequest left, InquiryRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InquiryRequest left, InquiryRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
