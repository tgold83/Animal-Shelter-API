using AnimalShelter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Repository
{
  public interface IJWTManagerRepository
  {
    Tokens Authenticate(Users users); 
  }
   
}