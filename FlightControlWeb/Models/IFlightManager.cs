﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightControlWeb.Models
{
    public interface IFlightManager
    {
        Flight CreateUpdatedFlight(FlightPlan flightPlan, DateTime dateTime);
        string CreateIdentifier(FlightPlan flightPlan);
        void SetExternalFlights(IEnumerable<Flight> flightsFromServer);
        bool IsSegmentsValid(FlightPlan flightplan);
    }
}