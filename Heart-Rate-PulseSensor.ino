/*
can detect and calculates heartbeat and BPm
bpm message pe user
alerts current user when bpm is not normal
VB.NET status

COM3 - PORT
9600 - BAUD
*/

#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <PulseSensorPlayground.h>
#define USE_ARDUINO_INTERRUPTS true

// pin
const int PulseWire = A0;  
const int LEDPin = 13;     
const int buzzerPin = 8;   

// bpm limit
int Threshold = 570; // detection sensitivity
const int LOW_BPM = 60;
const int HIGH_BPM = 100;

LiquidCrystal_I2C lcd(0x27, 16, 2); 

PulseSensorPlayground pulseSensor;

int myBPM = 0;

void setup() {
  Serial.begin(9600);

  // output pins for alert
  pinMode(LEDPin, OUTPUT);
  pinMode(buzzerPin, OUTPUT);

  // lcd config - welcmo message
  lcd.init();
  lcd.backlight();
  lcd.setCursor(0, 0);
  lcd.print(" Kasing-kasing Detector ");
  lcd.setCursor(0, 1);
  lcd.print("   Initializing ");
  delay(2000);
  lcd.clear();

  // PulseSensor config
  pulseSensor.analogInput(PulseWire);
  pulseSensor.setThreshold(Threshold); // 550

  if (pulseSensor.begin()) {
    lcd.setCursor(0, 0);
    lcd.print("Place your finger");
    lcd.setCursor(0, 1);
    lcd.print("on the sensor...");
  }
}

/*-------------------------------------------------------------------------*/

void loop() {
  myBPM = pulseSensor.getBeatsPerMinute();

  // if there are any heartbeat, the block will run
  if (pulseSensor.sawStartOfBeat()) {

    lcd.init();
    lcd.setCursor(0, 0);
    lcd.print("Heart Rate:");
    lcd.setCursor(0, 1);
    lcd.print(myBPM);
    lcd.print(" BPM");

    // bpm status (needs medical atttention or normal)
    String status;
    if (myBPM < LOW_BPM || myBPM > HIGH_BPM) { 
      digitalWrite(LEDPin, HIGH); // LED turnON
      tone(buzzerPin, 1000); // buzzer
      status = "DANGER! MAG DIET KA NA";
    } else {
      digitalWrite(LEDPin, LOW);
      noTone(buzzerPin);
      status = "NORMAL";
    }

    // Send data to VB.NET app - (85, NORMAL) or (120, DANGER MAG DIET KA NA)
    String vbOutput = String(myBPM) + "," + status;
    Serial.println(vbOutput); 
  }

  // Check for RESET command from VB.NET
  if (Serial.available()) {
    String cmd = Serial.readStringUntil('\n');
    cmd.trim();
    if (cmd == "RESET") {
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Ready for next");
      lcd.setCursor(0, 1);S
      lcd.print("user...");
      digitalWrite(LEDPin, LOW);
      noTone(buzzerPin);
    }
  }

  delay(50);
}
