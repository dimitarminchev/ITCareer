# Arduino Uno
![ArduinoUno.png](ArduinoUno.png)

# Arduino Uno Pinout
![ArduinoUnoPinout.png](ArduinoUnoPinout.png)

# Autodesk IDE
https://www.tinkercad.com/

# Arduino IDE
https://www.arduino.cc/

# Projects
## 1. Trafic Lights
![Project1.png](Project1.png)
```
void setup()
{
  pinMode(11, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(13, OUTPUT);
}
void loop()
{
  digitalWrite(13, HIGH);
  delay(1000); 
  digitalWrite(13, LOW);

  digitalWrite(12, HIGH);
  delay(1000); 
  digitalWrite(12, LOW);

  digitalWrite(11, HIGH);
  delay(1000); 
  digitalWrite(11, LOW);
}
```
## 2. Disco
![Project2.png](Project2.png)
```
void setup() 
{
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(7, OUTPUT);
  pinMode(8, OUTPUT);
  pinMode(9, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(13, OUTPUT);
}
void loop()
{
  int test = random(4, 13);
  digitalWrite(test, HIGH);
  delay(10);
  digitalWrite(test, LOW);
}
```