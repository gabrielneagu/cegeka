using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public class DummyDatabase
    {
        private bool status = false;
        private int count;
        public bool IsConnected { get; set; }
        public DummyDatabase()
        {
            IsConnected = false;
            count = 0;
        }

        public void Connect()
        {
            Random random = new Random();
            int ok = random.Next(1, 6);
            status = true;
            try
            {
                if (ok > 1)
                {
                    IsConnected = true;
                    Console.WriteLine("Connection has been established successfully");
                }
                else
                {
                    throw new DummyDatabaseConnectionException("Failed to connect database. Please try again.");
                }
            }
            catch(DummyDatabaseConnectionException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
        public void Disconnect()
        {
            if (status)
            {
                IsConnected = false;
                Console.WriteLine("Connection has been closed.");
            }
            else
            {
                Console.WriteLine("Please connect the database first.");
            }
        }
        public void Save(string wordToSave)
        {
            try
            {
                if (IsConnected)
                {
                    if (count < 5)
                    {
                        count++;
                        Console.WriteLine("The word " + wordToSave + " has been added to the database");
                    }
                    else
                    {
                        throw new DummyDatabaseOverflowException("The database has reached its storage limit.");
                    }
                }
                else
                {
                    throw new DummyDatabaseConnectionException("Cannot save the word. Please connect the database first.");
                }
            }
            catch(DummyDatabaseOverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DummyDatabaseConnectionException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
