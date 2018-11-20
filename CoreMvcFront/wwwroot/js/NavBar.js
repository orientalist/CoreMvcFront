$(document).ready(function(){
    GetAllNavBar();
});
var GetAllNavBar=function(){
    $.ajax({
        url:"/WebAPIs/GetAllNavBar",
        type:"GET"
    }).done(function(result){        
        if(result.httpStatus==1){            
            $.each(result.data,function(index,value){
                var li='<li class="nav-item active"><a class="nav-link" href="/'+value.controller+"/"+value.action+'">'+value.txt+'</a></li>';
                $("#navbarAll").append(li);
            });
        }                
    });
}