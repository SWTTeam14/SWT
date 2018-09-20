using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Fakes2;
using NUnit.Framework;
using NSubstitute;

namespace Fakes2_Unit_Test
{
    [TestFixture]
    public class DoorUnitTest
    {
        private DoorControl _uut;
        private IUserValidation _uv;
        private IEntryNotification _en;
        private IDoor _door;
        private IAlarm _alarm;

        [SetUp]

        public void SetUp()
        {
            _uv = Substitute.For<IUserValidation>();
            _en = Substitute.For<IEntryNotification>();
            _door = Substitute.For<IDoor>();
            _alarm = Substitute.For<IAlarm>();

            _uut = new DoorControl(_uv, _en, _door, _alarm);
        }

        [Test]

        public void 
    }
}
