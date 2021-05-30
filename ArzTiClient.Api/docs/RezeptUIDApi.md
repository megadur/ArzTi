# ArzTiClient.Api.RezeptUIDApi

All URIs are relative to *http://arzsoftware.de/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteRezeptUId**](RezeptUIDApi.md#deleterezeptuid) | **DELETE** /rezept/{ruid} | l�scht ein Rezept
[**GetRezeptUId**](RezeptUIDApi.md#getrezeptuid) | **GET** /rezept/{ruid} | liefert ein Rezept
[**GetRezeptUIdStatus**](RezeptUIDApi.md#getrezeptuidstatus) | **GET** /rezept/{ruid}/status | liefert den Status eines Rezepts
[**PatchRezeptUIdStatus**](RezeptUIDApi.md#patchrezeptuidstatus) | **PATCH** /rezept/{ruid}/status | Status�nderung eines Rezeptes



## DeleteRezeptUId

> Rezept DeleteRezeptUId (string ruid)

l�scht ein Rezept

deleteRezeptUId

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class DeleteRezeptUIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptUIDApi(Configuration.Default);
            var ruid = ruid_example;  // string | Die Rezept UID.

            try
            {
                // l�scht ein Rezept
                Rezept result = apiInstance.DeleteRezeptUId(ruid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptUIDApi.DeleteRezeptUId: " + e.Message );
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
 **ruid** | **string**| Die Rezept UID. | 

### Return type

[**Rezept**](Rezept.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liefert das Rezept f�r die ID |  -  |
| **401** | Unauthorized |  -  |
| **404** | The specified resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRezeptUId

> Rezept GetRezeptUId (string ruid)

liefert ein Rezept

getRezeptUId

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class GetRezeptUIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptUIDApi(Configuration.Default);
            var ruid = ruid_example;  // string | Die Rezept UID.

            try
            {
                // liefert ein Rezept
                Rezept result = apiInstance.GetRezeptUId(ruid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptUIDApi.GetRezeptUId: " + e.Message );
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
 **ruid** | **string**| Die Rezept UID. | 

### Return type

[**Rezept**](Rezept.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liefert das gefundene Rezepte. |  -  |
| **401** | Unauthorized |  -  |
| **404** | The specified resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRezeptUIdStatus

> RezeptStatus GetRezeptUIdStatus (string ruid)

liefert den Status eines Rezepts

getRezeptUIdStatus

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class GetRezeptUIdStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptUIDApi(Configuration.Default);
            var ruid = ruid_example;  // string | Die Rezept UID.

            try
            {
                // liefert den Status eines Rezepts
                RezeptStatus result = apiInstance.GetRezeptUIdStatus(ruid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptUIDApi.GetRezeptUIdStatus: " + e.Message );
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
 **ruid** | **string**| Die Rezept UID. | 

### Return type

[**RezeptStatus**](RezeptStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liefert das gefundene Rezepte. |  -  |
| **401** | Unauthorized |  -  |
| **404** | The specified resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchRezeptUIdStatus

> RezeptStatus PatchRezeptUIdStatus (string ruid, string status)

Status�nderung eines Rezeptes

patchRezeptUIdStatus

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class PatchRezeptUIdStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptUIDApi(Configuration.Default);
            var ruid = ruid_example;  // string | Die Rezept UID.
            var status = status_example;  // string | Status value

            try
            {
                // Status�nderung eines Rezeptes
                RezeptStatus result = apiInstance.PatchRezeptUIdStatus(ruid, status);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptUIDApi.PatchRezeptUIdStatus: " + e.Message );
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
 **ruid** | **string**| Die Rezept UID. | 
 **status** | **string**| Status value | 

### Return type

[**RezeptStatus**](RezeptStatus.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liefert den Status des Rezeptes f�r die ID |  -  |
| **401** | Unauthorized |  -  |
| **404** | The specified resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

