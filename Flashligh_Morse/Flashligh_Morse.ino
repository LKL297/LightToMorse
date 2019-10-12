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
  
  
  
  
  //delay(2500);
  
  
  
}
