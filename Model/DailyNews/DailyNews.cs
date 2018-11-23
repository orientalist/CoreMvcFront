using System;

namespace CoreMvcFront.Model{
    public class DailyNews{
        public int ID{get;set;}

        public DateTime NewsDate{get;set;}

        public string Subject{get;set;}

        public string Context{get;set;}

        public int Status{get;set;}
    }
}