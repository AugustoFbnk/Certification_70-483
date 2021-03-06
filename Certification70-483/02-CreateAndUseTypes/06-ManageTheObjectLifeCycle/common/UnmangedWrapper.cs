﻿using System;
using System.IO;

namespace Certification70_483._02_CreateAndUseTypes._06_ManageTheObjectLifeCycle.common
{
    public class UnmangedWrapper : IDisposable
    {
        public FileStream Stream { get; private set; }
        public UnmangedWrapper()
        {
            this.Stream = File.Open("temp.dat", FileMode.Create);
        }
        ~UnmangedWrapper()
        {
            Dispose(false);
        }
        public void Close()
        {
            Dispose();
        }
        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Stream != null)
                {
                    Stream.Close();
                }
            }
        }
    }
}
