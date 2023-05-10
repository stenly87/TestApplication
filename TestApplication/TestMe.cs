using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class TestMe
    {
        public string SomeValue { get; private set; }
        public ObjectStates State { get; private set; }

        int _value;
        private IDB<TestMe> db;

        public TestMe()
        {
            SomeValue = "not null";
        }

        public void ChangeValue(int value)
        {
            _value = value;
            State = ObjectStates.IsEdit;
        }

        public void SetUpDB(IDB<TestMe> db)
        {
            this.db = db;
        }

        public void Save()
        {
            db.Update(this);
            State = ObjectStates.Normal;
        }

        public void Insert()
        {
            db.Insert(this);
        }
    }
}
