# IO.IEngage - the C# library for the iEngage 2.1 API

This API enables Intelligent Engagement for your Business. iEngage is a platform that combines process, augmented intelligence and rewards to help you intelligently engage customers.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.0
- SDK version: 2.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.IEngage.Api;
using IO.IEngage.Client;
using IO.IEngage.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: default
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AugmentedIntelligenceApi();
            var text = text_example;  // string | Text you want classified
            var id = 789;  // long? | Classifier ID from the Admin Panel
            var clientToken = clientToken_example;  // string | Use the Client Token. Please generate it from the Applications section under the Production & Sandbox tabs

            try
            {
                // Classifies using your classifier
                VerveResponseTextClassificationList result = apiInstance.Classify(text, id, clientToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AugmentedIntelligenceApi.Classify: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.iengage.io:8243/api/2.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AugmentedIntelligenceApi* | [**Classify**](docs/AugmentedIntelligenceApi.md#classify) | **POST** /ml/classifier/classify | Classifies using your classifier
*AugmentedIntelligenceApi* | [**GetEntities**](docs/AugmentedIntelligenceApi.md#getentities) | **POST** /ml/ner/classify | Extracts entities from text
*AugmentedIntelligenceApi* | [**GetInteractionType**](docs/AugmentedIntelligenceApi.md#getinteractiontype) | **POST** /ml/interactionType | Returns the type of interaction
*AugmentedIntelligenceApi* | [**GetKeywords**](docs/AugmentedIntelligenceApi.md#getkeywords) | **POST** /ml/keywords | Returns the keywords of the sentence
*AugmentedIntelligenceApi* | [**GetPopularTag**](docs/AugmentedIntelligenceApi.md#getpopulartag) | **GET** /analytics/popular/tags | Get list of popular tag of interactions
*AugmentedIntelligenceApi* | [**GetSentiment**](docs/AugmentedIntelligenceApi.md#getsentiment) | **GET** /analytics/sentiments | Get sentiment count of interactions
*AugmentedIntelligenceApi* | [**GetTagEntitySentiments**](docs/AugmentedIntelligenceApi.md#gettagentitysentiments) | **GET** /analytics/tag/entitySentiment | Get list of tag entity sentiment
*AugmentedIntelligenceApi* | [**Sentiment**](docs/AugmentedIntelligenceApi.md#sentiment) | **POST** /ml/sentiment | Analyzes the sentiment of the content
*BPMApi* | [**AssignWFTask**](docs/BPMApi.md#assignwftask) | **POST** /bpm/tasks/{taskId}/assign | Assign task
*BPMApi* | [**CompleteWFTask**](docs/BPMApi.md#completewftask) | **POST** /bpm/tasks/{taskId}/complete | Complete task
*BPMApi* | [**GetBPMTasks**](docs/BPMApi.md#getbpmtasks) | **GET** /bpm/tasks/{taskId} | Get task by task id
*BPMApi* | [**GetSearchTask**](docs/BPMApi.md#getsearchtask) | **GET** /bpm/{userId}/tasks/name | Get list of BPM task assigned to user
*BPMApi* | [**GetTasksByEntity**](docs/BPMApi.md#gettasksbyentity) | **GET** /bpm/{userId}/tasks/{entityId} | Get list of BPM task assigned to user
*BPMApi* | [**GetUserBPMTasks**](docs/BPMApi.md#getuserbpmtasks) | **GET** /bpm/{userId}/tasks | Get list of BPM task assigned to user
*BPMApi* | [**GetUserRolesBPMTasks**](docs/BPMApi.md#getuserrolesbpmtasks) | **GET** /bpm/{userId}/roles/tasks | Get list of BPM task assigned to user roles
*CollaborationApi* | [**AddCommentBlog**](docs/CollaborationApi.md#addcommentblog) | **POST** /collaborations/blogs/{blogId}/comments | Comment on posted blog
*CollaborationApi* | [**AddCommentDiscussion**](docs/CollaborationApi.md#addcommentdiscussion) | **POST** /collaborations/discussions/{discussionId}/comments | Comment on discussion
*CollaborationApi* | [**DeleteBlog**](docs/CollaborationApi.md#deleteblog) | **DELETE** /collaborations/blogs/{blogId} | Delete blog
*CollaborationApi* | [**DeleteBlogComment**](docs/CollaborationApi.md#deleteblogcomment) | **DELETE** /collaborations/blogs/comments/{commentId} | Delete blog comment
*CollaborationApi* | [**DeleteDiscussion**](docs/CollaborationApi.md#deletediscussion) | **DELETE** /collaborations/discussions/{discussionId} | Delete discussion
*CollaborationApi* | [**DeleteDiscussionComment**](docs/CollaborationApi.md#deletediscussioncomment) | **DELETE** /collaborations/discussions/comments/{commentId} | Delete discussion comment
*CollaborationApi* | [**GetBlogComments**](docs/CollaborationApi.md#getblogcomments) | **GET** /collaborations/blogs/{blogId}/comments | Get list of comments on blog
*CollaborationApi* | [**GetBlogs**](docs/CollaborationApi.md#getblogs) | **GET** /collaborations/blogs | Get list of blogs
*CollaborationApi* | [**GetDiscussionComments**](docs/CollaborationApi.md#getdiscussioncomments) | **GET** /collaborations/discussions/{discussionId}/comments | Get list of comments on discussion
*CollaborationApi* | [**GetDiscussions**](docs/CollaborationApi.md#getdiscussions) | **GET** /collaborations/discussions | Get list of discussions
*CollaborationApi* | [**GetUserSubscribedBlogs**](docs/CollaborationApi.md#getusersubscribedblogs) | **GET** /collaborations/blogs/{userId}/subscribe | Get list of blogs subscribed by user
*CollaborationApi* | [**GetUserSubscribedDiscussions**](docs/CollaborationApi.md#getusersubscribeddiscussions) | **GET** /collaborations/discussions/{userId}/subscribe | Get list of discussions subscribed by user
*CollaborationApi* | [**PostBlog**](docs/CollaborationApi.md#postblog) | **POST** /collaborations/blogs | Post blog
*CollaborationApi* | [**StartDiscussion**](docs/CollaborationApi.md#startdiscussion) | **POST** /collaborations/discussions | Start discussion
*CollaborationApi* | [**SubscribeBlog**](docs/CollaborationApi.md#subscribeblog) | **POST** /collaborations/blogs/{blogId}/subscribe | Subscribe blog
*CollaborationApi* | [**SubscribeDiscussion**](docs/CollaborationApi.md#subscribediscussion) | **POST** /collaborations/discussions/{discussionId}/subscribe | Subscribe discussion
*CollaborationApi* | [**UnsubscribeBlog**](docs/CollaborationApi.md#unsubscribeblog) | **POST** /collaborations/blogs/{blogId}/unsubscribe | Unsubscribe blog
*CollaborationApi* | [**UnsubscribeDiscussion**](docs/CollaborationApi.md#unsubscribediscussion) | **POST** /collaborations/discussions/{discussionId}/unsubscribe | Unsubscribe discussion
*CollaborationApi* | [**UpdateBlog**](docs/CollaborationApi.md#updateblog) | **PUT** /collaborations/blogs/{blogId} | Update blog
*CollaborationApi* | [**UpdateBlogComment**](docs/CollaborationApi.md#updateblogcomment) | **PUT** /collaborations/blogs/comments/{commentId} | Update blog comment
*CollaborationApi* | [**UpdateDiscussion**](docs/CollaborationApi.md#updatediscussion) | **PUT** /collaborations/discussions/{discussionId} | Update discussion
*CollaborationApi* | [**UpdateDiscussionComment**](docs/CollaborationApi.md#updatediscussioncomment) | **PUT** /collaborations/discussions/comments/{commentId} | Update discussion comment
*GroupApi* | [**CreateGroup**](docs/GroupApi.md#creategroup) | **POST** /groups | Create group
*GroupApi* | [**DeleteGroup**](docs/GroupApi.md#deletegroup) | **DELETE** /groups/{groupId} | Delete group
*GroupApi* | [**FollowGroup**](docs/GroupApi.md#followgroup) | **POST** /groups/{groupId}/follow | Follow group
*GroupApi* | [**GetGroupFollowers**](docs/GroupApi.md#getgroupfollowers) | **GET** /groups/{groupId}/followers | Get the list of followers for the group
*GroupApi* | [**GetGroupIdeas**](docs/GroupApi.md#getgroupideas) | **GET** /groups/{groupId}/ideas | Get list of all ideas in a group
*GroupApi* | [**GetGroups**](docs/GroupApi.md#getgroups) | **GET** /groups | Get the list of groups visible for user
*GroupApi* | [**GetRecommendationGroup**](docs/GroupApi.md#getrecommendationgroup) | **GET** /groups/recommend | Get list of recommended groups
*GroupApi* | [**GetUserFollowingGroups**](docs/GroupApi.md#getuserfollowinggroups) | **GET** /groups/{userId}/following | Get list of groups that a user is following
*GroupApi* | [**SearchGroups**](docs/GroupApi.md#searchgroups) | **GET** /groups/search | Get list of matching groups
*GroupApi* | [**UnfollowGroup**](docs/GroupApi.md#unfollowgroup) | **POST** /groups/{groupId}/unfollow | Unfollow group
*GroupApi* | [**UpdateGroup**](docs/GroupApi.md#updategroup) | **PUT** /groups/{groupId} | Update group
*IdeaApi* | [**DeleteComment**](docs/IdeaApi.md#deletecomment) | **DELETE** /ideas/comments/{commentId} | Delete comment
*IdeaApi* | [**DeleteIdea**](docs/IdeaApi.md#deleteidea) | **DELETE** /ideas/{ideaId} | Delete idea
*IdeaApi* | [**FollowIdea**](docs/IdeaApi.md#followidea) | **POST** /ideas/{ideaId}/follow | Follow idea
*IdeaApi* | [**GetAllIdeas**](docs/IdeaApi.md#getallideas) | **GET** /ideas | Get list of Ideas
*IdeaApi* | [**GetFollowingIdeas**](docs/IdeaApi.md#getfollowingideas) | **GET** /ideas/{userId}/following | Get list of ideas that users are following
*IdeaApi* | [**GetGroupIdeas**](docs/IdeaApi.md#getgroupideas) | **GET** /ideas/getGroupIdeas | Get list of ideas in group
*IdeaApi* | [**GetIdea**](docs/IdeaApi.md#getidea) | **GET** /ideas/{ideaId} | Get idea by id
*IdeaApi* | [**GetIdeaComment**](docs/IdeaApi.md#getideacomment) | **GET** /ideas/{ideaId}/comments | Get list of comments on idea
*IdeaApi* | [**GetIdeaFollowers**](docs/IdeaApi.md#getideafollowers) | **GET** /ideas/{ideaId}/followers | Get list of followers for this idea
*IdeaApi* | [**GetIdeaRatingParameters**](docs/IdeaApi.md#getidearatingparameters) | **GET** /ideas/getIdeaRatingParameters | Get rating parameters of idea by user
*IdeaApi* | [**GetIdeaRatings**](docs/IdeaApi.md#getidearatings) | **GET** /ideas/getIdeaUserRating | Get list of ideas that are rated by user 
*IdeaApi* | [**GetRecommendIdeas**](docs/IdeaApi.md#getrecommendideas) | **GET** /ideas/recommend | Get the list of recommended ideas
*IdeaApi* | [**GetTopIdeas**](docs/IdeaApi.md#gettopideas) | **GET** /ideas/top | Get the list of top ideas
*IdeaApi* | [**GetUserIdeas**](docs/IdeaApi.md#getuserideas) | **GET** /ideas/{userId}/shared | Get list of ideas shared by user
*IdeaApi* | [**GetUserRateIdeas**](docs/IdeaApi.md#getuserrateideas) | **GET** /ideas/{userId}/rated | Get list of ideas rated by user
*IdeaApi* | [**RateIdea**](docs/IdeaApi.md#rateidea) | **POST** /ideas/rateIdea | Rate an idea
*IdeaApi* | [**RateIdea_0**](docs/IdeaApi.md#rateidea_0) | **GET** /ideas/rateIdeaByParameter | Give rating on idea
*IdeaApi* | [**SearchIdeas**](docs/IdeaApi.md#searchideas) | **GET** /ideas/search | Get list of matching ideas
*IdeaApi* | [**ShareFormIdea**](docs/IdeaApi.md#shareformidea) | **POST** /ideas/attachment | Share Idea with attachments
*IdeaApi* | [**ShareIdea**](docs/IdeaApi.md#shareidea) | **POST** /ideas | Share idea  
*IdeaApi* | [**ShareIdeaComment**](docs/IdeaApi.md#shareideacomment) | **POST** /ideas/{ideaId}/comments | Comment on shared idea
*IdeaApi* | [**UnfollowIdea**](docs/IdeaApi.md#unfollowidea) | **POST** /ideas/{ideaId}/unfollow | Unfollow idea
*IdeaApi* | [**UpdateCommet**](docs/IdeaApi.md#updatecommet) | **PUT** /ideas/comments/{commentId} | Update comment
*IdeaApi* | [**UpdateIdea**](docs/IdeaApi.md#updateidea) | **PUT** /ideas/{ideaId} | Update idea
*InteractionApi* | [**AddInteraction**](docs/InteractionApi.md#addinteraction) | **POST** /interactions | Share interaction without attachment
*InteractionApi* | [**AddInteraction_0**](docs/InteractionApi.md#addinteraction_0) | **POST** /interactions/attachment | Share interaction with attachment
*InteractionApi* | [**AddResponse**](docs/InteractionApi.md#addresponse) | **POST** /interactions/{interactionId}/responses | Response the specified interaction
*InteractionApi* | [**ChangeInteractionCategory**](docs/InteractionApi.md#changeinteractioncategory) | **PUT** /interactions/{interactionId}/{categoryId} | Change interaction category
*InteractionApi* | [**ChangeInteractionType**](docs/InteractionApi.md#changeinteractiontype) | **PUT** /interactions/{interactionId}/type | Change interaction type
*InteractionApi* | [**CreateInteractionCategory**](docs/InteractionApi.md#createinteractioncategory) | **POST** /interactions/categories | Create interaction category
*InteractionApi* | [**DeleteInteraction**](docs/InteractionApi.md#deleteinteraction) | **DELETE** /interactions/{interactionId} | Delete interaction
*InteractionApi* | [**DeleteInteractionCategory**](docs/InteractionApi.md#deleteinteractioncategory) | **DELETE** /interactions/categories/{categoryId} | Delete interaction category
*InteractionApi* | [**DeleteResponse**](docs/InteractionApi.md#deleteresponse) | **DELETE** /interactions/responses/{responseId} | Delete response
*InteractionApi* | [**DislikeResponse**](docs/InteractionApi.md#dislikeresponse) | **POST** /interactions/{interactionId}/responses/{responseId}/dislike | Dislike response
*InteractionApi* | [**GetFriendsInteractions**](docs/InteractionApi.md#getfriendsinteractions) | **GET** /interactions/friends | Get list of interactions shared by friends
*InteractionApi* | [**GetInteraction**](docs/InteractionApi.md#getinteraction) | **GET** /interactions/{interactionId} | Get interaction by id
*InteractionApi* | [**GetInteractionCategories**](docs/InteractionApi.md#getinteractioncategories) | **GET** /interactions/categories | Get the list of interaction categories
*InteractionApi* | [**GetInteractionsForUser**](docs/InteractionApi.md#getinteractionsforuser) | **GET** /interactions | Get list of all interactions visible to the user
*InteractionApi* | [**GetRecommendInteractions**](docs/InteractionApi.md#getrecommendinteractions) | **GET** /interactions/recommend | Get list of recommended interactions
*InteractionApi* | [**GetRecommendedInteractinsFromDB**](docs/InteractionApi.md#getrecommendedinteractinsfromdb) | **GET** /interactions/{userId}/recommendedInteractions | Get list of recommended interactions from DB
*InteractionApi* | [**GetRecommendedUsersFromDB**](docs/InteractionApi.md#getrecommendedusersfromdb) | **GET** /interactions/{interactionId}/recommendedUsers | Get list of recommended Users from DB
*InteractionApi* | [**GetResponses**](docs/InteractionApi.md#getresponses) | **GET** /interactions/{interactionId}/responses | Get list of responses by interactionId
*InteractionApi* | [**GetUserInteractions**](docs/InteractionApi.md#getuserinteractions) | **GET** /interactions/{userId}/shared | Get list of interactions shared by user
*InteractionApi* | [**GetUserSubscribedInteractionCategories**](docs/InteractionApi.md#getusersubscribedinteractioncategories) | **GET** /interactions/categories/{userId}/subscribe | Get list of interaction categories subscribed by the user
*InteractionApi* | [**GetUserSubscribedInteractions**](docs/InteractionApi.md#getusersubscribedinteractions) | **GET** /interactions/{userId}/subscribe | Get list of interactions subscribed by user
*InteractionApi* | [**LikeResponse**](docs/InteractionApi.md#likeresponse) | **POST** /interactions/{interactionId}/responses/{responseId}/like | Like response
*InteractionApi* | [**MarkAsAnResponse**](docs/InteractionApi.md#markasanresponse) | **POST** /interactions/{interactionId}/responses/{responseId}/mark | Mark response as a response
*InteractionApi* | [**SearchInteractions**](docs/InteractionApi.md#searchinteractions) | **GET** /interactions/search | Get list of matching interactions
*InteractionApi* | [**SubscribeInteractinCategory**](docs/InteractionApi.md#subscribeinteractincategory) | **POST** /interactions/categories/{categoryId}/subscribe | Subscribe interaction category
*InteractionApi* | [**SubscribeInteraction**](docs/InteractionApi.md#subscribeinteraction) | **POST** /interactions/{interactionId}/subscribe | Subscribe interaction
*InteractionApi* | [**UnmarkAsAnResponse**](docs/InteractionApi.md#unmarkasanresponse) | **POST** /interactions/{interactionId}/responses/{responseId}/unmark | Unmark response as a response
*InteractionApi* | [**UnsubscribeInteractinCategory**](docs/InteractionApi.md#unsubscribeinteractincategory) | **POST** /interactions/categories/{categoryId}/unsubscribe | Unsubscribe interaction category
*InteractionApi* | [**UnsubscribeInteraction**](docs/InteractionApi.md#unsubscribeinteraction) | **POST** /interactions/{interactionId}/unsubscribe | Unsubscribe interaction
*InteractionApi* | [**UpdateInteraction**](docs/InteractionApi.md#updateinteraction) | **PUT** /interactions/{interactionId} | Update interaction
*InteractionApi* | [**UpdateInteractionCategory**](docs/InteractionApi.md#updateinteractioncategory) | **PUT** /interactions/categories/{categoryId} | Update interaction category
*InteractionApi* | [**UpdateResponse**](docs/InteractionApi.md#updateresponse) | **PUT** /interactions/responses/{responseId} | Update response
*NotificationApi* | [**AddNotification**](docs/NotificationApi.md#addnotification) | **POST** /notifications | Create custom notification
*NotificationApi* | [**GetNotifications**](docs/NotificationApi.md#getnotifications) | **GET** /notifications | Get list of notifications
*NotificationApi* | [**MarkAllNotificationAsRead**](docs/NotificationApi.md#markallnotificationasread) | **POST** /notifications/read/all | Mark all notification as read
*NotificationApi* | [**MarkNotificationAsRead**](docs/NotificationApi.md#marknotificationasread) | **POST** /notifications/read/{notificationId} | Mark notification as read
*NotificationApi* | [**NotificationCount**](docs/NotificationApi.md#notificationcount) | **GET** /notifications/count | Get notifications count
*ProjectManagementApi* | [**AddMilestoneComment**](docs/ProjectManagementApi.md#addmilestonecomment) | **POST** /milestones/{milestoneId}/comments | Comment on milestone
*ProjectManagementApi* | [**AddTaskComment**](docs/ProjectManagementApi.md#addtaskcomment) | **POST** /milestones/tasks/{taskId}/comments | Comment on task
*ProjectManagementApi* | [**CreateMilestone**](docs/ProjectManagementApi.md#createmilestone) | **POST** /milestones | Create milestone
*ProjectManagementApi* | [**CreateTask**](docs/ProjectManagementApi.md#createtask) | **POST** /milestones/{milestoneId}/tasks | Create task
*ProjectManagementApi* | [**DeleteMilestone**](docs/ProjectManagementApi.md#deletemilestone) | **DELETE** /milestones/{milestoneId} | Delete milestone
*ProjectManagementApi* | [**DeleteTask**](docs/ProjectManagementApi.md#deletetask) | **DELETE** /milestones/tasks/{taskId} | Delete task
*ProjectManagementApi* | [**GetMilestones**](docs/ProjectManagementApi.md#getmilestones) | **GET** /milestones | Get list of milestones
*ProjectManagementApi* | [**GetMilestonesComments**](docs/ProjectManagementApi.md#getmilestonescomments) | **GET** /milestones/{milestoneId}/comments | Get list of comments written on Milestones
*ProjectManagementApi* | [**GetTaskComments**](docs/ProjectManagementApi.md#gettaskcomments) | **GET** /milestones/tasks/{taskId}/comments | Get list of Comments written on task
*ProjectManagementApi* | [**GetUserTasks**](docs/ProjectManagementApi.md#getusertasks) | **GET** /milestones/tasks/{userId}/assigned | Get list of task assigned to user
*ProjectManagementApi* | [**UpdateMilestone**](docs/ProjectManagementApi.md#updatemilestone) | **PUT** /milestones/{milestoneId} | Update milestone
*ProjectManagementApi* | [**UpdateTask**](docs/ProjectManagementApi.md#updatetask) | **PUT** /milestones/tasks/{taskId} | Update task
*ProjectManagementApi* | [**UpdateTaskStatus**](docs/ProjectManagementApi.md#updatetaskstatus) | **PUT** /milestones/tasks/{taskId}/status | Update task status
*RewardsApi* | [**GetTopFriends**](docs/RewardsApi.md#gettopfriends) | **GET** /rewards/points/top/friends | Get list of top friends
*RewardsApi* | [**GetTopUsers**](docs/RewardsApi.md#gettopusers) | **GET** /rewards/points/top | Get list of top users
*RewardsApi* | [**GetUserPoints**](docs/RewardsApi.md#getuserpoints) | **GET** /rewards/points/{userId} | Get list of user points
*SocialApi* | [**AddFriend**](docs/SocialApi.md#addfriend) | **POST** /social/friends/add | Add Friend
*SocialApi* | [**ConfirmFriendRequest**](docs/SocialApi.md#confirmfriendrequest) | **POST** /social/friends/request/action | confirm/ignore friend request
*SocialApi* | [**Follow**](docs/SocialApi.md#follow) | **POST** /social/follow | Follow user
*SocialApi* | [**GetUser**](docs/SocialApi.md#getuser) | **GET** /social/users/{userId} | Get user by id 
*SocialApi* | [**GetUserDetail**](docs/SocialApi.md#getuserdetail) | **GET** /social/userDetail | Get user details 
*SocialApi* | [**GetUserFollowers**](docs/SocialApi.md#getuserfollowers) | **GET** /social/followers/{userId} | Get list of followers
*SocialApi* | [**GetUserFollowing**](docs/SocialApi.md#getuserfollowing) | **GET** /social/following/{userId} | Get list of users that are being followed
*SocialApi* | [**GetUserFriends**](docs/SocialApi.md#getuserfriends) | **GET** /social/friends{userId} | Get list of friends
*SocialApi* | [**RemoveFriend**](docs/SocialApi.md#removefriend) | **POST** /social/friends/remove | Remove friend 
*SocialApi* | [**RequestFriend**](docs/SocialApi.md#requestfriend) | **POST** /social/friends/request | Send friend request
*SocialApi* | [**RequestsForMe**](docs/SocialApi.md#requestsforme) | **GET** /social/friends/request | Get list of friend requests
*SocialApi* | [**Unfollow**](docs/SocialApi.md#unfollow) | **POST** /social/unfollow | Unfollow user
*UserAuthenticationApi* | [**AddNotificationRegisteredId**](docs/UserAuthenticationApi.md#addnotificationregisteredid) | **POST** /devices | Add device token
*UserAuthenticationApi* | [**AddUser**](docs/UserAuthenticationApi.md#adduser) | **POST** /users | Add/Register new user
*UserAuthenticationApi* | [**Authenticate**](docs/UserAuthenticationApi.md#authenticate) | **GET** /authenticate | Authenticate User
*UserAuthenticationApi* | [**ChangePassword**](docs/UserAuthenticationApi.md#changepassword) | **PUT** /users/password | Change password
*UserAuthenticationApi* | [**CreateAssociation**](docs/UserAuthenticationApi.md#createassociation) | **POST** /associations | Create association
*UserAuthenticationApi* | [**DeleteUser**](docs/UserAuthenticationApi.md#deleteuser) | **DELETE** /users/{userId} | Delete user
*UserAuthenticationApi* | [**GetAssociations**](docs/UserAuthenticationApi.md#getassociations) | **GET** /associations | Get list of associations
*UserAuthenticationApi* | [**Logout**](docs/UserAuthenticationApi.md#logout) | **GET** /logout | Logout


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Association](docs/Association.md)
 - [Model.Blog](docs/Blog.md)
 - [Model.Comment](docs/Comment.md)
 - [Model.Discussion](docs/Discussion.md)
 - [Model.EntitiesClassified](docs/EntitiesClassified.md)
 - [Model.Entity](docs/Entity.md)
 - [Model.EntitySentiment](docs/EntitySentiment.md)
 - [Model.FlowFinder](docs/FlowFinder.md)
 - [Model.Group](docs/Group.md)
 - [Model.Idea](docs/Idea.md)
 - [Model.IdeaUserRating](docs/IdeaUserRating.md)
 - [Model.Interaction](docs/Interaction.md)
 - [Model.InteractionCategory](docs/InteractionCategory.md)
 - [Model.InteractionInputModel](docs/InteractionInputModel.md)
 - [Model.InteractionResponse](docs/InteractionResponse.md)
 - [Model.Keyword](docs/Keyword.md)
 - [Model.Milestone](docs/Milestone.md)
 - [Model.Multimedia](docs/Multimedia.md)
 - [Model.NER](docs/NER.md)
 - [Model.Notification](docs/Notification.md)
 - [Model.QuestionCategory](docs/QuestionCategory.md)
 - [Model.RequestForMe](docs/RequestForMe.md)
 - [Model.Sentiment](docs/Sentiment.md)
 - [Model.SentimentAnalytics](docs/SentimentAnalytics.md)
 - [Model.Tag](docs/Tag.md)
 - [Model.Task](docs/Task.md)
 - [Model.TextClassification](docs/TextClassification.md)
 - [Model.User](docs/User.md)
 - [Model.UserDetail](docs/UserDetail.md)
 - [Model.UserPoints](docs/UserPoints.md)
 - [Model.VerveResponseAssociation](docs/VerveResponseAssociation.md)
 - [Model.VerveResponseAssociationList](docs/VerveResponseAssociationList.md)
 - [Model.VerveResponseBlog](docs/VerveResponseBlog.md)
 - [Model.VerveResponseBlogList](docs/VerveResponseBlogList.md)
 - [Model.VerveResponseComment](docs/VerveResponseComment.md)
 - [Model.VerveResponseCommentList](docs/VerveResponseCommentList.md)
 - [Model.VerveResponseDiscussion](docs/VerveResponseDiscussion.md)
 - [Model.VerveResponseDiscussionList](docs/VerveResponseDiscussionList.md)
 - [Model.VerveResponseEntitiesClassifiedList](docs/VerveResponseEntitiesClassifiedList.md)
 - [Model.VerveResponseEntitySentimentList](docs/VerveResponseEntitySentimentList.md)
 - [Model.VerveResponseFlowFinder](docs/VerveResponseFlowFinder.md)
 - [Model.VerveResponseGroup](docs/VerveResponseGroup.md)
 - [Model.VerveResponseGroupList](docs/VerveResponseGroupList.md)
 - [Model.VerveResponseIdea](docs/VerveResponseIdea.md)
 - [Model.VerveResponseIdeaList](docs/VerveResponseIdeaList.md)
 - [Model.VerveResponseIdeaUserRatingList](docs/VerveResponseIdeaUserRatingList.md)
 - [Model.VerveResponseInteraction](docs/VerveResponseInteraction.md)
 - [Model.VerveResponseInteractionCategory](docs/VerveResponseInteractionCategory.md)
 - [Model.VerveResponseInteractionCategoryList](docs/VerveResponseInteractionCategoryList.md)
 - [Model.VerveResponseInteractionList](docs/VerveResponseInteractionList.md)
 - [Model.VerveResponseInteractionResponse](docs/VerveResponseInteractionResponse.md)
 - [Model.VerveResponseInteractionResponseList](docs/VerveResponseInteractionResponseList.md)
 - [Model.VerveResponseKeyword](docs/VerveResponseKeyword.md)
 - [Model.VerveResponseMilestone](docs/VerveResponseMilestone.md)
 - [Model.VerveResponseMilestoneList](docs/VerveResponseMilestoneList.md)
 - [Model.VerveResponseNotificationList](docs/VerveResponseNotificationList.md)
 - [Model.VerveResponseRequestForMeList](docs/VerveResponseRequestForMeList.md)
 - [Model.VerveResponseSentiment](docs/VerveResponseSentiment.md)
 - [Model.VerveResponseSentimentAnalytics](docs/VerveResponseSentimentAnalytics.md)
 - [Model.VerveResponseString](docs/VerveResponseString.md)
 - [Model.VerveResponseTagList](docs/VerveResponseTagList.md)
 - [Model.VerveResponseTask](docs/VerveResponseTask.md)
 - [Model.VerveResponseTaskList](docs/VerveResponseTaskList.md)
 - [Model.VerveResponseTextClassificationList](docs/VerveResponseTextClassificationList.md)
 - [Model.VerveResponseUser](docs/VerveResponseUser.md)
 - [Model.VerveResponseUserDetail](docs/VerveResponseUserDetail.md)
 - [Model.VerveResponseUserList](docs/VerveResponseUserList.md)
 - [Model.VerveResponseUserPoints](docs/VerveResponseUserPoints.md)
 - [Model.VerveResponseUserPointsList](docs/VerveResponseUserPointsList.md)
 - [Model.VerveResponseWFTask](docs/VerveResponseWFTask.md)
 - [Model.VerveResponseWFTaskList](docs/VerveResponseWFTaskList.md)
 - [Model.WFTask](docs/WFTask.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="default"></a>
### default

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: https://api.iengage.io:8243/authorize
- **Scopes**: N/A

