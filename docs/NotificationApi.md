# IO.IEngage.Api.NotificationApi

All URIs are relative to *https://api.iengage.io:8243/api/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddNotification**](NotificationApi.md#addnotification) | **POST** /notifications | Create custom notification
[**GetNotifications**](NotificationApi.md#getnotifications) | **GET** /notifications | Get list of notifications
[**MarkAllNotificationAsRead**](NotificationApi.md#markallnotificationasread) | **POST** /notifications/read/all | Mark all notification as read
[**MarkNotificationAsRead**](NotificationApi.md#marknotificationasread) | **POST** /notifications/read/{notificationId} | Mark notification as read
[**NotificationCount**](NotificationApi.md#notificationcount) | **GET** /notifications/count | Get notifications count


<a name="addnotification"></a>
# **AddNotification**
> bool? AddNotification (string requesterId, string clientToken, Notification body = null, string accessToken = null)

Create custom notification

This service allows a user to create a notification. The following fields(key:value) are required to be present in the Notification JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API. **Required fields**  1. title  2. body  3. extraData  4. roleName OR toUser: { emailId }

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class AddNotificationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new Notification(); // Notification |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Create custom notification
                bool? result = apiInstance.AddNotification(requesterId, clientToken, body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.AddNotification: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **body** | [**Notification**](Notification.md)|  | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

**bool?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotifications"></a>
# **GetNotifications**
> VerveResponseNotificationList GetNotifications (string type, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

Get list of notifications

Return the list of notifications

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetNotificationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var type = type_example;  // string |   /_*   Type of count  1) UNREAD   2) READ   3)ALL   *_/ (default to ALL)
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list        /_*   **A) Default values -**        1)notificationId       2)message       3)isRead       4)date        **A) Available values-**        1)notificationId       2)message       3)isRead       4)date       5)type       6)byUser       7)entity       8)parentEntity /n *_/ (optional)  (default to notificationId,message,isRead,date)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of notifications
                VerveResponseNotificationList result = apiInstance.GetNotifications(type, start, end, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.GetNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**|   /_*   Type of count  1) UNREAD   2) READ   3)ALL   *_/ | [default to ALL]
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list        /_*   **A) Default values -**        1)notificationId       2)message       3)isRead       4)date        **A) Available values-**        1)notificationId       2)message       3)isRead       4)date       5)type       6)byUser       7)entity       8)parentEntity /n *_/ | [optional] [default to notificationId,message,isRead,date]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseNotificationList**](VerveResponseNotificationList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="markallnotificationasread"></a>
# **MarkAllNotificationAsRead**
> bool? MarkAllNotificationAsRead (string requesterId, string clientToken, string accessToken = null)

Mark all notification as read

Allows the user to mark all the notification as read

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class MarkAllNotificationAsReadExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Mark all notification as read
                bool? result = apiInstance.MarkAllNotificationAsRead(requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.MarkAllNotificationAsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

**bool?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="marknotificationasread"></a>
# **MarkNotificationAsRead**
> bool? MarkNotificationAsRead (long? notificationId, string requesterId, string clientToken, string accessToken = null)

Mark notification as read

Allows the user to mark the notification as read

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class MarkNotificationAsReadExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var notificationId = 789;  // long? | notification Id
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Mark notification as read
                bool? result = apiInstance.MarkNotificationAsRead(notificationId, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.MarkNotificationAsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationId** | **long?**| notification Id | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

**bool?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationcount"></a>
# **NotificationCount**
> long? NotificationCount (string type, string requesterId, string clientToken, string accessToken = null)

Get notifications count

Returns the notification count

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class NotificationCountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var type = type_example;  // string |   /_*  Type of count  1) UNREAD   2) READ   3)ALL   *_/ (default to ALL)
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get notifications count
                long? result = apiInstance.NotificationCount(type, requesterId, clientToken, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.NotificationCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**|   /_*  Type of count  1) UNREAD   2) READ   3)ALL   *_/ | [default to ALL]
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

**long?**

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

