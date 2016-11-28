
int circe = 2;
int cyclops = 4;
int ithaca = 7;
int troy = 8;

String input;

void setup()
{
  Serial.begin(9600);
  pinMode(circe, INPUT);
  pinMode(cyclops, INPUT);
  pinMode(ithaca, INPUT);
  pinMode(troy, INPUT);
}

void loop()
{
        //output to unity
        //Serial.println("hello");
        
        int circeState = digitalRead(circe);
        int cyclopsState = digitalRead(cyclops);
        int ithacaState = digitalRead(ithaca);
        int troyState = digitalRead(troy);
        
//        String circeIn = String("circe: ") + String(circeState) + String("\n");
//        String cyclopsIn = String("cyclops: ") + String(cyclopsState) + String("\n");
//        String ithacaIn = String("ithaca: ") + String(ithacaState) + String("\n");
//        String troyIn = String("troy: ") + String(troyState) + String("\n");
//        input =  circeIn + cyclopsIn + ithacaIn + troyIn;

        input = String(circeState) + String(cyclopsState) + String(ithacaState) + String(troyState);

        
        
        Serial.println(input);

        //incoming from unity
          if (Serial.available() > 0) 
        {
                byte incomingByte = Serial.read();

                Serial.print("I received: ");
                Serial.println(incomingByte, DEC);
        }
}
