using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace day2
{
    public class statusRepository : Repository
    {
        public List<status> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                string statusQuery = "SELECT p.FirstName, p.LastName, s.StatusDescription, p.PersonId FROM PersonStatus s RIGHT OUTER JOIN Person p ON s.PersonStatusId = p.PersonStatusId;";
                return dbConnection.Query<status>(statusQuery, commandType: CommandType.Text).ToList();

                
                // return dbConnection.Query<status>("SELECT p.FirstName, p.LastName, s.StatusDescription FROM PersonStatus s INNER JOIN Person p ON s.PersonStatusId = p.PersonStatusId;"
                // , commandType: CommandType.Text).ToList();
            }
        }

        public void Insert(status status)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "INSERT INTO person(lastName, firstName, PersonStatusId) "
                    + "values(@lastName, @firstName, @PersonId);"
                    ,new { 
                        lastName = status.lastName,
                        firstName = status.firstName,
                        PersonId = status.PersonId
                    } 
                    ,commandType: CommandType.Text);
            }
        }
    }
}
