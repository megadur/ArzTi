# ArzTiClient.Api.ApothekeApi

All URIs are relative to *http://arzsoftware.de/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApothekeByIK**](ApothekeApi.md#getapothekebyik) | **GET** /apotheke/{apoik} | liefert Details einer Apotheke
[**GetApothekenList**](ApothekeApi.md#getapothekenlist) | **GET** /apotheke | liefert eine Liste aller Apotheken



## GetApothekeByIK

> Apotheke GetApothekeByIK (string apoik)

liefert Details einer Apotheke

getApothekeByIK

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class GetApothekeByIKExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ApothekeApi(Configuration.Default);
            var apoik = apoik_example;  // string | Die Apotheken IK.

            try
            {
                // liefert Details einer Apotheke
                Apotheke result = apiInstance.GetApothekeByIK(apoik);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApothekeApi.GetApothekeByIK: " + e.Message );
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

### Return type

[**Apotheke**](Apotheke.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | liefert Details einer Apotheke. |  -  |
| **401** | Unauthorized |  -  |
| **404** | The specified resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetApothekenList

> List&lt;Apotheke&gt; GetApothekenList ()

liefert eine Liste aller Apotheken

getApothekenList

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ArzTiClient.Api;
using ArzTiClient.Client;
using ArzTiClient.Model;

namespace Example
{
    public class GetApothekenListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://arzsoftware.de/v1";
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ApothekeApi(Configuration.Default);

            try
            {
                // liefert eine Liste aller Apotheken
                List<Apotheke> result = apiInstance.GetApothekenList();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApothekeApi.GetApothekenList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**List&lt;Apotheke&gt;**](Apotheke.md)

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

