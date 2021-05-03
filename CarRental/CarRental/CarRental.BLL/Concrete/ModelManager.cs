using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete
{
   public class ModelManager : IModelService
    {
        IModelDal _modelDal;
        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

        public void Add(Model model)
        {
            _modelDal.Add(model);
        }

        public void Delete(Model model)
        {
            _modelDal.Delete(model);
        }

        public void DeleteById(int modelID)
        {
            _modelDal.Delete(_modelDal.Get(x => x.ModelID == modelID));
        }

        public List<Model> GetAll()
        {
            return _modelDal.GetAll();
        }

        public Model GetById(int modelId)
        {
            return _modelDal.Get(x => x.ModelID == modelId);
        }

        public void Update(Model model)
        {
            _modelDal.Update(model);
        }
    }
}
