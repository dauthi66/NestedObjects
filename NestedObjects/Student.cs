using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Reprepresents an individual college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Legal first name
        /// </summary>
        public string FirstName {  get; set; }
        /// <summary>
        /// Legal last name
        /// </summary>
        public string LastName {  get; set; }
        /// <summary>
        /// The assigned school email 
        /// </summary>
        public string SchoolEmail {  get; set; }
        /// <summary>
        /// Current advisor assigned to student
        /// </summary>
        public Advisor AssignedAdvisor {  get; set; }
    }
}
 