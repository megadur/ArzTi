/*
 * Webservice ArzTI API
 *
 * Kommunikation des Webservers mit den jeweiligen Rechenzentren * UC: Abruf der eRezept-Daten - neue (noch nicht gesendete) | eRezept-ID | Zeitraum * UC: Abruf der eMuster16-Daten - neue (noch nicht gesendete) | eRezept-ID | Zeitraum * UC: Abruf der pRezept-Daten - neue (noch nicht gesendete) | eRezept-ID | Zeitraum * UC: Aktualisierung des eRezept-Status - eRezept-ID * UC: Löschen eines eRezepts - eRezept-ID * UC: Aktualisierung von Kundendaten (Apotheke -> Rechenzentrum Zuordnung) - Apotheke-IK * UC: ... 
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
    /// die Rezept ID
    /// </summary>
    [DataContract]
    public partial class RezeptId : IEquatable<RezeptId>
    {
        /// <summary>
        /// Gets or Sets Typ
        /// </summary>
        [DataMember(Name="typ", EmitDefaultValue=false)]
        public RezeptTyp Typ { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RezeptId {\n");
            sb.Append("  Typ: ").Append(Typ).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RezeptId)obj);
        }

        /// <summary>
        /// Returns true if RezeptId instances are equal
        /// </summary>
        /// <param name="other">Instance of RezeptId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RezeptId other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Typ == other.Typ ||
                    
                    Typ.Equals(other.Typ)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
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
                    
                    hashCode = hashCode * 59 + Typ.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RezeptId left, RezeptId right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RezeptId left, RezeptId right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
