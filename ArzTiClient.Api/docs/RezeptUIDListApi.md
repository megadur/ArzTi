# ArzTiClient.Api.RezeptUIDListApi

All URIs are relative to *http://arzsoftware.de/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PatchRezeptUIdListAbholstatus**](RezeptUIDListApi.md#patchrezeptuidlistabholstatus) | **PATCH** /rezept/abholung | �nderung des Abholstatus einer Liste von Rezepten
[**PatchRezeptUIdListStatus**](RezeptUIDListApi.md#patchrezeptuidliststatus) | **PATCH** /rezept/status | Status�nderung einer Liste von Rezepten
[**PutRezeptUidListPruefung**](RezeptUIDListApi.md#putrezeptuidlistpruefung) | **PUT** /rezept/pruefung | pr�ft eine Liste von UUID Rezepten



## PatchRezeptUIdListAbholstatus

> List&lt;Abholstatus&gt; PatchRezeptUIdListAbholstatus (List<RezeptUId> rezeptUId)

�nderung des Abholstatus einer Liste von Rezepten

patchRezeptUIdListAbholstatus

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class PatchRezeptUIdListAbholstatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptUIDListApi(Configuration.Default);
            var rezeptUId = new List<RezeptUId>(); // List<RezeptUId> | 

            try
            {
                // �nderung des Abholstatus einer Liste von Rezepten
                List<Abholstatus> result = apiInstance.PatchRezeptUIdListAbholstatus(rezeptUId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptUIDListApi.PatchRezeptUIdListAbholstatus: " + e.Message );
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
 **rezeptUId** | [**List&lt;RezeptUId&gt;**](RezeptUId.md)|  | 

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


## PatchRezeptUIdListStatus

> List&lt;RezeptStatus&gt; PatchRezeptUIdListStatus (List<RezeptStatus> rezeptStatus = null)

Status�nderung einer Liste von Rezepten

patchRezeptUIdListStatus

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class PatchRezeptUIdListStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptUIDListApi(Configuration.Default);
            var rezeptStatus = new List<RezeptStatus>(); // List<RezeptStatus> | ??? (optional) 

            try
            {
                // Status�nderung einer Liste von Rezepten
                List<RezeptStatus> result = apiInstance.PatchRezeptUIdListStatus(rezeptStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptUIDListApi.PatchRezeptUIdListStatus: " + e.Message );
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
 **rezeptStatus** | [**List&lt;RezeptStatus&gt;**](RezeptStatus.md)| ??? | [optional] 

### Return type

[**List&lt;RezeptStatus&gt;**](RezeptStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json, application/_*+json
- **Accept**: application/json, application/_*+json, application/xml


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


## PutRezeptUidListPruefung

> void PutRezeptUidListPruefung (List<RezeptUId> rezeptUId = null)

pr�ft eine Liste von UUID Rezepten

putRezeptUidListPruefung

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class PutRezeptUidListPruefungExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptUIDListApi(Configuration.Default);
            var rezeptUId = new List<RezeptUId>(); // List<RezeptUId> | optionaler Datensatz (optional) 

            try
            {
                // pr�ft eine Liste von UUID Rezepten
                apiInstance.PutRezeptUidListPruefung(rezeptUId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptUIDListApi.PutRezeptUidListPruefung: " + e.Message );
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
 **rezeptUId** | [**List&lt;RezeptUId&gt;**](RezeptUId.md)| optionaler Datensatz | [optional] 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | zur Pr�fung angenommen |  -  |
| **401** | Unauthorized |  -  |
| **404** | The specified resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

