#include <Servo.h>

Servo myservo1;
Servo myservo2;  
int servoPos = 0;

void setup() {
  Serial.begin(9600);
  myservo1.attach(9);
  myservo2.attach(10);
}

void loop() {
  String pos = Serial.readString();
  char turn = pos[0];
  servoPos = pos.substring(1).toInt();
  switch(turn)
  {
    case 'h':
      myservo2.write(servoPos);
    break;
    case 'v':
      myservo1.write(servoPos);
    break;
    
  }
}



