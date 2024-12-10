using JWTImplementation.Models;

namespace JWTImplementation.Interfaces
{
    public interface IEmployeeService
    {
        public List<Employe> GetEmployesDetails();
        public Employe GetEmploye(int id);
        public void AddEmploye(Employe employee);
        public void updateEmploye(Employe employe);
        public void deleteEmploye(int id);
    }
}
