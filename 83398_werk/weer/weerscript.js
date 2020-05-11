
  $( document ).ready(function() {
    console.log( "ready!" );
    
    $("#laatzien").click(function() {
       

      $.getJSON('http://api.openweathermap.org/data/2.5/weather?q=Rotterdam,nl&APPID=76936513dcdda5c1c5a4a8d0f9d673b4&lang=nl', function(data) {
      
      //output is the JSON string
        var output = "";
        console.log(data);

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
        output += "Gevoels tempratuur " + gevoeltempinc + "&#8451" ;

        output += "<br>";
        // output += data.sys.country ;
        output += "<br>";
        // output += data.main.temp ;
        output += "<br>";
        console.log("test");
        console.log ("land " + data.sys.country);


        var icoon = data.weather[0].icon;
        // output += data.weather[0].icon;

        var iconurl = "http://openweathermap.org/img/w/" + icoon + ".png";

        // output += iconurl;

        // $('#wicon').attr('src', iconurl);
      

        output += "<img id='wicon' src='" +iconurl + " ' alt='Weather icon'>";


        output += "<br>";output += "<br>";
        var mintemp = data.main.temp_min - 273.15;
        var mintempinc = Math.round(mintemp);
        output += "Minimum tempratuur vandaag is " + mintempinc + "&#8451" ;
        output += "<br>";

        var maxtemp = data.main.temp_max - 273.15;
        var maxtempinc = Math.round(maxtemp);
        output += "Maximum tempratuur vandaag is " + maxtempinc + "&#8451" ;
        output += "<br>";



        $("#weertoon").html(output);  
      });


    });
});