#include <Wire.h>
#include <DallasTemperature.h>
#include <OneWire.h>
#define ONE_WIRE_BUS_1 2

int led_1 = 9;
String readString; 
OneWire oneWire_1(ONE_WIRE_BUS_1);
DallasTemperature sensors_1(&oneWire_1);
float x1;

void setup()
{
  Serial.begin(9600);
  sensors_1.begin();
  pinMode(led_1, OUTPUT);   

}

void loop()
{

     sensors_1.requestTemperatures();
    
     delay(100);
     x1 = sensors_1.getTempCByIndex(0);

 Serial.println(x1);

switch(Serial.read()){
    case 'A' :
    digitalWrite(led_1,HIGH);
 
  delay(1000);
    
    break;
     case 'B' :
    digitalWrite(led_1,LOW);
 
  delay(1000);
    
    break;
  } 
}
