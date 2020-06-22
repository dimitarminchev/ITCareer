int motor1Pin1 = 5; // pin 2 on L293D IC
int motor1Pin2 = 4; // pin 7 on L293D IC
int motor2Pin1 = 6; // pin 10 on L293D IC
int motor2Pin2 = 7; // pin 15 on L293D IC

int state;
int flag=0;        //makes sure that the serial only prints once the state
int stateStop=0;

void setup() 
{
    // sets the pins as outputs:
    pinMode(motor1Pin1, OUTPUT);
    pinMode(motor1Pin2, OUTPUT);
    pinMode(motor2Pin1, OUTPUT); 
    pinMode(motor2Pin2, OUTPUT);
    
    // initialize serial communication at 9600 bits per second:
    Serial.begin(9600);
}

void loop() 
{
    //if some date is sent, reads it and saves in state
    if(Serial.available() > 0)
    {     
      state = Serial.read();   
      flag=0;
    }   
    
    // if the state is 'F' the DC motor will go forward
    if (state == 'F') 
    {
        digitalWrite(motor1Pin1, LOW);
        digitalWrite(motor1Pin2, HIGH); 
        digitalWrite(motor2Pin1, LOW);
        digitalWrite(motor2Pin2, HIGH);
        if(flag == 0)
        {
          Serial.println("FORWARD");
          flag=1;
        }
    }
    
    // if the state is 'R' the motor will turn right
    else if (state == 'R') 
    {
        digitalWrite(motor1Pin1, LOW);
        digitalWrite(motor1Pin2, LOW); 
        digitalWrite(motor2Pin1, HIGH);
        digitalWrite(motor2Pin2, HIGH);
        
        if(flag == 0)
        {
          Serial.println("RIGHT");
          flag=1;
        }
    }
    
    // if the state is 'S' the motor will Stop
    else if (state == 'S') 
    {
        digitalWrite(motor1Pin1, LOW); 
        digitalWrite(motor1Pin2, LOW); 
        digitalWrite(motor2Pin1, LOW);
        digitalWrite(motor2Pin2, LOW);
        
        if(flag == 0)
        {
          Serial.println("STOP");
          flag=1;
        }
    }
    
    // if the state is 'L' the motor will turn left
    else if (state == 'L') 
    {
        digitalWrite(motor1Pin1, HIGH);
        digitalWrite(motor1Pin2, HIGH); 
        digitalWrite(motor2Pin1, LOW);
        digitalWrite(motor2Pin2, LOW);
        
        if(flag == 0)
        {
          Serial.println("LEFT");
          flag=1;
        }
    }
    
    // if the state is 'B' the motor will Reverse
    else if (state == 'B') 
    {
        digitalWrite(motor1Pin1, HIGH);
        digitalWrite(motor1Pin2, LOW); 
        digitalWrite(motor2Pin1, HIGH);
        digitalWrite(motor2Pin2, LOW);
        
        if(flag == 0)
        {
          Serial.println("BACKWARDS");
          flag=1;
        }
    }
}