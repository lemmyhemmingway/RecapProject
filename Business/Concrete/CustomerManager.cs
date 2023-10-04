using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CustomerManager: ICustomerService
{
    private ICustomerDal _customerDal;

    public CustomerManager(ICustomerDal customerDal)
    {
        _customerDal = customerDal;

    }
    public IResult Add(Customer customer)
    {
        _customerDal.Add(customer);
        return new SuccessResult(Messages.CustomerAdded);
    }

    public IResult Update(Customer customer)
    {
        throw new NotImplementedException();
    }

    public IResult Delete(Customer customer)
    {
        throw new NotImplementedException();
    }

    public IDataResult<Customer> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public IDataResult<List<Customer>> GetAll()
    {
        throw new NotImplementedException();
    }
}