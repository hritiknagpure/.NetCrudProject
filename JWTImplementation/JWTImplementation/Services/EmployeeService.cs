using JWTImplementation.Context;
using JWTImplementation.Interfaces;
using JWTImplementation.Models;

namespace JWTImplementation.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly JwtContext _jwtContext;
        public EmployeeService(JwtContext jwtContext)
        {
            _jwtContext = jwtContext;
        }
        public void AddEmploye(Employe employee)
        {

        }

        public void deleteEmploye(int id)
        {
            throw new NotImplementedException();
        }

        public Employe GetEmploye(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employe> GetEmployesDetails()
        {
            throw new NotImplementedException();
        }

        public void updateEmploye(Employe employe)
        {
            throw new NotImplementedException();
        }
    }
}
