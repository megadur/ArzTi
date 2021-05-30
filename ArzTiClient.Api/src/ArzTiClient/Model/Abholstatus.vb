﻿' 
 * Webservice ArzTI API
 *
 * Kommunikation des Webservers mit den jeweiligen Rechenzentren V.2021-05-20 
 *
 * The version of the OpenAPI document: V1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 

Imports System
Imports System.IO
Imports System.Text
Imports System.Collections.Generic
Imports System.Runtime.Serialization
Imports Newtonsoft.Json
Imports System.ComponentModel.DataAnnotations
Imports OpenAPIDateConverter = ArzTiClient.Client.OpenAPIDateConverter

Namespace ArzTiClient.Model
    ''' <summary>
    ''' Abholstatus
    ''' </summary>
    <DataContract>
    Public Partial Class Abholstatus
        Implements IEquatable(Of Abholstatus), IValidatableObject
        ''' <summary>
        ''' Initializes a new instance of the <seecref="Abholstatus"/> class.
        ''' </summary>
        <JsonConstructorAttribute>
        Protected Sub New()
        End Sub
        ''' <summary>
        ''' Initializes a new instance of the <seecref="Abholstatus"/> class.
        ''' </summary>
        ''' <paramname="id">id.</param>
        ''' <paramname="uid">uid.</param>
        ''' <paramname="abgeholt">abgeholt (required).</param>
        Public Sub New(ByVal Optional id As Model.RezeptId = DirectCast(Nothing, Model.RezeptId), ByVal Optional uid As Model.RezeptUId = DirectCast(Nothing, Model.RezeptUId), ByVal Optional abgeholt As Boolean = Nothing)
            ' to ensure "abgeholt" is required (not null)
            If abgeholt Is Nothing Then
                Throw New InvalidDataException("abgeholt is a required property for Abholstatus and cannot be null")
            Else
                Me.Abgeholt = abgeholt
            End If

            Me.Id = id
            Me.Uid = uid
        End Sub

        ''' <summary>
        ''' Gets or Sets Id
        ''' </summary>
        <DataMember(Name:="id", EmitDefaultValue:=False)>
        Public Property Id As Model.RezeptId

        ''' <summary>
        ''' Gets or Sets Uid
        ''' </summary>
        <DataMember(Name:="uid", EmitDefaultValue:=False)>
        Public Property Uid As Model.RezeptUId

        ''' <summary>
        ''' Gets or Sets Abgeholt
        ''' </summary>
        <DataMember(Name:="abgeholt", EmitDefaultValue:=True)>
        Public Property Abgeholt As Boolean

        ''' <summary>
        ''' Returns the string presentation of the object
        ''' </summary>
        ''' <returns>String presentation of the object</returns>
        Public Overrides Function ToString() As String
            Dim sb = New StringBuilder()
            sb.Append("class Abholstatus {" & Microsoft.VisualBasic.Constants.vbLf)
            sb.Append(CStr("  Id: ")).Append(CObj(Id)).Append(Microsoft.VisualBasic.Constants.vbLf)
            sb.Append(CStr("  Uid: ")).Append(CObj(Uid)).Append(Microsoft.VisualBasic.Constants.vbLf)
            sb.Append(CStr("  Abgeholt: ")).Append(CBool(Abgeholt)).Append(Microsoft.VisualBasic.Constants.vbLf)
            sb.Append("}" & Microsoft.VisualBasic.Constants.vbLf)
            Return sb.ToString()
        End Function

        ''' <summary>
        ''' Returns the JSON string presentation of the object
        ''' </summary>
        ''' <returns>JSON string presentation of the object</returns>
        Public Overridable Function ToJson() As String
            Return JsonConvert.SerializeObject(Me, Formatting.Indented)
        End Function

        ''' <summary>
        ''' Returns true if objects are equal
        ''' </summary>
        ''' <paramname="input">Object to be compared</param>
        ''' <returns>Boolean</returns>
        Public Overrides Function Equals(ByVal input As Object) As Boolean
            Return Equals(TryCast(input, Abholstatus))
        End Function

        ''' <summary>
        ''' Returns true if Abholstatus instances are equal
        ''' </summary>
        ''' <paramname="input">Instance of Abholstatus to be compared</param>
        ''' <returns>Boolean</returns>
        Public Overloads Function Equals(ByVal input As Abholstatus) As Boolean Implements IEquatable(Of Abholstatus).Equals
            If input Is Nothing Then Return False
            Return (Id Is input.Id OrElse Id IsNot Nothing AndAlso Id.Equals(input.Id)) AndAlso (Uid Is input.Uid OrElse Uid IsNot Nothing AndAlso Uid.Equals(input.Uid)) AndAlso (Abgeholt = input.Abgeholt OrElse Abgeholt IsNot Nothing AndAlso Abgeholt.Equals(input.Abgeholt))
        End Function

        ''' <summary>
        ''' Gets the hash code
        ''' </summary>
        ''' <returns>Hash code</returns>
        Public Overrides Function GetHashCode() As Integer
            BEGIN TODO : Visual Basic does not support checked statements!
            Dim hashCode = 41 ' Overflow is fine, just wrap
            If Id IsNot Nothing Then hashCode = hashCode * 59 + Id.GetHashCode()
            If Uid IsNot Nothing Then hashCode = hashCode * 59 + Uid.GetHashCode()
            If Abgeholt IsNot Nothing Then hashCode = hashCode * 59 + Abgeholt.GetHashCode()
            Return hashCode
            END TODO : Visual Basic does not support checked statements!
        End Function

        ''' <summary>
        ''' To validate all properties of the instance
        ''' </summary>
        ''' <paramname="validationContext">Validation context</param>
        ''' <returns>Validation Result</returns>
        Private Iterator Function Validate(ByVal validationContext As ValidationContext) As IEnumerable(Of ValidationResult) Implements IValidatableObject.Validate
            Return
        End Function
    End Class
End Namespace
