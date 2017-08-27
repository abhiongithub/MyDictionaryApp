﻿using System;
using System.Threading.Tasks;
using MyDictionary.ViewModels;

namespace MyDictionary.Services
{
	public interface INavigationService
	{
		Task InitializeAsync();

		Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;

		Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;

		Task NavigateToAsync(Type viewModelType);

		Task NavigateToAsync(Type viewModelType, object parameter);

		Task NavigateBackAsync();

		Task RemoveLastFromBackStackAsync();
	}
}
