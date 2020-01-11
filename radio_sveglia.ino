#include <DS3231.h>
#include <LiquidCrystal.h>
#include <String.h>
#include "note.h"

#define buzzerPin 9
#define btnSveglia 8
#define btnEvento 7

DS3231  rtc(SDA, SCL);
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);

int melodia[] = {
  NOTE_E4, NOTE_E4, NOTE_E4, NOTE_C5, NOTE_B4, NOTE_B4,
  NOTE_B4, NOTE_C5, NOTE_A4, NOTE_A4, NOTE_A4, NOTE_G4, 
  NOTE_A4, NOTE_A4, NOTE_A4, NOTE_G4, NOTE_A4, NOTE_G4
};
int durataNote[] = {
  2, 4, 8, 8, 2, 4, 8, 8, 2, 4, 8, 8, 4, 4, 8, 8, 8, 8
};
int numeroNote = 18;

Time  t;
int hSveglia = -1;
int mSveglia = -1;
bool suona = false;
int i = 0;
long startS = 0;
int durata = 0;

String eventi[20];
String dateEventi[20];
int numEl = 0;
bool oggiEvento = false;
bool visEvento = false;
long startE = 0;
String message;
int pos = 0;

void setup()
{
  Serial.begin(115200);
  lcd.begin(16, 2);
  rtc.begin();
  //rtc.setDOW(FRIDAY);
  //rtc.setTime(10, 07, 30);
  //rtc.setDate(10, 01, 2020); 
  pinMode(buzzerPin, OUTPUT);
  pinMode(btnSveglia, INPUT);
  pinMode(btnEvento, INPUT);
}

void loop()
{
  lcd.setCursor(0, 0);
  
  visualizza();

  String dataOggi = rtc.getDateStr();
  
  if (dataOggi == dateEventi[0])
  {
    oggiEvento = true;
    startE = millis()/3600000;
    int lung = eventi[0].length();
    char evento[lung];
    eventi[0].toCharArray(evento, lung);
    message = evento;
    eliminaEvento();
  }
  
  if(millis()/3600000 - startE >= 24 && millis()/3600000 - startE < 25)
  {
    oggiEvento = false;
    startE = 0;
  }

  if (oggiEvento && digitalRead(btnEvento) == HIGH)
  {
    while(digitalRead(btnEvento) == HIGH);
    visEvento = !visEvento;
    pos = 0;
  }
    
  if (visEvento && millis() % 1000 == 0)
  {
    visEventoScorrevole();
  }


  t = rtc.getTime();

  if (t.hour == hSveglia && t.min == mSveglia && t.sec == 00)
    suona = true;
  
  if(suona && millis()-startS >= durata*1.3)
  {
    durata = 1500 / durataNote[i];
    tone(buzzerPin, melodia[i], durata);
    i++;
    if(i == numeroNote)
      i = 0;
    startS = millis();
  }

  if(digitalRead(btnSveglia) == HIGH && suona)
  {
    while(digitalRead(btnSveglia) == HIGH);
    i = 0;
    suona = false;
    startS = 0;
    durata = 0;
  }

  
  if(Serial.available() >= 3)
  {
    char c = Serial.read();
    if(c == 's')
    {
      hSveglia = Serial.read();
      mSveglia = Serial.read();
    }
    else if(c == 'e')
    {      
      String data = "";
      char lettera;
      do
      {
        lettera = Serial.read();
        if(lettera != '$')
          data += lettera;
      }while(lettera != '$');
      dateEventi[numEl] = data;
      String evento = "";
      do
      {
        lettera = Serial.read();
        if(lettera != '$')
          evento += lettera;
      }while(lettera != '$');
      eventi[numEl++] = evento;
    }
    else if(c == '$')
      numEl = 0;
  }
}

void visualizza()
{
  if(rtc.getDOWStr()=="Monday")
    lcd.print("Lun");
  else if(rtc.getDOWStr()=="Tuesday")
    lcd.print("Mar");
  else if(rtc.getDOWStr()=="Wednesday")
    lcd.print("Mer");
  else if(rtc.getDOWStr()=="Thursday")
    lcd.print("Gio");
  else if(rtc.getDOWStr()=="Friday")
    lcd.print("Ven");
  else if(rtc.getDOWStr()=="Saturday")
    lcd.print("Sab");
  else if(rtc.getDOWStr()=="Sunday")
    lcd.print("Dom");
  lcd.print(" ");  
  lcd.print(rtc.getDateStr());
  lcd.setCursor(0, 1);
  lcd.print(rtc.getTimeStr());
}

void eliminaEvento()
{
  for(int i=0; i < numEl-1; i++)
  {
    dateEventi[i] = dateEventi[i+1];
    eventi[i] = eventi[i+1];
  }
  numEl--;
}

void visEventoScorrevole()
{
    lcd.setCursor(0, 0);
    char lcdTop[16];//Create a char array to store the text for the line
    int copySize = 16; 
    if(message.length() < 16)
    {
        //if the message is bigger than the current buffer use its length instead;
        copySize = message.length();
    }
    //Store the current position temporarily and invert its sign if its negative since we are going in reverse
    int tempPos = pos;
    if(tempPos < 0)
    {
        tempPos = -(tempPos);
    }
    //Build the lcd text by copying the required text out of our template message variable 
    memcpy(&lcdTop[0],&message[tempPos],copySize);
    lcd.print(lcdTop);//Print it from position 0
    //Increase the current position and check if the position + 16 (screen size) would be larger than the message length , if it is go in reverse by inverting the sign.
    pos += 1;
    if(pos + 16 > message.length())
    {
      pos = -(pos);
    }
}
