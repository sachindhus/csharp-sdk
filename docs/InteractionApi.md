# IO.IEngage.Api.InteractionApi

All URIs are relative to *https://api.iengage.io:8243/api/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInteraction**](InteractionApi.md#addinteraction) | **POST** /interactions | Share interaction without attachment
[**AddInteraction_0**](InteractionApi.md#addinteraction_0) | **POST** /interactions/attachment | Share interaction with attachment
[**AddResponse**](InteractionApi.md#addresponse) | **POST** /interactions/{interactionId}/responses | Response the specified interaction
[**ChangeInteractionCategory**](InteractionApi.md#changeinteractioncategory) | **PUT** /interactions/{interactionId}/{categoryId} | Change interaction category
[**ChangeInteractionType**](InteractionApi.md#changeinteractiontype) | **PUT** /interactions/{interactionId}/type | Change interaction type
[**CreateInteractionCategory**](InteractionApi.md#createinteractioncategory) | **POST** /interactions/categories | Create interaction category
[**DeleteInteraction**](InteractionApi.md#deleteinteraction) | **DELETE** /interactions/{interactionId} | Delete interaction
[**DeleteInteractionCategory**](InteractionApi.md#deleteinteractioncategory) | **DELETE** /interactions/categories/{categoryId} | Delete interaction category
[**DeleteResponse**](InteractionApi.md#deleteresponse) | **DELETE** /interactions/responses/{responseId} | Delete response
[**DislikeResponse**](InteractionApi.md#dislikeresponse) | **POST** /interactions/{interactionId}/responses/{responseId}/dislike | Dislike response
[**GetFriendsInteractions**](InteractionApi.md#getfriendsinteractions) | **GET** /interactions/friends | Get list of interactions shared by friends
[**GetInteraction**](InteractionApi.md#getinteraction) | **GET** /interactions/{interactionId} | Get interaction by id
[**GetInteractionCategories**](InteractionApi.md#getinteractioncategories) | **GET** /interactions/categories | Get the list of interaction categories
[**GetInteractionsForUser**](InteractionApi.md#getinteractionsforuser) | **GET** /interactions | Get list of all interactions visible to the user
[**GetRecommendInteractions**](InteractionApi.md#getrecommendinteractions) | **GET** /interactions/recommend | Get list of recommended interactions
[**GetRecommendedInteractinsFromDB**](InteractionApi.md#getrecommendedinteractinsfromdb) | **GET** /interactions/{userId}/recommendedInteractions | Get list of recommended interactions from DB
[**GetRecommendedUsersFromDB**](InteractionApi.md#getrecommendedusersfromdb) | **GET** /interactions/{interactionId}/recommendedUsers | Get list of recommended Users from DB
[**GetResponses**](InteractionApi.md#getresponses) | **GET** /interactions/{interactionId}/responses | Get list of responses by interactionId
[**GetUserInteractions**](InteractionApi.md#getuserinteractions) | **GET** /interactions/{userId}/shared | Get list of interactions shared by user
[**GetUserSubscribedInteractionCategories**](InteractionApi.md#getusersubscribedinteractioncategories) | **GET** /interactions/categories/{userId}/subscribe | Get list of interaction categories subscribed by the user
[**GetUserSubscribedInteractions**](InteractionApi.md#getusersubscribedinteractions) | **GET** /interactions/{userId}/subscribe | Get list of interactions subscribed by user
[**LikeResponse**](InteractionApi.md#likeresponse) | **POST** /interactions/{interactionId}/responses/{responseId}/like | Like response
[**MarkAsAnResponse**](InteractionApi.md#markasanresponse) | **POST** /interactions/{interactionId}/responses/{responseId}/mark | Mark response as a response
[**SearchInteractions**](InteractionApi.md#searchinteractions) | **GET** /interactions/search | Get list of matching interactions
[**SubscribeInteractinCategory**](InteractionApi.md#subscribeinteractincategory) | **POST** /interactions/categories/{categoryId}/subscribe | Subscribe interaction category
[**SubscribeInteraction**](InteractionApi.md#subscribeinteraction) | **POST** /interactions/{interactionId}/subscribe | Subscribe interaction
[**UnmarkAsAnResponse**](InteractionApi.md#unmarkasanresponse) | **POST** /interactions/{interactionId}/responses/{responseId}/unmark | Unmark response as a response
[**UnsubscribeInteractinCategory**](InteractionApi.md#unsubscribeinteractincategory) | **POST** /interactions/categories/{categoryId}/unsubscribe | Unsubscribe interaction category
[**UnsubscribeInteraction**](InteractionApi.md#unsubscribeinteraction) | **POST** /interactions/{interactionId}/unsubscribe | Unsubscribe interaction
[**UpdateInteraction**](InteractionApi.md#updateinteraction) | **PUT** /interactions/{interactionId} | Update interaction
[**UpdateInteractionCategory**](InteractionApi.md#updateinteractioncategory) | **PUT** /interactions/categories/{categoryId} | Update interaction category
[**UpdateResponse**](InteractionApi.md#updateresponse) | **PUT** /interactions/responses/{responseId} | Update response


<a name="addinteraction"></a>
# **AddInteraction**
> VerveResponseInteraction AddInteraction (string requesterId, string clientToken, InteractionInputModel body = null, string accessToken = null)

Share interaction without attachment

This service allows a user to post an interaction. The following fields(key:value) are required to be present in the Interaction JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API.</br><b>Required fields </br>1. interactionTitle </br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class AddInteractionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new InteractionInputModel(); // InteractionInputModel |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Share interaction without attachment
                VerveResponseInteraction result = apiInstance.AddInteraction(requesterId, clientToken, body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.AddInteraction: " + e.Message );
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
 **body** | [**InteractionInputModel**](InteractionInputModel.md)|  | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteraction**](VerveResponseInteraction.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinteraction_0"></a>
# **AddInteraction_0**
> VerveResponseInteraction AddInteraction_0 (string interactionTitle, System.IO.Stream file, string requesterId, string clientToken, string categoryId = null, string interactionType = null, string interactionDescription = null, string association = null, string accessToken = null)

Share interaction with attachment

Allows the user to share interaction with attachment. Returns the interaction object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class AddInteraction_0Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionTitle = interactionTitle_example;  // string | interactionTitle
            var file = /path/to/file.txt;  // System.IO.Stream | file
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var categoryId = categoryId_example;  // string | categoryId (optional) 
            var interactionType = interactionType_example;  // string | interactionType (optional) 
            var interactionDescription = interactionDescription_example;  // string | interactionDescription (optional) 
            var association = association_example;  // string | association (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Share interaction with attachment
                VerveResponseInteraction result = apiInstance.AddInteraction_0(interactionTitle, file, requesterId, clientToken, categoryId, interactionType, interactionDescription, association, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.AddInteraction_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionTitle** | **string**| interactionTitle | 
 **file** | **System.IO.Stream****System.IO.Stream**| file | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **categoryId** | **string**| categoryId | [optional] 
 **interactionType** | **string**| interactionType | [optional] 
 **interactionDescription** | **string**| interactionDescription | [optional] 
 **association** | **string**| association | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteraction**](VerveResponseInteraction.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addresponse"></a>
# **AddResponse**
> VerveResponseInteractionResponse AddResponse (long? interactionId, string requesterId, string clientToken, InteractionResponse body = null, string accessToken = null)

Response the specified interaction

This service allows a user to post a response on an interaction. The following fields(key:value) are required to be present in the Response JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API.</br><b>Required fields </br>1. interactionId (Path Parameter)</br>2. responseDescription </br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class AddResponseExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionId = 789;  // long? | interactionId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new InteractionResponse(); // InteractionResponse |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Response the specified interaction
                VerveResponseInteractionResponse result = apiInstance.AddResponse(interactionId, requesterId, clientToken, body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.AddResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionId** | **long?**| interactionId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **body** | [**InteractionResponse**](InteractionResponse.md)|  | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionResponse**](VerveResponseInteractionResponse.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changeinteractioncategory"></a>
# **ChangeInteractionCategory**
> VerveResponseInteraction ChangeInteractionCategory (long? interactionId, long? categoryId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Change interaction category

Allows the user to change the interaction category.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class ChangeInteractionCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionId = 789;  // long? | interactionId
            var categoryId = 789;  // long? | New interaction categoryId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)createdDate<br/>5)interactionType<br/><b>A) Available values-</b><br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)issuer<br/>5)noOfResponses<br/>6)isClosed<br/>7)createdDate<br/>8)lastUpdatedDate<br/>9)videoId<br/>10)fileURL<br/>11)isSubscribed<br/>12)sentiment</br>13)entity<br/>14)interactionType<br/>15)categoryId<br/>16)categoryName (optional)  (default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Change interaction category
                VerveResponseInteraction result = apiInstance.ChangeInteractionCategory(interactionId, categoryId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.ChangeInteractionCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionId** | **long?**| interactionId | 
 **categoryId** | **long?**| New interaction categoryId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)interactionType&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)issuer&lt;br/&gt;5)noOfResponses&lt;br/&gt;6)isClosed&lt;br/&gt;7)createdDate&lt;br/&gt;8)lastUpdatedDate&lt;br/&gt;9)videoId&lt;br/&gt;10)fileURL&lt;br/&gt;11)isSubscribed&lt;br/&gt;12)sentiment&lt;/br&gt;13)entity&lt;br/&gt;14)interactionType&lt;br/&gt;15)categoryId&lt;br/&gt;16)categoryName | [optional] [default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteraction**](VerveResponseInteraction.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changeinteractiontype"></a>
# **ChangeInteractionType**
> VerveResponseInteraction ChangeInteractionType (long? interactionId, string interactionType, string requesterId, string clientToken, string fields = null, string accessToken = null)

Change interaction type

Allows the user to change the interaction type. Boolean value

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class ChangeInteractionTypeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionId = 789;  // long? | interactionId
            var interactionType = interactionType_example;  // string | New interaction type
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)createdDate<br/>5)interactionType<br/><b>A) Available values-</b><br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)issuer<br/>5)noOfResponses<br/>6)isClosed<br/>7)createdDate<br/>8)lastUpdatedDate<br/>9)videoId<br/>10)fileURL<br/>11)isSubscribed<br/>12)sentiment</br>13)entity<br/>14)interactionType<br/>15)categoryId<br/>16)categoryName (optional)  (default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Change interaction type
                VerveResponseInteraction result = apiInstance.ChangeInteractionType(interactionId, interactionType, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.ChangeInteractionType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionId** | **long?**| interactionId | 
 **interactionType** | **string**| New interaction type | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)interactionType&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)issuer&lt;br/&gt;5)noOfResponses&lt;br/&gt;6)isClosed&lt;br/&gt;7)createdDate&lt;br/&gt;8)lastUpdatedDate&lt;br/&gt;9)videoId&lt;br/&gt;10)fileURL&lt;br/&gt;11)isSubscribed&lt;br/&gt;12)sentiment&lt;/br&gt;13)entity&lt;br/&gt;14)interactionType&lt;br/&gt;15)categoryId&lt;br/&gt;16)categoryName | [optional] [default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteraction**](VerveResponseInteraction.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createinteractioncategory"></a>
# **CreateInteractionCategory**
> VerveResponseInteractionCategory CreateInteractionCategory (string requesterId, string clientToken, InteractionCategory body = null, string accessToken = null)

Create interaction category

This service allows a user to create a category. The following fields(key:value) are required to be present in the Category JSON object. Refer to the Model & Model Schema of the expected JSON Object for the body of this API.</br><b>Required fields </br>1. associationId </br>2. categoryName </br>3. interactionType </br>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class CreateInteractionCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var body = new InteractionCategory(); // InteractionCategory |  (optional) 
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Create interaction category
                VerveResponseInteractionCategory result = apiInstance.CreateInteractionCategory(requesterId, clientToken, body, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.CreateInteractionCategory: " + e.Message );
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
 **body** | [**InteractionCategory**](InteractionCategory.md)|  | [optional] 
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionCategory**](VerveResponseInteractionCategory.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinteraction"></a>
# **DeleteInteraction**
> VerveResponseInteraction DeleteInteraction (long? interactionId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Delete interaction

Allows the user to delete a interaction. Returns the deleted response

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class DeleteInteractionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionId = 789;  // long? | interactionId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)createdDate<br/>5)interactionType<br/><b>A) Available values-</b><br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)issuer<br/>5)noOfResponses<br/>6)isClosed<br/>7)createdDate<br/>8)lastUpdatedDate<br/>9)videoId<br/>10)fileURL<br/>11)isSubscribed<br/>12)sentiment</br>13)entity<br/>14)interactionType<br/>15)categoryId<br/>16)categoryName (optional)  (default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Delete interaction
                VerveResponseInteraction result = apiInstance.DeleteInteraction(interactionId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.DeleteInteraction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionId** | **long?**| interactionId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)interactionType&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)issuer&lt;br/&gt;5)noOfResponses&lt;br/&gt;6)isClosed&lt;br/&gt;7)createdDate&lt;br/&gt;8)lastUpdatedDate&lt;br/&gt;9)videoId&lt;br/&gt;10)fileURL&lt;br/&gt;11)isSubscribed&lt;br/&gt;12)sentiment&lt;/br&gt;13)entity&lt;br/&gt;14)interactionType&lt;br/&gt;15)categoryId&lt;br/&gt;16)categoryName | [optional] [default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteraction**](VerveResponseInteraction.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinteractioncategory"></a>
# **DeleteInteractionCategory**
> VerveResponseInteractionCategory DeleteInteractionCategory (long? categoryId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Delete interaction category

Allows the user to delete the interaction category. Returns the deleted interaction category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class DeleteInteractionCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var categoryId = 789;  // long? | categoryId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)categoryId<br/>2)categoryName<br/>3)interactionType<br/><b>A) Available values -</b> <br/>1)categoryId<br/>2)categoryName<br/>3)categoryDescription<br/>4)createdDate<br/>5)isSubscribed<br/>6)interactionType (optional)  (default to categoryId,categoryName,interactionType)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Delete interaction category
                VerveResponseInteractionCategory result = apiInstance.DeleteInteractionCategory(categoryId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.DeleteInteractionCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryId** | **long?**| categoryId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)categoryId&lt;br/&gt;2)categoryName&lt;br/&gt;3)interactionType&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt; &lt;br/&gt;1)categoryId&lt;br/&gt;2)categoryName&lt;br/&gt;3)categoryDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)isSubscribed&lt;br/&gt;6)interactionType | [optional] [default to categoryId,categoryName,interactionType]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionCategory**](VerveResponseInteractionCategory.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteresponse"></a>
# **DeleteResponse**
> VerveResponseInteractionResponse DeleteResponse (long? responseId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Delete response

Allows the user to delete an response. Returns the deleted response

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class DeleteResponseExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var responseId = 789;  // long? | responseId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)responseId<br/>2)responseDescription<br/>3)createdDate<br/>4)interactionType<br/><b>A) Available values -</b><br/>1)responseId<br/>2)responseDescription<br/>3)createdDate<br/>4)interactionId<br/>5)respondingUser<br/>6)isMarkedResponse<br/>7)noOfLikes<br/>8)noOfDislikes<br/>9)replyCount<br/>10)isLiked<br/>11)isDisliked<br/>12)interactionType (optional)  (default to responseId,responseDescription,createdDate,interactionType)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Delete response
                VerveResponseInteractionResponse result = apiInstance.DeleteResponse(responseId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.DeleteResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **responseId** | **long?**| responseId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)responseId&lt;br/&gt;2)responseDescription&lt;br/&gt;3)createdDate&lt;br/&gt;4)interactionType&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt;&lt;br/&gt;1)responseId&lt;br/&gt;2)responseDescription&lt;br/&gt;3)createdDate&lt;br/&gt;4)interactionId&lt;br/&gt;5)respondingUser&lt;br/&gt;6)isMarkedResponse&lt;br/&gt;7)noOfLikes&lt;br/&gt;8)noOfDislikes&lt;br/&gt;9)replyCount&lt;br/&gt;10)isLiked&lt;br/&gt;11)isDisliked&lt;br/&gt;12)interactionType | [optional] [default to responseId,responseDescription,createdDate,interactionType]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionResponse**](VerveResponseInteractionResponse.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dislikeresponse"></a>
# **DislikeResponse**
> VerveResponseInteractionResponse DislikeResponse (long? interactionId, long? responseId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Dislike response

Allows the user to dislike the response.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class DislikeResponseExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionId = 789;  // long? | interactionId
            var responseId = 789;  // long? | responseId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)responseId<br/>2)responseDescription<br/>3)createdDate<br/>4)interactionType<br/><b>A) Available values -</b><br/>1)responseId<br/>2)responseDescription<br/>3)createdDate<br/>4)interactionId<br/>5)respondingUser<br/>6)isMarkedResponse<br/>7)noOfLikes<br/>8)noOfDislikes<br/>9)replyCount<br/>10)isLiked<br/>11)isDisliked<br/>12)interactionType (optional)  (default to responseId,responseDescription,createdDate,interactionType)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Dislike response
                VerveResponseInteractionResponse result = apiInstance.DislikeResponse(interactionId, responseId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.DislikeResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionId** | **long?**| interactionId | 
 **responseId** | **long?**| responseId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)responseId&lt;br/&gt;2)responseDescription&lt;br/&gt;3)createdDate&lt;br/&gt;4)interactionType&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt;&lt;br/&gt;1)responseId&lt;br/&gt;2)responseDescription&lt;br/&gt;3)createdDate&lt;br/&gt;4)interactionId&lt;br/&gt;5)respondingUser&lt;br/&gt;6)isMarkedResponse&lt;br/&gt;7)noOfLikes&lt;br/&gt;8)noOfDislikes&lt;br/&gt;9)replyCount&lt;br/&gt;10)isLiked&lt;br/&gt;11)isDisliked&lt;br/&gt;12)interactionType | [optional] [default to responseId,responseDescription,createdDate,interactionType]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionResponse**](VerveResponseInteractionResponse.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfriendsinteractions"></a>
# **GetFriendsInteractions**
> VerveResponseInteractionList GetFriendsInteractions (string interactionStatus, int? start, int? end, string requesterId, string clientToken, string interactionType = null, long? categoryId = null, string association = null, string fields = null, string accessToken = null)

Get list of interactions shared by friends

Returns the list of interactions shared by friends

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetFriendsInteractionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionStatus = interactionStatus_example;  // string | Interaction status <br/> 1) ALL <br/> 2)  UNREPLIED <br/> 3)  REPLIED <br/> 4)  CLOSED
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var interactionType = interactionType_example;  // string | Interaction Type (optional) 
            var categoryId = 789;  // long? | categoryId (optional) 
            var association = association_example;  // string | association (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)createdDate<br/>5)interactionType<br/><b>A) Available values-</b><br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)issuer<br/>5)noOfResponses<br/>6)isClosed<br/>7)createdDate<br/>8)lastUpdatedDate<br/>9)videoId<br/>10)fileURL<br/>11)isSubscribed<br/>12)sentiment</br>13)entity<br/>14)interactionType<br/>15)categoryId<br/>16)categoryName (optional)  (default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of interactions shared by friends
                VerveResponseInteractionList result = apiInstance.GetFriendsInteractions(interactionStatus, start, end, requesterId, clientToken, interactionType, categoryId, association, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.GetFriendsInteractions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionStatus** | **string**| Interaction status &lt;br/&gt; 1) ALL &lt;br/&gt; 2)  UNREPLIED &lt;br/&gt; 3)  REPLIED &lt;br/&gt; 4)  CLOSED | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **interactionType** | **string**| Interaction Type | [optional] 
 **categoryId** | **long?**| categoryId | [optional] 
 **association** | **string**| association | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)interactionType&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)issuer&lt;br/&gt;5)noOfResponses&lt;br/&gt;6)isClosed&lt;br/&gt;7)createdDate&lt;br/&gt;8)lastUpdatedDate&lt;br/&gt;9)videoId&lt;br/&gt;10)fileURL&lt;br/&gt;11)isSubscribed&lt;br/&gt;12)sentiment&lt;/br&gt;13)entity&lt;br/&gt;14)interactionType&lt;br/&gt;15)categoryId&lt;br/&gt;16)categoryName | [optional] [default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionList**](VerveResponseInteractionList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinteraction"></a>
# **GetInteraction**
> VerveResponseInteraction GetInteraction (long? interactionId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Get interaction by id

Returns the interaction by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetInteractionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionId = 789;  // long? | interactionId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)createdDate<br/>5)interactionType<br/><b>A) Available values-</b><br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)issuer<br/>5)noOfResponses<br/>6)isClosed<br/>7)createdDate<br/>8)lastUpdatedDate<br/>9)videoId<br/>10)fileURL<br/>11)isSubscribed<br/>12)sentiment</br>13)entity<br/>14)interactionType<br/>15)categoryId<br/>16)categoryName (optional)  (default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get interaction by id
                VerveResponseInteraction result = apiInstance.GetInteraction(interactionId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.GetInteraction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionId** | **long?**| interactionId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)interactionType&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)issuer&lt;br/&gt;5)noOfResponses&lt;br/&gt;6)isClosed&lt;br/&gt;7)createdDate&lt;br/&gt;8)lastUpdatedDate&lt;br/&gt;9)videoId&lt;br/&gt;10)fileURL&lt;br/&gt;11)isSubscribed&lt;br/&gt;12)sentiment&lt;/br&gt;13)entity&lt;br/&gt;14)interactionType&lt;br/&gt;15)categoryId&lt;br/&gt;16)categoryName | [optional] [default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteraction**](VerveResponseInteraction.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinteractioncategories"></a>
# **GetInteractionCategories**
> VerveResponseInteractionCategoryList GetInteractionCategories (int? start, int? end, string requesterId, string clientToken, string interactionType = null, string association = null, string fields = null, string accessToken = null)

Get the list of interaction categories

Returns the list of interaction categories

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetInteractionCategoriesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var interactionType = interactionType_example;  // string | Interaction Type (optional) 
            var association = association_example;  // string | association (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)categoryId<br/>2)categoryName<br/>3)interactionType<br/><b>A) Available values -</b> <br/>1)categoryId<br/>2)categoryName<br/>3)categoryDescription<br/>4)createdDate<br/>5)isSubscribed<br/>6)interactionType (optional)  (default to categoryId,categoryName,interactionType)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get the list of interaction categories
                VerveResponseInteractionCategoryList result = apiInstance.GetInteractionCategories(start, end, requesterId, clientToken, interactionType, association, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.GetInteractionCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **interactionType** | **string**| Interaction Type | [optional] 
 **association** | **string**| association | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)categoryId&lt;br/&gt;2)categoryName&lt;br/&gt;3)interactionType&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt; &lt;br/&gt;1)categoryId&lt;br/&gt;2)categoryName&lt;br/&gt;3)categoryDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)isSubscribed&lt;br/&gt;6)interactionType | [optional] [default to categoryId,categoryName,interactionType]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionCategoryList**](VerveResponseInteractionCategoryList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinteractionsforuser"></a>
# **GetInteractionsForUser**
> VerveResponseInteractionList GetInteractionsForUser (string interactionStatus, int? start, int? end, string requesterId, string clientToken, long? categoryId = null, string interactionType = null, string association = null, string fields = null, string accessToken = null)

Get list of all interactions visible to the user

Returns the list of all interactions visible to the user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetInteractionsForUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionStatus = interactionStatus_example;  // string | Interaction status <br/> 1) ALL <br/> 2)  UNREPLIED <br/> 3)  REPLIED <br/> 4)  CLOSED
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var categoryId = 789;  // long? | categoryId (optional) 
            var interactionType = interactionType_example;  // string | Interaction Type (optional) 
            var association = association_example;  // string | association (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)createdDate<br/>5)interactionType<br/><b>A) Available values-</b><br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)issuer<br/>5)noOfResponses<br/>6)isClosed<br/>7)createdDate<br/>8)lastUpdatedDate<br/>9)videoId<br/>10)fileURL<br/>11)isSubscribed<br/>12)sentiment</br>13)entity<br/>14)interactionType<br/>15)categoryId<br/>16)categoryName (optional)  (default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of all interactions visible to the user
                VerveResponseInteractionList result = apiInstance.GetInteractionsForUser(interactionStatus, start, end, requesterId, clientToken, categoryId, interactionType, association, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.GetInteractionsForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionStatus** | **string**| Interaction status &lt;br/&gt; 1) ALL &lt;br/&gt; 2)  UNREPLIED &lt;br/&gt; 3)  REPLIED &lt;br/&gt; 4)  CLOSED | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **categoryId** | **long?**| categoryId | [optional] 
 **interactionType** | **string**| Interaction Type | [optional] 
 **association** | **string**| association | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)interactionType&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)issuer&lt;br/&gt;5)noOfResponses&lt;br/&gt;6)isClosed&lt;br/&gt;7)createdDate&lt;br/&gt;8)lastUpdatedDate&lt;br/&gt;9)videoId&lt;br/&gt;10)fileURL&lt;br/&gt;11)isSubscribed&lt;br/&gt;12)sentiment&lt;/br&gt;13)entity&lt;br/&gt;14)interactionType&lt;br/&gt;15)categoryId&lt;br/&gt;16)categoryName | [optional] [default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionList**](VerveResponseInteractionList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecommendinteractions"></a>
# **GetRecommendInteractions**
> VerveResponseInteractionList GetRecommendInteractions (int? start, int? end, string requesterId, string clientToken, string interactionType = null, string association = null, string fields = null, string accessToken = null)

Get list of recommended interactions

Returns the list of recommended interactions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetRecommendInteractionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var interactionType = interactionType_example;  // string | interactionType (optional) 
            var association = association_example;  // string | association (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)createdDate<br/>5)interactionType<br/><b>A) Available values-</b><br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)issuer<br/>5)noOfResponses<br/>6)isClosed<br/>7)createdDate<br/>8)lastUpdatedDate<br/>9)videoId<br/>10)fileURL<br/>11)isSubscribed<br/>12)sentiment</br>13)entity<br/>14)interactionType<br/>15)categoryId<br/>16)categoryName (optional)  (default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of recommended interactions
                VerveResponseInteractionList result = apiInstance.GetRecommendInteractions(start, end, requesterId, clientToken, interactionType, association, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.GetRecommendInteractions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **interactionType** | **string**| interactionType | [optional] 
 **association** | **string**| association | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)interactionType&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)issuer&lt;br/&gt;5)noOfResponses&lt;br/&gt;6)isClosed&lt;br/&gt;7)createdDate&lt;br/&gt;8)lastUpdatedDate&lt;br/&gt;9)videoId&lt;br/&gt;10)fileURL&lt;br/&gt;11)isSubscribed&lt;br/&gt;12)sentiment&lt;/br&gt;13)entity&lt;br/&gt;14)interactionType&lt;br/&gt;15)categoryId&lt;br/&gt;16)categoryName | [optional] [default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionList**](VerveResponseInteractionList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecommendedinteractinsfromdb"></a>
# **GetRecommendedInteractinsFromDB**
> VerveResponseInteractionList GetRecommendedInteractinsFromDB (long? userId, int? start, int? end, string requesterId, string clientToken, string interactionType = null, string association = null, string fields = null, string accessToken = null)

Get list of recommended interactions from DB

Returns the list of recommended interactions from DB

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetRecommendedInteractinsFromDBExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var userId = 789;  // long? | User Id whose recommended interactions want to get
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var interactionType = interactionType_example;  // string | Interaction Type (optional) 
            var association = association_example;  // string | association (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)createdDate<br/>5)interactionType<br/><b>A) Available values-</b><br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)issuer<br/>5)noOfResponses<br/>6)isClosed<br/>7)createdDate<br/>8)lastUpdatedDate<br/>9)videoId<br/>10)fileURL<br/>11)isSubscribed<br/>12)sentiment</br>13)entity<br/>14)interactionType<br/>15)categoryId<br/>16)categoryName (optional)  (default to interactionId,interactionTitle,interactionDescription,createdDate,,interactionType)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of recommended interactions from DB
                VerveResponseInteractionList result = apiInstance.GetRecommendedInteractinsFromDB(userId, start, end, requesterId, clientToken, interactionType, association, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.GetRecommendedInteractinsFromDB: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| User Id whose recommended interactions want to get | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **interactionType** | **string**| Interaction Type | [optional] 
 **association** | **string**| association | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)interactionType&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)issuer&lt;br/&gt;5)noOfResponses&lt;br/&gt;6)isClosed&lt;br/&gt;7)createdDate&lt;br/&gt;8)lastUpdatedDate&lt;br/&gt;9)videoId&lt;br/&gt;10)fileURL&lt;br/&gt;11)isSubscribed&lt;br/&gt;12)sentiment&lt;/br&gt;13)entity&lt;br/&gt;14)interactionType&lt;br/&gt;15)categoryId&lt;br/&gt;16)categoryName | [optional] [default to interactionId,interactionTitle,interactionDescription,createdDate,,interactionType]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionList**](VerveResponseInteractionList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecommendedusersfromdb"></a>
# **GetRecommendedUsersFromDB**
> VerveResponseUserList GetRecommendedUsersFromDB (long? interactionId, int? start, int? end, string requesterId, string clientToken, string association = null, string fields = null, string accessToken = null)

Get list of recommended Users from DB

Returns the list of recommended users from DB

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetRecommendedUsersFromDBExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionId = 789;  // long? | interactionId
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var association = association_example;  // string | association (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)userId<br/>2)firstName<br/>3)lastName<br/>4)profileImage<br/><b>A) Available values-</b><br/>1)userId<br/>2)firstName<br/>3)lastName<br/>4)emailId<br/>5)profileImage<br/>6)birthDate<br/> (optional)  (default to userId,firstName,lastName)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of recommended Users from DB
                VerveResponseUserList result = apiInstance.GetRecommendedUsersFromDB(interactionId, start, end, requesterId, clientToken, association, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.GetRecommendedUsersFromDB: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionId** | **long?**| interactionId | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **association** | **string**| association | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)userId&lt;br/&gt;2)firstName&lt;br/&gt;3)lastName&lt;br/&gt;4)profileImage&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)userId&lt;br/&gt;2)firstName&lt;br/&gt;3)lastName&lt;br/&gt;4)emailId&lt;br/&gt;5)profileImage&lt;br/&gt;6)birthDate&lt;br/&gt; | [optional] [default to userId,firstName,lastName]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseUserList**](VerveResponseUserList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresponses"></a>
# **GetResponses**
> VerveResponseInteractionResponseList GetResponses (long? interactionId, int? start, int? end, string requesterId, string clientToken, string fields = null, string accessToken = null)

Get list of responses by interactionId

Returns the list of responses by interactionId

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetResponsesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionId = 789;  // long? | interactionId
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)responseId<br/>2)responseDescription<br/>3)createdDate<br/>4)interactionType<br/><b>A) Available values -</b><br/>1)responseId<br/>2)responseDescription<br/>3)createdDate<br/>4)interactionId<br/>5)respondingUser<br/>6)isMarkedResponse<br/>7)noOfLikes<br/>8)noOfDislikes<br/>9)replyCount<br/>10)isLiked<br/>11)isDisliked<br/>12)interactionType (optional)  (default to responseId,responseDescription,createdDate,interactionType)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of responses by interactionId
                VerveResponseInteractionResponseList result = apiInstance.GetResponses(interactionId, start, end, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.GetResponses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionId** | **long?**| interactionId | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)responseId&lt;br/&gt;2)responseDescription&lt;br/&gt;3)createdDate&lt;br/&gt;4)interactionType&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt;&lt;br/&gt;1)responseId&lt;br/&gt;2)responseDescription&lt;br/&gt;3)createdDate&lt;br/&gt;4)interactionId&lt;br/&gt;5)respondingUser&lt;br/&gt;6)isMarkedResponse&lt;br/&gt;7)noOfLikes&lt;br/&gt;8)noOfDislikes&lt;br/&gt;9)replyCount&lt;br/&gt;10)isLiked&lt;br/&gt;11)isDisliked&lt;br/&gt;12)interactionType | [optional] [default to responseId,responseDescription,createdDate,interactionType]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionResponseList**](VerveResponseInteractionResponseList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserinteractions"></a>
# **GetUserInteractions**
> VerveResponseInteractionList GetUserInteractions (long? userId, string interactionStatus, int? start, int? end, string requesterId, string clientToken, long? categoryId = null, string interactionType = null, string association = null, string fields = null, string accessToken = null)

Get list of interactions shared by user

Returns the list of interactions shared by specific user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserInteractionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var userId = 789;  // long? | userId whose shared interactions want to get
            var interactionStatus = interactionStatus_example;  // string | Interaction status <br/> 1) ALL <br/> 2)  UNREPLIED <br/> 3)  REPLIED <br/> 4)  CLOSED
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var categoryId = 789;  // long? | categoryId (optional) 
            var interactionType = interactionType_example;  // string | Interaction Type (optional) 
            var association = association_example;  // string | association (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)createdDate<br/>5)interactionType<br/><b>A) Available values-</b><br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)issuer<br/>5)noOfResponses<br/>6)isClosed<br/>7)createdDate<br/>8)lastUpdatedDate<br/>9)videoId<br/>10)fileURL<br/>11)isSubscribed<br/>12)sentiment</br>13)entity<br/>14)interactionType<br/>15)categoryId<br/>16)categoryName (optional)  (default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of interactions shared by user
                VerveResponseInteractionList result = apiInstance.GetUserInteractions(userId, interactionStatus, start, end, requesterId, clientToken, categoryId, interactionType, association, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.GetUserInteractions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| userId whose shared interactions want to get | 
 **interactionStatus** | **string**| Interaction status &lt;br/&gt; 1) ALL &lt;br/&gt; 2)  UNREPLIED &lt;br/&gt; 3)  REPLIED &lt;br/&gt; 4)  CLOSED | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **categoryId** | **long?**| categoryId | [optional] 
 **interactionType** | **string**| Interaction Type | [optional] 
 **association** | **string**| association | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)interactionType&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)issuer&lt;br/&gt;5)noOfResponses&lt;br/&gt;6)isClosed&lt;br/&gt;7)createdDate&lt;br/&gt;8)lastUpdatedDate&lt;br/&gt;9)videoId&lt;br/&gt;10)fileURL&lt;br/&gt;11)isSubscribed&lt;br/&gt;12)sentiment&lt;/br&gt;13)entity&lt;br/&gt;14)interactionType&lt;br/&gt;15)categoryId&lt;br/&gt;16)categoryName | [optional] [default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionList**](VerveResponseInteractionList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersubscribedinteractioncategories"></a>
# **GetUserSubscribedInteractionCategories**
> VerveResponseInteractionCategoryList GetUserSubscribedInteractionCategories (long? userId, int? start, int? end, string requesterId, string clientToken, string interactionType = null, string association = null, string fields = null, string accessToken = null)

Get list of interaction categories subscribed by the user

Returns the list of interaction categories subscribed by the user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserSubscribedInteractionCategoriesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var userId = 789;  // long? | User Id whose subcripbed category want to get
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var interactionType = interactionType_example;  // string | interactionType (optional) 
            var association = association_example;  // string | association (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)categoryId<br/>2)categoryName<br/>3)interactionType<br/><b>A) Available values -</b> <br/>1)categoryId<br/>2)categoryName<br/>3)categoryDescription<br/>4)createdDate<br/>5)isSubscribed<br/>6)interactionType (optional)  (default to categoryId,categoryName,interactionType)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of interaction categories subscribed by the user
                VerveResponseInteractionCategoryList result = apiInstance.GetUserSubscribedInteractionCategories(userId, start, end, requesterId, clientToken, interactionType, association, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.GetUserSubscribedInteractionCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| User Id whose subcripbed category want to get | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **interactionType** | **string**| interactionType | [optional] 
 **association** | **string**| association | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)categoryId&lt;br/&gt;2)categoryName&lt;br/&gt;3)interactionType&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt; &lt;br/&gt;1)categoryId&lt;br/&gt;2)categoryName&lt;br/&gt;3)categoryDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)isSubscribed&lt;br/&gt;6)interactionType | [optional] [default to categoryId,categoryName,interactionType]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionCategoryList**](VerveResponseInteractionCategoryList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersubscribedinteractions"></a>
# **GetUserSubscribedInteractions**
> VerveResponseInteractionList GetUserSubscribedInteractions (long? userId, string interactionStatus, int? start, int? end, string requesterId, string clientToken, long? categoryId = null, string interactionType = null, string association = null, string fields = null, string accessToken = null)

Get list of interactions subscribed by user

Returns the list of interactions subscribed by specific user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class GetUserSubscribedInteractionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var userId = 789;  // long? | User Id whose subcribed interactions wants to get
            var interactionStatus = interactionStatus_example;  // string | Interaction status <br/> 1) ALL <br/> 2)  UNREPLIED <br/> 3)  REPLIED <br/> 4)  CLOSED
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var categoryId = 789;  // long? | categoryId (optional) 
            var interactionType = interactionType_example;  // string | Interaction Type (optional) 
            var association = association_example;  // string | association (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)createdDate<br/>5)interactionType<br/><b>A) Available values-</b><br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)issuer<br/>5)noOfResponses<br/>6)isClosed<br/>7)createdDate<br/>8)lastUpdatedDate<br/>9)videoId<br/>10)fileURL<br/>11)isSubscribed<br/>12)sentiment</br>13)entity<br/>14)interactionType<br/>15)categoryId<br/>16)categoryName (optional)  (default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of interactions subscribed by user
                VerveResponseInteractionList result = apiInstance.GetUserSubscribedInteractions(userId, interactionStatus, start, end, requesterId, clientToken, categoryId, interactionType, association, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.GetUserSubscribedInteractions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| User Id whose subcribed interactions wants to get | 
 **interactionStatus** | **string**| Interaction status &lt;br/&gt; 1) ALL &lt;br/&gt; 2)  UNREPLIED &lt;br/&gt; 3)  REPLIED &lt;br/&gt; 4)  CLOSED | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **categoryId** | **long?**| categoryId | [optional] 
 **interactionType** | **string**| Interaction Type | [optional] 
 **association** | **string**| association | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)interactionType&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)issuer&lt;br/&gt;5)noOfResponses&lt;br/&gt;6)isClosed&lt;br/&gt;7)createdDate&lt;br/&gt;8)lastUpdatedDate&lt;br/&gt;9)videoId&lt;br/&gt;10)fileURL&lt;br/&gt;11)isSubscribed&lt;br/&gt;12)sentiment&lt;/br&gt;13)entity&lt;br/&gt;14)interactionType&lt;br/&gt;15)categoryId&lt;br/&gt;16)categoryName | [optional] [default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionList**](VerveResponseInteractionList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="likeresponse"></a>
# **LikeResponse**
> VerveResponseInteractionResponse LikeResponse (long? interactionId, long? responseId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Like response

Allows the user to like the response.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class LikeResponseExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionId = 789;  // long? | interactionId
            var responseId = 789;  // long? | responseId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)responseId<br/>2)responseDescription<br/>3)createdDate<br/>4)interactionType<br/><b>A) Available values -</b><br/>1)responseId<br/>2)responseDescription<br/>3)createdDate<br/>4)interactionId<br/>5)respondingUser<br/>6)isMarkedResponse<br/>7)noOfLikes<br/>8)noOfDislikes<br/>9)replyCount<br/>10)isLiked<br/>11)isDisliked<br/>12)interactionType (optional)  (default to responseId,responseDescription,createdDate,interactionType)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Like response
                VerveResponseInteractionResponse result = apiInstance.LikeResponse(interactionId, responseId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.LikeResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionId** | **long?**| interactionId | 
 **responseId** | **long?**| responseId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)responseId&lt;br/&gt;2)responseDescription&lt;br/&gt;3)createdDate&lt;br/&gt;4)interactionType&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt;&lt;br/&gt;1)responseId&lt;br/&gt;2)responseDescription&lt;br/&gt;3)createdDate&lt;br/&gt;4)interactionId&lt;br/&gt;5)respondingUser&lt;br/&gt;6)isMarkedResponse&lt;br/&gt;7)noOfLikes&lt;br/&gt;8)noOfDislikes&lt;br/&gt;9)replyCount&lt;br/&gt;10)isLiked&lt;br/&gt;11)isDisliked&lt;br/&gt;12)interactionType | [optional] [default to responseId,responseDescription,createdDate,interactionType]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionResponse**](VerveResponseInteractionResponse.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="markasanresponse"></a>
# **MarkAsAnResponse**
> VerveResponseInteractionResponse MarkAsAnResponse (long? interactionId, long? responseId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Mark response as a response

Marks the response as accepted. This means the user is satisfied with the response & then the interaction will go into closed state

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class MarkAsAnResponseExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionId = 789;  // long? | interactionId
            var responseId = 789;  // long? | responseId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)responseId<br/>2)responseDescription<br/>3)createdDate<br/>4)interactionType<br/><b>A) Available values -</b><br/>1)responseId<br/>2)responseDescription<br/>3)createdDate<br/>4)interactionId<br/>5)respondingUser<br/>6)isMarkedResponse<br/>7)noOfLikes<br/>8)noOfDislikes<br/>9)replyCount<br/>10)isLiked<br/>11)isDisliked<br/>12)interactionType (optional)  (default to responseId,responseDescription,createdDate,interactionType)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Mark response as a response
                VerveResponseInteractionResponse result = apiInstance.MarkAsAnResponse(interactionId, responseId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.MarkAsAnResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionId** | **long?**| interactionId | 
 **responseId** | **long?**| responseId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)responseId&lt;br/&gt;2)responseDescription&lt;br/&gt;3)createdDate&lt;br/&gt;4)interactionType&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt;&lt;br/&gt;1)responseId&lt;br/&gt;2)responseDescription&lt;br/&gt;3)createdDate&lt;br/&gt;4)interactionId&lt;br/&gt;5)respondingUser&lt;br/&gt;6)isMarkedResponse&lt;br/&gt;7)noOfLikes&lt;br/&gt;8)noOfDislikes&lt;br/&gt;9)replyCount&lt;br/&gt;10)isLiked&lt;br/&gt;11)isDisliked&lt;br/&gt;12)interactionType | [optional] [default to responseId,responseDescription,createdDate,interactionType]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionResponse**](VerveResponseInteractionResponse.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchinteractions"></a>
# **SearchInteractions**
> VerveResponseInteractionList SearchInteractions (string searchText, string interactionStatus, int? start, int? end, string requesterId, string clientToken, string interactionType = null, string association = null, string fields = null, string accessToken = null)

Get list of matching interactions

Returns the list of matching interactions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class SearchInteractionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var searchText = searchText_example;  // string | Search Text, keywords to search
            var interactionStatus = interactionStatus_example;  // string | Interaction status <br/> 1) ALL <br/> 2)  UNREPLIED <br/> 3)  REPLIED <br/> 4)  CLOSED
            var start = 56;  // int? | start, initial value start from 0
            var end = 56;  // int? | end
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var interactionType = interactionType_example;  // string | Interaction Type (optional) 
            var association = association_example;  // string | association (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)createdDate<br/>5)interactionType<br/><b>A) Available values-</b><br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)issuer<br/>5)noOfResponses<br/>6)isClosed<br/>7)createdDate<br/>8)lastUpdatedDate<br/>9)videoId<br/>10)fileURL<br/>11)isSubscribed<br/>12)sentiment</br>13)entity<br/>14)interactionType<br/>15)categoryId<br/>16)categoryName (optional)  (default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Get list of matching interactions
                VerveResponseInteractionList result = apiInstance.SearchInteractions(searchText, interactionStatus, start, end, requesterId, clientToken, interactionType, association, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.SearchInteractions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchText** | **string**| Search Text, keywords to search | 
 **interactionStatus** | **string**| Interaction status &lt;br/&gt; 1) ALL &lt;br/&gt; 2)  UNREPLIED &lt;br/&gt; 3)  REPLIED &lt;br/&gt; 4)  CLOSED | 
 **start** | **int?**| start, initial value start from 0 | 
 **end** | **int?**| end | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **interactionType** | **string**| Interaction Type | [optional] 
 **association** | **string**| association | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)interactionType&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)issuer&lt;br/&gt;5)noOfResponses&lt;br/&gt;6)isClosed&lt;br/&gt;7)createdDate&lt;br/&gt;8)lastUpdatedDate&lt;br/&gt;9)videoId&lt;br/&gt;10)fileURL&lt;br/&gt;11)isSubscribed&lt;br/&gt;12)sentiment&lt;/br&gt;13)entity&lt;br/&gt;14)interactionType&lt;br/&gt;15)categoryId&lt;br/&gt;16)categoryName | [optional] [default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionList**](VerveResponseInteractionList.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscribeinteractincategory"></a>
# **SubscribeInteractinCategory**
> VerveResponseInteractionCategory SubscribeInteractinCategory (long? categoryId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Subscribe interaction category

Returns the subscribed interaction category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class SubscribeInteractinCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var categoryId = 789;  // long? | categoryId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)categoryId<br/>2)categoryName<br/>3)interactionType<br/><b>A) Available values -</b> <br/>1)categoryId<br/>2)categoryName<br/>3)categoryDescription<br/>4)createdDate<br/>5)isSubscribed<br/>6)interactionType (optional)  (default to categoryId,categoryName,interactionType)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Subscribe interaction category
                VerveResponseInteractionCategory result = apiInstance.SubscribeInteractinCategory(categoryId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.SubscribeInteractinCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryId** | **long?**| categoryId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)categoryId&lt;br/&gt;2)categoryName&lt;br/&gt;3)interactionType&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt; &lt;br/&gt;1)categoryId&lt;br/&gt;2)categoryName&lt;br/&gt;3)categoryDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)isSubscribed&lt;br/&gt;6)interactionType | [optional] [default to categoryId,categoryName,interactionType]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionCategory**](VerveResponseInteractionCategory.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscribeinteraction"></a>
# **SubscribeInteraction**
> VerveResponseInteraction SubscribeInteraction (long? interactionId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Subscribe interaction

Allows the user to subscribe a interaction

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class SubscribeInteractionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionId = 789;  // long? | interactionId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)createdDate<br/>5)interactionType<br/><b>A) Available values-</b><br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)issuer<br/>5)noOfResponses<br/>6)isClosed<br/>7)createdDate<br/>8)lastUpdatedDate<br/>9)videoId<br/>10)fileURL<br/>11)isSubscribed<br/>12)sentiment</br>13)entity<br/>14)interactionType<br/>15)categoryId<br/>16)categoryName (optional)  (default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Subscribe interaction
                VerveResponseInteraction result = apiInstance.SubscribeInteraction(interactionId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.SubscribeInteraction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionId** | **long?**| interactionId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)interactionType&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)issuer&lt;br/&gt;5)noOfResponses&lt;br/&gt;6)isClosed&lt;br/&gt;7)createdDate&lt;br/&gt;8)lastUpdatedDate&lt;br/&gt;9)videoId&lt;br/&gt;10)fileURL&lt;br/&gt;11)isSubscribed&lt;br/&gt;12)sentiment&lt;/br&gt;13)entity&lt;br/&gt;14)interactionType&lt;br/&gt;15)categoryId&lt;br/&gt;16)categoryName | [optional] [default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteraction**](VerveResponseInteraction.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unmarkasanresponse"></a>
# **UnmarkAsAnResponse**
> VerveResponseInteractionResponse UnmarkAsAnResponse (long? interactionId, long? responseId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Unmark response as a response

Unmarks the response. This will remove the marked response.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UnmarkAsAnResponseExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionId = 789;  // long? | interactionId
            var responseId = 789;  // long? | responseId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)responseId<br/>2)responseDescription<br/>3)createdDate<br/>4)interactionType<br/><b>A) Available values -</b><br/>1)responseId<br/>2)responseDescription<br/>3)createdDate<br/>4)interactionId<br/>5)respondingUser<br/>6)isMarkedResponse<br/>7)noOfLikes<br/>8)noOfDislikes<br/>9)replyCount<br/>10)isLiked<br/>11)isDisliked<br/>12)interactionType (optional)  (default to responseId,responseDescription,createdDate,interactionType)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Unmark response as a response
                VerveResponseInteractionResponse result = apiInstance.UnmarkAsAnResponse(interactionId, responseId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.UnmarkAsAnResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionId** | **long?**| interactionId | 
 **responseId** | **long?**| responseId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)responseId&lt;br/&gt;2)responseDescription&lt;br/&gt;3)createdDate&lt;br/&gt;4)interactionType&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt;&lt;br/&gt;1)responseId&lt;br/&gt;2)responseDescription&lt;br/&gt;3)createdDate&lt;br/&gt;4)interactionId&lt;br/&gt;5)respondingUser&lt;br/&gt;6)isMarkedResponse&lt;br/&gt;7)noOfLikes&lt;br/&gt;8)noOfDislikes&lt;br/&gt;9)replyCount&lt;br/&gt;10)isLiked&lt;br/&gt;11)isDisliked&lt;br/&gt;12)interactionType | [optional] [default to responseId,responseDescription,createdDate,interactionType]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionResponse**](VerveResponseInteractionResponse.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unsubscribeinteractincategory"></a>
# **UnsubscribeInteractinCategory**
> VerveResponseInteractionCategory UnsubscribeInteractinCategory (long? categoryId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Unsubscribe interaction category

Returns the unsubscribed interaction category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UnsubscribeInteractinCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var categoryId = 789;  // long? | categoryId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)categoryId<br/>2)categoryName<br/>3)interactionType<br/><b>A) Available values -</b> <br/>1)categoryId<br/>2)categoryName<br/>3)categoryDescription<br/>4)createdDate<br/>5)isSubscribed<br/>6)interactionType (optional)  (default to categoryId,categoryName,interactionType)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Unsubscribe interaction category
                VerveResponseInteractionCategory result = apiInstance.UnsubscribeInteractinCategory(categoryId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.UnsubscribeInteractinCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryId** | **long?**| categoryId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)categoryId&lt;br/&gt;2)categoryName&lt;br/&gt;3)interactionType&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt; &lt;br/&gt;1)categoryId&lt;br/&gt;2)categoryName&lt;br/&gt;3)categoryDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)isSubscribed&lt;br/&gt;6)interactionType | [optional] [default to categoryId,categoryName,interactionType]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionCategory**](VerveResponseInteractionCategory.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unsubscribeinteraction"></a>
# **UnsubscribeInteraction**
> VerveResponseInteraction UnsubscribeInteraction (long? interactionId, string requesterId, string clientToken, string fields = null, string accessToken = null)

Unsubscribe interaction

Allows the user to unsubscribe a interaction

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UnsubscribeInteractionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionId = 789;  // long? | interactionId
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)createdDate<br/>5)interactionType<br/><b>A) Available values-</b><br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)issuer<br/>5)noOfResponses<br/>6)isClosed<br/>7)createdDate<br/>8)lastUpdatedDate<br/>9)videoId<br/>10)fileURL<br/>11)isSubscribed<br/>12)sentiment</br>13)entity<br/>14)interactionType<br/>15)categoryId<br/>16)categoryName (optional)  (default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Unsubscribe interaction
                VerveResponseInteraction result = apiInstance.UnsubscribeInteraction(interactionId, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.UnsubscribeInteraction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionId** | **long?**| interactionId | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)interactionType&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)issuer&lt;br/&gt;5)noOfResponses&lt;br/&gt;6)isClosed&lt;br/&gt;7)createdDate&lt;br/&gt;8)lastUpdatedDate&lt;br/&gt;9)videoId&lt;br/&gt;10)fileURL&lt;br/&gt;11)isSubscribed&lt;br/&gt;12)sentiment&lt;/br&gt;13)entity&lt;br/&gt;14)interactionType&lt;br/&gt;15)categoryId&lt;br/&gt;16)categoryName | [optional] [default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteraction**](VerveResponseInteraction.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinteraction"></a>
# **UpdateInteraction**
> VerveResponseInteraction UpdateInteraction (long? interactionId, string interactionTitle, string requesterId, string clientToken, string interactionDescription = null, string fields = null, string accessToken = null)

Update interaction

Allows the user to update interaction. Returns the updated interaction

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UpdateInteractionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var interactionId = 789;  // long? | interactionId
            var interactionTitle = interactionTitle_example;  // string | Interaction Title
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var interactionDescription = interactionDescription_example;  // string | Describe Interaction (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)createdDate<br/>5)interactionType<br/><b>A) Available values-</b><br/>1)interactionId<br/>2)interactionTitle<br/>3)interactionDescription<br/>4)issuer<br/>5)noOfResponses<br/>6)isClosed<br/>7)createdDate<br/>8)lastUpdatedDate<br/>9)videoId<br/>10)fileURL<br/>11)isSubscribed<br/>12)sentiment</br>13)entity<br/>14)interactionType<br/>15)categoryId<br/>16)categoryName (optional)  (default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Update interaction
                VerveResponseInteraction result = apiInstance.UpdateInteraction(interactionId, interactionTitle, requesterId, clientToken, interactionDescription, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.UpdateInteraction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionId** | **long?**| interactionId | 
 **interactionTitle** | **string**| Interaction Title | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **interactionDescription** | **string**| Describe Interaction | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)interactionType&lt;br/&gt;&lt;b&gt;A) Available values-&lt;/b&gt;&lt;br/&gt;1)interactionId&lt;br/&gt;2)interactionTitle&lt;br/&gt;3)interactionDescription&lt;br/&gt;4)issuer&lt;br/&gt;5)noOfResponses&lt;br/&gt;6)isClosed&lt;br/&gt;7)createdDate&lt;br/&gt;8)lastUpdatedDate&lt;br/&gt;9)videoId&lt;br/&gt;10)fileURL&lt;br/&gt;11)isSubscribed&lt;br/&gt;12)sentiment&lt;/br&gt;13)entity&lt;br/&gt;14)interactionType&lt;br/&gt;15)categoryId&lt;br/&gt;16)categoryName | [optional] [default to interactionId,interactionTitle,interactionDescription,createdDate,interactionType,categoryName]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteraction**](VerveResponseInteraction.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinteractioncategory"></a>
# **UpdateInteractionCategory**
> VerveResponseInteractionCategory UpdateInteractionCategory (long? categoryId, string categoryName, string requesterId, string clientToken, string categoryDescription = null, string fields = null, string accessToken = null)

Update interaction category

Allows the user to update the interaction category. Returns the updated interaction category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UpdateInteractionCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var categoryId = 789;  // long? | categoryId
            var categoryName = categoryName_example;  // string | Category Name
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var categoryDescription = categoryDescription_example;  // string | Describe category (optional) 
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)categoryId<br/>2)categoryName<br/>3)interactionType<br/><b>A) Available values -</b> <br/>1)categoryId<br/>2)categoryName<br/>3)categoryDescription<br/>4)createdDate<br/>5)isSubscribed<br/>6)interactionType (optional)  (default to categoryId,categoryName,interactionType)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Update interaction category
                VerveResponseInteractionCategory result = apiInstance.UpdateInteractionCategory(categoryId, categoryName, requesterId, clientToken, categoryDescription, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.UpdateInteractionCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryId** | **long?**| categoryId | 
 **categoryName** | **string**| Category Name | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **categoryDescription** | **string**| Describe category | [optional] 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)categoryId&lt;br/&gt;2)categoryName&lt;br/&gt;3)interactionType&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt; &lt;br/&gt;1)categoryId&lt;br/&gt;2)categoryName&lt;br/&gt;3)categoryDescription&lt;br/&gt;4)createdDate&lt;br/&gt;5)isSubscribed&lt;br/&gt;6)interactionType | [optional] [default to categoryId,categoryName,interactionType]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionCategory**](VerveResponseInteractionCategory.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateresponse"></a>
# **UpdateResponse**
> VerveResponseInteractionResponse UpdateResponse (long? responseId, string response, string requesterId, string clientToken, string fields = null, string accessToken = null)

Update response

Allows the user to update an response. Returns the updated response

### Example
```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class UpdateResponseExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var responseId = 789;  // long? | responseId
            var response = response_example;  // string | response
            var requesterId = requesterId_example;  // string | requesterId can be user id OR email address.
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs
            var fields = fields_example;  // string | Filter fields in result list<br/> <b>A) Default values -</b> <br/>1)responseId<br/>2)responseDescription<br/>3)createdDate<br/>4)interactionType<br/><b>A) Available values -</b><br/>1)responseId<br/>2)responseDescription<br/>3)createdDate<br/>4)interactionId<br/>5)respondingUser<br/>6)isMarkedResponse<br/>7)noOfLikes<br/>8)noOfDislikes<br/>9)replyCount<br/>10)isLiked<br/>11)isDisliked<br/>12)interactionType (optional)  (default to responseId,responseDescription,createdDate,interactionType)
            var accessToken = accessToken_example;  // string | Unique session token for user. To get access token user will have to authenticate (optional) 

            try
            {
                // Update response
                VerveResponseInteractionResponse result = apiInstance.UpdateResponse(responseId, response, requesterId, clientToken, fields, accessToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.UpdateResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **responseId** | **long?**| responseId | 
 **response** | **string**| response | 
 **requesterId** | **string**| requesterId can be user id OR email address. | 
 **clientToken** | **string**| Use the Client Token. Please generate it from the Applications section under the Production &amp; Sandbox tabs | 
 **fields** | **string**| Filter fields in result list&lt;br/&gt; &lt;b&gt;A) Default values -&lt;/b&gt; &lt;br/&gt;1)responseId&lt;br/&gt;2)responseDescription&lt;br/&gt;3)createdDate&lt;br/&gt;4)interactionType&lt;br/&gt;&lt;b&gt;A) Available values -&lt;/b&gt;&lt;br/&gt;1)responseId&lt;br/&gt;2)responseDescription&lt;br/&gt;3)createdDate&lt;br/&gt;4)interactionId&lt;br/&gt;5)respondingUser&lt;br/&gt;6)isMarkedResponse&lt;br/&gt;7)noOfLikes&lt;br/&gt;8)noOfDislikes&lt;br/&gt;9)replyCount&lt;br/&gt;10)isLiked&lt;br/&gt;11)isDisliked&lt;br/&gt;12)interactionType | [optional] [default to responseId,responseDescription,createdDate,interactionType]
 **accessToken** | **string**| Unique session token for user. To get access token user will have to authenticate | [optional] 

### Return type

[**VerveResponseInteractionResponse**](VerveResponseInteractionResponse.md)

### Authorization

[default](../README.md#default)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
