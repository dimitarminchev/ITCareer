// Declaring variables for the motors:
byte leftMotorPin1 = 11; 
byte leftMotorPin2 = 10; 
byte rightMotorPin1 = 12; 
byte rightMotorPin2 = 13; 

// Declaring variables for the turn signals:
byte turnSignalFL = 4; 
byte turnSignalFR = 6; 
byte turnSignalRL = 2; 
byte turnSignalRR = 9; 

// Declaring variables for the stop lights:
byte stopLightRL = 3; 
byte stopLightRR = 8; 

// Declaring variables for the head lights:
byte lightFL = 5; 
byte lightFR = 7; 

int state;
byte flag=0;        
byte stateStop=0;

void setup() 
{
    // Setting up the motor pins as outputs:
    pinMode(leftMotorPin1, OUTPUT);
    pinMode(leftMotorPin2, OUTPUT);
    pinMode(rightMotorPin1, OUTPUT);
    pinMode(rightMotorPin2, OUTPUT);

    // Setting up the turn signal pins as outputs:
    pinMode(turnSignalFL, OUTPUT);
    pinMode(turnSignalFR, OUTPUT);
    pinMode(turnSignalRL, OUTPUT);
    pinMode(turnSignalRR, OUTPUT);

    // Setting up the stop light pins as outputs:
    pinMode(stopLightRL, OUTPUT);
    pinMode(stopLightRR, OUTPUT);

    // Setting up the head light pins as outputs:
    pinMode(lightFL , OUTPUT);
    pinMode(lightFR , OUTPUT);
    
    // Initializing serial communication at 9600 bits per second:
    Serial.begin(9600);
}

void loop() 
{
    // Beginning to read the serial input:
    if(Serial.available() > 0)
    {     
      state = Serial.read();   
      flag=0;
    }   
     if (state == 'F') 
    {
      digitalWrite(lightFL, HIGH);
      digitalWrite(lightFR, HIGH);
      digitalWrite(stopLightRL, LOW);
      digitalWrite(stopLightRR, LOW);
      digitalWrite(turnSignalFL, LOW);
      digitalWrite(turnSignalFR, LOW);
      digitalWrite(turnSignalRL, LOW);
      digitalWrite(turnSignalRR, LOW);
      
      digitalWrite(leftMotorPin1, HIGH);
      digitalWrite(leftMotorPin2, LOW); 
      digitalWrite(rightMotorPin1, LOW);
      digitalWrite(rightMotorPin2, HIGH);
      if(flag == 0)
      {
        Serial.println("FORWARD");
        flag=1;
      }
    }
    else if (state == 'R') 
    {
      digitalWrite(lightFL, HIGH);
      digitalWrite(lightFR, HIGH);
      digitalWrite(stopLightRL, LOW);
      digitalWrite(stopLightRR, LOW);
      digitalWrite(turnSignalFL, LOW);
      digitalWrite(turnSignalFR, HIGH);
      digitalWrite(turnSignalRL, LOW);
      digitalWrite(turnSignalRR, HIGH);
      
      digitalWrite(leftMotorPin1, HIGH); 
      digitalWrite(leftMotorPin2, LOW); 
      digitalWrite(rightMotorPin1, LOW);
      digitalWrite(rightMotorPin2, LOW);
      if(flag == 0)
      {
        Serial.println("LEFT");
        flag=1;
      }
      delay(1500);
      state=3;
      stateStop=1;
    }
     else if (state == 'S' || stateStop == 1) 
    {
      digitalWrite(lightFL, HIGH);
      digitalWrite(lightFR, HIGH);
      digitalWrite(stopLightRL, HIGH);
      digitalWrite(stopLightRR, HIGH);
      digitalWrite(turnSignalFL, LOW);
      digitalWrite(turnSignalFR, LOW);
      digitalWrite(turnSignalRL, LOW);
      digitalWrite(turnSignalRR, LOW);
      
      digitalWrite(leftMotorPin1, LOW); 
      digitalWrite(leftMotorPin2, LOW); 
      digitalWrite(rightMotorPin1, LOW);
      digitalWrite(rightMotorPin2, LOW);
      if(flag == 0)
      {
        Serial.println("STOP");
        flag=1;
      }
      stateStop=0;
      }
    else if (state == 'L') 
    {
      digitalWrite(lightFL, HIGH);
      digitalWrite(lightFR, HIGH);
      digitalWrite(stopLightRL, LOW);
      digitalWrite(stopLightRR, LOW);      
      digitalWrite(turnSignalFL, HIGH);
      digitalWrite(turnSignalFR, LOW);
      digitalWrite(turnSignalRL, HIGH);
      digitalWrite(turnSignalRR, LOW);
      
      digitalWrite(leftMotorPin1, LOW); 
      digitalWrite(leftMotorPin2, LOW); 
      digitalWrite(rightMotorPin1, LOW);
      digitalWrite(rightMotorPin2, HIGH);
      if(flag == 0){
        Serial.println("RIGHT");
        flag=1;
      }
      delay(1500);
      state=3;
      stateStop=1;
    }
     else if (state == 'B') 
    {
      digitalWrite(lightFL, LOW);
      digitalWrite(lightFR, LOW);
      digitalWrite(stopLightRL, LOW);
      digitalWrite(stopLightRR, LOW);
      digitalWrite(turnSignalFL, HIGH);
      digitalWrite(turnSignalFR, HIGH);
      digitalWrite(turnSignalRL, HIGH);
      digitalWrite(turnSignalRR, HIGH);
      
      digitalWrite(leftMotorPin1, LOW); 
      digitalWrite(leftMotorPin2, HIGH);
      digitalWrite(rightMotorPin1, HIGH);
      digitalWrite(rightMotorPin2, LOW);
      if(flag == 0)
      {
        Serial.println("REVERSE");
        flag=1;
      }
    }
}
