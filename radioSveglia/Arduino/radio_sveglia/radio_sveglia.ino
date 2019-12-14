#include <LiquidCrystal.h> 
#include "pitches.h"

LiquidCrystal lcd(12, 11, 5, 4, 3, 2);

int h=12;
int m;
int s;
int TIME;
const int hs=8;
const int ms=9;
int state1;
int state2;


int buzzerPin = 1;
int melodia[] = {
  NOTE_C4, NOTE_F4, NOTE_F4, NOTE_G4, NOTE_A4, NOTE_F4, NOTE_C5,
  NOTE_AS4, NOTE_A4, NOTE_A4, NOTE_AS4, NOTE_C5, NOTE_AS4, NOTE_A4,
  NOTE_AS4, NOTE_C5, NOTE_G4, NOTE_F4, NOTE_G4, NOTE_A4, NOTE_G4
};
int durataNote[] = {
  4, 4, 8, 8, 4, 4, 3, 8, 3, 8, 4, 8, 8, 8, 8, 4, 8, 8, 8, 8, 3
};
int numeroNote = 21;


void setup()
{
  lcd.begin(16,2);
  Serial.begin(9600); 
  pinMode(buzzerPin, OUTPUT);
}

void loop()
{
 lcd.setCursor(0,0);
 s=s+1;
 lcd.print("  ORA:");
 lcd.print(h);
 lcd.print(":");
 lcd.print(m);
 lcd.print(":");
 lcd.print(s);

 delay(1000);
 lcd.clear();
 if(s==60){
  s=0;
  m=m+1;
 }
 if(m==60)
 {
  m=0;
  h=h+1;
 }
 if(h==24)
 {
  h=0;
 }
 lcd.setCursor(0,1);

 lcd.print(" BUONA GIORNATA");
}


void settaggioOra()
{
   state1=digitalRead(hs);

 if(state1==1)
 {
   h=h+1;
   if(h==24)h=0;
 }
 state2=digitalRead(ms);
 if(state2==1)
 {
  s=0;
  m=m+1;
 }
}


void suona()
{
  for(int i = 0; i < numeroNote; i++)
  {
   int durata = 1500 / durataNote[i];
   tone(buzzerPin, melodia[i], durata);
   delay(durata * 1.3);
  }
}
