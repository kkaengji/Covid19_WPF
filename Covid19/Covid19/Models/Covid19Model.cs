using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19.Models
{
    public class Covid19Model
    {
        public string Local { get; set; } // 지역명

        public int Coronic { get; set; } // 확진자 수

        public int C_cnt { get; set; } // 증감 수

        public int C_death { get; set; } // 사망자 수

        public string C_day { get; set; } // 기준일시
    }
}