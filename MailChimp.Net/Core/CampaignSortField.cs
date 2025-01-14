
using System;
using System.ComponentModel;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// Campaign sort field.
    /// </summary>
    [Flags]
    public enum CampaignSortField
    {
        /// <summary>
        /// The send time.
        /// </summary>
        [Description("send_time")]
        SendTime = 1,

        /// <summary>
        /// The send time.
        /// </summary>
        [Description("create_time")]
        CreateTime = 2

    }
}