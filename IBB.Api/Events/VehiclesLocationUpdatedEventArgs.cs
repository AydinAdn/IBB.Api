using System;
using System.Collections.Generic;
using IBB.Api.Models;

namespace IBB.Api.Events
{
    public class VehiclesLocationUpdatedEventArgs : EventArgs
    {
        public VehiclesLocationUpdatedEventArgs(IEnumerable<VehicleLocationResponse> vehicleLocations)
        {
            this.UpdatedVehicleLocations = vehicleLocations;
        }

        public IEnumerable<VehicleLocationResponse> UpdatedVehicleLocations { get; }
    }
}