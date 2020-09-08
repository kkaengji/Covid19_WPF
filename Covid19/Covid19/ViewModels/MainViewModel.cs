using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Covid19.ViewModels
{
    class MainViewModel : Conductor<object>, IHaveDisplayName
    {
        #region 날짜 영역
        DispatcherTimer CurrentTimer;

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

        private void SetTimeNow()
        {
            NowDate = DateTime.Now.ToString("( yyyy.MM.dd )");
        }
        #endregion
    }
}
