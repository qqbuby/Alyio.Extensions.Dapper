﻿using System.Xml.Serialization;

namespace Dapper.Extensions.DataAccess
{
    /// <summary>
    /// A mapped UPDATE statement. 
    /// </summary>
    [XmlRoot("update")]
    public sealed class UpdateDefinition : BaseDefinition
    {
        /// <summary>
        /// Gets or sets the primary key column name of the table.
        /// </summary>
        [XmlAttribute("idName")]
        public string? IdName { get; set; }
    }
}
