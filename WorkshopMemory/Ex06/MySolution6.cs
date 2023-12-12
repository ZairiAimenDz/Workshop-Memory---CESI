﻿namespace WorkshopMemory.Ex06
{
    public class MySolution6
    {
        public static void Start()
        {
        }
    }



    public class StreamWriterManager : IDisposable
    {
        public StreamWriter Writer { get; set; }
        private bool disposedValue;

        public StreamWriterManager(string filepath)
        {
            Writer = new StreamWriter(filepath);
        }




        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }


                    Writer.Dispose();
                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }


        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~StreamWriterManager()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

}