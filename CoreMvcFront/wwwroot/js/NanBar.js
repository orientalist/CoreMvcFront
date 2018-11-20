$(document).ready(function(){
    GetAllNavBar();
});
var GetAllNavBar=function(){
    $.ajax({
        url:"WebAPIs/GetAllNavBar",
        type:"GET"
    }).done(function(result){
        console.log(result);
    });
}