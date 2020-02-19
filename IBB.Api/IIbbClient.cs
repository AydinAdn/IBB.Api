using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IBB.Api.Models;

namespace IBB.Api
{
    public interface IIbbClient
    {
        /// <summary>
        ///     Gets a list of all the Bus Garages.
        /// </summary>
        /// <returns>Garaj Listesi</returns>
        Task<IEnumerable<BusGarageResponse>> GetGaragesAsync();

        /// <summary>
        ///     Gets a list of all bus stops.
        /// </summary>
        /// <returns>Entire list of bus stops</returns>
        Task<IEnumerable<BusStopResponse>> GetBusStopsAsync();

        /// <summary>
        ///     Get bus stop by id
        /// </summary>
        /// <param name="busStopId">Id of the bus stop</param>
        /// <returns>The bus stop</returns>
        Task<IEnumerable<BusStopResponse>> GetBusStopsAsync(int busStopId);

        /// <summary>
        ///     Get live geolocation data of all vehicles.
        /// </summary>
        /// <returns>Geolocation data on all running public bus services</returns>
        Task<IEnumerable<VehicleLocationResponse>> GetVehicleLocationsAsync();

        /// <summary>
        ///     Gets X,Y coordinates of road traffic accidents that have occured.
        /// </summary>
        /// <param name="date">Date to search for accidents</param>
        /// <returns>Data on accidents that have occurred on the specified day.</returns>
        Task<IEnumerable<AccidentLocationResponse>> GetAccidentsLocationDataAsync(DateTime date);

        /// <summary>
        ///     Gets the routes for all bus services, detailing each bus stop on its route. 
        /// </summary>
        /// <returns>All bus routes</returns>
        Task<IEnumerable<BusRouteResponse>> GetBusRouteDetailsAsync();

        /// <summary>
        ///     Gets the route served by the specified bus route id. 
        /// </summary>
        /// <param name="busRouteId">Bus route id</param>
        /// <returns>The bus route for the specified route id</returns>
        Task<IEnumerable<BusRouteResponse>> GetBusRouteDetailsAsync(string busRouteId);

        /// <summary>
        ///     Gets the list of all public bus services with route ids and the locations it provides a service between.
        /// </summary>
        /// <returns>The list of public bus services</returns>
        Task<IEnumerable<BusServiceDetailResponse>> GetBusServiceDetailsAsync();

        /// <summary>
        ///     Gets the bus service information including the locations it provides a service between.
        /// </summary>
        /// <param name="busRouteId">The bus route id</param>
        /// <returns>Bus service details</returns>
        Task<IEnumerable<BusServiceDetailResponse>> GetBusServiceDetailsAsync(string busRouteId);
    }
}