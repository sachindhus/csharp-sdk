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
    /// DataFlavor
    /// </summary>
    [DataContract]
    public partial class DataFlavor :  IEquatable<DataFlavor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataFlavor" /> class.
        /// </summary>
        /// <param name="MimeType">MimeType.</param>
        /// <param name="HumanPresentableName">HumanPresentableName.</param>
        /// <param name="PrimaryType">PrimaryType.</param>
        /// <param name="SubType">SubType.</param>
        /// <param name="DefaultRepresentationClassAsString">DefaultRepresentationClassAsString.</param>
        /// <param name="FlavorJavaFileListType">FlavorJavaFileListType (default to false).</param>
        /// <param name="FlavorRemoteObjectType">FlavorRemoteObjectType (default to false).</param>
        /// <param name="FlavorSerializedObjectType">FlavorSerializedObjectType (default to false).</param>
        /// <param name="FlavorTextType">FlavorTextType (default to false).</param>
        /// <param name="MimeTypeSerializedObject">MimeTypeSerializedObject (default to false).</param>
        /// <param name="RepresentationClassByteBuffer">RepresentationClassByteBuffer (default to false).</param>
        /// <param name="RepresentationClassCharBuffer">RepresentationClassCharBuffer (default to false).</param>
        /// <param name="RepresentationClassInputStream">RepresentationClassInputStream (default to false).</param>
        /// <param name="RepresentationClassReader">RepresentationClassReader (default to false).</param>
        /// <param name="RepresentationClassRemote">RepresentationClassRemote (default to false).</param>
        /// <param name="RepresentationClassSerializable">RepresentationClassSerializable (default to false).</param>
        public DataFlavor(string MimeType = null, string HumanPresentableName = null, string PrimaryType = null, string SubType = null, string DefaultRepresentationClassAsString = null, bool? FlavorJavaFileListType = null, bool? FlavorRemoteObjectType = null, bool? FlavorSerializedObjectType = null, bool? FlavorTextType = null, bool? MimeTypeSerializedObject = null, bool? RepresentationClassByteBuffer = null, bool? RepresentationClassCharBuffer = null, bool? RepresentationClassInputStream = null, bool? RepresentationClassReader = null, bool? RepresentationClassRemote = null, bool? RepresentationClassSerializable = null)
        {
            this.MimeType = MimeType;
            this.HumanPresentableName = HumanPresentableName;
            this.PrimaryType = PrimaryType;
            this.SubType = SubType;
            this.DefaultRepresentationClassAsString = DefaultRepresentationClassAsString;
            // use default value if no "FlavorJavaFileListType" provided
            if (FlavorJavaFileListType == null)
            {
                this.FlavorJavaFileListType = false;
            }
            else
            {
                this.FlavorJavaFileListType = FlavorJavaFileListType;
            }
            // use default value if no "FlavorRemoteObjectType" provided
            if (FlavorRemoteObjectType == null)
            {
                this.FlavorRemoteObjectType = false;
            }
            else
            {
                this.FlavorRemoteObjectType = FlavorRemoteObjectType;
            }
            // use default value if no "FlavorSerializedObjectType" provided
            if (FlavorSerializedObjectType == null)
            {
                this.FlavorSerializedObjectType = false;
            }
            else
            {
                this.FlavorSerializedObjectType = FlavorSerializedObjectType;
            }
            // use default value if no "FlavorTextType" provided
            if (FlavorTextType == null)
            {
                this.FlavorTextType = false;
            }
            else
            {
                this.FlavorTextType = FlavorTextType;
            }
            // use default value if no "MimeTypeSerializedObject" provided
            if (MimeTypeSerializedObject == null)
            {
                this.MimeTypeSerializedObject = false;
            }
            else
            {
                this.MimeTypeSerializedObject = MimeTypeSerializedObject;
            }
            // use default value if no "RepresentationClassByteBuffer" provided
            if (RepresentationClassByteBuffer == null)
            {
                this.RepresentationClassByteBuffer = false;
            }
            else
            {
                this.RepresentationClassByteBuffer = RepresentationClassByteBuffer;
            }
            // use default value if no "RepresentationClassCharBuffer" provided
            if (RepresentationClassCharBuffer == null)
            {
                this.RepresentationClassCharBuffer = false;
            }
            else
            {
                this.RepresentationClassCharBuffer = RepresentationClassCharBuffer;
            }
            // use default value if no "RepresentationClassInputStream" provided
            if (RepresentationClassInputStream == null)
            {
                this.RepresentationClassInputStream = false;
            }
            else
            {
                this.RepresentationClassInputStream = RepresentationClassInputStream;
            }
            // use default value if no "RepresentationClassReader" provided
            if (RepresentationClassReader == null)
            {
                this.RepresentationClassReader = false;
            }
            else
            {
                this.RepresentationClassReader = RepresentationClassReader;
            }
            // use default value if no "RepresentationClassRemote" provided
            if (RepresentationClassRemote == null)
            {
                this.RepresentationClassRemote = false;
            }
            else
            {
                this.RepresentationClassRemote = RepresentationClassRemote;
            }
            // use default value if no "RepresentationClassSerializable" provided
            if (RepresentationClassSerializable == null)
            {
                this.RepresentationClassSerializable = false;
            }
            else
            {
                this.RepresentationClassSerializable = RepresentationClassSerializable;
            }
        }
        
        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public string MimeType { get; set; }
        /// <summary>
        /// Gets or Sets HumanPresentableName
        /// </summary>
        [DataMember(Name="humanPresentableName", EmitDefaultValue=false)]
        public string HumanPresentableName { get; set; }
        /// <summary>
        /// Gets or Sets PrimaryType
        /// </summary>
        [DataMember(Name="primaryType", EmitDefaultValue=false)]
        public string PrimaryType { get; set; }
        /// <summary>
        /// Gets or Sets SubType
        /// </summary>
        [DataMember(Name="subType", EmitDefaultValue=false)]
        public string SubType { get; set; }
        /// <summary>
        /// Gets or Sets DefaultRepresentationClassAsString
        /// </summary>
        [DataMember(Name="defaultRepresentationClassAsString", EmitDefaultValue=false)]
        public string DefaultRepresentationClassAsString { get; set; }
        /// <summary>
        /// Gets or Sets FlavorJavaFileListType
        /// </summary>
        [DataMember(Name="flavorJavaFileListType", EmitDefaultValue=false)]
        public bool? FlavorJavaFileListType { get; set; }
        /// <summary>
        /// Gets or Sets FlavorRemoteObjectType
        /// </summary>
        [DataMember(Name="flavorRemoteObjectType", EmitDefaultValue=false)]
        public bool? FlavorRemoteObjectType { get; set; }
        /// <summary>
        /// Gets or Sets FlavorSerializedObjectType
        /// </summary>
        [DataMember(Name="flavorSerializedObjectType", EmitDefaultValue=false)]
        public bool? FlavorSerializedObjectType { get; set; }
        /// <summary>
        /// Gets or Sets FlavorTextType
        /// </summary>
        [DataMember(Name="flavorTextType", EmitDefaultValue=false)]
        public bool? FlavorTextType { get; set; }
        /// <summary>
        /// Gets or Sets MimeTypeSerializedObject
        /// </summary>
        [DataMember(Name="mimeTypeSerializedObject", EmitDefaultValue=false)]
        public bool? MimeTypeSerializedObject { get; set; }
        /// <summary>
        /// Gets or Sets RepresentationClassByteBuffer
        /// </summary>
        [DataMember(Name="representationClassByteBuffer", EmitDefaultValue=false)]
        public bool? RepresentationClassByteBuffer { get; set; }
        /// <summary>
        /// Gets or Sets RepresentationClassCharBuffer
        /// </summary>
        [DataMember(Name="representationClassCharBuffer", EmitDefaultValue=false)]
        public bool? RepresentationClassCharBuffer { get; set; }
        /// <summary>
        /// Gets or Sets RepresentationClassInputStream
        /// </summary>
        [DataMember(Name="representationClassInputStream", EmitDefaultValue=false)]
        public bool? RepresentationClassInputStream { get; set; }
        /// <summary>
        /// Gets or Sets RepresentationClassReader
        /// </summary>
        [DataMember(Name="representationClassReader", EmitDefaultValue=false)]
        public bool? RepresentationClassReader { get; set; }
        /// <summary>
        /// Gets or Sets RepresentationClassRemote
        /// </summary>
        [DataMember(Name="representationClassRemote", EmitDefaultValue=false)]
        public bool? RepresentationClassRemote { get; set; }
        /// <summary>
        /// Gets or Sets RepresentationClassSerializable
        /// </summary>
        [DataMember(Name="representationClassSerializable", EmitDefaultValue=false)]
        public bool? RepresentationClassSerializable { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataFlavor {\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  HumanPresentableName: ").Append(HumanPresentableName).Append("\n");
            sb.Append("  PrimaryType: ").Append(PrimaryType).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  DefaultRepresentationClassAsString: ").Append(DefaultRepresentationClassAsString).Append("\n");
            sb.Append("  FlavorJavaFileListType: ").Append(FlavorJavaFileListType).Append("\n");
            sb.Append("  FlavorRemoteObjectType: ").Append(FlavorRemoteObjectType).Append("\n");
            sb.Append("  FlavorSerializedObjectType: ").Append(FlavorSerializedObjectType).Append("\n");
            sb.Append("  FlavorTextType: ").Append(FlavorTextType).Append("\n");
            sb.Append("  MimeTypeSerializedObject: ").Append(MimeTypeSerializedObject).Append("\n");
            sb.Append("  RepresentationClassByteBuffer: ").Append(RepresentationClassByteBuffer).Append("\n");
            sb.Append("  RepresentationClassCharBuffer: ").Append(RepresentationClassCharBuffer).Append("\n");
            sb.Append("  RepresentationClassInputStream: ").Append(RepresentationClassInputStream).Append("\n");
            sb.Append("  RepresentationClassReader: ").Append(RepresentationClassReader).Append("\n");
            sb.Append("  RepresentationClassRemote: ").Append(RepresentationClassRemote).Append("\n");
            sb.Append("  RepresentationClassSerializable: ").Append(RepresentationClassSerializable).Append("\n");
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
            return this.Equals(obj as DataFlavor);
        }

        /// <summary>
        /// Returns true if DataFlavor instances are equal
        /// </summary>
        /// <param name="other">Instance of DataFlavor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataFlavor other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MimeType == other.MimeType ||
                    this.MimeType != null &&
                    this.MimeType.Equals(other.MimeType)
                ) && 
                (
                    this.HumanPresentableName == other.HumanPresentableName ||
                    this.HumanPresentableName != null &&
                    this.HumanPresentableName.Equals(other.HumanPresentableName)
                ) && 
                (
                    this.PrimaryType == other.PrimaryType ||
                    this.PrimaryType != null &&
                    this.PrimaryType.Equals(other.PrimaryType)
                ) && 
                (
                    this.SubType == other.SubType ||
                    this.SubType != null &&
                    this.SubType.Equals(other.SubType)
                ) && 
                (
                    this.DefaultRepresentationClassAsString == other.DefaultRepresentationClassAsString ||
                    this.DefaultRepresentationClassAsString != null &&
                    this.DefaultRepresentationClassAsString.Equals(other.DefaultRepresentationClassAsString)
                ) && 
                (
                    this.FlavorJavaFileListType == other.FlavorJavaFileListType ||
                    this.FlavorJavaFileListType != null &&
                    this.FlavorJavaFileListType.Equals(other.FlavorJavaFileListType)
                ) && 
                (
                    this.FlavorRemoteObjectType == other.FlavorRemoteObjectType ||
                    this.FlavorRemoteObjectType != null &&
                    this.FlavorRemoteObjectType.Equals(other.FlavorRemoteObjectType)
                ) && 
                (
                    this.FlavorSerializedObjectType == other.FlavorSerializedObjectType ||
                    this.FlavorSerializedObjectType != null &&
                    this.FlavorSerializedObjectType.Equals(other.FlavorSerializedObjectType)
                ) && 
                (
                    this.FlavorTextType == other.FlavorTextType ||
                    this.FlavorTextType != null &&
                    this.FlavorTextType.Equals(other.FlavorTextType)
                ) && 
                (
                    this.MimeTypeSerializedObject == other.MimeTypeSerializedObject ||
                    this.MimeTypeSerializedObject != null &&
                    this.MimeTypeSerializedObject.Equals(other.MimeTypeSerializedObject)
                ) && 
                (
                    this.RepresentationClassByteBuffer == other.RepresentationClassByteBuffer ||
                    this.RepresentationClassByteBuffer != null &&
                    this.RepresentationClassByteBuffer.Equals(other.RepresentationClassByteBuffer)
                ) && 
                (
                    this.RepresentationClassCharBuffer == other.RepresentationClassCharBuffer ||
                    this.RepresentationClassCharBuffer != null &&
                    this.RepresentationClassCharBuffer.Equals(other.RepresentationClassCharBuffer)
                ) && 
                (
                    this.RepresentationClassInputStream == other.RepresentationClassInputStream ||
                    this.RepresentationClassInputStream != null &&
                    this.RepresentationClassInputStream.Equals(other.RepresentationClassInputStream)
                ) && 
                (
                    this.RepresentationClassReader == other.RepresentationClassReader ||
                    this.RepresentationClassReader != null &&
                    this.RepresentationClassReader.Equals(other.RepresentationClassReader)
                ) && 
                (
                    this.RepresentationClassRemote == other.RepresentationClassRemote ||
                    this.RepresentationClassRemote != null &&
                    this.RepresentationClassRemote.Equals(other.RepresentationClassRemote)
                ) && 
                (
                    this.RepresentationClassSerializable == other.RepresentationClassSerializable ||
                    this.RepresentationClassSerializable != null &&
                    this.RepresentationClassSerializable.Equals(other.RepresentationClassSerializable)
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
                if (this.MimeType != null)
                    hash = hash * 59 + this.MimeType.GetHashCode();
                if (this.HumanPresentableName != null)
                    hash = hash * 59 + this.HumanPresentableName.GetHashCode();
                if (this.PrimaryType != null)
                    hash = hash * 59 + this.PrimaryType.GetHashCode();
                if (this.SubType != null)
                    hash = hash * 59 + this.SubType.GetHashCode();
                if (this.DefaultRepresentationClassAsString != null)
                    hash = hash * 59 + this.DefaultRepresentationClassAsString.GetHashCode();
                if (this.FlavorJavaFileListType != null)
                    hash = hash * 59 + this.FlavorJavaFileListType.GetHashCode();
                if (this.FlavorRemoteObjectType != null)
                    hash = hash * 59 + this.FlavorRemoteObjectType.GetHashCode();
                if (this.FlavorSerializedObjectType != null)
                    hash = hash * 59 + this.FlavorSerializedObjectType.GetHashCode();
                if (this.FlavorTextType != null)
                    hash = hash * 59 + this.FlavorTextType.GetHashCode();
                if (this.MimeTypeSerializedObject != null)
                    hash = hash * 59 + this.MimeTypeSerializedObject.GetHashCode();
                if (this.RepresentationClassByteBuffer != null)
                    hash = hash * 59 + this.RepresentationClassByteBuffer.GetHashCode();
                if (this.RepresentationClassCharBuffer != null)
                    hash = hash * 59 + this.RepresentationClassCharBuffer.GetHashCode();
                if (this.RepresentationClassInputStream != null)
                    hash = hash * 59 + this.RepresentationClassInputStream.GetHashCode();
                if (this.RepresentationClassReader != null)
                    hash = hash * 59 + this.RepresentationClassReader.GetHashCode();
                if (this.RepresentationClassRemote != null)
                    hash = hash * 59 + this.RepresentationClassRemote.GetHashCode();
                if (this.RepresentationClassSerializable != null)
                    hash = hash * 59 + this.RepresentationClassSerializable.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}