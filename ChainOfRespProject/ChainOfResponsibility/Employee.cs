using ChainOfRespProject.Models;

namespace ChainOfRespProject.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover (Employee superVisior)
        {
            this.NextApprover = superVisior;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel model);
    }
}
