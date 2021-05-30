# ArzTiClient.Api.RezeptIDListApi

All URIs are relative to *http://arzsoftware.de/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRezeptIdList**](RezeptIDListApi.md#getrezeptidlist) | **GET** /apotheke/{apoik}/rezept | liefert eine Liste von Rezepten  einer Apotheke
[**GetRezeptIdListAbholstatus**](RezeptIDListApi.md#getrezeptidlistabholstatus) | **GET** /apotheke/{apoik}/rezept/abholung | Abfrage aller neuen Rezepte einer Apotheke
[**GetRezeptIdListPruefRes**](RezeptIDListApi.md#getrezeptidlistpruefres) | **GET** /apotheke/{apoik}/rezept/pruefung | Ergebnisabfrage zur Vorpr�fung aller Rezepte einer Apotheke
[**GetRezeptIdStatusList**](RezeptIDListApi.md#getrezeptidstatuslist) | **GET** /apotheke/{apoik}/rezept/status | Statusabfrage aller Rezepte einer Apotheke
[**PatchRezeptIdListAbholstatus**](RezeptIDListApi.md#patchrezeptidlistabholstatus) | **PATCH** /apotheke/{apoik}/rezept/abholung | �nderung des Abholstatus einer Liste von Rezepten
[**PatchRezeptIdListStatus**](RezeptIDListApi.md#patchrezeptidliststatus) | **PATCH** /apotheke/{apoik}/rezept/status | Status�nderung einer Liste von Rezepten
[**PutRezeptIdListPruefung**](RezeptIDListApi.md#putrezeptidlistpruefung) | **PUT** /apotheke/{apoik}/rezept/pruefung | pr�ft eine Liste von Rezepten



## GetRezeptIdList

> List&lt;Rezept&gt; GetRezeptIdList (string apoik, RezeptTyp? reztyp = null, int? maxnum = null, string zeitraum = null, List<string> status = null)

liefert eine Liste von Rezepten  einer Apotheke

getRezeptIdList: F�r die angegebene ApoIK werden alle Rezepte zur�ckgegeben.     Optional kann ein Rezepttyp angegeben werden und die maximale Anzahl der Datens�tze, die zur�ckgegeben werden.      Optional kann ein Zeitraum in der Form yyyy-mm angegeben werden und die maximale Anzahl der Datens�tze, die zur�ckgegeben werden.      Es werden solange neue Datens�tze zur�ckgegenben, bis keine neuen mehr vorhanden sind.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class GetRezeptIdListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptIDListApi(Configuration.Default);
            var apoik = apoik_example;  // string | Die Apotheken IK.
            var reztyp = ;  // RezeptTyp? | . (optional) 
            var maxnum = 56;  // int? | maximale Anzahl der Rezepte, die zur�ckgegeben werden (optional) 
            var zeitraum = zeitraum_example;  // string | Welcher Zeitraum im Format YYYY-MM (optional) 
            var status = new List<string>(); // List<string> | Status values that need to be considered for filter (optional) 

            try
            {
                // liefert eine Liste von Rezepten  einer Apotheke
                List<Rezept> result = apiInstance.GetRezeptIdList(apoik, reztyp, maxnum, zeitraum, status);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptIDListApi.GetRezeptIdList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apoik** | **string**| Die Apotheken IK. | 
 **reztyp** | **RezeptTyp?**| . | [optional] 
 **maxnum** | **int?**| maximale Anzahl der Rezepte, die zur�ckgegeben werden | [optional] 
 **zeitraum** | **string**| Welcher Zeitraum im Format YYYY-MM | [optional] 
 **status** | [**List&lt;string&gt;**](string.md)| Status values that need to be considered for filter | [optional] 

### Return type

[**List&lt;Rezept&gt;**](Rezept.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liefert eine Liste mit den gefundenen Rezepten. |  -  |
| **401** | Unauthorized |  -  |
| **404** | The specified resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRezeptIdListAbholstatus

> List&lt;Rezept&gt; GetRezeptIdListAbholstatus (string apoik, RezeptTyp? reztyp = null, string zeitraum = null)

Abfrage aller neuen Rezepte einer Apotheke

F�r die angegebene ApoIK werden alle Rezepte zur�ckgegeben, die noch nicht abgeholt wurden.      Optional kann ein Zeitraum in der Form yyyy-mm angegeben werden und die maximale Anzahl der Datens�tze, die zur�ckgegeben werden.      Es werden solange neue Datens�tze zur�ckgegenben, bis keine neuen mehr vorhanden sind.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class GetRezeptIdListAbholstatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptIDListApi(Configuration.Default);
            var apoik = apoik_example;  // string | Die Apotheken IK.
            var reztyp = ;  // RezeptTyp? | . (optional) 
            var zeitraum = zeitraum_example;  // string | Welcher Zeitraum im Format YYYY-MM (optional) 

            try
            {
                // Abfrage aller neuen Rezepte einer Apotheke
                List<Rezept> result = apiInstance.GetRezeptIdListAbholstatus(apoik, reztyp, zeitraum);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptIDListApi.GetRezeptIdListAbholstatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apoik** | **string**| Die Apotheken IK. | 
 **reztyp** | **RezeptTyp?**| . | [optional] 
 **zeitraum** | **string**| Welcher Zeitraum im Format YYYY-MM | [optional] 

### Return type

[**List&lt;Rezept&gt;**](Rezept.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liefert eine Liste der Status aller Rezepte |  -  |
| **401** | Unauthorized |  -  |
| **404** | The specified resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRezeptIdListPruefRes

> List&lt;RezeptPruefResult&gt; GetRezeptIdListPruefRes (string apoik, RezeptTyp? reztyp = null, string zeitraum = null, List<string> status = null)

Ergebnisabfrage zur Vorpr�fung aller Rezepte einer Apotheke

getRezeptIdListPruefRes

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class GetRezeptIdListPruefResExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptIDListApi(Configuration.Default);
            var apoik = apoik_example;  // string | Die Apotheken IK.
            var reztyp = ;  // RezeptTyp? | . (optional) 
            var zeitraum = zeitraum_example;  // string | Welcher Zeitraum im Format YYYY-MM (optional) 
            var status = new List<string>(); // List<string> | Status values that need to be considered for filter (optional) 

            try
            {
                // Ergebnisabfrage zur Vorpr�fung aller Rezepte einer Apotheke
                List<RezeptPruefResult> result = apiInstance.GetRezeptIdListPruefRes(apoik, reztyp, zeitraum, status);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptIDListApi.GetRezeptIdListPruefRes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apoik** | **string**| Die Apotheken IK. | 
 **reztyp** | **RezeptTyp?**| . | [optional] 
 **zeitraum** | **string**| Welcher Zeitraum im Format YYYY-MM | [optional] 
 **status** | [**List&lt;string&gt;**](string.md)| Status values that need to be considered for filter | [optional] 

### Return type

[**List&lt;RezeptPruefResult&gt;**](RezeptPruefResult.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liefert eine Liste der Status aller Rezepte |  -  |
| **401** | Unauthorized |  -  |
| **404** | The specified resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRezeptIdStatusList

> List&lt;RezeptStatus&gt; GetRezeptIdStatusList (string apoik, RezeptTyp? reztyp = null, string zeitraum = null)

Statusabfrage aller Rezepte einer Apotheke

getRezeptIdStatusList

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class GetRezeptIdStatusListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptIDListApi(Configuration.Default);
            var apoik = apoik_example;  // string | Die Apotheken IK.
            var reztyp = ;  // RezeptTyp? | . (optional) 
            var zeitraum = zeitraum_example;  // string | Welcher Zeitraum im Format YYYY-MM (optional) 

            try
            {
                // Statusabfrage aller Rezepte einer Apotheke
                List<RezeptStatus> result = apiInstance.GetRezeptIdStatusList(apoik, reztyp, zeitraum);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptIDListApi.GetRezeptIdStatusList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apoik** | **string**| Die Apotheken IK. | 
 **reztyp** | **RezeptTyp?**| . | [optional] 
 **zeitraum** | **string**| Welcher Zeitraum im Format YYYY-MM | [optional] 

### Return type

[**List&lt;RezeptStatus&gt;**](RezeptStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liefert eine Liste der Status aller Rezepte |  -  |
| **401** | Unauthorized |  -  |
| **404** | The specified resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchRezeptIdListAbholstatus

> List&lt;Abholstatus&gt; PatchRezeptIdListAbholstatus (string apoik, List<RezeptId> rezeptId)

�nderung des Abholstatus einer Liste von Rezepten

patchRezeptIdListAbholstatus: �ndert Abholstatus einer Liste von Rezepten

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class PatchRezeptIdListAbholstatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptIDListApi(Configuration.Default);
            var apoik = apoik_example;  // string | Die Apotheken IK.
            var rezeptId = new List<RezeptId>(); // List<RezeptId> | 

            try
            {
                // �nderung des Abholstatus einer Liste von Rezepten
                List<Abholstatus> result = apiInstance.PatchRezeptIdListAbholstatus(apoik, rezeptId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptIDListApi.PatchRezeptIdListAbholstatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apoik** | **string**| Die Apotheken IK. | 
 **rezeptId** | [**List&lt;RezeptId&gt;**](RezeptId.md)|  | 

### Return type

[**List&lt;Abholstatus&gt;**](Abholstatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json, application/_*+json
- **Accept**: application/json, text/plain, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the newly created item |  -  |
| **401** | Unauthorized |  -  |
| **404** | The specified resource was not found |  -  |
| **405** | Validation exception |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchRezeptIdListStatus

> List&lt;RezeptStatus&gt; PatchRezeptIdListStatus (string apoik, List<RezeptStatus> rezeptStatus = null)

Status�nderung einer Liste von Rezepten

patchRezeptIdListStatus

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class PatchRezeptIdListStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptIDListApi(Configuration.Default);
            var apoik = apoik_example;  // string | Die Apotheken IK.
            var rezeptStatus = new List<RezeptStatus>(); // List<RezeptStatus> |  (optional) 

            try
            {
                // Status�nderung einer Liste von Rezepten
                List<RezeptStatus> result = apiInstance.PatchRezeptIdListStatus(apoik, rezeptStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptIDListApi.PatchRezeptIdListStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apoik** | **string**| Die Apotheken IK. | 
 **rezeptStatus** | [**List&lt;RezeptStatus&gt;**](RezeptStatus.md)|  | [optional] 

### Return type

[**List&lt;RezeptStatus&gt;**](RezeptStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liefert den Status einer Liste von Rezepten |  -  |
| **401** | Unauthorized |  -  |
| **404** | The specified resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PutRezeptIdListPruefung

> void PutRezeptIdListPruefung (string apoik, List<RezeptId> rezeptId)

pr�ft eine Liste von Rezepten

putRezeptIdListPruefung

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class PutRezeptIdListPruefungExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptIDListApi(Configuration.Default);
            var apoik = apoik_example;  // string | Die Apotheken IK.
            var rezeptId = new List<RezeptId>(); // List<RezeptId> | user to add to the system

            try
            {
                // pr�ft eine Liste von Rezepten
                apiInstance.PutRezeptIdListPruefung(apoik, rezeptId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptIDListApi.PutRezeptIdListPruefung: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apoik** | **string**| Die Apotheken IK. | 
 **rezeptId** | [**List&lt;RezeptId&gt;**](RezeptId.md)| user to add to the system | 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: text/plain, application/json, application/xml
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | die Liste wurde akzeptiert |  -  |
| **401** | Unauthorized |  -  |
| **404** | The specified resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

