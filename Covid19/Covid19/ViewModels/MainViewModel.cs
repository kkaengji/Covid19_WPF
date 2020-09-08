using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19.ViewModels
{
    class MainViewModel : Conductor<object>, IHaveDisplayName
    {
        public MainViewModel()
        {
            ActivateItem(new KoreaViewModel());
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
    }
}
