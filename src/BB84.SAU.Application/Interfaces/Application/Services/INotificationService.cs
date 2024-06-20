﻿using System.Diagnostics.CodeAnalysis;

namespace BB84.SAU.Application.Interfaces.Application.Services;

/// <summary>
/// The NotificationService interface.
/// </summary>
public interface INotificationService
{
	/// <summary>
	/// The event handler for message receiving.
	/// </summary>
	event AsyncNotificationEventHandler? MessageReceived;

	/// <summary>
	/// Sends a <paramref name="message"/> to all the subscribers.
	/// </summary>
	/// <param name="message">The message to send.</param>
	void Send(string message);
}

/// <summary>
/// Represents the method that will handle an notification event when the event provides message data.
/// </summary>
/// <param name="sender">The source of the event.</param>
/// <param name="message">An <see cref="string"/> that contains the event message.</param>
/// <returns><see cref="Task"/></returns>
[SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "I want it that way.")]
public delegate Task AsyncNotificationEventHandler(object sender, string message);
