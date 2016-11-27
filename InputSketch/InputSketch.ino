void setup()
{
  Serial.begin(9600);
  
}

void loop()
{
        //output to unity
        Serial.println("hello");

        //incoming from unity
          if (Serial.available() > 0) 
        {
                byte incomingByte = Serial.read();

                Serial.print("I received: ");
                Serial.println(incomingByte, DEC);
        }
}
