﻿using System.Collections.ObjectModel;

using BB84.SAU.Application.Interfaces.Application.Services;
using BB84.SAU.Application.ViewModels.Base;
using BB84.SAU.Domain.Models;

namespace BB84.SAU.Application.ViewModels;

/// <summary>
/// The logbook view model class.
/// </summary>
public sealed class LogbookViewModel : ViewModelBase
{
	private readonly INotificationService _notificationService;

	/// <summary>
	/// Initializes a new instance of the <see cref="LogbookViewModel"/> class.
	/// </summary>
	/// <param name="notificationService">The notification service instance to use.</param>
	public LogbookViewModel(INotificationService notificationService)
	{
		_notificationService = notificationService;
		_notificationService.NotificationReceived += (sender, message) => OnNotificationReceived(message);
		LogbookEntries = [];
	}

	/// <summary>
	/// The logbook entries to show.
	/// </summary>
	public ObservableCollection<LogbookModel> LogbookEntries { get; }

	private void OnNotificationReceived(string message)
		=> LogbookEntries.Add(new(message));
}
