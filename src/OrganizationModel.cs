﻿//-----------------------------------------------------------------------
// <copyright file="OrganizationModel.cs" company="GlobalLink Vasont">
//     Copyright (c) GlobalLink Vasont. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Vasont.Publish.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This class represents an organization.
    /// </summary>
    public class OrganizationModel
    {
        /// <summary>
        /// Gets or sets the organization identifier.
        /// </summary>
        /// <value>
        /// The organization identifier.
        /// </value>
        [StringLength(200)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
    }
}
