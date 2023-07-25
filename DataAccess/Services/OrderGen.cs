
using DataAccess.Models.Customer;
using DataAccess.Models.Order;
using System.Collections.Generic;
using System.Reflection;

namespace DataAccess.Services;

public class OrderGen : IOrderGen
{

    public Task<T> CreateObject<T>() where T : new()
    {
        return Task.FromResult(new T());
    }

    public Task<T> CreateAndAssignObject<T>(T sourceObj) where T : new()
    {
        T newObj = new T();

        PropertyInfo[] sourceProperties = typeof(T).GetProperties();
        PropertyInfo[] newProperties= typeof(T).GetProperties();

        foreach(PropertyInfo sourceProperty in sourceProperties)
        {
            PropertyInfo newProperty = newProperties.FirstOrDefault(p => p.Name == sourceProperty.Name);
            if (newProperty != null && newProperty.PropertyType == sourceProperty.PropertyType)
            {
                newProperty.SetValue(newObj, sourceProperty.GetValue(sourceObj, null)); 

            }
        }

        return Task.FromResult(newObj);
    }
}
