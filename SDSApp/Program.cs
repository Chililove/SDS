using SDS.Core.Application_Service;
using SDS.Core.Application_Service.Service;
using SDS.Core.Domain_Service;
using SDS.Core.Entity;
using SDS.Infrastructure.Data.Repositories;
using SDS.UI;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace SDSApp
{
    class Program
    {

        static void Main(string[] args)
        {
            /* avatarRepository = new AvatarRepo();
             {
                 var avatar1 = new Avatar
                 {
                     Id = id++,
                     Name = "Bradley",
                     Type = "Meliodas",
                     Birthday = DateTime.Now.Date,
                     SoldDate = DateTime.Now.Date,
                     Color = "blue",
                     PreviousOwner = "Lotte",
                     Price = 2
                 };
                 avatarList.Add(avatar1);
                 //Console.WriteLine($"Name: {avatar1.Username}");
                 avatarList.Add(new Avatar()
                 {
                     Id = id++,
                     Name = "Chili",
                     Type = "Chililove",
                     Birthday = DateTime.Now.Date,
                     SoldDate = DateTime.Now.Date,
                     Color = "purple",
                     PreviousOwner = "hans",
                     Price = 1
                 });

                 //avatarRepository.Create(avatar1);


             };*/
            IAvatarRepository aRepo = new AvatarRepo();
            IAvatarService aService = new AvatarService(aRepo);
            Printer print = new Printer(aService);
            Console.WriteLine("Hello fellow Seven Deadly Sins maniac!");

            Console.WriteLine("Welcome to SDS\nBegin your adventure by choosing an option in the menu");

            var selection = ShowMenu();

            while (selection != 5)
            {
                switch (selection)
                {
                    case 1:
                        print.CreateAvatar();
                        break;
                    case 2:
                        ListAvatars();
                        break;

                    case 3:
                        print.UpdateAvatar();
                        break;

                    case 4:
                        print.Delete();
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Try again sinner");
                Console.ReadLine();
                ClearMenu();



                selection = ShowMenu();

            }
            Console.WriteLine("See you soon");
            Console.ReadLine();
            ClearMenu();
        }

        private static void ListAvatars()
        {        

             foreach (var avatar in avatarList)
             {
                 Console.WriteLine($"Id: {avatar.Id}\n Name: {avatar.Name}\n Type: {avatar.Type}\n Birthdate: {avatar.Birthday}\n Sold date: {avatar.SoldDate}\n Color: {avatar.Color}\n Previous Owner: {avatar.PreviousOwner}\n Price: {avatar.Price}");
             }
            
        }

        private static int ShowMenu()
        {
            string[] menuItems =
            {
                    "Create your avatar",
                    "Show avatars",
                    "Update avatar",
                    "Delete avatar",
                    "Exit SDS character setup"
            };

            Console.WriteLine("Select something:");

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{(i + 1)} : {menuItems[i]}");
            }
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 5)
            {
                Console.WriteLine("Please select a menuitem between 1- 5");
            }
            return selection;

        }

        private static void ClearMenu()
        {
            Console.Clear();
        }

       


    }


    
}
