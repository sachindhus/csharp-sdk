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
    ///  Class for testing UserAuthenticationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserAuthenticationApiTests
    {
        private UserAuthenticationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserAuthenticationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserAuthenticationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserAuthenticationApi
            //Assert.IsInstanceOfType(typeof(UserAuthenticationApi), instance, "instance is a UserAuthenticationApi");
        }

        
        /// <summary>
        /// Test AddUser
        /// </summary>
        [Test]
        public void AddUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string screenName = null;
            //string emailId = null;
            //string password = null;
            //string clientToken = null;
            //string firstName = null;
            //string middleName = null;
            //string lastName = null;
            //int? birthDay = null;
            //int? birthMonth = null;
            //int? birthYear = null;
            //string additionInformation = null;
            //var response = instance.AddUser(screenName, emailId, password, clientToken, firstName, middleName, lastName, birthDay, birthMonth, birthYear, additionInformation);
            //Assert.IsInstanceOf<VerveResponseUser> (response, "response is VerveResponseUser");
        }
        
        /// <summary>
        /// Test Authenticate
        /// </summary>
        [Test]
        public void AuthenticateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userName = null;
            //string password = null;
            //string clientToken = null;
            //var response = instance.Authenticate(userName, password, clientToken);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test ChangePassword
        /// </summary>
        [Test]
        public void ChangePasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currentPassword = null;
            //string newPassword = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.ChangePassword(currentPassword, newPassword, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test CreateAssociation
        /// </summary>
        [Test]
        public void CreateAssociationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.CreateAssociation(name, loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseAssociation> (response, "response is VerveResponseAssociation");
        }
        
        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Test]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? userId = null;
            //string clientToken = null;
            //var response = instance.DeleteUser(userId, clientToken);
            //Assert.IsInstanceOf<VerveResponseUser> (response, "response is VerveResponseUser");
        }
        
        /// <summary>
        /// Test GetAssociations
        /// </summary>
        [Test]
        public void GetAssociationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.GetAssociations(loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<VerveResponseAssociationList> (response, "response is VerveResponseAssociationList");
        }
        
        /// <summary>
        /// Test Logout
        /// </summary>
        [Test]
        public void LogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loggedInUserId = null;
            //string accessToken = null;
            //string clientToken = null;
            //var response = instance.Logout(loggedInUserId, accessToken, clientToken);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
    }

}