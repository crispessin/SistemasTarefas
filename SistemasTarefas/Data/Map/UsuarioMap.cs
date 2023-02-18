﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasTarefas.Models;

namespace SistemasTarefas.Data.Map
{
    public class TarefaMap : IEntityTypeConfiguration<TarefaModel>
    {
        public void Configure(EntityTypeBuilder<TarefaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x =>x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x =>x.Descricao).HasMaxLength(1000);
            builder.Property(x =>x.Status).IsRequired();
        }
    }
}
