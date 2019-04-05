let x = 0;
function setup()
{
  createCanvas(600,400);
  fill(0);
  ellipse(1,1,50,50);
}
var flag = false;
function draw()
{
  if ((mouseX>0 && mouseX<100)&&(mouseY>0 && mouseY<100))
  { 
    flag = true;
  }
  else
  {
    flag = false;   
  }
  if(flag)
  {
    if (mouseIsPressed)
    {
      ellipse(mouseX,mouseY,50,50);
      return false;
    }
  }
  
  
}