using System.Collections.Generic;
using CoreMvcFront.Model;
using System.Linq;

namespace CoreMvcFront.Services{
    public class NavBarBL{
        private NavBarDL navBarData;
        public NavBarBL(){
            navBarData=new NavBarDL();
        }

        public List<NavBarMenuModel> GetAllNavBar(string Conn){
            List<NavBarItem> Items=navBarData.GetAllItems(Conn);
            List<NavBarMenuModel> navBarMenus=new List<NavBarMenuModel>();
            if(Items.Count>0){
                foreach(NavBarItem item in Items.Where(i=>i.ItemStatus==1)){
                    NavBarMenuModel menuModel=new NavBarMenuModel();
                    menuModel.ID=item.ID;
                    menuModel.txt=item.ItemName;
                    menuModel.Controller=item.ItemController;
                    menuModel.Action=item.ItemAction;
                    navBarMenus.Add(menuModel);
                }                
            }
            return navBarMenus;
        }
    }
}