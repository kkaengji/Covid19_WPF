using Caliburn.Micro;
using Covid19.Helpers;
using Covid19.Models;
using Covid19.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Covid19.ViewModels
{
    class KoreaViewModel : Conductor<object>, IHaveDisplayName
    {
        #region API 속성 영역

        string local;
        public string Local
        {
            get => local;
            set
            {
                local = value;
                NotifyOfPropertyChange(() => Local);
            }
        }

        int coronic;
        public int Coronic
        {
            get => coronic;
            set
            {
                coronic = value;
                NotifyOfPropertyChange(() => Coronic);
            }
        }

        int c_cnt;
        public int C_cnt
        {
            get => c_cnt;
            set
            {
                c_cnt = value;
                NotifyOfPropertyChange(() => C_cnt);
            }
        }

        int c_death;
        public int C_death
        {
            get => c_death;
            set
            {
                c_death = value;
                NotifyOfPropertyChange(() => C_death);
            }
        }

        string c_day;
        public string C_day
        {
            get => c_day;
            set
            {
                c_day = value;
                NotifyOfPropertyChange(() => C_day);
            }
        }

        // 검색
        string txtSearchItem;
        public string TxtSearchItem
        {
            get => txtSearchItem;
            set
            {
                txtSearchItem = value;
                NotifyOfPropertyChange(() => TxtSearchItem);
            }
        }

        // 전체 dgvSearchItems 리스트
        BindableCollection<Covid19Model> dgvSearchItems;

        public BindableCollection<Covid19Model> DgvSearchItems
        {
            get => dgvSearchItems;
            set
            {
                dgvSearchItems = value;
                NotifyOfPropertyChange(() => DgvSearchItems);
            }
        }

        // 리스트 중 선택된 하나의 Items
        Covid19Model selectedCovid;

        public Covid19Model SelectedCovid
        {
            get => selectedCovid;
            set
            {
                selectedCovid = value;

                if (value != null)
                {
                    Local = value.Local;
                    Coronic = value.Coronic;
                    C_cnt = value.C_cnt;
                    C_death = value.C_death;
                    C_day = value.C_day;
                }

                NotifyOfPropertyChange(() => SelectedCovid);
            }
        }
        
        #endregion

        public KoreaViewModel()
        {

        }

        private void ButSearch() // 검색 버튼 클릭 시
        {
            WebClient wc = null;
            XmlDocument doc = null;

            wc = new WebClient() { Encoding = Encoding.UTF8 };
            doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://openapi.data.go.kr/openapi/service/rest/Covid19/getCovid19SidoInfStateJson"); // 기본 URL
            str.Append($"?serviceKey={Commons.CovidAPI_KEY}"); // 인증키

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");

            foreach (XmlNode item in items)
            {
            }
        }
    }
}
