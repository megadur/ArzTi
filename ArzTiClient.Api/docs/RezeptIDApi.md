# ArzTiClient.Api.RezeptIDApi

All URIs are relative to *http://arzsoftware.de/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteRezeptId**](RezeptIDApi.md#deleterezeptid) | **DELETE** /apotheke/{apoik}/rezept/{reztyp}/{rezid} | l�scht ein Rezept
[**GetRezeptId**](RezeptIDApi.md#getrezeptid) | **GET** /apotheke/{apoik}/rezept/{reztyp}/{rezid} | liefert ein Rezept
[**GetRezeptIdStatus**](RezeptIDApi.md#getrezeptidstatus) | **GET** /apotheke/{apoik}/rezept/{reztyp}/{rezid}/status | Statusabfrage eines Rezeptes
[**PatchRezeptIdStatus**](RezeptIDApi.md#patchrezeptidstatus) | **PATCH** /apotheke/{apoik}/rezept/{reztyp}/{rezid} | Status�nderung eines Rezeptes



## DeleteRezeptId

> Rezept DeleteRezeptId (string apoik, RezeptTyp reztyp, string rezid)

l�scht ein Rezept

deleteRezeptId

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class DeleteRezeptIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptIDApi(Configuration.Default);
            var apoik = apoik_example;  // string | Die Apotheken IK.
            var reztyp = ;  // RezeptTyp | .
            var rezid = rezid_example;  // string | Die RezeptID.

            try
            {
                // l�scht ein Rezept
                Rezept result = apiInstance.DeleteRezeptId(apoik, reztyp, rezid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptIDApi.DeleteRezeptId: " + e.Message );
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
 **reztyp** | **RezeptTyp**| . | 
 **rezid** | **string**| Die RezeptID. | 

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


## GetRezeptId

> Rezept GetRezeptId (string apoik, RezeptTyp reztyp, string rezid)

liefert ein Rezept

getRezeptId

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class GetRezeptIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptIDApi(Configuration.Default);
            var apoik = apoik_example;  // string | Die Apotheken IK.
            var reztyp = ;  // RezeptTyp | .
            var rezid = rezid_example;  // string | Die RezeptID.

            try
            {
                // liefert ein Rezept
                Rezept result = apiInstance.GetRezeptId(apoik, reztyp, rezid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptIDApi.GetRezeptId: " + e.Message );
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
 **reztyp** | **RezeptTyp**| . | 
 **rezid** | **string**| Die RezeptID. | 

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


## GetRezeptIdStatus

> Rezept GetRezeptIdStatus (string apoik, RezeptTyp reztyp, string rezid)

Statusabfrage eines Rezeptes

getRezeptIdStatus

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class GetRezeptIdStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptIDApi(Configuration.Default);
            var apoik = apoik_example;  // string | Die Apotheken IK.
            var reztyp = ;  // RezeptTyp | .
            var rezid = rezid_example;  // string | Die Rezept-ID.

            try
            {
                // Statusabfrage eines Rezeptes
                Rezept result = apiInstance.GetRezeptIdStatus(apoik, reztyp, rezid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptIDApi.GetRezeptIdStatus: " + e.Message );
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
 **reztyp** | **RezeptTyp**| . | 
 **rezid** | **string**| Die Rezept-ID. | 

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
| **200** | Liefert den Status des Rezeptes f�r die ID |  -  |
| **401** | Unauthorized |  -  |
| **404** | The specified resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchRezeptIdStatus

> RezeptStatus PatchRezeptIdStatus (string apoik, RezeptTyp reztyp, string rezid, string status)

Status�nderung eines Rezeptes

patchRezeptIdStatus

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class PatchRezeptIdStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RezeptIDApi(Configuration.Default);
            var apoik = apoik_example;  // string | Die Apotheken IK.
            var reztyp = ;  // RezeptTyp | .
            var rezid = rezid_example;  // string | Die Rezept-ID.
            var status = status_example;  // string | Status value

            try
            {
                // Status�nderung eines Rezeptes
                RezeptStatus result = apiInstance.PatchRezeptIdStatus(apoik, reztyp, rezid, status);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RezeptIDApi.PatchRezeptIdStatus: " + e.Message );
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
 **reztyp** | **RezeptTyp**| . | 
 **rezid** | **string**| Die Rezept-ID. | 
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

