using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace HomeImager
{
    public class SerialPortController
    {
        private SerialPort serialPort;
        private List<Double> temperature = new List<Double>();
        private String[] portNames;
        private StringBuilder message = new StringBuilder();


        public SerialPortController()
        {
            portNames = SerialPort.GetPortNames();
        }

        public List<Double> GetTemperature()
        {
            return temperature;
        }

        public object[] GetPortNames()
        {
            return portNames;
        }

        public void Send(char x)
        {
            serialPort.Write(new[] {(byte) x}, 0, 1);
        }

        public void Close()
        {
            serialPort.Close();
        }

        public String Read()
        {

            return serialPort.ReadLine();
        }

        public void Open(String input)
        {

            {

                serialPort = new SerialPort(input)
                {
                    DataBits = 8,
                    BaudRate = 9600,
                    StopBits = StopBits.One,
                    Parity = Parity.None
                };
                serialPort.Open();
                serialPort.DataReceived += DataRecivedHandler;

            }
        }

        private void DataRecivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                var buffer = serialPort.ReadExisting();
                foreach (var b in buffer)
                {
                    if ((b == '\r' || b == '\n') && message.Length > 0)
                    {
                        var toProcess = message;
                        temperature.Add(Byte.Parse(toProcess.ToString()));
                        message.Length = 0;
                    }
                    else
                    {
                        message.Append(b);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}




