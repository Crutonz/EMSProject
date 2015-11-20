using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQProject
{
    class Company
    {
        private List<FultimeEmployee> fultimeEmployee = new List<FultimeEmployee>();
        private List<ParttimeEmployee> ParttimeEmployee = new List<ParttimeEmployee>();
        private List<ContractEmployee> ContractEmployee = new List<ContractEmployee>();
        private List<SeasonalEmployee> SeasonalEmployee = new List<SeasonalEmployee>();



        //fultimeEmployee
        private string addFulltimeEmployee(string firstName, string lastName, string socialInsranceNumber, string dateOfBirth, string dataOfHire, string dateOfHire, string salary) 
        {


  
 
            if (false)
            {
                // return error information
                return;
            }
            else
            {
                FultimeEmployee employee = new FultimeEmployee();
                //adding
                //return successful infor.
                fultimeEmployee.push_back(employee);
                return "successful";
            }
           
        }

        //ParttimeEmployee
        private void addParttimeEmployee(string firstName, string lastName, string socialInsranceNumber, string dateOfBirth, string dateOfHire, string dateOfTermination, string hourlyRate)
        {
            //1. check the validation
            //2. The format is right
            //   coding....
            if (false)
            {
                // return error information
            }
            else
            {
                //adding
                //return successful infor.
            }
        }


        //ContractEmployee
        private void addContractEmployee(string firstName, string lastName, string socialInsranceNumber, string dateOfBirth, string contractStartDate, string contractStopDate, string fixContractAmount)
        {
            //1. check the validation
            //2. The format is right
            //   coding....
            if (false)
            {
                // return error information
            }
            else
            {
                //adding
                //return successful infor.
            }
        }


        //SeasonalEmployee
        private void addSeasonalEmployee(string firstName, string lastName, int socialInsranceNumber, string dateOfBirth, string season, string piecePay)
        { 
             //1. check the validation
            //2. The format is right
            //   coding....
            if (false)
            {
                // return error information
            }
            else
            {
                //adding
                //return successful infor.
            }
        }

        private void removeEmployee(int sin)
        { 
            //1. check the validation
            //2. The format is right
            //   coding....
            if (false)
            {
                // return error information
            }
            else
            {
                //adding
                //return successful infor.
            }
        }

        private void modifyEmployee(int sin)
        {
            //1. check the SIN number is valiable from 4 employee type from 4 List.
            // coding..........
            //foreach(var item in collection)  --traverse list
            //{
 

            //}
            //2. if SIN exist , make sure which employee is this.
            if (false)
            {
                // returen error information.
            }
            else
            {
                // SIN exist
                //foreach(var item in collection)  --find SIN
                {
                    if (true)
                    {
                        // delecte old information
                        //add new information
                    }
                }

            }

        }

        private void displayEmployee()//each type
        { 
        }

        private void displayEmployee()//each type
        {
        }

        private void displayEmployee()//each type
        {
        }

        private void displayEmployee()//each type
        {
        }

        private void displayEmployee()//all
        {
        }

        //load logging class method.




    }

    

}
