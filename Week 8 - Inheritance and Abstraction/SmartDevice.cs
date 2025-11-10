using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_8___Inheritance_and_Abstraction
{
    internal class SmartDevice
    {
        private int deviceID;
        private string deviceName;
        private bool status;

        public int DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }

        public string Name
        {
            get { return deviceName; }
            set { deviceName = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        SmartDevice(int deviceID, string name, bool status)
        {
            this.DeviceID = deviceID;
            this.Name = name;
            this.Status = status;
        }
    }
}
