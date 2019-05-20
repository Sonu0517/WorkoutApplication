using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CategoryRepository
    {

      public List<workout_category> ListAllCategory()
        {
            try
            {

                CasestudyEntities db = new CasestudyEntities();
               
                return db.workout_category.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }
        //adding category
        public void AddCategory(workout_category item)
        {
            try
            {
                CasestudyEntities db = new CasestudyEntities();
                db.workout_category.Add(item);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //Deleting category
        public void DeleteCategory(int id)
        {
            Console.WriteLine("enter the category id to delete");
            int Id = int.Parse(Console.ReadLine());
            try
            {
                CasestudyEntities db = new CasestudyEntities();
                var ObjCategory = (from obj in db.workout_category
                                   where obj.category_id == Id
                                   select obj).First();
                db.workout_category.Remove(ObjCategory);
                db.SaveChanges();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Editing category
        public void EditCategory(workout_category item)
        {

            try
            {
                CasestudyEntities db = new CasestudyEntities();
                var ObjCategory = (from obj in db.workout_category
                                   where obj.category_id == item.category_id
                                   select obj).First();

                ObjCategory.category_name= item.category_name;
               
                db.SaveChanges();




            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //get category
        public workout_category Get(int id)
        {
            workout_category objWork = null;

            try
            {
                CasestudyEntities db = new CasestudyEntities();
                objWork = (from obj in db.workout_category
                          where obj.category_id == id
                          select obj).First();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objWork;

        }






    }
}
