const int buttonPin = 2; // Pin connected to the button
const int ledPin1 = 13;  // LED connected to pin 13
const int ledPin2 = 11;  // LED connected to pin 11
const int ledPin3 = 9;   // LED connected to pin 9

bool isBlinking = false; // State to check if LEDs should blink
int buttonState = 0;     // Variable to store the button state
int lastButtonState = 0; // Variable to store the previous button state

void setup() {
  Serial.begin(9600);  // Start the serial communication

  pinMode(ledPin1, OUTPUT);   // Set pin 13 as output for LED
  pinMode(ledPin2, OUTPUT);   // Set pin 11 as output for LED
  pinMode(ledPin3, OUTPUT);   // Set pin 9 as output for LED

  pinMode(buttonPin, INPUT_PULLUP); // Use internal pull-up resistor for button pin
}

void loop() {
  buttonState = digitalRead(buttonPin); // Read the current state of the button

  if (Serial.available() > 0) {  
    String command = Serial.readStringUntil('\n');

    if (command == "LED_ON") {
    isBlinking = true;
    } 

    else if (command == "LED_OFF") {
    isBlinking = false;
    }
  }

  if (buttonState == LOW && lastButtonState == HIGH) {
    isBlinking = !isBlinking;
    delay(50); 
  }
  
  lastButtonState = buttonState; // Save the current state for comparison in the next loop

  if (isBlinking) {
    // Blink the LEDs if the isBlinking state is true
    digitalWrite(ledPin1, HIGH);  
    delay(500);                      
    digitalWrite(ledPin1, LOW);  

    digitalWrite(ledPin2, HIGH);  
    delay(500);                      
    digitalWrite(ledPin2, LOW);   

    digitalWrite(ledPin3, HIGH);  
    delay(500);                      
    digitalWrite(ledPin3, LOW);   
  } else {
    // Ensure all LEDs are off when not blinking
    digitalWrite(ledPin1, LOW);
    digitalWrite(ledPin2, LOW);
    digitalWrite(ledPin3, LOW);
  }
}
