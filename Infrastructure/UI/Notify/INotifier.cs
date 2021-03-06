﻿using System;
using System.Collections.Generic;

namespace CompatibleSoftware.Infrastructure.UI.Notify
{
    public interface INotifier
    {
        /// <summary>
        /// Adds a new UI notification
        /// </summary>
        /// <param name="type">
        /// The type of the notification (notifications with different types can be displayed differently)</param>
        /// <param name="message">A localized message to display</param>
        void Add(NotifyType type, String message);

        /// <summary>
        /// Get all notifications added
        /// </summary>
        IEnumerable<NotifyEntry> List();
    }
}
