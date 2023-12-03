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
    public partial class PreviousResponse : IEquatable<PreviousResponse>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>

        [DataMember(Name="content")]
        public byte[] Content { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>

        [DataMember(Name="owner")]
        public long? Owner { get; set; }

        /// <summary>
        /// Gets or Sets OriginalSubmitter
        /// </summary>

        [DataMember(Name="originalSubmitter")]
        public long? OriginalSubmitter { get; set; }

        /// <summary>
        /// Gets or Sets SubmittedOn
        /// </summary>

        [DataMember(Name="submittedOn")]
        public DateTime? SubmittedOn { get; set; }

        /// <summary>
        /// Gets or Sets SubmittedToKunde
        /// </summary>

        [DataMember(Name="submittedToKunde")]
        public string SubmittedToKunde { get; set; }

        /// <summary>
        /// Gets or Sets LedToInterview
        /// </summary>

        [DataMember(Name="ledToInterview")]
        public bool? LedToInterview { get; set; }

        /// <summary>
        /// Gets or Sets LedToOppdrag
        /// </summary>

        [DataMember(Name="ledToOppdrag")]
        public bool? LedToOppdrag { get; set; }

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
            sb.Append("class PreviousResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  OriginalSubmitter: ").Append(OriginalSubmitter).Append("\n");
            sb.Append("  SubmittedOn: ").Append(SubmittedOn).Append("\n");
            sb.Append("  SubmittedToKunde: ").Append(SubmittedToKunde).Append("\n");
            sb.Append("  LedToInterview: ").Append(LedToInterview).Append("\n");
            sb.Append("  LedToOppdrag: ").Append(LedToOppdrag).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PreviousResponse)obj);
        }

        /// <summary>
        /// Returns true if PreviousResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PreviousResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreviousResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Content == other.Content ||
                    Content != null &&
                    Content.Equals(other.Content)
                ) && 
                (
                    Owner == other.Owner ||
                    Owner != null &&
                    Owner.Equals(other.Owner)
                ) && 
                (
                    OriginalSubmitter == other.OriginalSubmitter ||
                    OriginalSubmitter != null &&
                    OriginalSubmitter.Equals(other.OriginalSubmitter)
                ) && 
                (
                    SubmittedOn == other.SubmittedOn ||
                    SubmittedOn != null &&
                    SubmittedOn.Equals(other.SubmittedOn)
                ) && 
                (
                    SubmittedToKunde == other.SubmittedToKunde ||
                    SubmittedToKunde != null &&
                    SubmittedToKunde.Equals(other.SubmittedToKunde)
                ) && 
                (
                    LedToInterview == other.LedToInterview ||
                    LedToInterview != null &&
                    LedToInterview.Equals(other.LedToInterview)
                ) && 
                (
                    LedToOppdrag == other.LedToOppdrag ||
                    LedToOppdrag != null &&
                    LedToOppdrag.Equals(other.LedToOppdrag)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                    if (Owner != null)
                    hashCode = hashCode * 59 + Owner.GetHashCode();
                    if (OriginalSubmitter != null)
                    hashCode = hashCode * 59 + OriginalSubmitter.GetHashCode();
                    if (SubmittedOn != null)
                    hashCode = hashCode * 59 + SubmittedOn.GetHashCode();
                    if (SubmittedToKunde != null)
                    hashCode = hashCode * 59 + SubmittedToKunde.GetHashCode();
                    if (LedToInterview != null)
                    hashCode = hashCode * 59 + LedToInterview.GetHashCode();
                    if (LedToOppdrag != null)
                    hashCode = hashCode * 59 + LedToOppdrag.GetHashCode();
                    if (IsInUse != null)
                    hashCode = hashCode * 59 + IsInUse.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PreviousResponse left, PreviousResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PreviousResponse left, PreviousResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
