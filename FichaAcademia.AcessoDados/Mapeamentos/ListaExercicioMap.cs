using FichaAcademia.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAcademia.AcessoDados.Mapeamentos
{
    class ListaExercicioMap : IEntityTypeConfiguration<ListaExercicio>
    {
        public void Configure(EntityTypeBuilder<ListaExercicio> builder)
        {
            builder.HasKey(le => le.ListaExercicioId);

            builder.Property(le => le.Frequencia).IsRequired();
            builder.Property(le => le.Repeticoes).IsRequired();
            builder.Property(le => le.Carga).IsRequired();

            builder.HasOne(le => le.Exercicio).WithMany(le => le.ListaExercicios).HasForeignKey(le => le.ExercicioId);
            builder.HasOne(le => le.Ficha).WithMany(le => le.ListaExercicios).HasForeignKey(le => le.FichaId);

            builder.ToTable("ListasExercicios");
        }
    }
}
