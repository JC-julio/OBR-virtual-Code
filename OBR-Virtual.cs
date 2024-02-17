using System;

public class Robo
{
    private const string MotorLeftBack = "motorLeftBack";
    private const string MotorRightBack = "motorRightBack";
    private const string MotorRightFront = "rightfront";
    private const string MotorLeftFront = "leftfront";

    private const string SensorLeft = "leftsensor";
    private const string SensorRight = "rightsensor";
    private const string SensorReserva = "SensorReseva";

    private const int VelocidadeMaxima = 100;
	Bot.GetComponent<Servomotor>( "motorLeftBack" ).Apply( 10 , VelocidadeMaxima );
	Bot.GetComponent<Servomotor>( "motorRightBack" ).Apply( 10 , VelocidadeMaxima );
	Bot.GetComponent<Servomotor>( "rightfront" ).Apply( 10 , VelocidadeMaxima );
	Bot.GetComponent<Servomotor>( "leftfront" ).Apply( 10 , VelocidadeMaxima );
    private void Main()
    {
            // Desligar todos os motores
			Bot.GetComponent<Servomotor>("MotorLeftBack").Locked = false;
			Bot.GetComponent<Servomotor>("MotorRightBack").Locked = false;
			Bot.GetComponent<Servomotor>("MotorRightFront").Locked = false;
			Bot.GetComponent<Servomotor>("MotorLeftFront").Locked = false;

        while (true)
        {
            // Se o sensor esquerdo detectar verde
            if ( Bot.GetComponent<ColorSensor>("SensorLeft").Analog).ToString()
            {
                // Ligar a luz verde
				Bot.GetComponent<Light>( "led" ).TurnOn( new Color(0, 255, 0) );

                // Parar o robô
                PararRobo();

                // Girar 90 graus para a direita
                GirarDireita(90);

                // Continuar o loop
                continue;
            }

            // Se o sensor direito detectar verde
            if ( Bot.GetComponent<ColorSensor>("SensorRight").Analog).ToString());
            {
                // Ligar a luz verde
				Bot.GetComponent<Light>( "led" ).TurnOn( new Color(0, 255, 0));

                // Parar o robô
                PararRobo();

                // Girar 90 graus para a esquerda
                GirarEsquerda(90);

                // Continuar o loop
                continue;
            }

            // Se ambos os sensores detectarem preto
            if ( Bot.GetComponent<ColorSensor>("SensorRight").Analog).ToString()) == "Preto" && if ( 								Bot.GetComponent<ColorSensor>("Sensor").Analog).ToString()) == "Preto")
            {
                // Andar para frente
                AndarFrente();
            }
            // Se o sensor esquerdo detectar preto e o direito branco
            else if ( Bot.GetComponent<ColorSensor>("SensorLeft").Analog).ToString()) == "Preto" && 										( Bot.GetComponent<ColorSensor>("SensorRight").Analog).ToString()) == "Branco")
            {
                // Girar para a direita
                GirarDireita();
            }
            // Se o sensor esquerdo detectar branco e o direito preto
            else if ( Bot.GetComponent<ColorSensor>("SensorRight").Analog).ToString()) == "Branco" && 								Bot.GetComponent<ColorSensor>("SensorLeft").Analog).ToString()
            {
                // Girar para a esquerda
                GirarEsquerda();
            }

            // Aguardar 100 milissegundos
            Aguardar(100);
        }
    }

    private void AndarFrente()
    {
		Bot.GetComponent<Servomotor>("MotorLeftBack").Apply( Math.Abs( 50 ), 50 );
		Bot.GetComponent<Servomotor>("MotorRightBack").Apply( Math.Abs( 50 ), 50 );
		Bot.GetComponent<Servomotor>("MotorRightFront").Apply( Math.Abs( 50 ), 50 );
		Bot.GetComponent<Servomotor>("MotorLeftFront").Apply( Math.Abs( 50 ), 50 );
    }

    private void PararRobo()
    {
			Bot.GetComponent<Servomotor>("MotorLeftBack").Locked = true;
			Bot.GetComponent<Servomotor>("MotorRightBack").Locked = true;
			Bot.GetComponent<Servomotor>("MotorRightFront").Locked = true;
			Bot.GetComponent<Servomotor>("MotorLeftFront").Locked = true;
    }

    private void GirarDireita(int angulo = 90)
    {
	while (angulo < 90) {
			Bot.GetComponent<Servomotor>("MotorLeftBack").Locked = true
			Bot.GetComponent<Servomotor>("MotorLeftFront").Locked = true;
	}
    }

    private void GirarEsquerda(int angulo = 90)
    {
	while (angulo < -90) {
			Bot.GetComponent<Servomotor>("MotorLeftBack").Locked = true
			Bot.GetComponent<Servomotor>("MotorLeftFront").Locked = true;
		}
    }