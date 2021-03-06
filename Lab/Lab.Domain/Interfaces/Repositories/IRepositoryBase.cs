﻿using Lab.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Lab.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity, TId> where TEntity : EntityBase<TId> where TId : IEquatable<TId>
    {
        TEntity Get(TId id);

        IEnumerable<TEntity> GetAll();

        void Save(TEntity entity);

        void Delete(TEntity entity);
    }
}
