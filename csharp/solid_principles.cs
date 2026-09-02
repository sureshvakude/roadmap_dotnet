namespace csharp
{
    internal class Solid_Principles
    {
        #region Single Resposibility Principle (SRP)
        // Definition: A class should have one, and only one, reason to change.
        // Violation: A Invoice class that calculates totals, saves invoices to a SQL database, and emails the customer.

        public class Invoice
        {
            public decimal CalculateTotal() => 100.50m;
        }

        public class InvoiceRepository
        {
            public void Save(Invoice invoice) { }
        }

        public class EmailService
        {
            public void SendEmail(string email, Invoice invoice) { }
        }
        #endregion

        #region Open/Close Principle (OCP)

        // Definition: Software entities should be open for extension but closed for modification.
        // Violation: A SalaryCalculator class filled with if-else or switch statements checking if an employee is "FullTime", "PartTime", or "Contractor". Adding a new type forces you to modify this class.

        public abstract class EmployeeSalary
        {
            public decimal CalculateSalary();
        }

        public class FullTimeEmployeeSalary : EmployeeSalary 
        {
            public override decimal CalculateSalary() => 5000;
        }

        public class PartTimeEmployeeSalary : EmployeeSalary
        {
            public override decimal CalculateSalary() => 2000;
        }
        #endregion

        #region Liskov Substitution Principle (LSP)

        // Defination: Objects of a subclass should behave exactly like objects of the superclass without breaking the system.
        // Violation: A subclass throws an error because it cannot execute a command supported by its parent.

        public class Bird { public virtual void Fly() { /* Fly logic */ } }

        public class Ostrich : Bird
        {
            public override void Fly() => throw new NotImplementedException(); // Violation: Ostrich cannot fly!
        }

        // Correct

        public class Bird { /* Shared bird properties */ }
        public class FlyingBird : Bird { public virtual void Fly() { /* Fly logic */ } }

        public class Eagle : FlyingBird { public override void Fly() { /* ... */ } }
        public class Ostrich : Bird { /* No fly method inherited */ }

        #endregion

        #region Interface Segregation Principle (ISP)

        // Defination: It is better to have multiple specific interfaces than one bloated, generic interface.
        // Violation: Forcing a class to implement methods it has no use for.

        public interface IMultiFunctionDevice
        {
            void Print();
            void Fax();
        }

        public class BasicPrinter : IMultiFunctionDevice
        {
            public void Print() { /* Print logic */ }
            public void Fax() => throw new NotImplementedException(); // Violation
        }

        // Correct

        public interface IPrinter { void Print(); }
        public interface IFax { void Fax(); }

        public class BasicPrinter : IPrinter
        {
            public void Print() { /* Print logic */ }
        }

        #endregion

        #region Dependency Inversion Principle (DIP)

        // Defination: Classes should depend on abstractions (interfaces), not on concrete types. This decouples your code components.
        // Violation: Instantiating a low-level dependency directly inside a high-level service class.

        public class Car
        {
            private Engine _engine = new Engine(); // Tightly coupled to a specific Engine type
            public void Start() => _engine.Start();
        }

        // correct

        public interface IEngine { void Start(); }

        public class V8Engine : IEngine { public void Start() { /* ... */ } }

        public class Car
        {
            private readonly IEngine _engine;

            // The abstraction is injected from the outside (e.g., using a built-in .NET DI container)
            public Car(IEngine engine)
            {
                _engine = engine;
            }
            public void Start() => _engine.Start();
        }

        #endregion
    }
}
