int LEDPIN = 4;
int BTNPIN = 5;

void setup() {
  // put your setup code here, to run once:
  pinMode(LEDPIN,OUTPUT);
  pinMode(BTNPIN,INPUT_PULLUP);
  Serial.begin(9600);
}

int thresholdAmount = 5;
int highAmount = 200;
int lowAmount = 20;
int prev = 0;
bool printAllow = true;
bool previousPrint = false;

void loop() {
  // put your main code here, to run repeatedly:
  
  int lightIN = analogRead(A0);

  if(printAllow){
    //Serial.println(lightIN);
    if(lightIN > highAmount){
      if(!previousPrint){
        Serial.print("ON ");
        Serial.println(lightIN);
      }
      
      printAllow = false;
      previousPrint = true;
      prev = lightIN;
    }
    else if(lightIN >lowAmount && lightIN <lowAmount+thresholdAmount){
      if(previousPrint){
        Serial.print("OFF ");
        Serial.println(lightIN);
      }
      previousPrint = false;
      printAllow = false;
      prev = lightIN;
    }
    
  }
  else
  {
      if( lightIN <prev+thresholdAmount+lowAmount){
        printAllow = true;
      }
      else if(lightIN <highAmount){
        printAllow = true;
      }
  }

  //check for setting of high and low values
  if(Serial.available() >0){
    String type = Serial.readStringUntil(':');
    Serial.read();//:
    String value = Serial.readStringUntil('\0');
    int lightVal = value.toInt();

    if(type =="SH"){
      highAmount = lightVal;
      Serial.print("UPDATE High set to ");
      Serial.println(highAmount);
    }else{
      lowAmount = lightVal;
      Serial.print("UPDATE Low set to ");
      Serial.println(lowAmount);
    }
  }
  
  
  
  //delay(2500);
  
  
  
}
