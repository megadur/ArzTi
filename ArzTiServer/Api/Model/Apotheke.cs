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
using ArzTiServer.Api.Converters;

namespace ArzTiServer.Api.Model
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Apotheke : IEquatable<Apotheke>
    {
        /// <summary>
        /// Gets or Sets Ik
        /// </summary>
        [Required]
        [DataMember(Name="ik", EmitDefaultValue=false)]
        public string Ik { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Apotheke {\n");
            sb.Append("  Ik: ").Append(Ik).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Apotheke)obj);
        }

        /// <summary>
        /// Returns true if Apotheke instances are equal
        /// </summary>
        /// <param name="other">Instance of Apotheke to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Apotheke other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Ik == other.Ik ||
                    Ik != null &&
                    Ik.Equals(other.Ik)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
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
                    if (Ik != null)
                    hashCode = hashCode * 59 + Ik.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Apotheke left, Apotheke right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Apotheke left, Apotheke right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
