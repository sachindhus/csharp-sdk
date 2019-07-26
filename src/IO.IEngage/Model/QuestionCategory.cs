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
    /// QuestionCategory
    /// </summary>
    [DataContract]
    public partial class QuestionCategory :  IEquatable<QuestionCategory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionCategory" /> class.
        /// </summary>
        /// <param name="CategoryId">CategoryId.</param>
        /// <param name="CategoryName">CategoryName.</param>
        /// <param name="CategoryDescription">CategoryDescription.</param>
        /// <param name="CategoryType">CategoryType.</param>
        /// <param name="CreatedDate">CreatedDate.</param>
        /// <param name="ModifiedDate">ModifiedDate.</param>
        /// <param name="Status">Status.</param>
        /// <param name="IsSubscribed">IsSubscribed (default to false).</param>
        public QuestionCategory(long? CategoryId = null, string CategoryName = null, string CategoryDescription = null, string CategoryType = null, DateTime? CreatedDate = null, DateTime? ModifiedDate = null, int? Status = null, bool? IsSubscribed = null)
        {
            this.CategoryId = CategoryId;
            this.CategoryName = CategoryName;
            this.CategoryDescription = CategoryDescription;
            this.CategoryType = CategoryType;
            this.CreatedDate = CreatedDate;
            this.ModifiedDate = ModifiedDate;
            this.Status = Status;
            // use default value if no "IsSubscribed" provided
            if (IsSubscribed == null)
            {
                this.IsSubscribed = false;
            }
            else
            {
                this.IsSubscribed = IsSubscribed;
            }
        }
        
        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="categoryId", EmitDefaultValue=false)]
        public long? CategoryId { get; set; }
        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name="categoryName", EmitDefaultValue=false)]
        public string CategoryName { get; set; }
        /// <summary>
        /// Gets or Sets CategoryDescription
        /// </summary>
        [DataMember(Name="categoryDescription", EmitDefaultValue=false)]
        public string CategoryDescription { get; set; }
        /// <summary>
        /// Gets or Sets CategoryType
        /// </summary>
        [DataMember(Name="categoryType", EmitDefaultValue=false)]
        public string CategoryType { get; set; }
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
        /// <summary>
        /// Gets or Sets IsSubscribed
        /// </summary>
        [DataMember(Name="isSubscribed", EmitDefaultValue=false)]
        public bool? IsSubscribed { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuestionCategory {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  CategoryDescription: ").Append(CategoryDescription).Append("\n");
            sb.Append("  CategoryType: ").Append(CategoryType).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IsSubscribed: ").Append(IsSubscribed).Append("\n");
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
            return this.Equals(obj as QuestionCategory);
        }

        /// <summary>
        /// Returns true if QuestionCategory instances are equal
        /// </summary>
        /// <param name="other">Instance of QuestionCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuestionCategory other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CategoryId == other.CategoryId ||
                    this.CategoryId != null &&
                    this.CategoryId.Equals(other.CategoryId)
                ) && 
                (
                    this.CategoryName == other.CategoryName ||
                    this.CategoryName != null &&
                    this.CategoryName.Equals(other.CategoryName)
                ) && 
                (
                    this.CategoryDescription == other.CategoryDescription ||
                    this.CategoryDescription != null &&
                    this.CategoryDescription.Equals(other.CategoryDescription)
                ) && 
                (
                    this.CategoryType == other.CategoryType ||
                    this.CategoryType != null &&
                    this.CategoryType.Equals(other.CategoryType)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.IsSubscribed == other.IsSubscribed ||
                    this.IsSubscribed != null &&
                    this.IsSubscribed.Equals(other.IsSubscribed)
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
                if (this.CategoryId != null)
                    hash = hash * 59 + this.CategoryId.GetHashCode();
                if (this.CategoryName != null)
                    hash = hash * 59 + this.CategoryName.GetHashCode();
                if (this.CategoryDescription != null)
                    hash = hash * 59 + this.CategoryDescription.GetHashCode();
                if (this.CategoryType != null)
                    hash = hash * 59 + this.CategoryType.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.IsSubscribed != null)
                    hash = hash * 59 + this.IsSubscribed.GetHashCode();
                return hash;
            }
        }
    }

}
