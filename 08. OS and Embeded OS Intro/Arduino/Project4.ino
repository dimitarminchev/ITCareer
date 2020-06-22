// Project 4. Buttons
int ButtonRedState = 0;
int ButtonYellowState = 0;
int ButtonGreenState = 0;

void setup()
{
  pinMode(3, INPUT);
  pinMode(13, OUTPUT);
  pinMode(2, INPUT);
  pinMode(12, OUTPUT);
  pinMode(1, INPUT);
  pinMode(11, OUTPUT);
}

void loop()
{
  // Red Button
  ButtonRedState = digitalRead(3);
  if (ButtonRedState == HIGH) {
    digitalWrite(13, HIGH);
  } else {
    digitalWrite(13, LOW);
  }
  // Yellow Button
  ButtonYellowState = digitalRead(2);
  if (ButtonYellowState == HIGH) {
    digitalWrite(12, HIGH);
  } else {
    digitalWrite(12, LOW);
  }
  // Green Button
  ButtonGreenState = digitalRead(1);
  if (ButtonGreenState == HIGH) {
    digitalWrite(11, HIGH);
  } else {
    digitalWrite(11, LOW);
  }
  ButtonRedState;
  delay(10); // Delay a little bit to improve simulation performance
}