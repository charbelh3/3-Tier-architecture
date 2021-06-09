using System;
using System.Collections.Generic;
using WebApplication6.Repository.Entities;
using AutoMapper;
using Business_Logic_Layer.Models;

namespace Business_Logic_Layer
{
    public class PersonBLL
    {

        private Data_Access_Layer.PersonDAL _DAL;
        private Mapper _PersonMapper;

        public PersonBLL()
        {
            _DAL = new Data_Access_Layer.PersonDAL();
            var _configPerson = new MapperConfiguration(cfg => cfg.CreateMap<Person, PersonModel>().ReverseMap());

            _PersonMapper = new Mapper(_configPerson);
        }

        public List<PersonModel> GetAllPersons()
        {
           List<Person> personsFromDB = _DAL.GetAllPersons();
           List<PersonModel> personsModel = _PersonMapper.Map<List<Person>, List<PersonModel>>(personsFromDB);

            return personsModel;
        }

        public PersonModel GetPersonById(int id)
        {
           var personEntity = _DAL.GetPersonById(id);

            PersonModel personModel = _PersonMapper.Map<Person, PersonModel>(personEntity);

            return personModel;
        }


        public void postPerson(PersonModel personModel)
        {
            Person personEntity = _PersonMapper.Map<PersonModel, Person>(personModel);
            _DAL.postPerson(personEntity);
        }

    }
}
