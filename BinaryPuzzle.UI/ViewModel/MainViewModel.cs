﻿using BinaryPuzzle.UI.Event;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPuzzle.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel(IUserSelectionViewModel userSelectionViewModel, IDifficultySelectionViewModel difficultySelectionViewModel, IGameGridViewModel gameGridViewModel, IEventAggregator eventAggregator)
        {
            UserSelectionViewModel = userSelectionViewModel;
            DifficultySelectionViewModel = difficultySelectionViewModel;
            GameGridViewModel = gameGridViewModel;
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<GenerateGridEvent>().Subscribe(OnGenerateGrid);
            _eventAggregator.GetEvent<OnClickEvent>().Subscribe(OnClick);
        }

        private void OnClick(OnClickEventArgs obj)
        {
            GameGridViewModel.OnClick(obj);
        }

        private void OnGenerateGrid(GenerateGridEventArgs obj)
        {
            GameGridViewModel.GenerateGrid(obj);
        }

        public async Task LoadAsync()
        {
            await UserSelectionViewModel.LoadAsync();
            await DifficultySelectionViewModel.LoadAsync();
        }


        public IUserSelectionViewModel UserSelectionViewModel { get; }

        public IDifficultySelectionViewModel DifficultySelectionViewModel { get; }
        public IGameGridViewModel GameGridViewModel { get; }

        private IEventAggregator _eventAggregator;
    }
}
