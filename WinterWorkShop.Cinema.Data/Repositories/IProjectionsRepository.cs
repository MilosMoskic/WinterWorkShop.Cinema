﻿using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public interface IProjectionsRepository
    {
        List<Projections> GetAllProjections();

        Projections GetProjectionsById(int id);
        Projections GetProjectionsByMovieId(int id);
    }
}
