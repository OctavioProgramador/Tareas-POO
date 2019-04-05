class Circulo{
  constructor(v1, ancho, alto, fill) {
     this.v1 = v1;
     this.ancho = ancho;
     this.alto = alto;
     this.fill = fill;
    }
   
   dibuja (){
     fill(this.fill);
     ellipse(this.v1.x, this.v1.y, 
       this.alto, this.ancho);
   } 
 }
 
 var vect1;
 var circulo1;
 
 function setup() {
   createCanvas(640, 480);
   vect1 = createVector(80, 80)  
   circulo1  = new Circulo(vect1,55,55,color("red"))
 }
 
 function mouseClicked()
 {
    circulo1.dibuja();
 }
 
 function draw() {
  //circulo1.dibuja(fill); 
 
 }