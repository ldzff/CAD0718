using System;
using IxMilia.Dxf.Entities;

namespace RobTeach.Models
{
    public class SelectableDxfEntity
    {
        public DxfEntity Entity { get; }
        public Guid Id { get; }

        public SelectableDxfEntity(DxfEntity entity)
        {
            Entity = entity;
            Id = Guid.NewGuid();
        }
    }
}
