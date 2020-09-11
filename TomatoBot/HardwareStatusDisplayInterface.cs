using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace TomatoBot
{
    public class HardwareStatusDisplayInterface
    {
        private SerialPort _port = null;
        private SerialPort Port
        {
            get
            {
                if (_port == null)
                {
                    _port = new SerialPort("com4", 9600, Parity.None, 8, StopBits.One);
                    _port.ReadBufferSize = 128;
                    _port.Open();
                }

                return _port;
            }
        }
        public bool CanInitialize()
        {
            bool portCanConnect = true;
            try
            {
                var port = Port; // attempt to connect
            }
            catch
            {
                portCanConnect = false;
            }

            return portCanConnect;
        }
    }
}
