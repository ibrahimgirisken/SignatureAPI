using SignatureAPI.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Application.Features.Queries.AppUser.GetAllUser
{
    public class GetAllUserQueryResponse
    {
        public List<UserListDTO> UserListDTO{ get; set; }
    }
}
