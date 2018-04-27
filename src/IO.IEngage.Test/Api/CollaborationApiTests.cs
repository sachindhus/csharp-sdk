/* 
 * Stakeholder engagement API
 *
 * This API enables Intelligent Engagement for your Business. iEngage is a platform that combines process, augmented intelligence and rewards to help you intelligently engage customers.
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.IEngage.Client;
using IO.IEngage.Api;
using IO.IEngage.Model;

namespace IO.IEngage.Test
{
    /// <summary>
    ///  Class for testing CollaborationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CollaborationApiTests
    {
        private CollaborationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CollaborationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CollaborationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CollaborationApi
            //Assert.IsInstanceOfType(typeof(CollaborationApi), instance, "instance is a CollaborationApi");
        }

        
        /// <summary>
        /// Test AddCommentBlog
        /// </summary>
        [Test]
        public void AddCommentBlogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? blogId = null;
            //string commentText = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.AddCommentBlog(blogId, commentText, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseComment> (response, "response is VerveResponseComment");
        }
        
        /// <summary>
        /// Test AddCommentDiscussion
        /// </summary>
        [Test]
        public void AddCommentDiscussionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? discussionId = null;
            //string commentText = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.AddCommentDiscussion(discussionId, commentText, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseComment> (response, "response is VerveResponseComment");
        }
        
        /// <summary>
        /// Test DeleteBlog
        /// </summary>
        [Test]
        public void DeleteBlogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? blogId = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.DeleteBlog(blogId, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseBlog> (response, "response is VerveResponseBlog");
        }
        
        /// <summary>
        /// Test DeleteBlogComment
        /// </summary>
        [Test]
        public void DeleteBlogCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? commentId = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.DeleteBlogComment(commentId, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseComment> (response, "response is VerveResponseComment");
        }
        
        /// <summary>
        /// Test DeleteDiscussion
        /// </summary>
        [Test]
        public void DeleteDiscussionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? discussionId = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.DeleteDiscussion(discussionId, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseDiscussion> (response, "response is VerveResponseDiscussion");
        }
        
        /// <summary>
        /// Test DeleteDiscussionComment
        /// </summary>
        [Test]
        public void DeleteDiscussionCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? commentId = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.DeleteDiscussionComment(commentId, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseComment> (response, "response is VerveResponseComment");
        }
        
        /// <summary>
        /// Test GetBlogComments
        /// </summary>
        [Test]
        public void GetBlogCommentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? blogId = null;
            //int? start = null;
            //int? end = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.GetBlogComments(blogId, start, end, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseCommentList> (response, "response is VerveResponseCommentList");
        }
        
        /// <summary>
        /// Test GetBlogs
        /// </summary>
        [Test]
        public void GetBlogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? organizationId = null;
            //int? start = null;
            //int? end = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //string fields = null;
            //var response = instance.GetBlogs(organizationId, start, end, loggedInUserId, accessToken, clientToken, fields);
            //Assert.IsInstanceOf<VerveResponseBlogList> (response, "response is VerveResponseBlogList");
        }
        
        /// <summary>
        /// Test GetDiscussionComments
        /// </summary>
        [Test]
        public void GetDiscussionCommentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? discussionId = null;
            //int? start = null;
            //int? end = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.GetDiscussionComments(discussionId, start, end, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseCommentList> (response, "response is VerveResponseCommentList");
        }
        
        /// <summary>
        /// Test GetDiscussions
        /// </summary>
        [Test]
        public void GetDiscussionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? organizationId = null;
            //int? start = null;
            //int? end = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //string fields = null;
            //var response = instance.GetDiscussions(organizationId, start, end, loggedInUserId, accessToken, clientToken, fields);
            //Assert.IsInstanceOf<VerveResponseDiscussionList> (response, "response is VerveResponseDiscussionList");
        }
        
        /// <summary>
        /// Test GetUserSubscribedBlogs
        /// </summary>
        [Test]
        public void GetUserSubscribedBlogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? userId = null;
            //int? start = null;
            //int? end = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //string fields = null;
            //var response = instance.GetUserSubscribedBlogs(userId, start, end, loggedInUserId, accessToken, clientToken, fields);
            //Assert.IsInstanceOf<VerveResponseBlog> (response, "response is VerveResponseBlog");
        }
        
        /// <summary>
        /// Test GetUserSubscribedDiscussions
        /// </summary>
        [Test]
        public void GetUserSubscribedDiscussionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? userId = null;
            //int? start = null;
            //int? end = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //string fields = null;
            //var response = instance.GetUserSubscribedDiscussions(userId, start, end, loggedInUserId, accessToken, clientToken, fields);
            //Assert.IsInstanceOf<VerveResponseGroupList> (response, "response is VerveResponseGroupList");
        }
        
        /// <summary>
        /// Test PostBlog
        /// </summary>
        [Test]
        public void PostBlogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? organizationId = null;
            //string blogTitle = null;
            //string blogDescription = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.PostBlog(organizationId, blogTitle, blogDescription, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseBlog> (response, "response is VerveResponseBlog");
        }
        
        /// <summary>
        /// Test StartDiscussion
        /// </summary>
        [Test]
        public void StartDiscussionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? organizationId = null;
            //string subject = null;
            //string description = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.StartDiscussion(organizationId, subject, description, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseDiscussion> (response, "response is VerveResponseDiscussion");
        }
        
        /// <summary>
        /// Test SubscribeBlog
        /// </summary>
        [Test]
        public void SubscribeBlogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? blogId = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.SubscribeBlog(blogId, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseBlog> (response, "response is VerveResponseBlog");
        }
        
        /// <summary>
        /// Test SubscribeDiscussion
        /// </summary>
        [Test]
        public void SubscribeDiscussionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? discussionId = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.SubscribeDiscussion(discussionId, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseDiscussion> (response, "response is VerveResponseDiscussion");
        }
        
        /// <summary>
        /// Test UnsubscribeBlog
        /// </summary>
        [Test]
        public void UnsubscribeBlogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? blogId = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.UnsubscribeBlog(blogId, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseBlog> (response, "response is VerveResponseBlog");
        }
        
        /// <summary>
        /// Test UnsubscribeDiscussion
        /// </summary>
        [Test]
        public void UnsubscribeDiscussionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? discussionId = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.UnsubscribeDiscussion(discussionId, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseDiscussion> (response, "response is VerveResponseDiscussion");
        }
        
        /// <summary>
        /// Test UpdateBlog
        /// </summary>
        [Test]
        public void UpdateBlogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? blogId = null;
            //string blogTitle = null;
            //string blogDescription = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.UpdateBlog(blogId, blogTitle, blogDescription, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseBlog> (response, "response is VerveResponseBlog");
        }
        
        /// <summary>
        /// Test UpdateBlogComment
        /// </summary>
        [Test]
        public void UpdateBlogCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? commentId = null;
            //string commentText = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.UpdateBlogComment(commentId, commentText, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseComment> (response, "response is VerveResponseComment");
        }
        
        /// <summary>
        /// Test UpdateDiscussion
        /// </summary>
        [Test]
        public void UpdateDiscussionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? discussionId = null;
            //string subject = null;
            //string discussionDescription = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.UpdateDiscussion(discussionId, subject, discussionDescription, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseDiscussion> (response, "response is VerveResponseDiscussion");
        }
        
        /// <summary>
        /// Test UpdateDiscussionComment
        /// </summary>
        [Test]
        public void UpdateDiscussionCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? commentId = null;
            //string commentText = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.UpdateDiscussionComment(commentId, commentText, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseDiscussion> (response, "response is VerveResponseDiscussion");
        }
        
    }

}