using System;
using System.ComponentModel;

namespace SmsBomber
{
    [Serializable]
    public class ControlsViewModel : INotifyPropertyChanged
    {

        private string _countCycle;
        private string _delay;
        private string _countThreads;
        private string _phoneNumber;
        private string _numberPhoneNumber;

        private bool _sitesAlpari;
        private bool _sitesFindClone;
        private bool _sitesTwitch;
        private bool _sitesTinder;
        private bool _sitesInvitro;
        private bool _sitesYoula;
        private bool _sitesGuruTaxi;

        #region Настройки программы
        public string CountCycle
        {
            get { return _countCycle; }
            set
            {
                _countCycle = value;
                NotifyPropertyChanged(nameof(CountCycle));
            }
        }

        public string Delay
        {
            get { return _delay; }
            set
            {
                _delay = value;
                NotifyPropertyChanged(nameof(Delay));
            }
        }

        public string CountThreads
        {
            get { return _countThreads; }
            set
            {
                _countThreads = value;
                NotifyPropertyChanged(nameof(CountThreads));
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                NotifyPropertyChanged(nameof(PhoneNumber));
            }
        }

        public string NumberPhoneNumber
        {
            get { return _numberPhoneNumber; }
            set
            {
                _numberPhoneNumber = value;
                NotifyPropertyChanged(nameof(NumberPhoneNumber));
            }
        }
        #endregion

        #region Сохранение чекбоксов с сайтами
        public bool SitesAlpari
        {
            get { return _sitesAlpari; }
            set
            {
                _sitesAlpari = value;
                NotifyPropertyChanged(nameof(SitesAlpari));
            }
        }

        public bool SitesFindClone
        {
            get { return _sitesFindClone; }
            set
            {
                _sitesFindClone = value;
                NotifyPropertyChanged(nameof(SitesFindClone));
            }
        }

        public bool SitesTwitch
        {
            get { return _sitesTwitch; }
            set
            {
                _sitesTwitch = value;
                NotifyPropertyChanged(nameof(SitesTwitch));
            }
        }

        public bool SitesTinder
        {
            get { return _sitesTinder; }
            set
            {
                _sitesTinder = value;
                NotifyPropertyChanged(nameof(SitesTinder));
            }
        }

        public bool SitesInvitro
        {
            get { return _sitesInvitro; }
            set
            {
                _sitesInvitro = value;
                NotifyPropertyChanged(nameof(SitesInvitro));
            }
        }

        public bool SitesYoula
        {
            get { return _sitesYoula; }
            set
            {
                _sitesYoula = value;
                NotifyPropertyChanged(nameof(SitesYoula));
            }
        }

        public bool SitesGuruTaxi
        {
            get { return _sitesGuruTaxi; }
            set
            {
                _sitesGuruTaxi = value;
                NotifyPropertyChanged(nameof(SitesGuruTaxi));
            }
        }
        #endregion

        private void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
