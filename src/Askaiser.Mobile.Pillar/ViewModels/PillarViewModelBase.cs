﻿namespace Askaiser.Mobile.Pillar.ViewModels
{
    /// <summary>
    /// The preffered ViewModel class of every ViewModel which can be bound to a View
    /// in the app bootstrapping configuration.
    /// It already contains some useful observable properties.
    /// </summary>
    /// <seealso cref="ViewModelBase" />
    /// <seealso cref="IViewModel" />
    public abstract class PillarViewModelBase : ViewModelBase, IViewModel
    {
        private string _title;
        private bool _isBusy;

        /// <summary>
        /// Represents the page Title.
        /// It's up to you to bind this property to a Page title.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { Set(() => Title, ref _title, value); }
        }

        /// <summary>
        /// If true, the associated Page will not exists in the navigation stack.
        /// A good example is a login screen, once you are logged in and on a different page,
        /// if you press the back button you won't return to the login screen.
        /// </summary>
        public bool NoHistory { get; set; }

        /// <summary>
        /// Indicates that a long running or background process is running.
        /// You might want to use this with a BooleanConverter to show / hide controls during the process.
        /// </summary>
        public bool IsBusy
        {
            get { return _isBusy; }
            set { Set(() => IsBusy, ref _isBusy, value); }
        }

        public virtual void ViewEntering()
        { }

        public virtual void ViewEntered()
        { }

        public virtual void ViewLeaving()
        { }

        public virtual void ViewLeaved()
        { }
    }
}

