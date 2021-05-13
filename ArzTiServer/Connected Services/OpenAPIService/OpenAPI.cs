﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.11.1.0 (NJsonSchema v10.4.3.0 (Newtonsoft.Json v12.0.0.2)) (http://NSwag.org)
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

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.11.1.0 (NJsonSchema v10.4.3.0 (Newtonsoft.Json v12.0.0.2))")]
    public interface IController
    {
        /// <summary>liefert eine Liste von Rezepten  einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="maxnum">maximale Anzahl der Rezepte, die zurückgegeben werden</param>
        /// <param name="zeitraum">Welcher Zeitraum im Format YYYY-MM</param>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <returns>Liefert eine Liste mit den gefundenen Rezepten.</returns>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Rezept>> GetRezeptIdListAsync(string apoik, RezeptTyp? reztyp, int? maxnum, string zeitraum, System.Collections.Generic.IEnumerable<string> status);
    
        /// <summary>Statusabfrage aller Rezepte einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="zeitraum">Welcher Zeitraum im Format YYYY-MM</param>
        /// <returns>Liefert eine Liste der Status aller Rezepte</returns>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<RezeptStatus>> GetRezeptIdStatusListAsync(string apoik, RezeptTyp? reztyp, string zeitraum);
    
        /// <summary>Statusänderung einer Liste von Rezepten</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <returns>Liefert den Status einer Liste von Rezepten</returns>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<RezeptStatus>> PatchRezeptIdListStatusAsync(string apoik, System.Collections.Generic.IEnumerable<RezeptStatus> body);
    
        /// <summary>Abfrage aller neuen Rezepte einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="zeitraum">Welcher Zeitraum im Format YYYY-MM</param>
        /// <returns>Liefert eine Liste der Status aller Rezepte</returns>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Rezept>> GetRezeptIdListAbholstatusAsync(string apoik, RezeptTyp? reztyp, string zeitraum);
    
        /// <summary>Änderung des Abholstatus einer Liste von Rezepten</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <returns>Returns the newly created item</returns>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Abholstatus>> PatchRezeptIdListAbholstatusAsync(string apoik, System.Collections.Generic.IEnumerable<RezeptId> body);
    
        /// <summary>Statusabfrage aller Rezepte einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="zeitraum">Welcher Zeitraum im Format YYYY-MM</param>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <returns>Liefert eine Liste der Status aller Rezepte</returns>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<RezeptPruefResult>> GetRezeptIdListPruefResAsync(string apoik, RezeptTyp? reztyp, string zeitraum, System.Collections.Generic.IEnumerable<string> status);
    
        /// <summary>prüft eine Liste von Rezepten</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="body">user to add to the system</param>
        /// <returns>die Liste wurde akzeptiert</returns>
        System.Threading.Tasks.Task PutRezeptIdListPruefungAsync(string apoik, System.Collections.Generic.IEnumerable<RezeptId> body);
    
        /// <summary>liefert ein Rezept</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die RezeptID.</param>
        /// <returns>Liefert das Rezept für die ID</returns>
        System.Threading.Tasks.Task<Rezept> GetRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid);
    
        /// <summary>löscht ein Rezept</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die RezeptID.</param>
        /// <returns>Liefert das Rezept für die ID</returns>
        System.Threading.Tasks.Task<Rezept> DeleteRezeptIdAsync(string apoik, RezeptTyp reztyp, string rezid);
    
        /// <summary>Statusänderung eines Rezeptes</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die Rezept-ID.</param>
        /// <param name="status">Status value</param>
        /// <returns>Liefert den Status des Rezeptes für die ID</returns>
        System.Threading.Tasks.Task<RezeptStatus> PatchRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid, string status);
    
        /// <summary>Statusabfrage eines Rezeptes</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die Rezept-ID.</param>
        /// <returns>Liefert den Status des Rezeptes für die ID</returns>
        System.Threading.Tasks.Task<Rezept> GetRezeptIdStatusAsync(string apoik, RezeptTyp reztyp, string rezid);
    
        /// <summary>liefert ein Rezept</summary>
        /// <param name="ruid">Die Rezept UID.</param>
        /// <returns>Liefert das gefundene Rezepte.</returns>
        System.Threading.Tasks.Task<Rezept> GetRezeptUIdAsync(string ruid);
    
        /// <summary>löscht ein Rezept</summary>
        /// <param name="ruid">Die Rezept UID.</param>
        /// <returns>Liefert das Rezept für die ID</returns>
        System.Threading.Tasks.Task<Rezept> DeleteRezeptUIdAsync(string ruid);
    
        /// <summary>liefert den Status eines Rezepts</summary>
        /// <param name="ruid">Die Rezept UID.</param>
        /// <returns>Liefert das gefundene Rezepte.</returns>
        System.Threading.Tasks.Task<RezeptStatus> GetRezeptUIdStatusAsync(string ruid);
    
        /// <summary>Statusänderung eines Rezeptes</summary>
        /// <param name="ruid">Die Rezept UID.</param>
        /// <param name="status">Status value</param>
        /// <returns>Liefert den Status des Rezeptes für die ID</returns>
        System.Threading.Tasks.Task<RezeptStatus> PatchRezeptUIdStatusAsync(string ruid, string status);
    
        /// <summary>Änderung des Abholstatus einer Liste von Rezepten</summary>
        /// <returns>Returns the newly created item</returns>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Abholstatus>> PatchRezeptUIdListAbholstatusAsync(System.Collections.Generic.IEnumerable<RezeptUId> body);
    
        /// <summary>prüft eine Liste von UUID Rezepten</summary>
        /// <param name="body">optionaler Datensatz</param>
        /// <returns>zur Prüfung angenommen</returns>
        System.Threading.Tasks.Task PutRezeptUidListPruefungAsync(System.Collections.Generic.IEnumerable<RezeptUId> body);
    
        /// <summary>Statusänderung einer Liste von Rezepten</summary>
        /// <returns>Liefert den Status einer Liste von Rezepten</returns>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<RezeptStatus>> PatchRezeptUIdListStatusAsync(System.Collections.Generic.IEnumerable<RezeptStatus> body);
    
        /// <summary>liefert eine Liste aller Apotheken</summary>
        /// <returns>Liefert eine Liste mit den gefundenen Rezepten.</returns>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Apotheke>> GetApothekenListAsync();
    
        /// <summary>liefert Details einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <returns>liefert Details einer Apotheke.</returns>
        System.Threading.Tasks.Task<Apotheke> GetApothekeByIKAsync(string apoik);
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.11.1.0 (NJsonSchema v10.4.3.0 (Newtonsoft.Json v12.0.0.2))")]
    [Microsoft.AspNetCore.Mvc.Route("v1")]
    public partial class Controller : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private IController _implementation;
    
        public Controller(IController implementation)
        {
            _implementation = implementation;
        }
    
        /// <summary>liefert eine Liste von Rezepten  einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="maxnum">maximale Anzahl der Rezepte, die zurückgegeben werden</param>
        /// <param name="zeitraum">Welcher Zeitraum im Format YYYY-MM</param>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <returns>Liefert eine Liste mit den gefundenen Rezepten.</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Rezept>> GetRezeptIdList(string apoik, [Microsoft.AspNetCore.Mvc.FromQuery] RezeptTyp? reztyp, [Microsoft.AspNetCore.Mvc.FromQuery] int? maxnum, [Microsoft.AspNetCore.Mvc.FromQuery] string zeitraum, [Microsoft.AspNetCore.Mvc.FromQuery] System.Collections.Generic.IEnumerable<string> status)
        {
            return _implementation.GetRezeptIdListAsync(apoik, reztyp, maxnum, zeitraum, status);
        }
    
        /// <summary>Statusabfrage aller Rezepte einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="zeitraum">Welcher Zeitraum im Format YYYY-MM</param>
        /// <returns>Liefert eine Liste der Status aller Rezepte</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/status")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<RezeptStatus>> GetRezeptIdStatusList(string apoik, [Microsoft.AspNetCore.Mvc.FromQuery] RezeptTyp? reztyp, [Microsoft.AspNetCore.Mvc.FromQuery] string zeitraum)
        {
            return _implementation.GetRezeptIdStatusListAsync(apoik, reztyp, zeitraum);
        }
    
        /// <summary>Statusänderung einer Liste von Rezepten</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <returns>Liefert den Status einer Liste von Rezepten</returns>
        [Microsoft.AspNetCore.Mvc.HttpPatch, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/status")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<RezeptStatus>> PatchRezeptIdListStatus(string apoik, [Microsoft.AspNetCore.Mvc.FromBody] System.Collections.Generic.IEnumerable<RezeptStatus> body)
        {
            return _implementation.PatchRezeptIdListStatusAsync(apoik, body);
        }
    
        /// <summary>Abfrage aller neuen Rezepte einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="zeitraum">Welcher Zeitraum im Format YYYY-MM</param>
        /// <returns>Liefert eine Liste der Status aller Rezepte</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/abholung")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Rezept>> GetRezeptIdListAbholstatus(string apoik, [Microsoft.AspNetCore.Mvc.FromQuery] RezeptTyp? reztyp, [Microsoft.AspNetCore.Mvc.FromQuery] string zeitraum)
        {
            return _implementation.GetRezeptIdListAbholstatusAsync(apoik, reztyp, zeitraum);
        }
    
        /// <summary>Änderung des Abholstatus einer Liste von Rezepten</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <returns>Returns the newly created item</returns>
        [Microsoft.AspNetCore.Mvc.HttpPatch, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/abholung")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Abholstatus>> PatchRezeptIdListAbholstatus(string apoik, [Microsoft.AspNetCore.Mvc.FromBody] System.Collections.Generic.IEnumerable<RezeptId> body)
        {
            return _implementation.PatchRezeptIdListAbholstatusAsync(apoik, body);
        }
    
        /// <summary>Statusabfrage aller Rezepte einer Apotheke</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="zeitraum">Welcher Zeitraum im Format YYYY-MM</param>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <returns>Liefert eine Liste der Status aller Rezepte</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/pruefung")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<RezeptPruefResult>> GetRezeptIdListPruefRes(string apoik, [Microsoft.AspNetCore.Mvc.FromQuery] RezeptTyp? reztyp, [Microsoft.AspNetCore.Mvc.FromQuery] string zeitraum, [Microsoft.AspNetCore.Mvc.FromQuery] System.Collections.Generic.IEnumerable<string> status)
        {
            return _implementation.GetRezeptIdListPruefResAsync(apoik, reztyp, zeitraum, status);
        }
    
        /// <summary>prüft eine Liste von Rezepten</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="body">user to add to the system</param>
        /// <returns>die Liste wurde akzeptiert</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/pruefung")]
        public System.Threading.Tasks.Task PutRezeptIdListPruefung(string apoik, [Microsoft.AspNetCore.Mvc.FromBody] System.Collections.Generic.IEnumerable<RezeptId> body)
        {
            return _implementation.PutRezeptIdListPruefungAsync(apoik, body);
        }
    
        /// <summary>liefert ein Rezept</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die RezeptID.</param>
        /// <returns>Liefert das Rezept für die ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/{reztyp}/{rezid}")]
        public System.Threading.Tasks.Task<Rezept> GetRezeptId(string apoik, RezeptTyp reztyp, string rezid)
        {
            return _implementation.GetRezeptIdAsync(apoik, reztyp, rezid);
        }
    
        /// <summary>löscht ein Rezept</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die RezeptID.</param>
        /// <returns>Liefert das Rezept für die ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/{reztyp}/{rezid}")]
        public System.Threading.Tasks.Task<Rezept> DeleteRezeptId(string apoik, RezeptTyp reztyp, string rezid)
        {
            return _implementation.DeleteRezeptIdAsync(apoik, reztyp, rezid);
        }
    
        /// <summary>Statusänderung eines Rezeptes</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die Rezept-ID.</param>
        /// <param name="status">Status value</param>
        /// <returns>Liefert den Status des Rezeptes für die ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpPatch, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/{reztyp}/{rezid}")]
        public System.Threading.Tasks.Task<RezeptStatus> PatchRezeptIdStatus(string apoik, RezeptTyp reztyp, string rezid, [Microsoft.AspNetCore.Mvc.FromQuery] string status)
        {
            return _implementation.PatchRezeptIdStatusAsync(apoik, reztyp, rezid, status);
        }
    
        /// <summary>Statusabfrage eines Rezeptes</summary>
        /// <param name="apoik">Die Apotheken IK.</param>
        /// <param name="reztyp">.</param>
        /// <param name="rezid">Die Rezept-ID.</param>
        /// <returns>Liefert den Status des Rezeptes für die ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("apotheke/{apoik}/rezept/{reztyp}/{rezid}/status")]
        public System.Threading.Tasks.Task<Rezept> GetRezeptIdStatus(string apoik, RezeptTyp reztyp, string rezid)
        {
            return _implementation.GetRezeptIdStatusAsync(apoik, reztyp, rezid);
        }
    
        /// <summary>liefert ein Rezept</summary>
        /// <param name="ruid">Die Rezept UID.</param>
        /// <returns>Liefert das gefundene Rezepte.</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("rezept/{ruid}")]
        public System.Threading.Tasks.Task<Rezept> GetRezeptUId(string ruid)
        {
            return _implementation.GetRezeptUIdAsync(ruid);
        }
    
        /// <summary>löscht ein Rezept</summary>
        /// <param name="ruid">Die Rezept UID.</param>
        /// <returns>Liefert das Rezept für die ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("rezept/{ruid}")]
        public System.Threading.Tasks.Task<Rezept> DeleteRezeptUId(string ruid)
        {
            return _implementation.DeleteRezeptUIdAsync(ruid);
        }
    
        /// <summary>liefert den Status eines Rezepts</summary>
        /// <param name="ruid">Die Rezept UID.</param>
        /// <returns>Liefert das gefundene Rezepte.</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("rezept/{ruid}/status")]
        public System.Threading.Tasks.Task<RezeptStatus> GetRezeptUIdStatus(string ruid)
        {
            return _implementation.GetRezeptUIdStatusAsync(ruid);
        }
    
        /// <summary>Statusänderung eines Rezeptes</summary>
        /// <param name="ruid">Die Rezept UID.</param>
        /// <param name="status">Status value</param>
        /// <returns>Liefert den Status des Rezeptes für die ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpPatch, Microsoft.AspNetCore.Mvc.Route("rezept/{ruid}/status")]
        public System.Threading.Tasks.Task<RezeptStatus> PatchRezeptUIdStatus(string ruid, [Microsoft.AspNetCore.Mvc.FromQuery] string status)
        {
            return _implementation.PatchRezeptUIdStatusAsync(ruid, status);
        }
    
        /// <summary>Änderung des Abholstatus einer Liste von Rezepten</summary>
        /// <returns>Returns the newly created item</returns>
        [Microsoft.AspNetCore.Mvc.HttpPatch, Microsoft.AspNetCore.Mvc.Route("rezept/abholung")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Abholstatus>> PatchRezeptUIdListAbholstatus([Microsoft.AspNetCore.Mvc.FromBody] System.Collections.Generic.IEnumerable<RezeptUId> body)
        {
            return _implementation.PatchRezeptUIdListAbholstatusAsync(body);
        }
    
        /// <summary>prüft eine Liste von UUID Rezepten</summary>
        /// <param name="body">optionaler Datensatz</param>
        /// <returns>zur Prüfung angenommen</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("rezept/pruefung")]
        public System.Threading.Tasks.Task PutRezeptUidListPruefung([Microsoft.AspNetCore.Mvc.FromBody] System.Collections.Generic.IEnumerable<RezeptUId> body)
        {
            return _implementation.PutRezeptUidListPruefungAsync(body);
        }
    
        /// <summary>Statusänderung einer Liste von Rezepten</summary>
        /// <returns>Liefert den Status einer Liste von Rezepten</returns>
        [Microsoft.AspNetCore.Mvc.HttpPatch, Microsoft.AspNetCore.Mvc.Route("rezept/status")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<RezeptStatus>> PatchRezeptUIdListStatus([Microsoft.AspNetCore.Mvc.FromBody] System.Collections.Generic.IEnumerable<RezeptStatus> body)
        {
            return _implementation.PatchRezeptUIdListStatusAsync(body);
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
        public System.Threading.Tasks.Task<Apotheke> GetApothekeByIK(string apoik)
        {
            return _implementation.GetApothekeByIKAsync(apoik);
        }
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class RezeptStatus 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RezeptId Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("uid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RezeptUId Uid { get; set; }
    
        /// <summary>Status des Rezepts</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v12.0.0.2)")]
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
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Rezept 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RezeptId Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("uid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RezeptUId Uid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Data { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>die Rezept ID</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class RezeptId 
    {
        [Newtonsoft.Json.JsonProperty("typ", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RezeptTyp Typ { get; set; }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>die Rezept RUID</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class RezeptUId 
    {
        [Newtonsoft.Json.JsonProperty("ruid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Ruid { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class RezeptPruefResult 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RezeptId Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("uid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RezeptUId Uid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("statusinfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Statusinfo { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Abholstatus 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RezeptId Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("uid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RezeptUId Uid { get; set; }
    
        [Newtonsoft.Json.JsonProperty("abgeholt", Required = Newtonsoft.Json.Required.Always)]
        public bool Abgeholt { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v12.0.0.2)")]
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
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.4.3.0 (Newtonsoft.Json v12.0.0.2)")]
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
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108