using SDS.Core.Domain_Service;
using SDS.Core.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SDS.Core.Application_Service.Service
{
    public class AvatarService : IAvatarService
    {
        private readonly IAvatarRepository _aRepo;
        public static IEnumerable<Avatar> avatarList;


        public AvatarService(IAvatarRepository aRepo)
        {

            _aRepo = aRepo;
        }

        public Avatar Create(Avatar avatar)
        {
            if (avatar.Name.Length < 1)
            {
                throw new InvalidDataException("Name must be atleast 1 char");
            }
            return _aRepo.Create(avatar);

        }
        public Avatar Update(Avatar avatar)
        {
            if (avatar.Name.Length < 1)
            {
                throw new InvalidDataException("Name must be atleast 1 char");
            }
            return _aRepo.Update(avatar);

        }

        public List<Avatar> ReadAllAvatars()
        {
            return _aRepo.GetAllAvatars();
        }

        public Avatar Delete(Avatar avatar)
        {
            if (avatar.Id < 1)
            {

                throw new InvalidDataException("Id must be atleast 1");
            }
            return _aRepo.Delete(avatar);
        }


        public void ListAvatars()
        {
            foreach (var avatar in avatarList)
            {
                Console.WriteLine($"Id: {avatar.Id}\n Name: {avatar.Name}\n Type: {avatar.Type}\n Birthdate: {avatar.Birthday}\n Sold date: {avatar.SoldDate}\n Color: {avatar.Color}\n Previous Owner: {avatar.PreviousOwner}\n Price: {avatar.Price}");
            }
        }

        public Avatar ReadById(int id)
        {
            return _aRepo.GetAvatarById(id);
        }
    }
}