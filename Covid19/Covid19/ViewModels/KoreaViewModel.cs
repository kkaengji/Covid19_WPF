using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19.ViewModels
{
    class KoreaViewModel : Conductor<object>, IHaveDisplayName
    {
        public KoreaViewModel()
        {
            Coronic(); // 확진자 수
        }

        private void Coronic()
        {

        }
    }
}
