using System;

namespace OOPLesson2_P2.Concrete
{
    public class Student
    {
        private Class _class; // Field
        public Class Class // Property that has both of get and set
        {
            get
            {
                return this._class;
            }
            internal set // Internal is kinda public but it means this feature(I mean setting) can be used in only this project, it can not be called from another project such as ConsoleAppProject because we are in ConsoleAppLibraryProject right now.
            {
                this._class = value;
            }
        }

        public string Name; // Field
        public DateTime BirthDate; // Field
    }
}