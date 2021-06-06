/* 
 * Webservice ArzTI API
 *
 * Kommunikation des Webservers mit den jeweiligen Rechenzentren V.2021-05-20 
 *
 * OpenAPI spec version: V1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// RezeptPruefResult
    /// </summary>
    [DataContract]
        public partial class RezeptPruefResult :  IEquatable<RezeptPruefResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RezeptPruefResult" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="uid">uid.</param>
        /// <param name="statusinfo">statusinfo.</param>
        public RezeptPruefResult(RezeptId id = default(RezeptId), RezeptUId uid = default(RezeptUId), List<Statusinfo> statusinfo = default(List<Statusinfo>))
        {
            this.Id = id;
            this.Uid = uid;
            this.Statusinfo = statusinfo;
        }
        
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
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RezeptPruefResult);
        }

        /// <summary>
        /// Returns true if RezeptPruefResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RezeptPruefResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RezeptPruefResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.Statusinfo == input.Statusinfo ||
                    this.Statusinfo != null &&
                    input.Statusinfo != null &&
                    this.Statusinfo.SequenceEqual(input.Statusinfo)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Statusinfo != null)
                    hashCode = hashCode * 59 + this.Statusinfo.GetHashCode();
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
}
