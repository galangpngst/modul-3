using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_app.Model
{
    class Accubattrey
    {
        private int voltage;
        private bool stateOn = false;

        public Accubattrey(int voltage)
        {
            this.voltage = voltage;
        }

        public void turnOn()
        {
            this.stateOn = true;
        }

        public void turnOff()
        {
            this.stateOn = false;
        }

        public bool isOn()
        {
            return this.stateOn;
        }

    }
}
