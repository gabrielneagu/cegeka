using System;

namespace Ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            DummyDatabase dummyDatabase = new DummyDatabase();
            dummyDatabase.Connect();
            //dummyDatabase.Disconnect();

            DummyDatabase dummyDatabase1 = new DummyDatabase();
            dummyDatabase1.Disconnect();

            dummyDatabase.Save("gabita1");
            dummyDatabase.Save("gabita2");
            dummyDatabase.Save("gabita3");
            dummyDatabase.Save("gabita4");
            dummyDatabase.Save("gabita5");
            dummyDatabase.Save("gabita6");
        }
    }
}
