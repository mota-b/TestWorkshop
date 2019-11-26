using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Delegate
{
    class clsDispose_Fin
    {
        // Flag: Has Dispose already been called?
        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public clsDispose_Fin()
        {
            Console.WriteLine("created object in clsFIN ");

        }

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            this.Dispose1(true);
            GC.SuppressFinalize(this);
            

        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose1(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                Console.WriteLine("Handeling Dispose");
                // Free any other managed objects here.

                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        ~clsDispose_Fin()
        {
            Console.WriteLine("deleted object in clsFIN ");
            this.Dispose1(false);
        }

        
    }
}
