﻿using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ITypeOfNewFeedServices
    {

        Task<List<TypeOfNewFeed>> TypeOfNewFeeds();


    }
}
