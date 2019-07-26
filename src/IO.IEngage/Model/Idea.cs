/* 
 * iEngage 2.0 API
 *
 * This API enables Intelligent Engagement for your Business. iEngage is a platform that combines process, augmented intelligence and rewards to help you intelligently engage customers.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.IEngage.Model
{
    /// <summary>
    /// Idea
    /// </summary>
    [DataContract]
    public partial class Idea :  IEquatable<Idea>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Idea" /> class.
        /// </summary>
        /// <param name="IdeaId">IdeaId.</param>
        /// <param name="IdeaTitle">IdeaTitle.</param>
        /// <param name="Group">Group.</param>
        /// <param name="IdeaDescription">IdeaDescription.</param>
        /// <param name="Ideator">Ideator.</param>
        /// <param name="IdeaCreationDate">IdeaCreationDate.</param>
        /// <param name="LastModifiedDate">LastModifiedDate.</param>
        /// <param name="IdeaStage">IdeaStage.</param>
        /// <param name="Domain">Domain.</param>
        /// <param name="Technology">Technology.</param>
        /// <param name="AccessType">AccessType.</param>
        /// <param name="VideoId">VideoId.</param>
        /// <param name="ActiveStatus">ActiveStatus.</param>
        /// <param name="TeamStatus">TeamStatus.</param>
        /// <param name="ProjectStatus">ProjectStatus.</param>
        /// <param name="TotalFollowers">TotalFollowers.</param>
        /// <param name="TotalComments">TotalComments.</param>
        /// <param name="TotalBlogs">TotalBlogs.</param>
        /// <param name="AverageRatingScore">AverageRatingScore.</param>
        /// <param name="NumberOfRatings">NumberOfRatings.</param>
        /// <param name="CurrentUserFollowing">CurrentUserFollowing (default to false).</param>
        /// <param name="CurrentUserRating">CurrentUserRating.</param>
        /// <param name="IdeaFileURL">IdeaFileURL.</param>
        /// <param name="AttachmentList">AttachmentList.</param>
        /// <param name="Sentiment">Sentiment.</param>
        /// <param name="SentimentDetails">SentimentDetails.</param>
        /// <param name="SentimentWeightage">SentimentWeightage.</param>
        /// <param name="Entity">Entity.</param>
        public Idea(long? IdeaId = null, string IdeaTitle = null, Group Group = null, string IdeaDescription = null, User Ideator = null, DateTime? IdeaCreationDate = null, DateTime? LastModifiedDate = null, string IdeaStage = null, string Domain = null, string Technology = null, string AccessType = null, string VideoId = null, string ActiveStatus = null, string TeamStatus = null, string ProjectStatus = null, long? TotalFollowers = null, long? TotalComments = null, long? TotalBlogs = null, double? AverageRatingScore = null, long? NumberOfRatings = null, bool? CurrentUserFollowing = null, double? CurrentUserRating = null, string IdeaFileURL = null, List<Multimedia> AttachmentList = null, string Sentiment = null, Sentiment SentimentDetails = null, double? SentimentWeightage = null, List<NER> Entity = null)
        {
            this.IdeaId = IdeaId;
            this.IdeaTitle = IdeaTitle;
            this.Group = Group;
            this.IdeaDescription = IdeaDescription;
            this.Ideator = Ideator;
            this.IdeaCreationDate = IdeaCreationDate;
            this.LastModifiedDate = LastModifiedDate;
            this.IdeaStage = IdeaStage;
            this.Domain = Domain;
            this.Technology = Technology;
            this.AccessType = AccessType;
            this.VideoId = VideoId;
            this.ActiveStatus = ActiveStatus;
            this.TeamStatus = TeamStatus;
            this.ProjectStatus = ProjectStatus;
            this.TotalFollowers = TotalFollowers;
            this.TotalComments = TotalComments;
            this.TotalBlogs = TotalBlogs;
            this.AverageRatingScore = AverageRatingScore;
            this.NumberOfRatings = NumberOfRatings;
            // use default value if no "CurrentUserFollowing" provided
            if (CurrentUserFollowing == null)
            {
                this.CurrentUserFollowing = false;
            }
            else
            {
                this.CurrentUserFollowing = CurrentUserFollowing;
            }
            this.CurrentUserRating = CurrentUserRating;
            this.IdeaFileURL = IdeaFileURL;
            this.AttachmentList = AttachmentList;
            this.Sentiment = Sentiment;
            this.SentimentDetails = SentimentDetails;
            this.SentimentWeightage = SentimentWeightage;
            this.Entity = Entity;
        }
        
        /// <summary>
        /// Gets or Sets IdeaId
        /// </summary>
        [DataMember(Name="ideaId", EmitDefaultValue=false)]
        public long? IdeaId { get; set; }
        /// <summary>
        /// Gets or Sets IdeaTitle
        /// </summary>
        [DataMember(Name="ideaTitle", EmitDefaultValue=false)]
        public string IdeaTitle { get; set; }
        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public Group Group { get; set; }
        /// <summary>
        /// Gets or Sets IdeaDescription
        /// </summary>
        [DataMember(Name="ideaDescription", EmitDefaultValue=false)]
        public string IdeaDescription { get; set; }
        /// <summary>
        /// Gets or Sets Ideator
        /// </summary>
        [DataMember(Name="ideator", EmitDefaultValue=false)]
        public User Ideator { get; set; }
        /// <summary>
        /// Gets or Sets IdeaCreationDate
        /// </summary>
        [DataMember(Name="ideaCreationDate", EmitDefaultValue=false)]
        public DateTime? IdeaCreationDate { get; set; }
        /// <summary>
        /// Gets or Sets LastModifiedDate
        /// </summary>
        [DataMember(Name="lastModifiedDate", EmitDefaultValue=false)]
        public DateTime? LastModifiedDate { get; set; }
        /// <summary>
        /// Gets or Sets IdeaStage
        /// </summary>
        [DataMember(Name="ideaStage", EmitDefaultValue=false)]
        public string IdeaStage { get; set; }
        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }
        /// <summary>
        /// Gets or Sets Technology
        /// </summary>
        [DataMember(Name="technology", EmitDefaultValue=false)]
        public string Technology { get; set; }
        /// <summary>
        /// Gets or Sets AccessType
        /// </summary>
        [DataMember(Name="accessType", EmitDefaultValue=false)]
        public string AccessType { get; set; }
        /// <summary>
        /// Gets or Sets VideoId
        /// </summary>
        [DataMember(Name="videoId", EmitDefaultValue=false)]
        public string VideoId { get; set; }
        /// <summary>
        /// Gets or Sets ActiveStatus
        /// </summary>
        [DataMember(Name="activeStatus", EmitDefaultValue=false)]
        public string ActiveStatus { get; set; }
        /// <summary>
        /// Gets or Sets TeamStatus
        /// </summary>
        [DataMember(Name="teamStatus", EmitDefaultValue=false)]
        public string TeamStatus { get; set; }
        /// <summary>
        /// Gets or Sets ProjectStatus
        /// </summary>
        [DataMember(Name="projectStatus", EmitDefaultValue=false)]
        public string ProjectStatus { get; set; }
        /// <summary>
        /// Gets or Sets TotalFollowers
        /// </summary>
        [DataMember(Name="totalFollowers", EmitDefaultValue=false)]
        public long? TotalFollowers { get; set; }
        /// <summary>
        /// Gets or Sets TotalComments
        /// </summary>
        [DataMember(Name="totalComments", EmitDefaultValue=false)]
        public long? TotalComments { get; set; }
        /// <summary>
        /// Gets or Sets TotalBlogs
        /// </summary>
        [DataMember(Name="totalBlogs", EmitDefaultValue=false)]
        public long? TotalBlogs { get; set; }
        /// <summary>
        /// Gets or Sets AverageRatingScore
        /// </summary>
        [DataMember(Name="averageRatingScore", EmitDefaultValue=false)]
        public double? AverageRatingScore { get; set; }
        /// <summary>
        /// Gets or Sets NumberOfRatings
        /// </summary>
        [DataMember(Name="numberOfRatings", EmitDefaultValue=false)]
        public long? NumberOfRatings { get; set; }
        /// <summary>
        /// Gets or Sets CurrentUserFollowing
        /// </summary>
        [DataMember(Name="currentUserFollowing", EmitDefaultValue=false)]
        public bool? CurrentUserFollowing { get; set; }
        /// <summary>
        /// Gets or Sets CurrentUserRating
        /// </summary>
        [DataMember(Name="currentUserRating", EmitDefaultValue=false)]
        public double? CurrentUserRating { get; set; }
        /// <summary>
        /// Gets or Sets IdeaFileURL
        /// </summary>
        [DataMember(Name="ideaFileURL", EmitDefaultValue=false)]
        public string IdeaFileURL { get; set; }
        /// <summary>
        /// Gets or Sets AttachmentList
        /// </summary>
        [DataMember(Name="attachmentList", EmitDefaultValue=false)]
        public List<Multimedia> AttachmentList { get; set; }
        /// <summary>
        /// Gets or Sets Sentiment
        /// </summary>
        [DataMember(Name="sentiment", EmitDefaultValue=false)]
        public string Sentiment { get; set; }
        /// <summary>
        /// Gets or Sets SentimentDetails
        /// </summary>
        [DataMember(Name="sentimentDetails", EmitDefaultValue=false)]
        public Sentiment SentimentDetails { get; set; }
        /// <summary>
        /// Gets or Sets SentimentWeightage
        /// </summary>
        [DataMember(Name="sentimentWeightage", EmitDefaultValue=false)]
        public double? SentimentWeightage { get; set; }
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public List<NER> Entity { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Idea {\n");
            sb.Append("  IdeaId: ").Append(IdeaId).Append("\n");
            sb.Append("  IdeaTitle: ").Append(IdeaTitle).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  IdeaDescription: ").Append(IdeaDescription).Append("\n");
            sb.Append("  Ideator: ").Append(Ideator).Append("\n");
            sb.Append("  IdeaCreationDate: ").Append(IdeaCreationDate).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  IdeaStage: ").Append(IdeaStage).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Technology: ").Append(Technology).Append("\n");
            sb.Append("  AccessType: ").Append(AccessType).Append("\n");
            sb.Append("  VideoId: ").Append(VideoId).Append("\n");
            sb.Append("  ActiveStatus: ").Append(ActiveStatus).Append("\n");
            sb.Append("  TeamStatus: ").Append(TeamStatus).Append("\n");
            sb.Append("  ProjectStatus: ").Append(ProjectStatus).Append("\n");
            sb.Append("  TotalFollowers: ").Append(TotalFollowers).Append("\n");
            sb.Append("  TotalComments: ").Append(TotalComments).Append("\n");
            sb.Append("  TotalBlogs: ").Append(TotalBlogs).Append("\n");
            sb.Append("  AverageRatingScore: ").Append(AverageRatingScore).Append("\n");
            sb.Append("  NumberOfRatings: ").Append(NumberOfRatings).Append("\n");
            sb.Append("  CurrentUserFollowing: ").Append(CurrentUserFollowing).Append("\n");
            sb.Append("  CurrentUserRating: ").Append(CurrentUserRating).Append("\n");
            sb.Append("  IdeaFileURL: ").Append(IdeaFileURL).Append("\n");
            sb.Append("  AttachmentList: ").Append(AttachmentList).Append("\n");
            sb.Append("  Sentiment: ").Append(Sentiment).Append("\n");
            sb.Append("  SentimentDetails: ").Append(SentimentDetails).Append("\n");
            sb.Append("  SentimentWeightage: ").Append(SentimentWeightage).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Idea);
        }

        /// <summary>
        /// Returns true if Idea instances are equal
        /// </summary>
        /// <param name="other">Instance of Idea to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Idea other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdeaId == other.IdeaId ||
                    this.IdeaId != null &&
                    this.IdeaId.Equals(other.IdeaId)
                ) && 
                (
                    this.IdeaTitle == other.IdeaTitle ||
                    this.IdeaTitle != null &&
                    this.IdeaTitle.Equals(other.IdeaTitle)
                ) && 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.IdeaDescription == other.IdeaDescription ||
                    this.IdeaDescription != null &&
                    this.IdeaDescription.Equals(other.IdeaDescription)
                ) && 
                (
                    this.Ideator == other.Ideator ||
                    this.Ideator != null &&
                    this.Ideator.Equals(other.Ideator)
                ) && 
                (
                    this.IdeaCreationDate == other.IdeaCreationDate ||
                    this.IdeaCreationDate != null &&
                    this.IdeaCreationDate.Equals(other.IdeaCreationDate)
                ) && 
                (
                    this.LastModifiedDate == other.LastModifiedDate ||
                    this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(other.LastModifiedDate)
                ) && 
                (
                    this.IdeaStage == other.IdeaStage ||
                    this.IdeaStage != null &&
                    this.IdeaStage.Equals(other.IdeaStage)
                ) && 
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) && 
                (
                    this.Technology == other.Technology ||
                    this.Technology != null &&
                    this.Technology.Equals(other.Technology)
                ) && 
                (
                    this.AccessType == other.AccessType ||
                    this.AccessType != null &&
                    this.AccessType.Equals(other.AccessType)
                ) && 
                (
                    this.VideoId == other.VideoId ||
                    this.VideoId != null &&
                    this.VideoId.Equals(other.VideoId)
                ) && 
                (
                    this.ActiveStatus == other.ActiveStatus ||
                    this.ActiveStatus != null &&
                    this.ActiveStatus.Equals(other.ActiveStatus)
                ) && 
                (
                    this.TeamStatus == other.TeamStatus ||
                    this.TeamStatus != null &&
                    this.TeamStatus.Equals(other.TeamStatus)
                ) && 
                (
                    this.ProjectStatus == other.ProjectStatus ||
                    this.ProjectStatus != null &&
                    this.ProjectStatus.Equals(other.ProjectStatus)
                ) && 
                (
                    this.TotalFollowers == other.TotalFollowers ||
                    this.TotalFollowers != null &&
                    this.TotalFollowers.Equals(other.TotalFollowers)
                ) && 
                (
                    this.TotalComments == other.TotalComments ||
                    this.TotalComments != null &&
                    this.TotalComments.Equals(other.TotalComments)
                ) && 
                (
                    this.TotalBlogs == other.TotalBlogs ||
                    this.TotalBlogs != null &&
                    this.TotalBlogs.Equals(other.TotalBlogs)
                ) && 
                (
                    this.AverageRatingScore == other.AverageRatingScore ||
                    this.AverageRatingScore != null &&
                    this.AverageRatingScore.Equals(other.AverageRatingScore)
                ) && 
                (
                    this.NumberOfRatings == other.NumberOfRatings ||
                    this.NumberOfRatings != null &&
                    this.NumberOfRatings.Equals(other.NumberOfRatings)
                ) && 
                (
                    this.CurrentUserFollowing == other.CurrentUserFollowing ||
                    this.CurrentUserFollowing != null &&
                    this.CurrentUserFollowing.Equals(other.CurrentUserFollowing)
                ) && 
                (
                    this.CurrentUserRating == other.CurrentUserRating ||
                    this.CurrentUserRating != null &&
                    this.CurrentUserRating.Equals(other.CurrentUserRating)
                ) && 
                (
                    this.IdeaFileURL == other.IdeaFileURL ||
                    this.IdeaFileURL != null &&
                    this.IdeaFileURL.Equals(other.IdeaFileURL)
                ) && 
                (
                    this.AttachmentList == other.AttachmentList ||
                    this.AttachmentList != null &&
                    this.AttachmentList.SequenceEqual(other.AttachmentList)
                ) && 
                (
                    this.Sentiment == other.Sentiment ||
                    this.Sentiment != null &&
                    this.Sentiment.Equals(other.Sentiment)
                ) && 
                (
                    this.SentimentDetails == other.SentimentDetails ||
                    this.SentimentDetails != null &&
                    this.SentimentDetails.Equals(other.SentimentDetails)
                ) && 
                (
                    this.SentimentWeightage == other.SentimentWeightage ||
                    this.SentimentWeightage != null &&
                    this.SentimentWeightage.Equals(other.SentimentWeightage)
                ) && 
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.SequenceEqual(other.Entity)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.IdeaId != null)
                    hash = hash * 59 + this.IdeaId.GetHashCode();
                if (this.IdeaTitle != null)
                    hash = hash * 59 + this.IdeaTitle.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.IdeaDescription != null)
                    hash = hash * 59 + this.IdeaDescription.GetHashCode();
                if (this.Ideator != null)
                    hash = hash * 59 + this.Ideator.GetHashCode();
                if (this.IdeaCreationDate != null)
                    hash = hash * 59 + this.IdeaCreationDate.GetHashCode();
                if (this.LastModifiedDate != null)
                    hash = hash * 59 + this.LastModifiedDate.GetHashCode();
                if (this.IdeaStage != null)
                    hash = hash * 59 + this.IdeaStage.GetHashCode();
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                if (this.Technology != null)
                    hash = hash * 59 + this.Technology.GetHashCode();
                if (this.AccessType != null)
                    hash = hash * 59 + this.AccessType.GetHashCode();
                if (this.VideoId != null)
                    hash = hash * 59 + this.VideoId.GetHashCode();
                if (this.ActiveStatus != null)
                    hash = hash * 59 + this.ActiveStatus.GetHashCode();
                if (this.TeamStatus != null)
                    hash = hash * 59 + this.TeamStatus.GetHashCode();
                if (this.ProjectStatus != null)
                    hash = hash * 59 + this.ProjectStatus.GetHashCode();
                if (this.TotalFollowers != null)
                    hash = hash * 59 + this.TotalFollowers.GetHashCode();
                if (this.TotalComments != null)
                    hash = hash * 59 + this.TotalComments.GetHashCode();
                if (this.TotalBlogs != null)
                    hash = hash * 59 + this.TotalBlogs.GetHashCode();
                if (this.AverageRatingScore != null)
                    hash = hash * 59 + this.AverageRatingScore.GetHashCode();
                if (this.NumberOfRatings != null)
                    hash = hash * 59 + this.NumberOfRatings.GetHashCode();
                if (this.CurrentUserFollowing != null)
                    hash = hash * 59 + this.CurrentUserFollowing.GetHashCode();
                if (this.CurrentUserRating != null)
                    hash = hash * 59 + this.CurrentUserRating.GetHashCode();
                if (this.IdeaFileURL != null)
                    hash = hash * 59 + this.IdeaFileURL.GetHashCode();
                if (this.AttachmentList != null)
                    hash = hash * 59 + this.AttachmentList.GetHashCode();
                if (this.Sentiment != null)
                    hash = hash * 59 + this.Sentiment.GetHashCode();
                if (this.SentimentDetails != null)
                    hash = hash * 59 + this.SentimentDetails.GetHashCode();
                if (this.SentimentWeightage != null)
                    hash = hash * 59 + this.SentimentWeightage.GetHashCode();
                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();
                return hash;
            }
        }
    }

}
