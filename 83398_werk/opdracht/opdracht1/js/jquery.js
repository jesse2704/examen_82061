


//$('#divbutton1').innerHTML=data.coord.lat;

//http:api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=76936513dcdda5c1c5a4a8d0f9d673b4
	
	$(document).ready(function(){
		  $("#button1").click(function(){
	 

			  $.getJSON("http://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=76936513dcdda5c1c5a4a8d0f9d673b4", function(data) {
               		  
				  var text = "Date: ${data.main}";
			  });
                    
        
        $("#show").html(text);
    });
	});
//		   
//    $.getJSON("http:api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=76936513dcdda5c1c5a4a8d0f9d673b4")
//    .done(function (data) {
//        console.log ("function 'done' ");
//        //hier laat je de gegevens in een tabel zien
//        var output = "<p>";
//        var output = data.main;
//        var output = data.main;
//        var output = "</p>";
//    
//        $("#show").html(output);
//    }); 
