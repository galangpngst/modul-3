using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_app.Controller
{
    class car
    {
        private DoorController doorcontroller;
        private AccubatteryController accubatterycontroller;
        private OnCarEngineStateChanged callback;

        public car(DoorController doorcontroller, AccubatteryController accubatterycontroller, OnCarEngineStateChanged callback)
        {
            this.doorcontroller = doorcontroller;
            this.accubatterycontroller = accubatterycontroller;
            this.callback = callback;
        }

        private bool doorIsClosed()
        {
            return this.doorcontroller.isClose();
        }
        private bool doorIsLocked()
        {
            return this.doorcontroller.isLocked();
        }
        private bool powerIsReady()
        {
            return this.accubatterycontroller.accubatteryIsOn();
        }
         public void startEngine()
         {
            if (!doorIsClosed())
            {
                this.callback.onCarEngineStatechanged("STOPED", "Close the door");
                return;
            }

            if (!doorIsLocked())
            {
                this.callback.onCarEngineStatechanged("STOPED", "Lock the door");
                return;
            }

            if (!powerIsReady())
            {
                this.callback.onCarEngineStatechanged("STOPED", "no power available");
                return;
            }

            this.callback.onCarEngineStatechanged("STARTED", "Engine Started");
         }
         public void toggleTheLockdoorButton()
        {
            if (!doorIsLocked())
            {
                this.doorcontroller.activateLock();
            }
            else
            {
                this.doorcontroller.unlock();
            }
        }
        public void toggleTheOpendoorButton()
        {
            if (!doorIsClosed())
            {
                this.doorcontroller.close();
            }
            else
            {
                this.doorcontroller.open();
            }
            
        }

        public void togglePowerButton()
        {
            if (!powerIsReady())
            {
                this.accubatterycontroller.turnOn();
            }
            else
            {
                this.accubatterycontroller.turnOff();
            }
        }


    }
    interface OnCarEngineStateChanged
    {
        void onCarEngineStatechanged(string value, string message);
    }
}
