using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface IModelService
    {
        void Add(Model model);
        void Update(Model model);
        void Delete(Model model);
        void DeleteById(int modelID);
        Model GetById(int modelId);
        List<Model> GetAll();
    }
}
