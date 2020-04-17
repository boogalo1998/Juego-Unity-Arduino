int switchPin1 = 7;  // digital pin to attach the switch
int switchPin2 = 8;
int Pin1 =A2;
int Pin2 =A3;
int data1;
int data2;

void setup()
{
  Serial.begin(9600);
  pinMode(switchPin1, INPUT);  // set digital pin 0 as input
  pinMode(switchPin2, INPUT); 
  pinMode(Pin1, INPUT);  // set digital pin 0 as input
  pinMode(Pin2, INPUT);  // set digital pin 0 as input
  
}

void loop()
{
  if (digitalRead(switchPin1) == HIGH) // if the switch is pressed
  {
    //Serial.println("L");
    Serial.write(1);
    //flush= espera a que termine de enviar la información completamente
    Serial.flush();
    delay(20);
  }
  
  if (digitalRead(switchPin2) == HIGH) // if the switch is pressed
  {
    //Serial.println("R");
    Serial.write(2);
    Serial.flush();
    delay(20);
  }
  
  data1 = analogRead(Pin1 );
  data2 = analogRead(Pin2);
  if(analogRead(Pin1)){
  

  Serial.print(data1);
  Serial.print(",");
 
  }

 
  if(analogRead(Pin2)){
  
 
  Serial.println(data2 );
  Serial.flush();
  delay(20);
    }
  
  
}
