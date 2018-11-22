using System.Collections.Generic;
using CoreMvcFront.Model;
using System.Linq;

namespace CoreMvcFront.Services{
    public class DailyNewsBL{
        private DailyNewsData dailyNewsData;

        public DailyNewsBL(){
            dailyNewsData=new DailyNewsData();
        }

        public List<DailyNews> GetDailyNews(string Conn){
            return dailyNewsData.GetDailyNews(Conn);
        }
    }
}