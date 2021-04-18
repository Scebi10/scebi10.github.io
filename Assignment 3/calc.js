/*
   Calculator Forms Style Sheet
   Author: Scebi
   Date:   20201/04/04

*/

//document.getElementById("add").onclick = function() {add()};
//function add(){
 // var a = parseInt(document.getElementById("value1").value);
  // var b = parseInt(document.getElementById("value1").value);
   
   //var op = document.getElementById("operator").value;
//   var addResults = a+b;
 //  document.getElementById("display").innerHTML = addResults;






   //if(document.getElementById("add").onclick = function() {
  //    calculate = a + b;
  // } else if(op == "multiply"){
  //    calculate = a * b
  // }else if(op == "divide"){
 //     calculate = a / b
 //  }
   
  // document.getElementById("display").innerHTML = calculate;
  // document.querySelector("results").innerHTML;
//}
// function add() {
//    var a = document.getElementById("aVl").value;
// var b = document.getElementById("bVl").value;
// var addResults =parseInt(a) + parseInt(b);
//    document.getElementById("display").innerHTML = a;
//    document.getElementById("display").innerHTML = b;
//   document.getElementById("display").innerHTML = addResults;
// }

window.onload = function(){ 
   

document.getElementById("add").onclick = function() {add()};
function add() {
   var a = document.getElementById("value1").value;
var b = document.getElementById("value2").value;
var addResults =parseInt(a) + parseInt(b);
   document.getElementById("display").innerHTML = a;
   document.getElementById("display").innerHTML = b;
  document.getElementById("display").innerHTML =a +" + "+b +" = " + addResults;
  event.preventDefault();
}

document.getElementById("multiply").onclick = function() {multiply()};
function multiply() {
   var a = document.getElementById("value1").value;
var b = document.getElementById("value2").value;
var addResults =parseInt(a) * parseInt(b);
   document.getElementById("display").innerHTML = a;
   document.getElementById("display").innerHTML = b;
  document.getElementById("display").innerHTML =a +" x "+b +" = " + addResults;
  event.preventDefault();
}

document.getElementById("divide").onclick = function() {divide()};
function divide() {
   var a = document.getElementById("value1").value;
var b = document.getElementById("value2").value;
var addResults =parseInt(a) / parseInt(b);
   document.getElementById("display").innerHTML = a;
   document.getElementById("display").innerHTML = b;
  document.getElementById("display").innerHTML = a +" ÷ "+b +" = " + addResults;
  event.preventDefault();
}
document.getElementById("clear").onclick = function() {clear()};
function clear(){
   document.getElementById("value1").value = " ";
 document.getElementById("value2").value = " ";
//var addResults =parseInt(a) / parseInt(b);
   // document.getElementById("display").innerHTML = a;
   // document.getElementById("display").innerHTML = b;
  document.getElementById("display").innerHTML = " " ;
  event.preventDefault();
}
};
