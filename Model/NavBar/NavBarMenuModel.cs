using System.Collections.Generic;

namespace CoreMvcFront.Model{
    public class NavBarMenuModel{
        public string txt{get;set;}

        public int ID{get;set;}
        public string Controller{get;set;}

        public string Action{get;set;}

        public bool expandex{get;set;}=false;

        public IEnumerable<NavBarItem> items{get;set;}
    }
}