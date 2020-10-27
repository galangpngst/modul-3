using MVC_app.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_app.Controller
{
    class AccubatteryController
    {
        private Accubattrey accubattery;
        private OnPowerChanged callBackOnPowerchanged;

        public AccubatteryController(OnPowerChanged callBackOnPowerchanged)
        {
            this.callBackOnPowerchanged = callBackOnPowerchanged;
            this.accubattery = new Accubattrey(12);
        }
        public bool accubatteryIsOn()
        {
            return this.accubattery.isOn(); 
        }
        public void turnOn()
        {
            this.accubattery.turnOn();
            this.callBackOnPowerchanged.onPowerChangedStatus("ON", "power is on");
        }
        public void turnOff()
        {
            this.accubattery.turnOff();
            this.callBackOnPowerchanged.onPowerChangedStatus("OFF", "power is off");
        }
    }
    interface OnPowerChanged
    {
        void onPowerChangedStatus(string value, string message);
    }
}
