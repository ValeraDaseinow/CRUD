using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using For_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace For_Project.Models
{
    public class Logic 
    {

        ApplicationContext db = new ApplicationContext(); //контекст БД для работы через EntityFramework

        public Logic()
        {

        }

        public List<X> Get() //вывод всех записей
        {
            return db.xes.ToList();
        }

        public X Get(int id) 
        {
            return db.xes.Find(id);
        }

        public int Post(X x)
        {
            db.xes.Add(x);
            db.SaveChanges();

            return x.Id;
        }

        public bool Put(int id, string value)
        {
            X x = db.xes.Find(id);
            if (x == null) //если нет записи с заданным id
                return false;
            else
            {
                x.Value = value;
                db.Entry(x).State = EntityState.Modified; //внесение изменений в запись БД
                db.SaveChanges();
                return true;
            }
        }

        public bool Delete(int id)
        {
            X x = db.xes.Find(id);
            if (x == null)
                return false;
            else
            {
                db.Entry(x).State = EntityState.Deleted; //удаление записи из БД
                db.SaveChanges();
                return true;
            }
        }
    }
}
