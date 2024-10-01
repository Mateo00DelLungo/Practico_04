using Newtonsoft.Json.Linq;
using System.Reflection;

namespace Practico_04.Utils
{
    public class MapperBase<Input, Output> : IMapper<Input, Output>
        where Input : new()
        where Output : new()
    {
        private void GetProperties(PropertyInfo property, object fromValue, object whereToValue)
        {
            try
            {
                string propName = property.Name;
                var propValue = property.GetValue(fromValue);
                whereToValue.GetType().GetProperty(propName).SetValue(whereToValue, propValue);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Output Set(Input entity)
        {
            Output oValue = new Output();
            PropertyInfo[] properties = typeof(Input).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                GetProperties(property, entity, oValue);
            }
            return oValue;
        }
        public Input Get(Output oValue)
        {
            Input entity = new Input();
            PropertyInfo[] properties = typeof(Output).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                GetProperties(property, oValue, entity);
            }
            return entity;
        }
        public List<Output> Set(List<Input> entitylist)
        {
            List<Output> lst = new List<Output>();
            foreach (Input entity in entitylist)
            {
                lst.Add(Set(entity));
            }
            return lst;
        }
        public List<Input> Get(List<Output> oValueList)
        {
            List<Input> lst = new List<Input>();
            foreach (Output oValue in oValueList)
            {
                lst.Add(Get(oValue));
            }
            return lst;
        }
    }
}
