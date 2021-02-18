using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2_UI
{
    class ProgramUI2
    {
        public readonly Claim_Repo _crepo = new Claim_Repo();
        public readonly Queue<Claim> _claim = new Queue<Claim>();
        
        public bool continueToRun = true;
        //public readonly string userInput = Console.ReadLine();
        public void RunClaimMenu()
        {

            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Welcome, Komodo Claims Agent. Enter a key to continue.");
                Console.ReadKey();
                Console.WriteLine("Would you like to:\n" +
                "1. See a list of all claims to be processed, \n" +
             "2. Process the next claim\n" +
             "3. Enter a new claim \n" +
                 "4. Exit \n" +
                "Please enter a number between 1 and 4.");
                ;

                switch (userInput)
                {
                    case "1":
                        ShowAllClaims();
                        _crepo.SeedContent();
                        break;
                    case "2":
                        ShowNextClaim();
                        break;
                    case "3":
                        AddClaim();
                        _crepo.SeedContent();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("INVALID! Please enter a number between 1 and 4.");
                        Console.ReadKey();
                        break;



                }
            }
