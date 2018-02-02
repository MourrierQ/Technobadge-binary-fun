using Autofac;
using BinaryPuzzle.DataAccess;
using BinaryPuzzle.UI.ViewModel;
using BinaryPuzzle.UI.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace BinaryPuzzle.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();

            builder.RegisterType<BinaryPuzzleDbContext>().AsSelf();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<UserSelectionViewModel>().As<IUserSelectionViewModel>();
            builder.RegisterType<DifficultySelectionViewModel>().As<IDifficultySelectionViewModel>();
            builder.RegisterType<GameGridViewModel>().As<IGameGridViewModel>();
            builder.RegisterType<TimerViewModel>().As<ITimerViewModel>();

            builder.RegisterType<LookupDataService>().AsImplementedInterfaces();
            builder.RegisterType<UserDataService>().As<IUserDataService>();
            builder.RegisterType<DifficultyDataService>().As<IDifficultyDataService>();

            return builder.Build();
        }
    }
}
