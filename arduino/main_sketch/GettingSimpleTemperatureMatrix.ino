#include <Wire.h>
#include <Servo.h>
#include <Adafruit_MLX90614.h>

Servo myservo1;
Servo myservo2; 
bool repeat = true;
Adafruit_MLX90614 mlx; 

void setup() 
{
  mlx = Adafruit_MLX90614();
  Serial.begin(9600);
  myservo1.attach(9);
  myservo2.attach(10); 
  pinMode(13, OUTPUT);
  mlx.begin();  
}

void loop() 
{ 
  while(repeat)
  {
    digitalWrite(13, HIGH);
    for(int i = 60; i < 120; i++)
    {
      myservo2.write(65);
      delay(100);
      myservo1.write(i);
      delay(50);
      for(int j = 65; j < 110; j++)
      {
        myservo2.write(j);
        delay(50);
        Serial.print(mlx.readObjectTempC());
        Serial.print(' ');
      }
      Serial.println();
    }
    repeat = false;
  } 
}
