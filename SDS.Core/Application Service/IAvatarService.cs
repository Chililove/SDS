using System;
using System.Collections.Generic;
using System.Text;
using SDS.Core.Entity;

namespace SDS.Core.Application_Service
{
    public interface IAvatarService
    {

        public List<Avatar> ReadAllAvatars();
        Avatar Create(Avatar avatar);

        Avatar Update(Avatar avatar);

        Avatar Delete(int id);
        Avatar ReadById(int id);
    }
}
