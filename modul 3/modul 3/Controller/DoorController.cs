using MVC_app.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_app.Controller
{
    class DoorController
    {
        private Door door;
        private OnDoorChanged callbackOnDoorChanged;

        public DoorController(OnDoorChanged callbackOnDoorchanged)
        {
            this.callbackOnDoorChanged = callbackOnDoorchanged;
            this.door = new Door();
        }
        public void close()
        {
            this.door.close();
            this.callbackOnDoorChanged.onDoorOpenStatechanged("CLOSED", "door closed");
        }
        public void open()
        {
            this.door.open();
            this.callbackOnDoorChanged.onDoorOpenStatechanged("OPENED", "door opened");
        }
        public void activateLock()
        {
            this.door.activateLock();
            this.callbackOnDoorChanged.onLockDoorstatechanged("LOCKED", "door locked");
        }
        public void unlock()
        {
            this.door.unlock();
            this.callbackOnDoorChanged.onLockDoorstatechanged("UNLOCKED", "door unlocked");
        }
        public bool isClose()
        {
            return this.door.isClosed();
        }
        public bool isLocked()
        {
            return this.door.islocked();
        }
    }
    interface OnDoorChanged
    {
        void onLockDoorstatechanged(string value, string message);
        void onDoorOpenStatechanged(string value, string message);
    }
}
