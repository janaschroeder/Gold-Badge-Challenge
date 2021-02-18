using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2_Repo
{
    class Claim_Repo
    {
        private readonly Queue<Claim> _claimQueue = new Queue<Claim>;
       
        //Read
        public Queue<Claim> GetAllClaims()
        {
            return _claimQueue
                }

        public Queue<Claim> GetNextClaim()
        {
            _claimQueue.Dequeue();
                    }

        //Create
        public Queue<Claim> CreateBlankClaim()
        _claimQueue.Enqueue();
            }

        public void SeedContent()

        Claim claim1 = new Claim(
            1,
{1},
            "Car accident on 465.",
            400.00m,
            (2018, 04, 25),
            (2018, 04, 27),
        "true");


Claim claim2 = new Claim(
            2,
{2},
            "House fire in kitchen.",
            4000.00m,
            (2018, 04, 11),
            (2018, 04, 12),
        "true");

Claim claim3 = new Claim(
            3,
{3},
            "Stolen pancakes.",
            4.00m,
            (2018, 04, 27),
            (2018, 06,01),
        "false");

_claimQueue.Enqueue(claim1);
        _claimQueue.Enqueue(claim2);
        _claimQueue.Enqueue(claim3);
        