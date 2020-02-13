using System;
using System.Collections.Generic;
using IBB.Api.Models;

namespace IBB.Api.Events
{
    public class AracKonumUpdatedEventArgs : EventArgs
    {
        public AracKonumUpdatedEventArgs()
        {
        }

        public AracKonumUpdatedEventArgs(IEnumerable<AracKonumuResponse> aracKonumlari)
        {
            this.UpdatedAracKonumlari = aracKonumlari;
        }

        public IEnumerable<AracKonumuResponse> UpdatedAracKonumlari { get; }
    }
}