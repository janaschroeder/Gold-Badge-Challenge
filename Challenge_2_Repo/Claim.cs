using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2_Repo
{
    public class Claim
    {

        private int ClaimmID { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
                public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set;       }


        public bool IsValid = true; 

public Claim() { }
public Claim (int claimId, IncidentType typeOfClaim, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool IsValid, )
    {
        ClaimId = ClaimId;
        IncidentType = typeOfIncident;
       Description = description;
        ClaimAmount = claimAmount;
        dateOfIncident = dateOfIncident;
        DateOfClaim = dateOfClaim;
            }
}
public enum InccidentType { Car = 1, Home, Theft, }
}
