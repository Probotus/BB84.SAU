﻿using System.Collections.ObjectModel;

using BB84.SAU.Application.Interfaces.Application.Services;
using BB84.SAU.Application.ViewModels.Base;
using BB84.SAU.Domain.Models;

namespace BB84.SAU.Application.ViewModels;

/// <summary>
/// The logbook view model class.
/// </summary>
/// <param name="notificationService">The notification service instance to use.</param>
public sealed class LogbookViewModel(INotificationService notificationService) : ViewModelBase
{
	/// <summary>
	/// The logbook entries to show.
	/// </summary>
	public ObservableCollection<LogbookModel> LogbookEntries
		=> notificationService.Messages;
}
