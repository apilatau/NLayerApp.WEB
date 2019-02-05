using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ComNotHis.BLL.DTO;
using ComNotHis.DAL.Entities;
using ComNotHis.DAL.Interface;
using ComNotHis.BLL.Infrastructure;
using ComNotHis.BLL.Interfaces;
using AutoMapper;

namespace ComNotHis.BLL.Services
{
    public class AdditionalService : IAdditionalService
    {
        IUnitOfWork Database { get; set; }

        public AdditionalService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void MakeAdditionalServise(AdditionalDTO addDTO)
        {
            Additional adds = Database.Additionals.Get(addDTO.Id);

            // проверяется, есть ли такая уже доработка
            if (adds == null)
                Database.Additionals.Create(AddNewAdditional(addDTO)); //создается объект Additional- доработка
            else



            Database.Save();
        }

        private Additional AddNewAdditional(AdditionalDTO addDTO)
        {
            Additional add = new Additional
            {
                DateClosed = addDTO.DateClosed,
                DateRecieved = addDTO.DateRecieved,
                TextJustification = addDTO.TextJustification,
                TextSpecification = addDTO.TextSpecification,
            };

            return add;
        }
        private Additional UpdateAdditional(ref Additional add, ref AdditionalDTO addDTO)
        {
            add.DateRecieved = addDTO.DateRecieved;
            add.DateClosed = addDTO.DateClosed;
            add.TextJustification = addDTO.TextJustification;
            add.TextSpecification = addDTO.TextSpecification;
        }

        //проверяет одинаковость текста обоснования
        private bool IsEqualTextJustification(Additional add,AdditionalDTO addDTO)
        {
            if (add.TextJustification == addDTO.TextJustification)
                return true;
            else
                return false;
        }
        //проверяет одинаковость текста уточнения
        private bool IsEqualTextSpecification(Additional add, AdditionalDTO addDTO)
        {
            if (add.TextSpecification == addDTO.TextSpecification)
                return true;
            else
                return false;
        }

        public IEnumerable<PhoneDTO> GetPhones()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Phone, PhoneDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Phone>, List<PhoneDTO>>(Database.Phones.GetAll());
        }

        public PhoneDTO GetPhone(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id телефона", "");
            var phone = Database.Phones.Get(id.Value);
            if (phone == null)
                throw new ValidationException("Телефон не найден", "");

            return new PhoneDTO { Company = phone.Company, Id = phone.Id, Name = phone.Name, Price = phone.Price };
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
