// put your setup code here, to run once:
void setup() 
{
  // Set Digital Pin 10 as Output Pin
  pinMode(10, OUTPUT);
}

// put your main code here, to run repeatedly:
void loop() 
{
  // Turn Pin 10 to HIGH
  digitalWrite(10, HIGH);
  
  // Wait 1000 milliseconds
  delay(1000); 

  // Turn Pin 10 to HIGH
  digitalWrite(10, LOW);

  // Wait 1000 milliseconds
  delay(1000); 
}
