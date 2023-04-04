// put your setup code here, to run once:
void setup()
{
  // Set Digital Pin 5 as Input Pin
  pinMode(5, INPUT);
  
  // Set Digital Pin 10 as Output Pin
  pinMode(10, OUTPUT);
}

// put your main code here, to run repeatedly:
void loop()
{
  // Read The Button State
  int buttonState = digitalRead(5);

  // Check the Button State
  if (buttonState == HIGH) 
  {
    // Turn Pin 10 to HIGH
    digitalWrite(10, HIGH);
  } 
  else 
  {
    // Turn Pin 10 to LOW
    digitalWrite(10, LOW);
  }
  
  // Delay a little bit to improve simulation performance
  delay(10); 
}
