/*
 * Swagger Petstore - OpenAPI 3.0
 *
 * This is an opeapi specification for lab project 1  Made by _Oleksandr Myroshnychenko_  Group - 6.04.121.10.19.2
 *
 * OpenAPI spec version: 1.0.11
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Exam : IEquatable<Exam>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Mark
        /// </summary>

        [DataMember(Name="Mark")]
        public decimal? Mark { get; set; }

        /// <summary>
        /// Gets or Sets StudentId
        /// </summary>

        [DataMember(Name="StudentId")]
        public int? StudentId { get; set; }

        /// <summary>
        /// Gets or Sets SubjectId
        /// </summary>

        [DataMember(Name="SubjectId")]
        public int? SubjectId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Exam {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Mark: ").Append(Mark).Append("\n");
            sb.Append("  StudentId: ").Append(StudentId).Append("\n");
            sb.Append("  SubjectId: ").Append(SubjectId).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Exam)obj);
        }

        /// <summary>
        /// Returns true if Exam instances are equal
        /// </summary>
        /// <param name="other">Instance of Exam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Exam other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Mark == other.Mark ||
                    Mark != null &&
                    Mark.Equals(other.Mark)
                ) && 
                (
                    StudentId == other.StudentId ||
                    StudentId != null &&
                    StudentId.Equals(other.StudentId)
                ) && 
                (
                    SubjectId == other.SubjectId ||
                    SubjectId != null &&
                    SubjectId.Equals(other.SubjectId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Mark != null)
                    hashCode = hashCode * 59 + Mark.GetHashCode();
                    if (StudentId != null)
                    hashCode = hashCode * 59 + StudentId.GetHashCode();
                    if (SubjectId != null)
                    hashCode = hashCode * 59 + SubjectId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Exam left, Exam right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Exam left, Exam right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
