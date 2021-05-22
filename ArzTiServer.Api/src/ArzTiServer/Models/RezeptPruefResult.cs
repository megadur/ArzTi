/*
 * Webservice ArzTI API
 *
 * Kommunikation des Webservers mit den jeweiligen Rechenzentren V.2021-05-20            
 *
 * The version of the OpenAPI document: V1
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using ArzTiServer.Converters;

namespace ArzTiServer.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class RezeptPruefResult : IEquatable<RezeptPruefResult>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public RezeptId Id { get; set; }

        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public RezeptUId Uid { get; set; }

        /// <summary>
        /// Gets or Sets Statusinfo
        /// </summary>
        [DataMember(Name="statusinfo", EmitDefaultValue=false)]
        public List<Statusinfo> Statusinfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RezeptPruefResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  Statusinfo: ").Append(Statusinfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((RezeptPruefResult)obj);
        }

        /// <summary>
        /// Returns true if RezeptPruefResult instances are equal
        /// </summary>
        /// <param name="other">Instance of RezeptPruefResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RezeptPruefResult other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Uid == other.Uid ||
                    Uid != null &&
                    Uid.Equals(other.Uid)
                ) && 
                (
                    Statusinfo == other.Statusinfo ||
                    Statusinfo != null &&
                    other.Statusinfo != null &&
                    Statusinfo.SequenceEqual(other.Statusinfo)
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
                    if (Uid != null)
                    hashCode = hashCode * 59 + Uid.GetHashCode();
                    if (Statusinfo != null)
                    hashCode = hashCode * 59 + Statusinfo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RezeptPruefResult left, RezeptPruefResult right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RezeptPruefResult left, RezeptPruefResult right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
