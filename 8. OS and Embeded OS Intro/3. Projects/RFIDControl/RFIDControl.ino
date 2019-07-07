#include <SoftwareSerial.h>
#include <LiquidCrystal_PCF8574.h>
#include <Wire.h>
#include <Servo.h>
#include <Servo.h>
Servo ms;
const int LedGreen = 8;
const int LedRed = 7;
const int LedYellow = 6;
const int Zoomer = 12;
SoftwareSerial RF(10, 11); // RX, TX
int code;
bool vleze = false;
String brak;
String TurnYellowLed;
LiquidCrystal_PCF8574 lcd(0x27); // set the LCD address to 0x27 for a 16 chars and 2 line display


void setup() {
  Serial.begin(9600);
  RF.begin(9600);
  ms.attach(4); 
  digitalWrite(Zoomer,LOW);
 

  InitializeLEDs();
  InitializeLCD();
}

void loop() {

  //Waits for input from the program
  if(Serial.available()){
    //Reads the input from the program
    TurnYellowLed = Serial.readString(); 
    //if programs is now started
    if(TurnYellowLed=="CommunicationON"){
      //Turns on Communication LED
      digitalWrite(LedYellow,HIGH);
    }
    //if program is closing
    if(TurnYellowLed=="CommunicationOFF"){
      //Turns off Communication LED
      digitalWrite(LedYellow,LOW);
    }
  }
  //Reads the code from the RF Reader 
 while(RF.available()>0){
  code =RF.read();
  //Sends the readed code from the card to Serial Port
  Serial.println(code);
  vleze = true;
 }
 
 if(vleze){
      vleze = false;
      //Reads the input from the program
      brak = Serial.readString(); 
      
      if(brak!="0"&&brak!="ScanedCardForRegistration"&&brak !="CommunicationON"&&brak!="CommunicationOFF"&&brak!=""){
        LEDPassLCD(brak);
        Pass();
      }
      if(brak=="0"){
        NotPass();
      } 
 }
}

void Pass(){
  digitalWrite(Zoomer,HIGH);
  ServoOpen();
  LEDPass();
  digitalWrite(Zoomer,LOW);
  LcdClear();
  ServoClose();
}
void NotPass(){
  LCDNotPass();
  LEDNotPass();
  LcdClear();
}
void InitializeLCD(){
  Wire.begin();
  Wire.beginTransmission(0x27);
  lcd.begin(20, 4); // initialize the lcd
  lcd.setBacklight(255);
  lcd.clear();   
  lcd.setCursor(0, 0);
  lcd.print("Scanning...");
}

void InitializeLEDs(){
   pinMode(LedGreen,OUTPUT);
  pinMode(LedYellow,OUTPUT);
  pinMode(LedRed,OUTPUT);
  digitalWrite(LedYellow,LOW);
}

void LEDPass(){  
      digitalWrite(LedGreen,HIGH);
      delay(2200);
      digitalWrite(LedGreen,LOW);    
      
}

void ServoOpen(){
  ms.write(50);
  delay(653);
  ms.write(90);
}

void ServoClose(){
  ms.write(150);
  delay(653);
ms.write(90);
}

void LEDNotPass(){
  for(int a=0;a<2;a++)
  { 
        digitalWrite(LedRed,HIGH);
        
        digitalWrite(Zoomer,HIGH);
        delay(1000);
        digitalWrite(Zoomer,LOW);
        
        digitalWrite(LedRed,LOW);

       
        delay(1000);
        digitalWrite(Zoomer,LOW);
  }
}

void LEDPassLCD(String EmpName){
  lcd.clear();
  lcd.setCursor(0, 0);
   lcd.print("Wait To Pass");
   lcd.setCursor(0, 1);
   lcd.print("Hello");
   lcd.setCursor(0, 2);
   lcd.print(EmpName);
   lcd.setCursor(5, 3);
   lcd.print("Welcome");
   
}
void LCDNotPass(){
  lcd.clear();
  lcd.setCursor(0, 0);
   lcd.print("Wait To Pass");
   lcd.setCursor(0, 1);
   lcd.print("Acces Denied");
   lcd.setCursor(0, 2);
   lcd.print(":(:(:(:(:(:(:(:(:(");
}
void LcdClear(){
  delay(5000);
  lcd.clear();
  lcd.clear();
  lcd.setCursor(0, 0);
   lcd.print("Scanning...");
}
