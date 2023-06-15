// Pin assignments
const int Green_light = 13;
const int Yellow_light = 12;
const int Red_light = 11;
const int Button_pin = 10;

// Time durations (in seconds)
const unsigned long Green_time = 45;
const unsigned long Yellow_time = 5;
const unsigned long Red_time = 45;

enum States {GREEN, YELLOW, RED};
States currentState = GREEN;
unsigned long stateStartTime;

void setup() {
  pinMode(Green_light, OUTPUT);
  pinMode(Yellow_light, OUTPUT);
  pinMode(Red_light, OUTPUT);
  pinMode(Button_pin, INPUT_PULLUP);
  Serial.begin(9600); // start serial communication
  stateStartTime = millis();  // initialize state start time
  digitalWrite(Green_light, HIGH); // Initially Green light ON
}

void loop() {
  unsigned long stateElapsedTime = (millis() - stateStartTime) / 1000;  // time elapsed since the state start time, in seconds

  // Check if data is available to read
  if (Serial.available() > 0) {
    // Read the incoming data
    String incomingData = Serial.readString();

    // Trim the string
    incomingData.trim();

    // Change the state of the traffic light based on the received data
    if (incomingData == "GREEN") {
      currentState = GREEN;
      stateStartTime = millis();
      digitalWrite(Red_light, LOW);
      digitalWrite(Green_light, HIGH);
    } else if (incomingData == "YELLOW") {
      currentState = YELLOW;
      stateStartTime = millis();
      digitalWrite(Green_light, LOW);
      digitalWrite(Yellow_light, HIGH);
    } else if (incomingData == "RED") {
      currentState = RED;
      stateStartTime = millis();
      digitalWrite(Yellow_light, LOW);
      digitalWrite(Red_light, HIGH);
    }
  }

  switch (currentState) {
    case GREEN:
      if (stateElapsedTime >= Green_time || digitalRead(Button_pin) == LOW) {
        currentState = YELLOW;
        stateStartTime = millis();  // reset the state start time
        digitalWrite(Green_light, LOW);
        digitalWrite(Yellow_light, HIGH);
      }
      break;

    case YELLOW:
      if (stateElapsedTime >= Yellow_time) {
        currentState = RED;
        stateStartTime = millis();  // reset the state start time
        digitalWrite(Yellow_light, LOW);
        digitalWrite(Red_light, HIGH);
      }
      break;

    case RED:
      if (stateElapsedTime >= Red_time) {
        currentState = GREEN;
        stateStartTime = millis();  // reset the state start time
        digitalWrite(Red_light, LOW);
        digitalWrite(Green_light, HIGH);
      }
      break;
  }
}
