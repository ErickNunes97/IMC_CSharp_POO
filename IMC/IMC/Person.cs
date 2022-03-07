using System;
using System.Collections.Generic;
using System.Text;




namespace IMC
{
    class Person
    {
        private string _name;
        private int _age;

        public Person(string _name, int _age)
        {
            this._age = _age;
            this._name = _name;
        }
 

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int _age)
        {
            this._age = _age;
        }
    }
}
