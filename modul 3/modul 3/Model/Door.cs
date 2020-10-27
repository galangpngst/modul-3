using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_app.Model
{
    class Door
    {
        private bool closed;
        private bool locked;
        public void close()
        {
            this.closed = true;
        }
        public void open()
        {
            this.closed = false;
        }
        public void activateLock()
        {
            this.locked = true;
        }
        public void unlock()
        {
            this.locked = false;
        }
        public bool islocked()
        {
            return this.locked;
        }
        public bool isClosed()
        {
            return this.closed;
        }
    }
}
