using SDS.Core.Application_Service;
using SDS.Core.Domain_Service;
using SDS.Core.Entity;
using SDS.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDS.UI
{
    public class Printer
    {
        private readonly IAvatarService _avatarServie;


        public Printer(IAvatarService avatarService)
        {
            _avatarServie = avatarService;
        }

        public void CreateAvatar()
        {

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Type: ");
            var type = Console.ReadLine();
            Console.WriteLine("Birthdate: ");
            DateTime newBirthday;
            while (!DateTime.TryParse(Console.ReadLine(), out newBirthday))
            {
                Console.WriteLine("try again");
            }

            Console.WriteLine("SoldDate: ");
            DateTime newSoldDate;
            while (!DateTime.TryParse(Console.ReadLine(), out newSoldDate))
            {
                Console.WriteLine("try again");
            }


            Console.WriteLine("Color: ");
            var color = Console.ReadLine();
            Console.WriteLine("Previous Owner: ");
            var previousOwner = Console.ReadLine();
            Console.WriteLine("Price: ");
            double newPrice;
            while (!double.TryParse(Console.ReadLine(), out newPrice))
            {
                Console.WriteLine("try again");
            }

            _avatarServie.Create(new Avatar()

            {

                Name = name,
                Type = type,
                Birthday = newBirthday,
                SoldDate = newSoldDate,
                Color = color,
                PreviousOwner = previousOwner,
                Price = newPrice


            }
            );

        }

        public Avatar FindAvatarById()
        {
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Insert a number");


            }
            Avatar avatar = _avatarServie.ReadById(id);
            Console.WriteLine("Write something");

            return null;
        }


        public void UpdateAvatar()
        {
            Console.WriteLine("Insert id of avatar to update: ");

            var avatar = FindAvatarById();
            Console.WriteLine("Name: ");
            avatar.Name = Console.ReadLine();
            Console.WriteLine("Type: ");
            avatar.Type = Console.ReadLine();

            Console.WriteLine("Birthdate: ");
            DateTime newBirthday;
            while (!DateTime.TryParse(Console.ReadLine(), out newBirthday))
            {
                Console.WriteLine("try again");
            }

            avatar.Birthday = newBirthday;
            Console.WriteLine("Sold Date: ");
            DateTime newSoldDate;
            while (!DateTime.TryParse(Console.ReadLine(), out newSoldDate))
            {
                Console.WriteLine("try again");
            }
            avatar.SoldDate = newSoldDate;

            Console.WriteLine("Color: ");
            avatar.Color = Console.ReadLine();
            Console.WriteLine("Previous owner: ");
            avatar.PreviousOwner = Console.ReadLine();
            Console.WriteLine("Price: ");
            double newPrice;
            while (!double.TryParse(Console.ReadLine(), out newPrice))
            {
                Console.WriteLine("try again");
            }
            avatar.Price = newPrice;
        }


        public void Delete()
        {
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Insert id of avatar to delete:");
            Avatar avatar = _avatarServie.Delete(id);
            Console.WriteLine("Write something");
            }
            
        

        }
   
     }
        /*
    var avatarFound = FindAvatarById();
    if (avatarFound != null)
    {
        avatarList.Remove(avatarFound);
    }*/
    



}