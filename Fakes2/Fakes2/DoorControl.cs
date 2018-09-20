using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fakes2
{
    public class DoorControl
    {
        private readonly IUserValidation _uv;
        private readonly IEntryNotification _en;
        private readonly IDoor _door;
        private readonly IAlarm _alarm;

        private bool CurrentDoorState = false;

        public DoorControl(IUserValidation uv, IEntryNotification en, IDoor door, IAlarm alarm)
        {
            _uv = uv;
            _en = en;
            _door = door;
            _alarm = alarm;
        }
        public void RequestEntry(string id)
        {
            if (_uv.ValidateEntryRequest(id) == true)
            {
                _door.Open();
                _en.NotifyEntryGranted();
                CurrentDoorState = true;
            }
            else if (_uv.ValidateEntryRequest(id) == false)
            {
                _en.NotifyEntryDenied();
            }
        }

        public void DoorOpened()
        {
            if (CurrentDoorState == false) 
            {
                _door.Closed();
                _alarm.RaiseAlarm();
            }
            else if (CurrentDoorState == true)
            {
               _door.Closed();
                CurrentDoorState = false;
            }
        }

        public void DoorClose()
        {

        }
    }
}
