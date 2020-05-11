//zet de gegevens in een array 
var items = [];

function guardarNumeros() {
  boxvalue = document.getElementById('box').value;
  items.push(boxvalue);  
  console.log(items);
}

function guardarNumeros() {
    boxvalue = document.getElementById('box').value;
    items.push(boxvalue);  
    console.log(items);
    localStorage.setItem("items", JSON.stringify(items)); 
    
    return false;
  }

//   var hoi = "hoi";
//   console.log(hoi);


// var array = [1, 2, 3];

function showLocalItems() {
    item1 = JSON.parse(localStorage.getItem("items"));
    console.log(item1);
}

function gegevens(){
var x = item1.toString();
  document.getElementById("demo").innerHTML = x;
}

console.log(typeof items); //object
console.log(items); //[1, 2, 3]

console.log(localStorage);