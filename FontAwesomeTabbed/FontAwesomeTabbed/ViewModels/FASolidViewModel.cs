using FontAwesome;
using FontAwesomeTabbed.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FontAwesomeTabbed.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class FASolidViewModel : BaseViewModel
    {
        private Icon _scrollToIcon;
        public Icon ScrollToIcon
        {
            get => _scrollToIcon;
            set => _scrollToIcon = value;
        }

        public ICommand ScrollToTopCommand { get; set; }
        public ICommand ScrollToBottomCommand { get; set; }

        ObservableCollection<Icon> _icons { get; }
        public ObservableCollection<Icon> Icons
        {
            get
            {
                ObservableCollection<Icon> theCollection = new ObservableCollection<Icon>();

                if (_icons != null)
                {
                    List<Icon> entities = (from e in _icons
                                           where e.Name.ToLower().Contains(_searchText.ToLower())
                                           select e).ToList();
                    if (entities != null && entities.Any())
                        theCollection = new ObservableCollection<Icon>(entities);
                }

                return theCollection;
            }
        }

        public ICommand RefreshCommand { get; }
        bool isRefreshing;
        public bool IsRefreshing
        {
            get => isRefreshing;
            set
            {
                isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        private Command _searchCommand;
        public ICommand SearchCommand
        {
            get
            {
                _searchCommand = _searchCommand ?? new Command(DoSearchCommand, CanExecuteSearchCommand);
                return _searchCommand;
            }
        }

        private string _searchText = string.Empty;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                if (_searchText != value)
                {
                    _searchText = value ?? string.Empty;
                    OnPropertyChanged(nameof(SearchText));

                    if (SearchCommand.CanExecute(null))
                        SearchCommand.Execute(null);
                }
            }
        }

        public FASolidViewModel()
        {
            _icons = ExecuteIconCollection();
            RefreshCommand = new Command(ExecuteRefreshCommand);

            ScrollToTopCommand = new Command(ExcuteScrollToTop);
            ScrollToBottomCommand = new Command(ExcuteScrollToBottom);
        }

        ObservableCollection<Icon> ExecuteIconCollection()
        {
            ObservableCollection<Icon> icons = new ObservableCollection<Icon>();

            foreach (var icon in GetAllIcons())
                icons.Add(icon);

            return icons;
        }

        List<Icon> GetAllIcons()
        {
            List<Icon> icons = new List<Icon>();
            Icon icon;

            Type type = typeof(FontAwesomeSolid);
            foreach (var property in type.GetFields())
            {
                icon = new Icon() { Glyph = property.GetValue(null).ToString(), Name = property.Name, FontFamily = "FASolid" };
                icons.Add(icon);
            }

            return icons;
        }

        private void DoSearchCommand() => OnPropertyChanged(nameof(Icons));
        private bool CanExecuteSearchCommand() => true;

        void ExecuteRefreshCommand()
        {
            Icons.Clear();
            IsRefreshing = false;
        }

        void ExcuteScrollToTop()
        {
            ScrollToIcon = Icons.FirstOrDefault();
            OnPropertyChanged(nameof(ScrollToIcon));
        }
        void ExcuteScrollToBottom()
        {
            ScrollToIcon = Icons.LastOrDefault();
            OnPropertyChanged(nameof(ScrollToIcon));
        }
    }
}