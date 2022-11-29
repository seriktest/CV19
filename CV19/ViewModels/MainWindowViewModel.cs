﻿using CV19.ViewModels.Base;

namespace CV19.ViewModels;

internal class MainWindowViewModel: ViewModel
{
    #region Заголовок окна
    /// <summary>
    /// Заголовок окна
    /// </summary>
    private string _title = "Анализ";
    public string Title
    {
        get => _title;
        set => Set(ref _title, value);
        /*set
        {
            if(Equals(_title, value)) return;
            _title = value;
            OnPropertyChanged();
        }OnPropertyChanged*/
    }

    #endregion
}