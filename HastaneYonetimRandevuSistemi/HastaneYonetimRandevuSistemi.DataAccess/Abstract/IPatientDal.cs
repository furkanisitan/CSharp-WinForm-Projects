﻿using HastaneYonetimRandevuSistemi.Core.DataAccess;
using HastaneYonetimRandevuSistemi.Entities.Concrete;

namespace HastaneYonetimRandevuSistemi.DataAccess.Abstract
{
    public interface IPatientDal : IEntityRepository<Patient>
    {
    }
}
