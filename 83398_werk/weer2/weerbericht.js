
  $( document ).ready(function() {
    console.log( "ready!" );
    
    $("#laatzien").click(function() {
       

      $.getJSON('http://api.openweathermap.org/data/2.5/weather?q=Rotterdam,nl&APPID=76936513dcdda5c1c5a4a8d0f9d673b4&lang=nl', function(data) {
      
      //output is the JSON string
        var output = "";
        console.log(data);

        output += "<div id='info'>";
        //icoon
        var icoon = data.weather[0].icon;
        var iconurl = "http://openweathermap.org/img/w/" + icoon + ".png";
        output += "<img id='wicon' src='" +iconurl + " ' alt='Weather icon'>";
        output += "<br>" ;


        //weer mededeling
        output += "Het weer in "
        output += data.name +", "+ data.sys.country ;
        output += "<br>" ;
  
        var temp = data.main.temp - 273.15;
        var tempinc = Math.round(temp);
        output += "Het is nu " + tempinc + "&#8451" ;
        output += "<br>";
        
        var beschrijving = data.weather[0].description;
        output += "Vandaag is het " + beschrijving ;
        output += "<br>";

        var gevoeltemp = data.main.feels_like - 273.15;
        var gevoeltempinc = Math.round(gevoeltemp);
        output += "Gevoels temp " + gevoeltempinc + "&#8451" ;

        output += "<br>";



        var mintemp = data.main.temp_min - 273.15;
        var mintempinc = Math.round(mintemp);
        output += "Min temp " + mintempinc + "&#8451" ;
        // output += "<br>";

        var maxtemp = data.main.temp_max - 273.15;
        var maxtempinc = Math.round(maxtemp);
        output += " Max temp " + maxtempinc + "&#8451" ;
        output += "<br>";
        output += "</id>";



        var sunset = data.sys.sunset;
        var zononder = new Date(sunset*1000);

        console.log(zononder);   

        var sunrise = data.sys.sunrise;
        var zonop = new Date(sunrise*1000);

        console.log(zonop);




        if (zononder > zonop ) {
        document.body.style.background = "#414141";
          document.getElementById
        } 
        // else {
        // document.body.style.background = "Blue";
        // }

        $("#weertoon").html(output);  
      });


    });
});