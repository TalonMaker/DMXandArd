String Config [] = 
{ 
  "02:I",
  "03:I",
  "04:I"
};
int Port;
String InOut;
void setup(){
   Serial.begin(115200);
   Serial.print("~CONFIG~");
   for (int i=0; i<sizeof Config/sizeof Config[0]; i++) {
    Port = Config[i].substring(0, 2).toInt();
    InOut=(Config[i].substring(3));
    if(InOut=="I")
    {
      pinMode(Port, INPUT_PULLUP);
    }
    else
    {
      pinMode(Port, OUTPUT);
    }
        Serial.print(Port);
        Serial.print(':');
        Serial.print(InOut);
        Serial.print('~');
   }
   Serial.println("END~");
   //pinMode(a, OUTPUT);
   //pinMode(a, OUTPUT);
}

void loop() {
  
  if(!Serial.available())
  {
    Serial.print("~VALUES~");
    for (int i=0; i<sizeof Config/sizeof Config[0]; i++) {
    Port = Config[i].substring(0, 2).toInt();
    InOut=(Config[i].substring(3));
    if(InOut=="I")
    {
      Serial.print(Port);
      Serial.print(':');
      Serial.print(digitalRead(Port));
      Serial.print('~');
    }
    }
   Serial.println("END~");
  }
  else
  {
  Serial.println("Busy");
  }
  delay(50);
}
