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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.IEngage.Model
{
    /// <summary>
    /// Task
    /// </summary>
    [DataContract]
    public partial class Task :  IEquatable<Task>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="TaskId">TaskId.</param>
        /// <param name="TaskTitle">TaskTitle.</param>
        /// <param name="TaskDescription">TaskDescription.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Priority">Priority.</param>
        /// <param name="DueDate">DueDate.</param>
        /// <param name="MilestoneName">MilestoneName.</param>
        /// <param name="GroupType">GroupType.</param>
        /// <param name="GroupName">GroupName.</param>
        public Task(long? TaskId = null, string TaskTitle = null, string TaskDescription = null, int? Status = null, int? Priority = null, DateTime? DueDate = null, string MilestoneName = null, string GroupType = null, string GroupName = null)
        {
            this.TaskId = TaskId;
            this.TaskTitle = TaskTitle;
            this.TaskDescription = TaskDescription;
            this.Status = Status;
            this.Priority = Priority;
            this.DueDate = DueDate;
            this.MilestoneName = MilestoneName;
            this.GroupType = GroupType;
            this.GroupName = GroupName;
        }
        
        /// <summary>
        /// Gets or Sets TaskId
        /// </summary>
        [DataMember(Name="taskId", EmitDefaultValue=false)]
        public long? TaskId { get; set; }
        /// <summary>
        /// Gets or Sets TaskTitle
        /// </summary>
        [DataMember(Name="taskTitle", EmitDefaultValue=false)]
        public string TaskTitle { get; set; }
        /// <summary>
        /// Gets or Sets TaskDescription
        /// </summary>
        [DataMember(Name="taskDescription", EmitDefaultValue=false)]
        public string TaskDescription { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }
        /// <summary>
        /// Gets or Sets DueDate
        /// </summary>
        [DataMember(Name="dueDate", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// Gets or Sets MilestoneName
        /// </summary>
        [DataMember(Name="milestoneName", EmitDefaultValue=false)]
        public string MilestoneName { get; set; }
        /// <summary>
        /// Gets or Sets GroupType
        /// </summary>
        [DataMember(Name="groupType", EmitDefaultValue=false)]
        public string GroupType { get; set; }
        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Task {\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  TaskTitle: ").Append(TaskTitle).Append("\n");
            sb.Append("  TaskDescription: ").Append(TaskDescription).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  MilestoneName: ").Append(MilestoneName).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
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
            return this.Equals(obj as Task);
        }

        /// <summary>
        /// Returns true if Task instances are equal
        /// </summary>
        /// <param name="other">Instance of Task to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Task other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TaskId == other.TaskId ||
                    this.TaskId != null &&
                    this.TaskId.Equals(other.TaskId)
                ) && 
                (
                    this.TaskTitle == other.TaskTitle ||
                    this.TaskTitle != null &&
                    this.TaskTitle.Equals(other.TaskTitle)
                ) && 
                (
                    this.TaskDescription == other.TaskDescription ||
                    this.TaskDescription != null &&
                    this.TaskDescription.Equals(other.TaskDescription)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) && 
                (
                    this.DueDate == other.DueDate ||
                    this.DueDate != null &&
                    this.DueDate.Equals(other.DueDate)
                ) && 
                (
                    this.MilestoneName == other.MilestoneName ||
                    this.MilestoneName != null &&
                    this.MilestoneName.Equals(other.MilestoneName)
                ) && 
                (
                    this.GroupType == other.GroupType ||
                    this.GroupType != null &&
                    this.GroupType.Equals(other.GroupType)
                ) && 
                (
                    this.GroupName == other.GroupName ||
                    this.GroupName != null &&
                    this.GroupName.Equals(other.GroupName)
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
                if (this.TaskId != null)
                    hash = hash * 59 + this.TaskId.GetHashCode();
                if (this.TaskTitle != null)
                    hash = hash * 59 + this.TaskTitle.GetHashCode();
                if (this.TaskDescription != null)
                    hash = hash * 59 + this.TaskDescription.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                if (this.DueDate != null)
                    hash = hash * 59 + this.DueDate.GetHashCode();
                if (this.MilestoneName != null)
                    hash = hash * 59 + this.MilestoneName.GetHashCode();
                if (this.GroupType != null)
                    hash = hash * 59 + this.GroupType.GetHashCode();
                if (this.GroupName != null)
                    hash = hash * 59 + this.GroupName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}