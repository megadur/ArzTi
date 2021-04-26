﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.10.9.0 (NJsonSchema v10.4.1.0 (Newtonsoft.Json v12.0.0.2)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"

namespace ArzTiServer.OpenAPIService
{
    using System = global::System;
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.10.9.0 (NJsonSchema v10.4.1.0 (Newtonsoft.Json v12.0.0.2))")]
    public interface IArzTiController
    {
        /// <summary>liefert eine Liste von Rezepten  einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="maxnum">maximale Anzahl der Rezepte, die zurückgegeben werden</param>
        /// <param name="zeitraum">Welcher Zeitraum im Format YYYY-MM</param>
        /// <returns>Liefert eine Liste mit den gefundenen Rezepten.</returns>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Rezept>> GetRezeptListNewAsync(string apoik, RezeptTyp? reztyp, int? maxnum, string zeitraum);
    
        /// <summary>Statusabfrage aller Rezepte einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="zeitraum">Welcher Zeitraum im Format YYYY-MM</param>
        /// <returns>Liefert eine Liste der Status aller Rezepte</returns>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<RezeptStatus>> GetRezeptListByStatusAsync(string apoik, RezeptTyp? reztyp, string zeitraum);
    
        /// <summary>Änderung des Abholstatus einer Liste von Rezepten</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <returns>Returns the newly created item</returns>
        System.Threading.Tasks.Task<Abholstatus> PutAbholstatusRezeptListAsync(string apoik, System.Collections.Generic.IEnumerable<Abholstatus> body);
    
        /// <summary>prüft eine Liste von Rezepten</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="body">optionaler eMuster16 Datensatz</param>
        /// <returns>Liefert das Rezept für die ID</returns>
        System.Threading.Tasks.Task<RezeptPruefRes> PutRezeptPruefungAsync(string apoik, Rezept body);
    
        /// <summary>liefert ein Rezept</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die RezeptID.</param>
        /// <returns>Liefert das Rezept für die ID</returns>
        System.Threading.Tasks.Task<Rezept> GetRezeptAsync(string apoik, RezeptTyp reztyp, string rezid);
    
        /// <summary>löscht ein Rezept</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die RezeptID.</param>
        /// <returns>Liefert das Rezept für die ID</returns>
        System.Threading.Tasks.Task<Rezept> DeleteRezeptAsync(string apoik, RezeptTyp reztyp, string rezid);
    
        /// <summary>Statusabfrage eines Rezeptes</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die Rezept-ID.</param>
        /// <returns>Liefert den Status des Rezeptes für die ID</returns>
        System.Threading.Tasks.Task<Rezept> GetRezeptStatusAsync(string apoik, RezeptTyp reztyp, string rezid);
    
        /// <summary>Statusänderung eines Rezeptes</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die Rezept-ID.</param>
        /// <returns>Liefert den Status des Rezeptes für die ID</returns>
        System.Threading.Tasks.Task<Rezept> PatchRezeptStatusAsync(string apoik, Reztyp reztyp, string rezid, RezeptStatus body);
    
        /// <summary>liefert eine Liste aller Apotheken</summary>
        /// <returns>Liefert eine Liste mit den gefundenen Rezepten.</returns>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Apotheke>> GetApothekenListAsync();
    
        /// <summary>liefert Details einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <returns>liefert Details einer Apotheke.</returns>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Apotheke>> GetApothekeAsync(string apoik);
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.10.9.0 (NJsonSchema v10.4.1.0 (Newtonsoft.Json v12.0.0.2))")]
    [Microsoft.AspNetCore.Mvc.Route("v1")]
    public partial class ArzTiController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private IArzTiController _implementation;
    
        public ArzTiController(IArzTiController implementation)
        {
            _implementation = implementation;
        }
    
        /// <summary>liefert eine Liste von Rezepten  einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="maxnum">maximale Anzahl der Rezepte, die zurückgegeben werden</param>
        /// <param name="zeitraum">Welcher Zeitraum im Format YYYY-MM</param>
        /// <returns>Liefert eine Liste mit den gefundenen Rezepten.</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Rezept>> GetRezeptListNew(string apoik, [Microsoft.AspNetCore.Mvc.FromQuery] RezeptTyp? reztyp, [Microsoft.AspNetCore.Mvc.FromQuery] int? maxnum, [Microsoft.AspNetCore.Mvc.FromQuery] string zeitraum)
        {
            return _implementation.GetRezeptListNewAsync(apoik, reztyp, maxnum, zeitraum);
        }
    
        /// <summary>Statusabfrage aller Rezepte einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="zeitraum">Welcher Zeitraum im Format YYYY-MM</param>
        /// <returns>Liefert eine Liste der Status aller Rezepte</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/status")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<RezeptStatus>> GetRezeptListByStatus(string apoik, [Microsoft.AspNetCore.Mvc.FromQuery] RezeptTyp? reztyp, [Microsoft.AspNetCore.Mvc.FromQuery] string zeitraum)
        {
            return _implementation.GetRezeptListByStatusAsync(apoik, reztyp, zeitraum);
        }
    
        /// <summary>Änderung des Abholstatus einer Liste von Rezepten</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <returns>Returns the newly created item</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/abholumg")]
        public System.Threading.Tasks.Task<Abholstatus> PutAbholstatusRezeptList(string apoik, [Microsoft.AspNetCore.Mvc.FromBody] System.Collections.Generic.IEnumerable<Abholstatus> body)
        {
            return _implementation.PutAbholstatusRezeptListAsync(apoik, body);
        }
    
        /// <summary>prüft eine Liste von Rezepten</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="body">optionaler eMuster16 Datensatz</param>
        /// <returns>Liefert das Rezept für die ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/pruefung")]
        public System.Threading.Tasks.Task<RezeptPruefRes> PutRezeptPruefung(string apoik, [Microsoft.AspNetCore.Mvc.FromBody] Rezept body)
        {
            return _implementation.PutRezeptPruefungAsync(apoik, body);
        }
    
        /// <summary>liefert ein Rezept</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die RezeptID.</param>
        /// <returns>Liefert das Rezept für die ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/{reztyp}/{rezid}")]
        public System.Threading.Tasks.Task<Rezept> GetRezept(string apoik, RezeptTyp reztyp, string rezid)
        {
            return _implementation.GetRezeptAsync(apoik, reztyp, rezid);
        }
    
        /// <summary>löscht ein Rezept</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die RezeptID.</param>
        /// <returns>Liefert das Rezept für die ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/{reztyp}/{rezid}")]
        public System.Threading.Tasks.Task<Rezept> DeleteRezept(string apoik, RezeptTyp reztyp, string rezid)
        {
            return _implementation.DeleteRezeptAsync(apoik, reztyp, rezid);
        }
    
        /// <summary>Statusabfrage eines Rezeptes</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die Rezept-ID.</param>
        /// <returns>Liefert den Status des Rezeptes für die ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/{reztyp}/{rezid}/status")]
        public System.Threading.Tasks.Task<Rezept> GetRezeptStatus(string apoik, RezeptTyp reztyp, string rezid)
        {
            return _implementation.GetRezeptStatusAsync(apoik, reztyp, rezid);
        }
    
        /// <summary>Statusänderung eines Rezeptes</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die Rezept-ID.</param>
        /// <returns>Liefert den Status des Rezeptes für die ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpPatch, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/{reztyp}/{rezid}/status")]
        public System.Threading.Tasks.Task<Rezept> PatchRezeptStatus(string apoik, Reztyp reztyp, string rezid, [Microsoft.AspNetCore.Mvc.FromBody] RezeptStatus body)
        {
            return _implementation.PatchRezeptStatusAsync(apoik, reztyp, rezid, body);
        }
    
        /// <summary>liefert eine Liste aller Apotheken</summary>
        /// <returns>Liefert eine Liste mit den gefundenen Rezepten.</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("apotheke")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Apotheke>> GetApothekenList()
        {
            return _implementation.GetApothekenListAsync();
        }
    
        /// <summary>liefert Details einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <returns>liefert Details einer Apotheke.</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Apotheke>> GetApotheke(string apoik)
        {
            return _implementation.GetApothekeAsync(apoik);
        }
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.1.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class RezeptPruefRes 
    {
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RezeptStatus Status { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());
        }
    
        public static RezeptPruefRes FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RezeptPruefRes>(data, new Newtonsoft.Json.JsonSerializerSettings());
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.1.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class RezeptStatus 
    {
        /// <summary>Status des E-Rezepts</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("typ", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RezeptTyp Typ { get; set; }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MRezeptStatus Status { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());
        }
    
        public static RezeptStatus FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RezeptStatus>(data, new Newtonsoft.Json.JsonSerializerSettings());
        }
    
    }
    
    /// <summary>Der Status des eMuster16</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.1.0 (Newtonsoft.Json v12.0.0.2)")]
    public enum MRezeptStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"VOR_PRUEFUNG")]
        VOR_PRUEFUNG = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"FEHLER")]
        FEHLER = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"VERBESSERBAR")]
        VERBESSERBAR = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ABRECHENBAR")]
        ABRECHENBAR = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"HINWEIS")]
        HINWEIS = 4,
    
    }
    
    /// <summary>Der Statuswert des E-Rezeptes</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.1.0 (Newtonsoft.Json v12.0.0.2)")]
    public enum ERezeptStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"VOR_PRUEFUNG")]
        VOR_PRUEFUNG = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"VOR_ABRECHNUNG")]
        VOR_ABRECHNUNG = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"FEHLER")]
        FEHLER = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"VERBESSERBAR  ")]
        VERBESSERBAR__ = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"RUECKWEISUNG")]
        RUECKWEISUNG = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ABGERECHNET")]
        ABGERECHNET = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"STORNIERT")]
        STORNIERT = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"HINWEIS")]
        HINWEIS = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ABRECHENBAR")]
        ABRECHENBAR = 8,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.1.0 (Newtonsoft.Json v12.0.0.2)")]
    public enum RezeptTyp
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ERezept")]
        ERezept = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MRezept")]
        MRezept = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PRezept")]
        PRezept = 2,
    
    }
    
    /// <summary>base64 codierte Leistung</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.1.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Rezept 
    {
        [Newtonsoft.Json.JsonProperty("typ", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RezeptTyp Typ { get; set; }
    
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Data { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());
        }
    
        public static Rezept FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Rezept>(data, new Newtonsoft.Json.JsonSerializerSettings());
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.1.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Abholstatus 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("typ", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RezeptTyp Typ { get; set; }
    
        [Newtonsoft.Json.JsonProperty("abgeholt", Required = Newtonsoft.Json.Required.Always)]
        public bool Abgeholt { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());
        }
    
        public static Abholstatus FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Abholstatus>(data, new Newtonsoft.Json.JsonSerializerSettings());
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.1.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Apotheke 
    {
        [Newtonsoft.Json.JsonProperty("ik", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Ik { get; set; }
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());
        }
    
        public static Apotheke FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Apotheke>(data, new Newtonsoft.Json.JsonSerializerSettings());
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.1.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Error 
    {
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Message { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());
        }
    
        public static Error FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Error>(data, new Newtonsoft.Json.JsonSerializerSettings());
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.1.0 (Newtonsoft.Json v12.0.0.2)")]
    public enum Reztyp
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ERezept")]
        ERezept = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MRezept")]
        MRezept = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PRezept")]
        PRezept = 2,
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108