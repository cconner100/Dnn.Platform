﻿#region Copyright
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2013
// by DotNetNuke Corporation
// All Rights Reserved
#endregion

using System.Runtime.Serialization;

namespace DotNetNuke.Services.Subscriptions.Entities
{
    /// <summary>
    /// A class containing everything needed to reference a specific subscription without using the primary key
    /// </summary>
    [DataContract]
    public class SubscriptionDescription
    {
        /// <summary>
        /// The site the subscription is associated with
        /// </summary>
        [DataMember(Name = "portalId")]
        public int PortalId { get; set; }

        /// <summary>
        /// The type of subscription.
        /// </summary>
        [DataMember(Name = "subscriptionTypeId")]
        public int SubscriptionTypeId { get; set; }

        /// <summary>
        /// The user the subscription is associated with
        /// </summary>
        [DataMember(Name = "userId")]
        public int UserId { get; set; }

        /// <summary>
        /// Content Item ID the subscription is referencing (if any)
        /// </summary>
        [DataMember(Name = "contentItemId")]
        public int ContentItemId { get; set; }

        /// <summary>
        /// Object key providing additional information on the subscription (if any). It is used as a 'filtering' mechanics for a specific subscription type.
        /// </summary>
        [DataMember(Name = "objectKey")]
        public string ObjectKey { get; set; }

        /// <summary>
        /// Associates the subsciptoin with a module (important for items not associated with a specific content item; ie. new content item subs)
        /// </summary>
        [DataMember(Name = "moduleId")]
        public int ModuleId { get; set; }

        /// <summary>
        /// Associates the subscription with a specific group (important for modules that operate in group mode). 
        /// </summary>
        [DataMember(Name = "groupId")]
        public int GroupId { get; set; }
    }
}