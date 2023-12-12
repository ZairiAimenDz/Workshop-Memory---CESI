using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopMemory.Ex06
{
    public class Solution6
    {

        public static void Start()
        {
            string stringA = "I seem to be turned around!";
            IntPtr sptr = Marshal.StringToHGlobalAnsi(stringA);

            MyResource mr = new MyResource(sptr);
            mr.Dispose();
        }

        public class MyResource : IDisposable
        {
            private IntPtr handle;
            private Component component = new Component();
            private bool disposed = false;

            public MyResource(IntPtr handle)
            {
                this.handle = handle;
            }
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            protected virtual void Dispose(bool disposing)
            {
                if (!this.disposed)
                {
                    if (disposing)
                    {
                        component.Dispose();
                    }
                    handle = IntPtr.Zero;
                    disposed = true;

                }
            }

            [System.Runtime.InteropServices.DllImport("Kernel32")]
            private extern static Boolean CloseHandle(IntPtr handle);


            ~MyResource()
            {
                Dispose(false);
            }
        }

    }
}
