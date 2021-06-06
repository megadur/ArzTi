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
    /// E-, M-, oder P-Rezept
    /// </summary>
    /// <value>E-, M-, oder P-Rezept</value>
    [TypeConverter(typeof(CustomEnumConverter<RezeptTyp>))]
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RezeptTyp
    {

        /// <summary>
        /// Enum ERezeptEnum for ERezept
        /// </summary>
        [EnumMember(Value = "ERezept")]
        ERezeptEnum = 1,

        /// <summary>
        /// Enum MRezeptEnum for MRezept
        /// </summary>
        [EnumMember(Value = "MRezept")]
        MRezeptEnum = 2,

        /// <summary>
        /// Enum PRezeptEnum for PRezept
        /// </summary>
        [EnumMember(Value = "PRezept")]
        PRezeptEnum = 3,

    }
}
