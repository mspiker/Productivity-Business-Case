using PBCTracker.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PBCTracker.Services
{
    public interface ICaseRepository
    {
        IEnumerable<Case> GetUserCases(string Username);
        IEnumerable<Case> GetAllCases();
        Case GetCase(int id);

    }
}
