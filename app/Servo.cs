using System.IO.Ports;
using System.Windows.Forms;

namespace HomeImager
{
    public class Servo 
    {
        private readonly SerialPort serialPort;
        private char direction;

        public Servo()
        {

            serialPort = new SerialPort
            {
                PortName = "COM3",
                BaudRate = 9600

            };
            serialPort.Open();
            serialPort.WriteLine("v0");
            serialPort.WriteLine("h0");
            

        }

        public void Forward(char direction, byte angle)
        {

            serialPort.Write(direction + angle.ToString());
        }

        public void Back(char direction, byte angle)
        {
            serialPort.Write(direction + angle.ToString());
        }
    }
}
