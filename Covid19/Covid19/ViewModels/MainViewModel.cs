using Caliburn.Micro;
using System;
using System.Windows.Threading;
using System.Windows;
using System.Globalization;

namespace Covid19.ViewModels
{
    class MainViewModel : Conductor<object>, IHaveDisplayName
    {
        #region 날짜 영역
        DispatcherTimer CurrentTimer;

        string nowTime;
        public string NowTime
        {
            get => nowTime;
            set
            {
                nowTime = value;
                NotifyOfPropertyChange(() => NowTime);
            }
        }

        string nowDate;
        public string NowDate
        {
            get => nowDate;
            set
            {
                nowDate = value;
                NotifyOfPropertyChange(() => NowDate);
            }
        }

        #endregion

        public MainViewModel()
        {

            ActivateItem(new KoreaViewModel()); 

            SetTimeNow(); // 날짜
        }

        #region 버튼 클릭 이벤트

        public void KoreaTab()
        {
            ActivateItem(new KoreaViewModel());
        }

        public void ForeignCountryTab()
        {
            ActivateItem(new ForeignCountryViewModel());
        }

        #endregion

        #region 날짜 함수
        private void UpdateTime()
        {
            CurrentTimer = new DispatcherTimer();
            CurrentTimer.Interval = TimeSpan.FromSeconds(1);
            CurrentTimer.Tick += Time_Tick2;
            CurrentTimer.Start();
        }

        private void Time_Tick2(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.BeginInvoke((System.Action)(() => SetTimeNow()));
        }

        private void SetTimeNow()
        {
            NowTime = DateTime.Now.ToString("tt hh:mm )", new CultureInfo("en-US"));
            NowDate = DateTime.Now.ToString("( yyyy.MM.dd ");
        }
        #endregion
    }
}
